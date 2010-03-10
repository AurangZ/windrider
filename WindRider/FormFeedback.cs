using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Net;
using System.Threading;
using Terranova.API;

namespace WindRider
{
    public partial class FormFeedback : Form
    {
        private ProcessInfo[] listEntries = null;
        private List<String> titles_ = null;
        private List<String> exclusions;
        private Thread uploader;

        public FormFeedback()
        {
            InitializeComponent();
            readURLs();
        }

        private void readURLs()
        {
            try
            {
                string[] lines = ReadLinesAtEnd("eventsFile.txt", 5);
                titles_ = new List<String>(lines);
            }
            catch (Exception exc)
            {
                Console.Out.WriteLine("Exception " + exc.ToString());
            }
        }

        public static string[] ReadLinesAtEnd(string filename, int linesToRead)
        {
            Queue<string> result = new Queue<string>(20);
            using (StreamReader stream = File.OpenText(filename))
            {
                string line;
                while ((line = stream.ReadLine()) != null)
                {
                    
                    string[] elements = line.Split(' ');
                    if (elements[0].Contains("BeforeNavigate")) 
                        if (!elements[1].Contains("about:home"))
                            result.Enqueue(elements[1].Trim().Split('?')[0]); 
                }
            }
            return result.ToArray();
        }

        private void Fill()
        {
            fillExclusions();
            listEntries = ProcessCE.GetProcesses();

            processListView.Items.Add(new ListViewItem("--- PROGRAMS ---"));

            foreach (ProcessInfo item in listEntries)
            {
                if (!exclusions.Contains(item.FullPath.Split('\\').Last()))
                 {
                        this.processListView.Columns[0].Width = this.processListView.Width - 4;
                        this.processListView.HeaderStyle = ColumnHeaderStyle.None;
                        processListView.Items.Add(new ListViewItem(new string[] { item.FullPath.Split('\\').Last().Replace(".exe", ""), "INVISIBLE" }));
                  }
             }
       
             try
             {
                    processListView.Items.Add(new ListViewItem("--- RECENT WEBPAGES ---"));
                    for (int i = 0; i < titles_.Count; i++)
                    {
                        processListView.Items.Add(new ListViewItem(titles_[i].ToString()));
                    }
                }
                catch (Exception exc) 
                {
                    Console.Out.WriteLine("Exception " + exc.ToString());
                }

                reasonListView.Items.Add(new ListViewItem("Slow"));
                reasonListView.Items.Add(new ListViewItem("Did not load"));

            
        }

        public static byte[] StrToByteArray(string str)
        {
            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
            return encoding.GetBytes(str);
        }


        private void fillExclusions()
        {
            exclusions = new List<string>();
            exclusions.Add("device.exe");
            exclusions.Add("filesys.exe");
            exclusions.Add("NK.EXE");
            exclusions.Add("shell32.exe");
            exclusions.Add("gwes.exe");
            exclusions.Add("services.exe");
            exclusions.Add("pMSNServer.exe");
            exclusions.Add("connmgr.exe");
            exclusions.Add("srvtrust.exe");
            exclusions.Add("ConManClient2.exe");
            exclusions.Add("EmulatorStub.exe");
            exclusions.Add("repllog.exe");
            exclusions.Add("telshell.exe");
            exclusions.Add("BTTray.exe");
            exclusions.Add("tmail.exe");
            exclusions.Add("appman.exe");
            exclusions.Add("fexplore.exe");
            exclusions.Add("home.exe");
            exclusions.Add("cprog.exe");
            exclusions.Add("cdial.exe");
            exclusions.Add("ObigoSvc.exe");
            exclusions.Add("CommLoader.exe");
            exclusions.Add("qimf_RegManagerStarter.exe");
            exclusions.Add("VCDaemon.exe");
            exclusions.Add("rapic.exe");
            exclusions.Add("rapic.exe");
            exclusions.Add("rapiclnt.exe");
            exclusions.Add("udp2tcp.exe");
            exclusions.Add("rnaapp.exe");
            exclusions.Add("poutlook.exe");
            exclusions.Add("nk.exe");
        }


        public void UploadFile()
        {
            Sender sender = new Sender();
            string localFile = "eventsFile.txt";
            if (File.Exists(localFile) == true && FormTesting.allowBrowsing == true)
            {
                try
                {
                    StreamReader rdr = new StreamReader(localFile);

                    string inLine = rdr.ReadLine();
                    string[] words = inLine.Split(' ');
                    inLine = "";
                    foreach (string word in words)
                    {
                        inLine += word.Split('?')[0] + " ";
                    }

                    while (inLine != null)
                    {
                        sender.send(FormTesting.hash + '|' + FormTesting.zipCode + '|' + FormTesting.provider + '|' + inLine);
                        inLine = rdr.ReadLine();

                        if (inLine != null)
                        {
                            words = inLine.Split(' ');
                            inLine = "";
                            foreach (string word in words)
                            {
                                inLine += word.Split('?')[0] + " ";
                            }
                        }
                    }

                    rdr.Close();
                    File.Delete(localFile);
                }
                catch (Exception exc)
                {
                    Console.Out.WriteLine("Exception " + exc.ToString());
                }
            }

            sender.send(FormTesting.hash + '|' + FormTesting.zipCode + '|' + FormTesting.provider + '|' + reasonListView.Items[reasonListView.SelectedIndices[0]].Text + '|' + processListView.Items[processListView.SelectedIndices[0]].Text);
        }

        private void menuItem3_Click(object sender, EventArgs e)
        {
            ThreadStart starter = new ThreadStart(UploadFile);
            uploader = new Thread(starter);
            uploader.Start();
        }

        private void FormFeedback_Load(object sender, EventArgs e)
        {
            processListView.Items.Clear();
            reasonListView.Items.Clear();
            readURLs();
            Fill();
            reasonListView.Items[0].Selected = true;
            processListView.Items[0].Selected = true;
        }

        private void FormFeedback_GotFocus(object sender, EventArgs e)
        {
            processListView.Items.Clear();
            reasonListView.Items.Clear();
            readURLs();
            Fill();
            reasonListView.Items[0].Selected = true;
            processListView.Items[0].Selected = true;
        }

        private void FormFeedback_LostFocus(object sender, EventArgs e)
        {
            if (uploader != null)
            {
                uploader.Abort();
            }
        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
            if (processListView.Focused == true)
            {
                reasonListView.Focus();
            }
            else
            {
                processListView.Focus();
            }
        }

        private void menuItem5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }

}