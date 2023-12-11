
namespace Student_management
{
    partial class frm_AccountLoginHistory
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
            this.grbAccountInfo = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbRole = new System.Windows.Forms.ComboBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radioLocked = new System.Windows.Forms.RadioButton();
            this.radioNormal = new System.Windows.Forms.RadioButton();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grd = new System.Windows.Forms.DataGridView();
            this.grbAccountInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.SuspendLayout();
            // 
            // grbAccountInfo
            // 
            this.grbAccountInfo.Controls.Add(this.label6);
            this.grbAccountInfo.Controls.Add(this.cbbRole);
            this.grbAccountInfo.Controls.Add(this.txtPhone);
            this.grbAccountInfo.Controls.Add(this.label5);
            this.grbAccountInfo.Controls.Add(this.radioLocked);
            this.grbAccountInfo.Controls.Add(this.radioNormal);
            this.grbAccountInfo.Controls.Add(this.dtp);
            this.grbAccountInfo.Controls.Add(this.txtName);
            this.grbAccountInfo.Controls.Add(this.label4);
            this.grbAccountInfo.Controls.Add(this.label2);
            this.grbAccountInfo.Controls.Add(this.label1);
            this.grbAccountInfo.Controls.Add(this.label3);
            this.grbAccountInfo.Controls.Add(this.txtUsername);
            this.grbAccountInfo.Location = new System.Drawing.Point(8, 1);
            this.grbAccountInfo.Name = "grbAccountInfo";
            this.grbAccountInfo.Size = new System.Drawing.Size(785, 121);
            this.grbAccountInfo.TabIndex = 35;
            this.grbAccountInfo.TabStop = false;
            this.grbAccountInfo.Text = "Account Information";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(396, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 53;
            this.label6.Text = "Role:";
            // 
            // cbbRole
            // 
            this.cbbRole.FormattingEnabled = true;
            this.cbbRole.Location = new System.Drawing.Point(503, 57);
            this.cbbRole.Name = "cbbRole";
            this.cbbRole.Size = new System.Drawing.Size(204, 28);
            this.cbbRole.TabIndex = 52;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(102, 85);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(279, 26);
            this.txtPhone.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 50;
            this.label5.Text = "Phone:";
            // 
            // radioLocked
            // 
            this.radioLocked.AutoSize = true;
            this.radioLocked.Location = new System.Drawing.Point(626, 90);
            this.radioLocked.Name = "radioLocked";
            this.radioLocked.Size = new System.Drawing.Size(86, 24);
            this.radioLocked.TabIndex = 49;
            this.radioLocked.TabStop = true;
            this.radioLocked.Text = "Locked";
            this.radioLocked.UseVisualStyleBackColor = true;
            // 
            // radioNormal
            // 
            this.radioNormal.AutoSize = true;
            this.radioNormal.Location = new System.Drawing.Point(510, 90);
            this.radioNormal.Name = "radioNormal";
            this.radioNormal.Size = new System.Drawing.Size(84, 24);
            this.radioNormal.TabIndex = 48;
            this.radioNormal.TabStop = true;
            this.radioNormal.Text = "Normal";
            this.radioNormal.UseVisualStyleBackColor = true;
            // 
            // dtp
            // 
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp.Location = new System.Drawing.Point(503, 23);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(131, 26);
            this.dtp.TabIndex = 8;
            this.dtp.Value = new System.DateTime(2023, 11, 26, 1, 0, 14, 0);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(102, 53);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(279, 26);
            this.txtName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(396, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Status:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Full name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(396, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date of birth:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(102, 21);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(279, 26);
            this.txtUsername.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grd);
            this.groupBox1.Location = new System.Drawing.Point(8, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(785, 322);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login history";
            // 
            // grd
            // 
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd.Location = new System.Drawing.Point(5, 30);
            this.grd.Name = "grd";
            this.grd.RowHeadersWidth = 62;
            this.grd.RowTemplate.Height = 28;
            this.grd.Size = new System.Drawing.Size(773, 280);
            this.grd.TabIndex = 0;
            // 
            // frm_AccountLoginHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbAccountInfo);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_AccountLoginHistory";
            this.Text = "Login History";
            this.Load += new System.EventHandler(this.frm_AccountLoginHistory_Load);
            this.grbAccountInfo.ResumeLayout(false);
            this.grbAccountInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAccountInfo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbRole;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioLocked;
        private System.Windows.Forms.RadioButton radioNormal;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grd;
    }
}