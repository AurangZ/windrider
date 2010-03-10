namespace WindRider
{
    partial class FormFeedback
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
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem();
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem();
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.processListLabel = new System.Windows.Forms.Label();
            this.reasonsLabel = new System.Windows.Forms.Label();
            this.feedbackLabel = new System.Windows.Forms.Label();
            this.processListView = new System.Windows.Forms.ListView();
            this.Name = new System.Windows.Forms.ColumnHeader();
            this.reasonListView = new System.Windows.Forms.ListView();
            this.Reason = new System.Windows.Forms.ColumnHeader();
            this.mainMenu2 = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.mainMenu3 = new System.Windows.Forms.MainMenu();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem3);
            this.mainMenu1.MenuItems.Add(this.menuItem2);
            // 
            // menuItem3
            // 
            this.menuItem3.Text = "Feedback";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.MenuItems.Add(this.menuItem4);
            this.menuItem2.MenuItems.Add(this.menuItem5);
            this.menuItem2.Text = "Utils";
            // 
            // processListLabel
            // 
            this.processListLabel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.processListLabel.Location = new System.Drawing.Point(1, 2);
            this.processListLabel.Name = "processListLabel";
            this.processListLabel.Size = new System.Drawing.Size(170, 35);
            this.processListLabel.Text = "Select the program that you are not satisfied with:";
            // 
            // reasonsLabel
            // 
            this.reasonsLabel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.reasonsLabel.Location = new System.Drawing.Point(3, 136);
            this.reasonsLabel.Name = "reasonsLabel";
            this.reasonsLabel.Size = new System.Drawing.Size(211, 20);
            this.reasonsLabel.Text = "Why are you not satisfied?";
            // 
            // feedbackLabel
            // 
            this.feedbackLabel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.feedbackLabel.Location = new System.Drawing.Point(1, 225);
            this.feedbackLabel.Name = "feedbackLabel";
            this.feedbackLabel.Size = new System.Drawing.Size(226, 20);
            this.feedbackLabel.Text = "Thank You for your feedback!";
            // 
            // processListView
            // 
            this.processListView.Columns.Add(this.Name);
            this.processListView.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.processListView.Location = new System.Drawing.Point(2, 35);
            this.processListView.Name = "processListView";
            this.processListView.Size = new System.Drawing.Size(224, 100);
            this.processListView.TabIndex = 10;
            this.processListView.View = System.Windows.Forms.View.Details;
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.Width = 154;
            // 
            // reasonListView
            // 
            this.reasonListView.Columns.Add(this.Reason);
            this.reasonListView.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            listViewItem7.Text = "Slow";
            listViewItem8.Text = "Did not load";
            this.reasonListView.Items.Add(listViewItem7);
            this.reasonListView.Items.Add(listViewItem8);
            this.reasonListView.Location = new System.Drawing.Point(3, 153);
            this.reasonListView.Name = "reasonListView";
            this.reasonListView.Size = new System.Drawing.Size(223, 68);
            this.reasonListView.TabIndex = 14;
            this.reasonListView.View = System.Windows.Forms.View.Details;
            // 
            // Reason
            // 
            this.Reason.Text = "Reason";
            this.Reason.Width = 153;
            // 
            // mainMenu2
            // 
            this.mainMenu2.MenuItems.Add(this.menuItem1);
            // 
            // menuItem1
            // 
            this.menuItem1.Text = "Send feedback";
            // 
            // menuItem4
            // 
            this.menuItem4.Text = "Tab";
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Text = "Back";
            this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // FormFeedback
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(240, 320);
            this.Controls.Add(this.reasonListView);
            this.Controls.Add(this.processListView);
            this.Controls.Add(this.feedbackLabel);
            this.Controls.Add(this.reasonsLabel);
            this.Controls.Add(this.processListLabel);
            this.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.KeyPreview = true;
            this.Menu = this.mainMenu1;
            this.Text = "WindRider";
            this.Load += new System.EventHandler(this.FormFeedback_Load);
            this.LostFocus += new System.EventHandler(this.FormFeedback_LostFocus);
            this.GotFocus += new System.EventHandler(this.FormFeedback_GotFocus);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label processListLabel;
        private System.Windows.Forms.Label reasonsLabel;
        private System.Windows.Forms.Label feedbackLabel;
        private System.Windows.Forms.ListView processListView;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ListView reasonListView;
        private System.Windows.Forms.ColumnHeader Reason;
        private System.Windows.Forms.MainMenu mainMenu2;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MainMenu mainMenu3;
    }
}

