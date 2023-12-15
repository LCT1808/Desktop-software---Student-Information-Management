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
    public partial class frm_AccountEdit : Form
    {
        MyDBContext context = new MyDBContext();
        private int condition;
        private Account _account;

        public frm_AccountEdit()
        {
            InitializeComponent();
        }

        public void enable_buttons(bool t)
        {
            bDelete.Enabled = t;
            bAdd.Enabled = t;
            bEdit.Enabled = t;
            bSave.Enabled = t;
        }

        public void clear_grbAccountInfo()
        {
            txtUsername.Text = "";
            txtPhone.Text = "";
            txtName.Text = "";
            dtp.Value = DateTime.Now;
            cbbRole.SelectedIndex = -1;
            radioNormal.Checked = false;
            radioNormal.Checked = false;
        }

        public void enable_AccountInfo(bool b)
        {
            txtName.Enabled = b;
            txtPhone.Enabled = b;
            txtUsername.Enabled = b;
            dtp.Enabled = b;
            cbbRole.Enabled = b;
            radioLocked.Enabled = b;
            radioNormal.Enabled = b;
        }

        public void show_GRD()
        {
            grd.DataSource = context.Accounts.AsNoTracking().ToList();
            grd.Columns["Id"].Visible = false;
            grd.Columns["Pwd"].Visible = false;
            grd.Columns["LoginHistories"].Visible = false;
            grd.Columns["Avatar"].Visible = false;
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirm deletion of this information.", "Reconfirm", MessageBoxButtons.YesNo);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                var _account = context.Accounts.FirstOrDefault(a => a.Username.Equals(txtUsername.Text));
                context.Accounts.Remove(_account);
                context.SaveChanges();

                show_GRD();
                default_begin();
            }
        }

        private void frm_AccountEdit_Load(object sender, EventArgs e)
        {
            show_GRD();
            enable_AccountInfo(false);
            enable_buttons(false);
            bAdd.Enabled = true;
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            if (condition == 2)
            {
                clear_grbAccountInfo();
                radioLocked.Checked = false;
                txtUsername.Focus();
            }
            enable_AccountInfo(true);
            enable_buttons(false);
            bSave.Enabled = true;

            condition = 0;
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            condition = 1;
            _account = context.Accounts.FirstOrDefault(a => a.Username.Equals(txtUsername.Text));

            enable_AccountInfo(true);
            enable_buttons(false);
            bSave.Enabled = true;
        }

        public bool status_check()
        {
            if (radioLocked.Checked == true)
            {
                if (radioNormal.Checked == true){ radioNormal.Checked = false; }
                return false;
            }
            else
            {
                if (radioNormal.Checked == false){ radioNormal.Checked = true; }
                return true;
            }
        }

        public void default_begin()
        {
            clear_grbAccountInfo();
            enable_AccountInfo(false);
            enable_buttons(false);
            bAdd.Enabled = true;
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (condition == 0)
            {
                if (txtName.Text != "" && txtPhone.Text != "" && txtUsername.Text != "" && cbbRole.SelectedIndex != -1 && (status_check() != true || status_check() != false))
                {
                    if (txtPhone.Text.Length != 10)
                    {
                        MessageBox.Show("Phone number must have 10 characters.");
                        this.bAdd_Click(sender, e);
                    }
                    else
                    {
                        var account = new Account()
                        {
                            Username = txtUsername.Text,
                            DateOfBirth = dtp.Value.Date,
                            Name = txtName.Text,
                            Phone = txtPhone.Text,
                            Role = cbbRole.Text,
                            Pwd = txtPhone.Text.Substring(4, 6),
                            Status = status_check()
                        };

                        DialogResult confirm = MessageBox.Show("Confirm you want to add this account.", "Confirm or not?", MessageBoxButtons.YesNo);

                        if (confirm == System.Windows.Forms.DialogResult.Yes)
                        {
                            context.Accounts.Add(account);
                            context.SaveChanges();
                            MessageBox.Show("A new account has been added successfully.");
                            show_GRD();
                            default_begin();
                        }
                        else
                        {
                            default_begin();
                        }
                    }
                }
                else
                {
                    DialogResult confirm = MessageBox.Show("Account information must be filled in completely.", "Continue adding or not?", MessageBoxButtons.YesNo);

                    if (confirm == System.Windows.Forms.DialogResult.Yes) { this.bAdd_Click(sender, e); }
                    else
                    {
                        default_begin();
                    }
                }
            }
            else if (condition == 1)
            {
                if (_account != null)
                {
                    _account.Username = txtUsername.Text;
                    _account.Name = txtName.Text;
                    _account.DateOfBirth = dtp.Value;
                    _account.Role = cbbRole.Text;
                    _account.Phone = txtPhone.Text;
                    _account.Status = status_check();
                    context.SaveChanges();
                    MessageBox.Show("The account information has been updated successfully.");

                    show_GRD();
                    default_begin();
                }
            }
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
            if (grd.CurrentRow == null) return;
            else
            {
                txtUsername.Text = grd.CurrentRow.Cells[1].Value.ToString();
                txtName.Text = grd.CurrentRow.Cells[4].Value.ToString();
                dtp.Value = DateTime.Parse(grd.CurrentRow.Cells[7].Value.ToString());
                cbbRole.Text = grd.CurrentRow.Cells[3].Value.ToString();
                txtPhone.Text = grd.CurrentRow.Cells[6].Value.ToString();
                if (bool.Parse(grd.CurrentRow.Cells[8].Value.ToString()) == true)
                {
                    status_locked(false);
                }
                else {
                    status_locked(true);
                }
            }

            enable_AccountInfo(false);
            enable_buttons(true);
            bSave.Enabled = false;
            condition = 2;
        }
    }
}
