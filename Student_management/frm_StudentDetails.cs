using OfficeOpenXml;
using Student_management.Config;
using Student_management.DTO;
using Student_management.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_management
{
    public partial class frm_StudentDetails : Form
    {
        private string _studentID { get; set; }
        private string _role;
        MyDBContext context = new MyDBContext();
        int condition;
        private Student _student;
        private Certificate _certificate;

        public frm_StudentDetails(string _stuID, string role)
        {
            InitializeComponent();
            _studentID = _stuID;
            _role = role;
        }

        public void default_begin()
        {
            clear_grbCerInfo();
            enable_CerInfo(false);
            enable_buttons(false);
            bAdd.Enabled = true;
        }

        public void show_GRD()
        {
            if (_student.Certificates != null)
            {
                grdCer.DataSource = _student.Certificates.ToList();
                grdCer.Columns["Student"].Visible = false;
                grdCer.Columns["Id"].Visible = false;
            }
        }

        public void clear_grbCerInfo()
        {
            txtCerID.Text = "";
            txtCerName.Text = "";
            dtpCer.Value = DateTime.Now;
        }

        public void enable_buttons(bool t)
        {
            bDelete.Enabled = t;
            bEdit.Enabled = t;
            bSave.Enabled = t;
            bAdd.Enabled = t;
        }

        public void enable_CerInfo(bool b)
        {
            txtCerID.Enabled = b;
            txtCerName.Enabled = b;
            dtpCer.Enabled = b;
        }

        private void frm_StudentDetails_Load(object sender, EventArgs e)
        {
            if (_role == "employee")
            {
                enable_buttons(false);
                bImport.Enabled = false;
                bExport.Enabled = false;
            }
            else
            {
                enable_CerInfo(false);
                enable_buttons(false);
                bAdd.Enabled = true;
            }

            txtID.Enabled = false;
            txtName.Enabled = false;
            dtp.Enabled = false;
            txtDepartment.Enabled = false;
            txtCerID.Enabled = false;
            txtCerName.Enabled = false;
            dtpCer.Enabled = false;

            txtID.Text = _studentID;
            _student = context.Students.AsQueryable().Include(s => s.Certificates).FirstOrDefault(s => s.StudentID.Equals(_studentID));
            show_GRD();
            txtName.Text = _student.Fullname;
            dtp.Value = _student.DateOfBirth;
            txtDepartment.Text = _student.Department;
        }

        private void grdCer_Click(object sender, EventArgs e)
        {
            if (grdCer.CurrentRow == null) return;
            else
            {
                txtCerID.Text = grdCer.CurrentRow.Cells[1].Value.ToString();
                txtCerName.Text = grdCer.CurrentRow.Cells[3].Value.ToString();
                dtpCer.Value = DateTime.Parse(grdCer.CurrentRow.Cells[4].Value.ToString());
            }

            if (_role != "employee")
            {
                enable_buttons(true);
                bSave.Enabled = false;
                condition = 2;
            }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            if (condition == 2)
            {
                clear_grbCerInfo();
                txtCerID.Focus();
            }
            enable_CerInfo(true);
            enable_buttons(false);
            bSave.Enabled = true;

            condition = 0;
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (condition == 0)
            {
                if (txtCerID.Text != "" && txtCerName.Text != "")
                {
                    var certificate = new Certificate() { Student = _student, CerID = txtCerID.Text, Date = dtpCer.Value.Date, NameOfCer = txtCerName.Text };
                    
                    DialogResult confirm = MessageBox.Show("Confirm you want to add this certificate.", "Confirm or not?", MessageBoxButtons.YesNo);

                    if (confirm == System.Windows.Forms.DialogResult.Yes) {
                        context.Certificates.Add(certificate);
                        context.SaveChanges();
                        MessageBox.Show("A new certificate has been added successfully.");
                        show_GRD();
                        default_begin();
                    }
                    else
                    {
                        default_begin();
                    }
                }
                else
                {
                    DialogResult confirm = MessageBox.Show("Certificate information must be filled in completely.", "Continue adding or not?", MessageBoxButtons.YesNo);
                    
                    if (confirm == System.Windows.Forms.DialogResult.Yes) { this.bAdd_Click(sender, e); }
                    else {
                        default_begin();
                    }
                }
            }
            else if (condition == 1)
            {
                if (_certificate != null)
                {
                    _certificate.CerID = txtCerID.Text;
                    _certificate.NameOfCer = txtCerName.Text;
                    _certificate.Date = dtpCer.Value;
                    context.SaveChanges();
                    MessageBox.Show("The certificate information has been updated successfully.");

                    show_GRD();
                    default_begin();
                }
            }
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirm deletion of this information.", "Reconfirm", MessageBoxButtons.YesNo);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                var _cer = context.Certificates.FirstOrDefault(cer => cer.CerID.Equals(txtCerID.Text));
                context.Certificates.Remove(_cer);
                context.SaveChanges();
                show_GRD();
                default_begin();
            }
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            enable_buttons(false);
            bSave.Enabled = true;
            enable_CerInfo(true);

            condition = 1;
            _certificate = context.Certificates.FirstOrDefault(cer => cer.CerID.Equals(txtCerID.Text));
        }

        private void bImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog()
            {
                Filter = "Excel Files (.xlsx)|*.xlsx| CSV Files (.csv)|*.csv",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            var _listCertificate = new List<Certificate>();

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                    using (var package = new ExcelPackage(new FileInfo(openFile.FileName)))
                    {
                        var worksheet = package.Workbook.Worksheets.First();
                        int columnCount = worksheet.Dimension.End.Column;
                        for (int i = 2; i < worksheet.Dimension.End.Row; i++)
                        {
                            var skip = false;
                            var _listCellValue = new List<String>();
                            for (int j = 1; j <= columnCount; j++)
                            {
                                var cellValue = worksheet.Cells[i, j].Text;
                                if (string.IsNullOrEmpty(cellValue))
                                {
                                    skip = true;
                                    break;
                                }
                                _listCellValue.Add(cellValue);
                            }
                            if (!skip)
                            {
                                _listCertificate.Add(new Certificate()
                                {
                                    CerID = _listCellValue[0],
                                    NameOfCer = _listCellValue[1],
                                    Student = _student,
                                    Date = DateTime.Parse(_listCellValue[2])
                                }); ;
                            }
                        }
                    }
                    foreach (var cer in _listCertificate)
                    {
                        context.Certificates.Add(cer);
                    }
                    context.SaveChanges();
                    MessageBox.Show("Import successfully.");
                    this.frm_StudentDetails_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Import fail: " + ex.Message);
                }
            }
        }

        private void bExport_Click(object sender, EventArgs e)
        {
            var listHeader = new List<String>() {
                "CerID",
                "NameOfCer",
                "Date"
            };
            ExportData.ExportToData(grdCer, listHeader);
        }
    }
}
