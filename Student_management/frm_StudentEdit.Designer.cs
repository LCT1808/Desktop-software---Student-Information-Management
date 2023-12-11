
namespace Student_management
{
    partial class frm_StudentEdit
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
            this.grbStudentInfo = new System.Windows.Forms.GroupBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbDepartment = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.grbUpdate = new System.Windows.Forms.GroupBox();
            this.bSave = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grd = new System.Windows.Forms.DataGridView();
            this.grbStudentInfo.SuspendLayout();
            this.grbUpdate.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.SuspendLayout();
            // 
            // grbStudentInfo
            // 
            this.grbStudentInfo.Controls.Add(this.dtp);
            this.grbStudentInfo.Controls.Add(this.txtName);
            this.grbStudentInfo.Controls.Add(this.label4);
            this.grbStudentInfo.Controls.Add(this.cbbDepartment);
            this.grbStudentInfo.Controls.Add(this.label2);
            this.grbStudentInfo.Controls.Add(this.label1);
            this.grbStudentInfo.Controls.Add(this.label3);
            this.grbStudentInfo.Controls.Add(this.txtID);
            this.grbStudentInfo.Location = new System.Drawing.Point(7, -2);
            this.grbStudentInfo.Name = "grbStudentInfo";
            this.grbStudentInfo.Size = new System.Drawing.Size(785, 93);
            this.grbStudentInfo.TabIndex = 28;
            this.grbStudentInfo.TabStop = false;
            this.grbStudentInfo.Text = "Student Information";
            // 
            // dtp
            // 
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp.Location = new System.Drawing.Point(503, 25);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(116, 26);
            this.dtp.TabIndex = 8;
            this.dtp.Value = new System.DateTime(2023, 11, 26, 1, 0, 14, 0);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(102, 60);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(279, 26);
            this.txtName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(396, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Department:";
            // 
            // cbbDepartment
            // 
            this.cbbDepartment.FormattingEnabled = true;
            this.cbbDepartment.Items.AddRange(new object[] {
            "CNTT",
            "BHLD",
            "TCNH",
            "QTKD",
            "DUOC",
            "TTK"});
            this.cbbDepartment.Location = new System.Drawing.Point(503, 58);
            this.cbbDepartment.Name = "cbbDepartment";
            this.cbbDepartment.Size = new System.Drawing.Size(272, 28);
            this.cbbDepartment.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Full Name:";
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
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(102, 25);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(279, 26);
            this.txtID.TabIndex = 4;
            // 
            // grbUpdate
            // 
            this.grbUpdate.Controls.Add(this.bSave);
            this.grbUpdate.Controls.Add(this.bAdd);
            this.grbUpdate.Controls.Add(this.bEdit);
            this.grbUpdate.Controls.Add(this.bDelete);
            this.grbUpdate.Location = new System.Drawing.Point(7, 90);
            this.grbUpdate.Name = "grbUpdate";
            this.grbUpdate.Size = new System.Drawing.Size(785, 57);
            this.grbUpdate.TabIndex = 26;
            this.grbUpdate.TabStop = false;
            this.grbUpdate.Text = "Update";
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(566, 17);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(94, 31);
            this.bSave.TabIndex = 26;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(274, 17);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(94, 31);
            this.bAdd.TabIndex = 25;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bEdit
            // 
            this.bEdit.Location = new System.Drawing.Point(422, 17);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(94, 31);
            this.bEdit.TabIndex = 24;
            this.bEdit.Text = "Edit";
            this.bEdit.UseVisualStyleBackColor = true;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(124, 17);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(94, 31);
            this.bDelete.TabIndex = 23;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grd);
            this.groupBox1.Location = new System.Drawing.Point(7, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(785, 301);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List of Students";
            // 
            // grd
            // 
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd.Location = new System.Drawing.Point(6, 25);
            this.grd.Name = "grd";
            this.grd.RowHeadersWidth = 62;
            this.grd.RowTemplate.Height = 28;
            this.grd.Size = new System.Drawing.Size(773, 270);
            this.grd.TabIndex = 0;
            this.grd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_CellClick);
            // 
            // frm_StudentEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbUpdate);
            this.Controls.Add(this.grbStudentInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_StudentEdit";
            this.Text = "Update Student";
            this.Load += new System.EventHandler(this.frm_StudentEdit_Load);
            this.grbStudentInfo.ResumeLayout(false);
            this.grbStudentInfo.PerformLayout();
            this.grbUpdate.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbStudentInfo;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbDepartment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.GroupBox grbUpdate;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grd;
    }
}