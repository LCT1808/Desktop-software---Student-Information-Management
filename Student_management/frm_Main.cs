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
    public partial class frm_Main : Form
    {
        private Form currentForm;
        private string _username;
        private string _role;
        public frm_Main()
        {
            InitializeComponent();
        }

        public void OpenChildForm(Form newForm)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            currentForm = newForm;
            currentForm.TopLevel = false;
            panel.Controls.Add(currentForm);
            newForm.Show();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            frm_Login f = new frm_Login();
            f.FormClosed += (args, s) => {
                _username = f._username;
                _role = f._role;
            };
            DialogResult result = f.ShowDialog();
            
            if (_role == "manager")
            {
                EditAccountMenuItem.Enabled = false;
            }
            if (_role == "employee")
            {
                EditAccountMenuItem.Enabled = false;
                EditStudentMenuItem.Enabled = false;
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_StudentEdit());
            return;
        }

        private void listOfSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_AccountsList());
            return;
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_AccountEdit());
            return;
        }

        private void changeProToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_AccountChangePicture(_username));
            return;
        }

        private void listOfStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_StudentList(_role));
            return;
        }
    }
}
