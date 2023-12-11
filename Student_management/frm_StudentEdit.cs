using Student_management.Config;
using Student_management.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_management
{
    public partial class frm_StudentEdit : Form
    {
        MyDBContext context = new MyDBContext();
        Student _student;
        int condition;

        public frm_StudentEdit()
        {
            InitializeComponent();
        }

        public void enable_buttons(bool t)
        {
            bDelete.Enabled = t;
            bEdit.Enabled = t;
            bSave.Enabled = t;
            bAdd.Enabled = t;
        }

        public void clear_grbStudentInfo()
        {
            txtID.Text = "";
            txtName.Text = "";
            dtp.Value = DateTime.Now;
            cbbDepartment.SelectedIndex = -1;
        }

        public void show_GRD()
        {
            grd.DataSource = context.Students.ToList();
            grd.Columns["Id"].Visible = false;
            grd.Columns["Certificates"].Visible = false;
        }

        private void frm_StudentEdit_Load(object sender, EventArgs e)
        {
            show_GRD();
            enable_StudentInfo(false);
            enable_buttons(false);
            bAdd.Enabled = true;
        }

        public void enable_StudentInfo(bool b)
        {
            txtID.Enabled = b;
            txtName.Enabled = b;
            dtp.Enabled = b;
            cbbDepartment.Enabled = b;
        }

        private void grd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grd.CurrentRow == null) return;
            else
            {
                txtID.Text = grd.CurrentRow.Cells[1].Value.ToString();
                txtName.Text = grd.CurrentRow.Cells[2].Value.ToString();
                dtp.Value = DateTime.Parse(grd.CurrentRow.Cells[3].Value.ToString());
                cbbDepartment.Text = grd.CurrentRow.Cells[4].Value.ToString();
            }

            enable_StudentInfo(false);
            enable_buttons(true);
            bSave.Enabled = false;
            condition = 2;
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            condition = 1;
            _student = context.Students.FirstOrDefault(s => s.StudentID.Equals(txtID.Text));

            enable_StudentInfo(true);
            enable_buttons(false);
            bSave.Enabled = true;
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            if (condition == 2)
            {
                clear_grbStudentInfo();
                txtID.Focus();
            }
            enable_StudentInfo(true);
            enable_buttons(false);
            bSave.Enabled = true;

            condition = 0;
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (condition == 0)
            {
                if (txtID.Text != "" && txtName.Text != "" && cbbDepartment.SelectedIndex != -1)
                {
                    var student = new Student() { StudentID = txtID.Text, Fullname = txtName.Text, DateOfBirth = dtp.Value.Date, Department = cbbDepartment.Text };
                    context.Students.Add(student);
                    context.SaveChanges();
                    MessageBox.Show("A new student has been added successfully.");

                    show_GRD();
                    clear_grbStudentInfo();
                    enable_StudentInfo(false);
                    enable_buttons(false);
                    bAdd.Enabled = true;
                }
                else {
                    MessageBox.Show("Student information must be filled in completely.");
                    this.bAdd_Click(sender, e);
                }
            }
            else if (condition == 1)
            {
                if (_student != null)
                {
                    _student.StudentID = txtID.Text;
                    _student.Fullname = txtName.Text;
                    _student.DateOfBirth = dtp.Value;
                    _student.Department = cbbDepartment.Text;
                    context.SaveChanges();
                    MessageBox.Show("The student information has been updated successfully.");

                    show_GRD();
                    clear_grbStudentInfo();
                    enable_StudentInfo(false);
                    enable_buttons(false);
                    bAdd.Enabled = true;
                }
            }
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirm deletion of this information.", "Reconfirm", MessageBoxButtons.YesNo);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                var _student = context.Students.FirstOrDefault(s => s.StudentID.Equals(txtID.Text));
                context.Students.Remove(_student);
                context.SaveChanges();

                show_GRD();
                clear_grbStudentInfo();
                enable_buttons(false);
                bAdd.Enabled = true;
            }
        }
    }
}
