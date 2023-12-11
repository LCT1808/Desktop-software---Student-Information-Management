using Student_management.Config;
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
    public partial class frm_AccountsList : Form
    {
        MyDBContext context = new MyDBContext();

        public frm_AccountsList()
        {
            InitializeComponent();
        }

        public void enable_AccountInfo(bool b)
        {
            txtName.Enabled = b;
            txtPhone.Enabled = b;
            txtRole.Enabled = b;
            dtp.Enabled = false;
            radioLocked.Enabled = b;
            radioNormal.Enabled = b;
        }

        private void bLoginHistory_Click(object sender, EventArgs e)
        {
            string _username = grd.CurrentRow.Cells[1].Value.ToString(); ;

            frm_AccountLoginHistory _frm_AccountLoginHistory = new frm_AccountLoginHistory(_username);
            DialogResult result = _frm_AccountLoginHistory.ShowDialog();
        }

        private void frm_AccountsList_Load(object sender, EventArgs e)
        {
            grd.DataSource = context.Accounts.AsNoTracking().ToList();
            grd.Columns["Id"].Visible = false;
            grd.Columns["Pwd"].Visible = false;
            grd.Columns["Avatar"].Visible = false;
            grd.Columns["LoginHistories"].Visible = false;
            /*if (grd.Columns.Contains("Pwd"))
            {
                foreach (DataGridViewRow row in grd.Rows)
                {
                    row.Cells["Pwd"].Value = new string('*', 10);
                }
            }*/
            enable_AccountInfo(false);
            bLoginHistory.Enabled = false;
        }

        public void status_locked(bool b)
        {
            radioLocked.Checked = b;
            if (radioLocked.Checked == b)
            {
                radioNormal.Checked = !b;
            }
        }

        private void grd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            enable_AccountInfo(true);
            txtName.Enabled = false;
            txtPhone.Enabled = false;
            dtp.Enabled = false;
            txtRole.Enabled = false;
            radioLocked.Enabled = false;
            radioNormal.Enabled = false;

            if (grd.CurrentRow == null) return;
            else
            {
                txtName.Text = grd.CurrentRow.Cells[4].Value.ToString();
                txtPhone.Text = grd.CurrentRow.Cells[6].Value.ToString();
                dtp.Value = DateTime.Parse(grd.CurrentRow.Cells[7].Value.ToString());
                txtRole.Text = grd.CurrentRow.Cells[3].Value.ToString();
                if (bool.Parse(grd.CurrentRow.Cells[8].Value.ToString()) == true)
                {
                    status_locked(false);
                }
                else status_locked(true);
                bLoginHistory.Enabled = true;
            }
        }
    }
}
