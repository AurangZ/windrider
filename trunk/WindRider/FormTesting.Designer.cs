namespace WindRider
{
    partial class FormTesting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuFeedback = new System.Windows.Forms.MenuItem();
            this.menuTesting = new System.Windows.Forms.MenuItem();
            this.textZipcode = new System.Windows.Forms.TextBox();
            this.labelThanks = new System.Windows.Forms.Label();
            this.labelGen = new System.Windows.Forms.Label();
            this.textCarrier = new System.Windows.Forms.TextBox();
            this.checkBoxBrowsing = new System.Windows.Forms.CheckBox();
            this.feedbackLabel = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.labelWait = new System.Windows.Forms.Label();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuFeedback);
            this.mainMenu1.MenuItems.Add(this.menuTesting);
            // 
            // menuFeedback
            // 
            this.menuFeedback.Text = "Run tests";
            this.menuFeedback.Click += new System.EventHandler(this.menuTesting_Click);
            // 
            // menuTesting
            // 
            this.menuTesting.Text = "Feedback";
            this.menuTesting.Click += new System.EventHandler(this.menuFeedback_Click);
            // 
            // textZipcode
            // 
            this.textZipcode.AcceptsTab = true;
            this.textZipcode.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textZipcode.Location = new System.Drawing.Point(17, 32);
            this.textZipcode.Name = "textZipcode";
            this.textZipcode.Size = new System.Drawing.Size(133, 21);
            this.textZipcode.TabIndex = 0;
            // 
            // labelThanks
            // 
            this.labelThanks.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelThanks.Location = new System.Drawing.Point(15, 9);
            this.labelThanks.Name = "labelThanks";
            this.labelThanks.Size = new System.Drawing.Size(141, 20);
            this.labelThanks.Text = "Zipcode or Address:";
            // 
            // labelGen
            // 
            this.labelGen.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelGen.Location = new System.Drawing.Point(17, 61);
            this.labelGen.Name = "labelGen";
            this.labelGen.Size = new System.Drawing.Size(100, 20);
            this.labelGen.Text = "Carrier:";
            // 
            // textCarrier
            // 
            this.textCarrier.AcceptsTab = true;
            this.textCarrier.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textCarrier.Location = new System.Drawing.Point(17, 86);
            this.textCarrier.Name = "textCarrier";
            this.textCarrier.Size = new System.Drawing.Size(133, 21);
            this.textCarrier.TabIndex = 4;
            // 
            // checkBoxBrowsing
            // 
            this.checkBoxBrowsing.Checked = true;
            this.checkBoxBrowsing.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBrowsing.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.checkBoxBrowsing.Location = new System.Drawing.Point(-3, 123);
            this.checkBoxBrowsing.Name = "checkBoxBrowsing";
            this.checkBoxBrowsing.Size = new System.Drawing.Size(172, 20);
            this.checkBoxBrowsing.TabIndex = 10;
            this.checkBoxBrowsing.Text = "Send Browsing Info";
            // 
            // feedbackLabel
            // 
            this.feedbackLabel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.feedbackLabel.Location = new System.Drawing.Point(1, 157);
            this.feedbackLabel.Name = "feedbackLabel";
            this.feedbackLabel.Size = new System.Drawing.Size(168, 20);
            this.feedbackLabel.Text = "Thank You for your feedback!";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(21, 113);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(132, 20);
            this.progressBar.Visible = false;
            // 
            // labelWait
            // 
            this.labelWait.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.labelWait.ForeColor = System.Drawing.Color.Black;
            this.labelWait.Location = new System.Drawing.Point(35, 146);
            this.labelWait.Name = "labelWait";
            this.labelWait.Size = new System.Drawing.Size(100, 20);
            this.labelWait.Text = "Please wait ...";
            this.labelWait.Visible = false;
            // 
            // labelSpeed
            // 
            this.labelSpeed.Location = new System.Drawing.Point(3, 177);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(100, 20);
            // 
            // FormTesting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.labelWait);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.feedbackLabel);
            this.Controls.Add(this.checkBoxBrowsing);
            this.Controls.Add(this.textCarrier);
            this.Controls.Add(this.labelGen);
            this.Controls.Add(this.labelThanks);
            this.Controls.Add(this.textZipcode);
            this.Menu = this.mainMenu1;
            this.Name = "FormTesting";
            this.Text = "WindRider";
            this.Load += new System.EventHandler(this.FormTesting_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textZipcode;
        private System.Windows.Forms.Label labelThanks;
        private System.Windows.Forms.Label labelGen;
        private System.Windows.Forms.TextBox textCarrier;
        private System.Windows.Forms.MenuItem menuFeedback;
        private System.Windows.Forms.CheckBox checkBoxBrowsing;
        private System.Windows.Forms.MenuItem menuTesting;
        private System.Windows.Forms.Label feedbackLabel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label labelWait;
        private System.Windows.Forms.Label labelSpeed;
    }
}