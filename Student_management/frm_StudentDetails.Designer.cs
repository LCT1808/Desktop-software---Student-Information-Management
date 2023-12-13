
namespace Student_management
{
    partial class frm_StudentDetails
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
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.grbCertificateInfo = new System.Windows.Forms.GroupBox();
            this.bExport = new System.Windows.Forms.Button();
            this.bImport = new System.Windows.Forms.Button();
            this.dtpCer = new System.Windows.Forms.DateTimePicker();
            this.txtCerName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCerID = new System.Windows.Forms.TextBox();
            this.grbUpdate = new System.Windows.Forms.GroupBox();
            this.bSave = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grdCer = new System.Windows.Forms.DataGridView();
            this.grbStudentInfo.SuspendLayout();
            this.grbCertificateInfo.SuspendLayout();
            this.grbUpdate.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCer)).BeginInit();
            this.SuspendLayout();
            // 
            // grbStudentInfo
            // 
            this.grbStudentInfo.Controls.Add(this.txtDepartment);
            this.grbStudentInfo.Controls.Add(this.dtp);
            this.grbStudentInfo.Controls.Add(this.txtName);
            this.grbStudentInfo.Controls.Add(this.label4);
            this.grbStudentInfo.Controls.Add(this.label2);
            this.grbStudentInfo.Controls.Add(this.label1);
            this.grbStudentInfo.Controls.Add(this.label3);
            this.grbStudentInfo.Controls.Add(this.txtID);
            this.grbStudentInfo.Location = new System.Drawing.Point(10, 0);
            this.grbStudentInfo.Name = "grbStudentInfo";
            this.grbStudentInfo.Size = new System.Drawing.Size(381, 152);
            this.grbStudentInfo.TabIndex = 29;
            this.grbStudentInfo.TabStop = false;
            this.grbStudentInfo.Text = "Student Information";
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(119, 113);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(246, 26);
            this.txtDepartment.TabIndex = 9;
            // 
            // dtp
            // 
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp.Location = new System.Drawing.Point(119, 83);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(116, 26);
            this.dtp.TabIndex = 8;
            this.dtp.Value = new System.DateTime(2023, 11, 26, 1, 0, 14, 0);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(119, 52);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(246, 26);
            this.txtName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Department:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Full Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date of birth:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(119, 21);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(246, 26);
            this.txtID.TabIndex = 4;
            // 
            // grbCertificateInfo
            // 
            this.grbCertificateInfo.Controls.Add(this.bExport);
            this.grbCertificateInfo.Controls.Add(this.bImport);
            this.grbCertificateInfo.Controls.Add(this.dtpCer);
            this.grbCertificateInfo.Controls.Add(this.txtCerName);
            this.grbCertificateInfo.Controls.Add(this.label6);
            this.grbCertificateInfo.Controls.Add(this.label7);
            this.grbCertificateInfo.Controls.Add(this.label8);
            this.grbCertificateInfo.Controls.Add(this.txtCerID);
            this.grbCertificateInfo.Location = new System.Drawing.Point(406, 0);
            this.grbCertificateInfo.Name = "grbCertificateInfo";
            this.grbCertificateInfo.Size = new System.Drawing.Size(383, 152);
            this.grbCertificateInfo.TabIndex = 30;
            this.grbCertificateInfo.TabStop = false;
            this.grbCertificateInfo.Text = " Certificate Information";
            // 
            // bExport
            // 
            this.bExport.Location = new System.Drawing.Point(266, 115);
            this.bExport.Name = "bExport";
            this.bExport.Size = new System.Drawing.Size(94, 31);
            this.bExport.TabIndex = 32;
            this.bExport.Text = "Export";
            this.bExport.UseVisualStyleBackColor = true;
            this.bExport.Click += new System.EventHandler(this.bExport_Click);
            // 
            // bImport
            // 
            this.bImport.Location = new System.Drawing.Point(118, 115);
            this.bImport.Name = "bImport";
            this.bImport.Size = new System.Drawing.Size(94, 31);
            this.bImport.TabIndex = 31;
            this.bImport.Text = "Import";
            this.bImport.UseVisualStyleBackColor = true;
            this.bImport.Click += new System.EventHandler(this.bImport_Click);
            // 
            // dtpCer
            // 
            this.dtpCer.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCer.Location = new System.Drawing.Point(119, 84);
            this.dtpCer.Name = "dtpCer";
            this.dtpCer.Size = new System.Drawing.Size(116, 26);
            this.dtpCer.TabIndex = 8;
            this.dtpCer.Value = new System.DateTime(2023, 11, 26, 1, 0, 14, 0);
            // 
            // txtCerName
            // 
            this.txtCerName.Location = new System.Drawing.Point(119, 53);
            this.txtCerName.Name = "txtCerName";
            this.txtCerName.Size = new System.Drawing.Size(246, 26);
            this.txtCerName.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Date:";
            // 
            // txtCerID
            // 
            this.txtCerID.Location = new System.Drawing.Point(119, 24);
            this.txtCerID.Name = "txtCerID";
            this.txtCerID.Size = new System.Drawing.Size(246, 26);
            this.txtCerID.TabIndex = 4;
            // 
            // grbUpdate
            // 
            this.grbUpdate.Controls.Add(this.bSave);
            this.grbUpdate.Controls.Add(this.bAdd);
            this.grbUpdate.Controls.Add(this.bEdit);
            this.grbUpdate.Controls.Add(this.bDelete);
            this.grbUpdate.Location = new System.Drawing.Point(10, 151);
            this.grbUpdate.Name = "grbUpdate";
            this.grbUpdate.Size = new System.Drawing.Size(779, 57);
            this.grbUpdate.TabIndex = 27;
            this.grbUpdate.TabStop = false;
            this.grbUpdate.Text = "Update Certificate";
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(601, 20);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(94, 31);
            this.bSave.TabIndex = 26;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(309, 20);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(94, 31);
            this.bAdd.TabIndex = 25;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bEdit
            // 
            this.bEdit.Location = new System.Drawing.Point(457, 20);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(94, 31);
            this.bEdit.TabIndex = 24;
            this.bEdit.Text = "Edit";
            this.bEdit.UseVisualStyleBackColor = true;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(159, 20);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(94, 31);
            this.bDelete.TabIndex = 23;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdCer);
            this.groupBox1.Location = new System.Drawing.Point(10, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(779, 243);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List of Certificates";
            // 
            // grdCer
            // 
            this.grdCer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCer.Location = new System.Drawing.Point(5, 21);
            this.grdCer.Name = "grdCer";
            this.grdCer.RowHeadersWidth = 62;
            this.grdCer.RowTemplate.Height = 28;
            this.grdCer.Size = new System.Drawing.Size(768, 216);
            this.grdCer.TabIndex = 0;
            this.grdCer.Click += new System.EventHandler(this.grdCer_Click);
            // 
            // frm_StudentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbUpdate);
            this.Controls.Add(this.grbCertificateInfo);
            this.Controls.Add(this.grbStudentInfo);
            this.Name = "frm_StudentDetails";
            this.Text = "Student Details";
            this.Load += new System.EventHandler(this.frm_StudentDetails_Load);
            this.grbStudentInfo.ResumeLayout(false);
            this.grbStudentInfo.PerformLayout();
            this.grbCertificateInfo.ResumeLayout(false);
            this.grbCertificateInfo.PerformLayout();
            this.grbUpdate.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbStudentInfo;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.GroupBox grbCertificateInfo;
        private System.Windows.Forms.DateTimePicker dtpCer;
        private System.Windows.Forms.TextBox txtCerName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCerID;
        private System.Windows.Forms.GroupBox grbUpdate;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grdCer;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Button bExport;
        private System.Windows.Forms.Button bImport;
    }
}