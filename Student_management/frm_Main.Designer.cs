
namespace Student_management
{
    partial class frm_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditStudentMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListOfAccountsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditAccountMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeProToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem,
            this.accountToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listOfStudentToolStripMenuItem,
            this.EditStudentMenuItem});
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.studentToolStripMenuItem.Text = "Student";
            // 
            // listOfStudentToolStripMenuItem
            // 
            this.listOfStudentToolStripMenuItem.Name = "listOfStudentToolStripMenuItem";
            this.listOfStudentToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.listOfStudentToolStripMenuItem.Text = "List of Students";
            this.listOfStudentToolStripMenuItem.Click += new System.EventHandler(this.listOfStudentToolStripMenuItem_Click);
            // 
            // EditStudentMenuItem
            // 
            this.EditStudentMenuItem.Name = "EditStudentMenuItem";
            this.EditStudentMenuItem.Size = new System.Drawing.Size(270, 34);
            this.EditStudentMenuItem.Text = "Edit";
            this.EditStudentMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ListOfAccountsMenuItem,
            this.EditAccountMenuItem,
            this.changeProToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(93, 29);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // ListOfAccountsMenuItem
            // 
            this.ListOfAccountsMenuItem.Name = "ListOfAccountsMenuItem";
            this.ListOfAccountsMenuItem.Size = new System.Drawing.Size(287, 34);
            this.ListOfAccountsMenuItem.Text = "List of Accounts";
            this.ListOfAccountsMenuItem.Click += new System.EventHandler(this.listOfSystemToolStripMenuItem_Click);
            // 
            // EditAccountMenuItem
            // 
            this.EditAccountMenuItem.Name = "EditAccountMenuItem";
            this.EditAccountMenuItem.Size = new System.Drawing.Size(287, 34);
            this.EditAccountMenuItem.Text = "Edit";
            this.EditAccountMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem1_Click);
            // 
            // changeProToolStripMenuItem
            // 
            this.changeProToolStripMenuItem.Name = "changeProToolStripMenuItem";
            this.changeProToolStripMenuItem.Size = new System.Drawing.Size(287, 34);
            this.changeProToolStripMenuItem.Text = "Change Profile Picture";
            this.changeProToolStripMenuItem.Click += new System.EventHandler(this.changeProToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(287, 34);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.Location = new System.Drawing.Point(0, 36);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(800, 413);
            this.panel.TabIndex = 1;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_Main";
            this.Text = "Student information management";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditStudentMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListOfAccountsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditAccountMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeProToolStripMenuItem;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
    }
}

