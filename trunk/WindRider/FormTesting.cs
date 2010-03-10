using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.Threading;
using System.Net;


namespace WindRider
{
    public partial class FormTesting : Form
    {
        [DllImport("coredll.dll")]
        private extern static int GetDeviceUniqueID([In, Out] byte[] appdata,
                               int cbApplictionData,
                                int dwDeviceIDVersion,
                                [In, Out] byte[] deviceIDOuput,
                                out uint pcbDeviceIDOutput);

        public static string zipCode;
        public static string provider;
        public static string hash;
        public static double speedTested;

        public static bool testsFinshed = false;

        public static bool allowBrowsing = true;
        public static bool allowLocation = false;

        private Thread threadTests;

        public FormTesting()
        {
            InitializeComponent();
        }

        private void FormTesting_Load(object sender, EventArgs e)
        {
            string localFile = "characteristics";
            StreamReader rdr = null;

            if (File.Exists(localFile) == true)
            {
                try
                {
                    rdr = new StreamReader(localFile);

                    zipCode = rdr.ReadLine();
                    textZipcode.Text = zipCode;
                    provider = rdr.ReadLine();
                    textCarrier.Text = provider;

                    allowLocation = bool.Parse(rdr.ReadLine());
                    allowBrowsing = bool.Parse(rdr.ReadLine());
                    checkBoxBrowsing.Checked = allowBrowsing;

                    rdr.Close();
                }
                catch (Exception exc)
                {
                    rdr.Close();
                    Console.Out.WriteLine("Exception " + exc.ToString());
                }
            }
            byte[] AppData = Encoding.Unicode.GetBytes("WindRider");
            int appDataSize = AppData.Length;
            byte[] DeviceOutput = new byte[20];
            uint SizeOut = 20;
            GetDeviceUniqueID(AppData, appDataSize, 1, DeviceOutput, out SizeOut);

            hash = ByteArrayToString(DeviceOutput);

        }

        static string ByteArrayToString(byte[] arrInput)
        {
            int i;
            StringBuilder sOutput = new StringBuilder(arrInput.Length);
            for (i = 0; i < arrInput.Length; i++)
            {
                sOutput.Append(arrInput[i].ToString("X2"));
            }
            return sOutput.ToString();
        }

        private void menuTesting_Click(object sender, EventArgs e)
        {
                progressBar.Visible = true;
                progressBar.Value = 0;
                testsFinshed = false;

                labelThanks.Visible = false;
                labelGen.Visible = false;
                feedbackLabel.Visible = false;
                textZipcode.Visible = false;
                textCarrier.Visible = false;
                checkBoxBrowsing.Visible = false;
                menuTesting.Enabled = false;
                menuFeedback.Enabled = false;
                labelWait.Visible = true;
                labelSpeed.Visible = false;

                ThreadStart starter = new ThreadStart(PerformTests);
                threadTests = new Thread(starter);
                threadTests.Start();

                this.Refresh();

                while (progressBar.Value < 100 && testsFinshed == false)
                {
                    Thread.Sleep(2000);
                    progressBar.Value += 2;
                    this.Refresh();
                }

                threadTests.Abort();

                progressBar.Visible = false;
                labelSpeed.Text = String.Format("{0:0.00}", speedTested) + " KBps";
                
                labelThanks.Visible = true;
                labelGen.Visible = true;
                feedbackLabel.Visible = true;
                textZipcode.Visible = true;
                textCarrier.Visible = true;
                checkBoxBrowsing.Visible = true;
                menuTesting.Enabled = true;
                menuFeedback.Enabled = true;
                labelWait.Visible = false;
                labelSpeed.Visible = true;
        }

        private void menuFeedback_Click(object sender, EventArgs e)
        {
                FormFeedback frmVarMain = new FormFeedback();
                frmVarMain.Show();
                zipCode = textZipcode.Text;
                provider = textCarrier.Text;

                allowBrowsing = checkBoxBrowsing.Checked;

                TextWriter tw = new StreamWriter("characteristics");
                tw.WriteLine(textZipcode.Text);
                tw.WriteLine(textCarrier.Text);
                tw.WriteLine(allowLocation.ToString());
                tw.WriteLine(allowBrowsing.ToString());

                tw.Close(); 
        }

        public void PerformTests()
        {
            Tester tester = new Tester();

            speedTested = tester.test();
            testsFinshed = true;
        }
    }
}