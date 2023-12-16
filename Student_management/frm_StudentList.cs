using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using Student_management.Config;
using Student_management.DTO;
using Student_management.Helpers;

namespace Student_management
{
    public partial class frm_StudentList : Form
    {
        MyDBContext context = new MyDBContext();
        private string _role;
        public frm_StudentList(string role)
        {
            InitializeComponent();
            _role = role;
        }

        public void show_GRD()
        {
            grd.DataSource = context.Students.ToList();
            grd.Columns["Id"].Visible = false;
            grd.Columns["Certificates"].Visible = false;
        }

        public void clear_grbStudentInfo()
        {
            txtID.Text = "";
            txtName.Text = "";
            dtp.Value = DateTime.Now;
            cbbDepartment.SelectedIndex = -1;
        }

        private void bDetails_Click(object sender, EventArgs e)
        {
            string _stuID = txtID.Text;

            frm_StudentDetails _frm_studentDetails = new frm_StudentDetails(_stuID, _role);
            DialogResult result = _frm_studentDetails.ShowDialog();
        }

        private void frm_StudentList_Load(object sender, EventArgs e)
        {
            if (_role == "employee")
            {
                bExport.Enabled = false;
                bImport.Enabled = false;
            }
            cbbSort.SelectedIndex = 0;
            show_GRD();

            grbStudentInfo.Enabled = false;
        }

        private void grd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bDetails.Enabled = true;
            grbStudentInfo.Enabled = true;
            txtID.Enabled = false;
            txtName.Enabled = false;
            cbbDepartment.Enabled = false;
            dtp.Enabled = false;

            if (grd.CurrentRow == null) return;
            else
            {
                txtID.Text = grd.CurrentRow.Cells[1].Value.ToString();
                txtName.Text = grd.CurrentRow.Cells[2].Value.ToString();
                dtp.Value = DateTime.Parse(grd.CurrentRow.Cells[3].Value.ToString());
                cbbDepartment.Text = grd.CurrentRow.Cells[4].Value.ToString();
            }
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            var _student = context.Students.ToList();
            var _keyword = txtSearch.Text;

            var _search = _student.Where(s => s.Fullname.Contains(_keyword) || s.Department.Contains(_keyword) || s.StudentID.Contains(_keyword) || s.DateOfBirth.ToString().Contains(_keyword));
            grd.DataSource = _search.ToList();
        }

        private void cbbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbSort.SelectedIndex == 0)
            {
                grd.DataSource = context.Students.ToList();
            }
            else if (cbbSort.SelectedIndex == 1)
            {
                grd.DataSource = context.Students.OrderBy(s => s.Fullname).ToList();
            }
            else if (cbbSort.SelectedIndex == 2)
            {
                grd.DataSource = context.Students.OrderBy(s => s.DateOfBirth).ToList();
            }
            else if (cbbSort.SelectedIndex == 3)
            {
                grd.DataSource = context.Students.OrderBy(s => s.Department).ToList();
            }
        }

        private void bImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog() {
                Filter = "Excel Files (.xlsx)|*.xlsx| CSV Files (.csv)|*.csv",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            var _listStudent = new List<Student>();

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
                                _listCellValue.Add(worksheet.Cells[i,j].Text);
                            }
                            if (!skip)
                            {
                                _listStudent.Add(new Student()
                                {
                                    StudentID = _listCellValue[0],
                                    Fullname = _listCellValue[1],
                                    DateOfBirth = DateTime.Parse(_listCellValue[2]),
                                    Department = _listCellValue[3]
                                });
                            }
                            
                        }
                    }
                    foreach (var student in _listStudent)
                    {
                        context.Students.Add(student);
                    }
                    context.SaveChanges();
                    MessageBox.Show("Import successfully.");
                    this.frm_StudentList_Load(sender, e);
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
                "StudentId",
                "Fullname",
                "DateOfBirth",
                "Department"
            };
            ExportData.ExportToData(grd, listHeader);
        }
    }
}
