
namespace Student_management
{
    partial class frm_AccountChangePicture
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
            this.picture = new System.Windows.Forms.PictureBox();
            this.grbAccountInfo = new System.Windows.Forms.GroupBox();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.bChange = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.grbAccountInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(41, 21);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(311, 329);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // grbAccountInfo
            // 
            this.grbAccountInfo.Controls.Add(this.txtRole);
            this.grbAccountInfo.Controls.Add(this.label6);
            this.grbAccountInfo.Controls.Add(this.txtPhone);
            this.grbAccountInfo.Controls.Add(this.label5);
            this.grbAccountInfo.Controls.Add(this.dtp);
            this.grbAccountInfo.Controls.Add(this.txtName);
            this.grbAccountInfo.Controls.Add(this.label2);
            this.grbAccountInfo.Controls.Add(this.label1);
            this.grbAccountInfo.Controls.Add(this.label3);
            this.grbAccountInfo.Controls.Add(this.txtUsername);
            this.grbAccountInfo.Location = new System.Drawing.Point(370, 59);
            this.grbAccountInfo.Name = "grbAccountInfo";
            this.grbAccountInfo.Size = new System.Drawing.Size(392, 259);
            this.grbAccountInfo.TabIndex = 34;
            this.grbAccountInfo.TabStop = false;
            this.grbAccountInfo.Text = "Account Information";
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(133, 218);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(203, 26);
            this.txtRole.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 53;
            this.label6.Text = "Role:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(133, 126);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(203, 26);
            this.txtPhone.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 50;
            this.label5.Text = "Phone:";
            // 
            // dtp
            // 
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp.Location = new System.Drawing.Point(133, 172);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(131, 26);
            this.dtp.TabIndex = 8;
            this.dtp.Value = new System.DateTime(2023, 11, 26, 1, 0, 14, 0);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(133, 80);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(203, 26);
            this.txtName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Full name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date of birth:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(133, 34);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(203, 26);
            this.txtUsername.TabIndex = 4;
            // 
            // bChange
            // 
            this.bChange.Location = new System.Drawing.Point(171, 359);
            this.bChange.Name = "bChange";
            this.bChange.Size = new System.Drawing.Size(165, 31);
            this.bChange.TabIndex = 55;
            this.bChange.Text = "Change Picture";
            this.bChange.UseVisualStyleBackColor = true;
            this.bChange.Click += new System.EventHandler(this.bChange_Click);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(401, 359);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(165, 31);
            this.bSave.TabIndex = 56;
            this.bSave.Text = "Save change";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // frm_AccountChangePicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.bChange);
            this.Controls.Add(this.grbAccountInfo);
            this.Controls.Add(this.picture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_AccountChangePicture";
            this.Text = "Change Profile Picture";
            this.Load += new System.EventHandler(this.frm_AccountChangePicture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.grbAccountInfo.ResumeLayout(false);
            this.grbAccountInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.GroupBox grbAccountInfo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.Button bChange;
        private System.Windows.Forms.Button bSave;
    }
}