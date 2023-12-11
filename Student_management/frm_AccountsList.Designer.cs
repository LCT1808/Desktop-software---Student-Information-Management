
namespace Student_management
{
    partial class frm_AccountsList
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
            this.txtRole = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bLoginHistory = new System.Windows.Forms.Button();
            this.radioLocked = new System.Windows.Forms.RadioButton();
            this.radioNormal = new System.Windows.Forms.RadioButton();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grd = new System.Windows.Forms.DataGridView();
            this.grbAccountInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.SuspendLayout();
            // 
            // grbAccountInfo
            // 
            this.grbAccountInfo.Controls.Add(this.txtRole);
            this.grbAccountInfo.Controls.Add(this.label5);
            this.grbAccountInfo.Controls.Add(this.bLoginHistory);
            this.grbAccountInfo.Controls.Add(this.radioLocked);
            this.grbAccountInfo.Controls.Add(this.radioNormal);
            this.grbAccountInfo.Controls.Add(this.dtp);
            this.grbAccountInfo.Controls.Add(this.txtPhone);
            this.grbAccountInfo.Controls.Add(this.label4);
            this.grbAccountInfo.Controls.Add(this.label2);
            this.grbAccountInfo.Controls.Add(this.label1);
            this.grbAccountInfo.Controls.Add(this.label3);
            this.grbAccountInfo.Controls.Add(this.txtName);
            this.grbAccountInfo.Location = new System.Drawing.Point(8, 1);
            this.grbAccountInfo.Name = "grbAccountInfo";
            this.grbAccountInfo.Size = new System.Drawing.Size(785, 95);
            this.grbAccountInfo.TabIndex = 31;
            this.grbAccountInfo.TabStop = false;
            this.grbAccountInfo.Text = "Account Information";
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(420, 60);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(130, 26);
            this.txtRole.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(370, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 50;
            this.label5.Text = "Role:";
            // 
            // bLoginHistory
            // 
            this.bLoginHistory.Location = new System.Drawing.Point(632, 20);
            this.bLoginHistory.Name = "bLoginHistory";
            this.bLoginHistory.Size = new System.Drawing.Size(123, 31);
            this.bLoginHistory.TabIndex = 32;
            this.bLoginHistory.Text = "Login History";
            this.bLoginHistory.UseVisualStyleBackColor = true;
            this.bLoginHistory.Click += new System.EventHandler(this.bLoginHistory_Click);
            // 
            // radioLocked
            // 
            this.radioLocked.AutoSize = true;
            this.radioLocked.Location = new System.Drawing.Point(696, 62);
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
            this.radioNormal.Location = new System.Drawing.Point(613, 62);
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
            this.dtp.Location = new System.Drawing.Point(486, 25);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(116, 26);
            this.dtp.TabIndex = 8;
            this.dtp.Value = new System.DateTime(2023, 11, 26, 1, 0, 14, 0);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(102, 60);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(256, 26);
            this.txtPhone.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(555, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Status:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Full name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date of birth:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(102, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(256, 26);
            this.txtName.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grd);
            this.groupBox1.Location = new System.Drawing.Point(8, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(785, 348);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List of accounts";
            // 
            // grd
            // 
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd.Location = new System.Drawing.Point(6, 25);
            this.grd.Name = "grd";
            this.grd.RowHeadersWidth = 62;
            this.grd.RowTemplate.Height = 28;
            this.grd.Size = new System.Drawing.Size(773, 317);
            this.grd.TabIndex = 0;
            this.grd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_CellClick);
            // 
            // frm_AccountsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.grbAccountInfo);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_AccountsList";
            this.Text = "List of accounts";
            this.Load += new System.EventHandler(this.frm_AccountsList_Load);
            this.grbAccountInfo.ResumeLayout(false);
            this.grbAccountInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAccountInfo;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grd;
        private System.Windows.Forms.RadioButton radioLocked;
        private System.Windows.Forms.RadioButton radioNormal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bLoginHistory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRole;
    }
}