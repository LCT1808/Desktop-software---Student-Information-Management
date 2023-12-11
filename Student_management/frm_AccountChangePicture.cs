using Student_management.Config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_management
{
    public partial class frm_AccountChangePicture : Form
    {
        MyDBContext context = new MyDBContext();
        private string _username;
        public frm_AccountChangePicture(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void bChange_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    picture.Image = new Bitmap(openFileDialog.FileName);
                }
                catch (Exception ex) {
                    MessageBox.Show("Upload fail: " + ex.Message);
                }
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            var _acc = context.Accounts.FirstOrDefault(a => a.Username.Equals(_username));

            if (picture.Image != null)
                using (MemoryStream ms = new MemoryStream())
                {
                    ImageFormat imageFormat = ImageFormat.Png;
                    picture.Image.Save(ms, imageFormat);
                    _acc.Avatar = ms.ToArray();
                }
            context.SaveChanges();
            MessageBox.Show("Update profile's picture successfully.");
        }

        private void frm_AccountChangePicture_Load(object sender, EventArgs e)
        {
            txtUsername.Enabled = false;
            txtRole.Enabled = false;
            txtPhone.Enabled = false;
            txtName.Enabled = false;
            dtp.Enabled = false;

            var _acc = context.Accounts.FirstOrDefault(a => a.Username.Equals(_username));
            txtUsername.Text = _acc.Username;
            txtName.Text = _acc.Name;
            txtPhone.Text = _acc.Phone;
            dtp.Value = _acc.DateOfBirth;
            txtRole.Text = _acc.Role;

            if (_acc.Avatar != null)
            {
                using (MemoryStream ms = new MemoryStream(_acc.Avatar))
                {
                    picture.Image = Image.FromStream(ms);
                }
            }
            picture.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
