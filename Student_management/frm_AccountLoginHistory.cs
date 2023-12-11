using Student_management.Config;
using Student_management.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_management
{
    public partial class frm_AccountLoginHistory : Form
    {
        private string _username;
        MyDBContext context = new MyDBContext();
        private Account _account;

        public frm_AccountLoginHistory(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void frm_AccountLoginHistory_Load(object sender, EventArgs e)
        {
            txtName.Enabled = false;
            txtPhone.Enabled = false;
            txtUsername.Enabled = false;
            dtp.Enabled = false;
            cbbRole.Enabled = false;
            radioLocked.Enabled = false;
            radioNormal.Enabled = false;

            txtUsername.Text = _username;
            _account = context.Accounts.AsQueryable().Include(a => a.LoginHistories).FirstOrDefault(a => a.Username.Equals(_username));
            
            context.SaveChanges();

            if (_account.LoginHistories != null)
            {
                grd.DataSource = _account.LoginHistories.ToList();
                grd.Columns["Id"].Visible = false;
                grd.Columns["Account"].Visible = false;
            }
            txtPhone.Text = _account.Phone;
            txtName.Text = _account.Name;
            dtp.Value = _account.DateOfBirth;
            cbbRole.Text = _account.Role;
            if (bool.Parse(_account.Status.ToString()) == true)
            {
                radioNormal.Checked = true;
            }
            else radioLocked.Checked = false;

        }
    }
}
