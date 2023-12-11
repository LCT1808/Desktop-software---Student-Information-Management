
namespace Student_management
{
    partial class frm_AccountEdit
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
            this.grbSearch = new System.Windows.Forms.GroupBox();
            this.bSave = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.grbAccountInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.grbSearch.SuspendLayout();
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
            this.grbAccountInfo.TabIndex = 33;
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
            this.cbbRole.Items.AddRange(new object[] {
            "admin",
            "manager",
            "employee"});
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
            this.groupBox1.Location = new System.Drawing.Point(8, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(785, 273);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List of accounts";
            // 
            // grd
            // 
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd.Location = new System.Drawing.Point(5, 30);
            this.grd.Name = "grd";
            this.grd.RowHeadersWidth = 62;
            this.grd.RowTemplate.Height = 28;
            this.grd.Size = new System.Drawing.Size(773, 237);
            this.grd.TabIndex = 0;
            this.grd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_CellClick);
            // 
            // grbSearch
            // 
            this.grbSearch.Controls.Add(this.bSave);
            this.grbSearch.Controls.Add(this.bAdd);
            this.grbSearch.Controls.Add(this.bEdit);
            this.grbSearch.Controls.Add(this.bDelete);
            this.grbSearch.Location = new System.Drawing.Point(8, 121);
            this.grbSearch.Name = "grbSearch";
            this.grbSearch.Size = new System.Drawing.Size(785, 57);
            this.grbSearch.TabIndex = 34;
            this.grbSearch.TabStop = false;
            this.grbSearch.Text = "Update";
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(566, 17);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(94, 31);
            this.bSave.TabIndex = 30;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(274, 17);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(94, 31);
            this.bAdd.TabIndex = 29;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bEdit
            // 
            this.bEdit.Location = new System.Drawing.Point(422, 17);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(94, 31);
            this.bEdit.TabIndex = 28;
            this.bEdit.Text = "Edit";
            this.bEdit.UseVisualStyleBackColor = true;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(124, 17);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(94, 31);
            this.bDelete.TabIndex = 27;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // frm_AccountEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.grbSearch);
            this.Controls.Add(this.grbAccountInfo);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_AccountEdit";
            this.Text = "Update account";
            this.Load += new System.EventHandler(this.frm_AccountEdit_Load);
            this.grbAccountInfo.ResumeLayout(false);
            this.grbAccountInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.grbSearch.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAccountInfo;
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
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbRole;
        private System.Windows.Forms.GroupBox grbSearch;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Button bDelete;
    }
}