
namespace Student_management
{
    partial class frm_StudentList
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
            this.bDetails = new System.Windows.Forms.Button();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbDepartment = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.grbSearch = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.bSearch = new System.Windows.Forms.Button();
            this.grbSort = new System.Windows.Forms.GroupBox();
            this.cbbSort = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grd = new System.Windows.Forms.DataGridView();
            this.grbData = new System.Windows.Forms.GroupBox();
            this.bExport = new System.Windows.Forms.Button();
            this.bImport = new System.Windows.Forms.Button();
            this.grbStudentInfo.SuspendLayout();
            this.grbSearch.SuspendLayout();
            this.grbSort.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.grbData.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbStudentInfo
            // 
            this.grbStudentInfo.Controls.Add(this.bDetails);
            this.grbStudentInfo.Controls.Add(this.dtp);
            this.grbStudentInfo.Controls.Add(this.txtName);
            this.grbStudentInfo.Controls.Add(this.label4);
            this.grbStudentInfo.Controls.Add(this.cbbDepartment);
            this.grbStudentInfo.Controls.Add(this.label2);
            this.grbStudentInfo.Controls.Add(this.label1);
            this.grbStudentInfo.Controls.Add(this.label3);
            this.grbStudentInfo.Controls.Add(this.txtID);
            this.grbStudentInfo.Location = new System.Drawing.Point(8, 1);
            this.grbStudentInfo.Name = "grbStudentInfo";
            this.grbStudentInfo.Size = new System.Drawing.Size(785, 93);
            this.grbStudentInfo.TabIndex = 31;
            this.grbStudentInfo.TabStop = false;
            this.grbStudentInfo.Text = "Student Information";
            // 
            // bDetails
            // 
            this.bDetails.Location = new System.Drawing.Point(645, 23);
            this.bDetails.Name = "bDetails";
            this.bDetails.Size = new System.Drawing.Size(94, 31);
            this.bDetails.TabIndex = 28;
            this.bDetails.Text = "Details";
            this.bDetails.UseVisualStyleBackColor = true;
            this.bDetails.Click += new System.EventHandler(this.bDetails_Click);
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
            // grbSearch
            // 
            this.grbSearch.Controls.Add(this.txtSearch);
            this.grbSearch.Controls.Add(this.bSearch);
            this.grbSearch.Location = new System.Drawing.Point(247, 93);
            this.grbSearch.Name = "grbSearch";
            this.grbSearch.Size = new System.Drawing.Size(316, 57);
            this.grbSearch.TabIndex = 30;
            this.grbSearch.TabStop = false;
            this.grbSearch.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(96, 22);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(214, 26);
            this.txtSearch.TabIndex = 29;
            // 
            // bSearch
            // 
            this.bSearch.Location = new System.Drawing.Point(9, 21);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(81, 31);
            this.bSearch.TabIndex = 22;
            this.bSearch.Text = "Search";
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // grbSort
            // 
            this.grbSort.Controls.Add(this.cbbSort);
            this.grbSort.Location = new System.Drawing.Point(8, 92);
            this.grbSort.Name = "grbSort";
            this.grbSort.Size = new System.Drawing.Size(233, 57);
            this.grbSort.TabIndex = 29;
            this.grbSort.TabStop = false;
            this.grbSort.Text = "Sort base on:";
            // 
            // cbbSort
            // 
            this.cbbSort.FormattingEnabled = true;
            this.cbbSort.Items.AddRange(new object[] {
            "Student ID",
            "Full Name",
            "Date of Birth",
            "Department"});
            this.cbbSort.Location = new System.Drawing.Point(44, 21);
            this.cbbSort.Name = "cbbSort";
            this.cbbSort.Size = new System.Drawing.Size(183, 28);
            this.cbbSort.TabIndex = 23;
            this.cbbSort.SelectedIndexChanged += new System.EventHandler(this.cbbSort_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grd);
            this.groupBox1.Location = new System.Drawing.Point(8, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(785, 301);
            this.groupBox1.TabIndex = 28;
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
            // grbData
            // 
            this.grbData.Controls.Add(this.bExport);
            this.grbData.Controls.Add(this.bImport);
            this.grbData.Location = new System.Drawing.Point(569, 93);
            this.grbData.Name = "grbData";
            this.grbData.Size = new System.Drawing.Size(223, 57);
            this.grbData.TabIndex = 31;
            this.grbData.TabStop = false;
            this.grbData.Text = "Data";
            // 
            // bExport
            // 
            this.bExport.Location = new System.Drawing.Point(119, 20);
            this.bExport.Name = "bExport";
            this.bExport.Size = new System.Drawing.Size(94, 31);
            this.bExport.TabIndex = 23;
            this.bExport.Text = "Export";
            this.bExport.UseVisualStyleBackColor = true;
            this.bExport.Click += new System.EventHandler(this.bExport_Click);
            // 
            // bImport
            // 
            this.bImport.Location = new System.Drawing.Point(14, 20);
            this.bImport.Name = "bImport";
            this.bImport.Size = new System.Drawing.Size(94, 31);
            this.bImport.TabIndex = 22;
            this.bImport.Text = "Import";
            this.bImport.UseVisualStyleBackColor = true;
            this.bImport.Click += new System.EventHandler(this.bImport_Click);
            // 
            // frm_StudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.grbData);
            this.Controls.Add(this.grbStudentInfo);
            this.Controls.Add(this.grbSearch);
            this.Controls.Add(this.grbSort);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_StudentList";
            this.Text = "List of Students";
            this.Load += new System.EventHandler(this.frm_StudentList_Load);
            this.grbStudentInfo.ResumeLayout(false);
            this.grbStudentInfo.PerformLayout();
            this.grbSearch.ResumeLayout(false);
            this.grbSearch.PerformLayout();
            this.grbSort.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.grbData.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbStudentInfo;
        private System.Windows.Forms.Button bDetails;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbDepartment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.GroupBox grbSearch;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.GroupBox grbSort;
        private System.Windows.Forms.ComboBox cbbSort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grd;
        private System.Windows.Forms.GroupBox grbData;
        private System.Windows.Forms.Button bExport;
        private System.Windows.Forms.Button bImport;
        private System.Windows.Forms.TextBox txtSearch;
    }
}