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
    public partial class frm_Login : Form
    {
        private MyDBContext myDBContext = new MyDBContext();
        public string _username { private set; get; }
        public string _role { private set; get; }
        public frm_Login()
        {
            InitializeComponent();

        }

        private void bOK_Click(object sender, EventArgs e)
        {
            var acc = myDBContext.Accounts.FirstOrDefault(account => account.Username.Equals(txtUsername.Text) && account.Pwd.Equals(txtPwd.Text));
            if (acc != null && acc.Status == true)
            {
                var _loginHistory = new LoginHistory() { Account = acc, LoginTime = DateTime.Now};
                myDBContext.LoginHistories.Add(_loginHistory);
                myDBContext.SaveChanges();
                _username = acc.Username;
                _role = acc.Role;
                this.Close();
            }
            else if (acc != null && acc.Status == false)
            {
                MessageBox.Show("This account was locked.");
                txtUsername.Text = "";
                txtPwd.Text = "";
                txtUsername.Focus();
            }
            else if (acc == null)
            {
                MessageBox.Show("Username or Password was incorrect!");
            }
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }
    }
}
