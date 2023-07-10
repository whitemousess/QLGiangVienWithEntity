using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLGiangVienWithEntity
{
    public partial class frmRegister : Form
    {
        QLGiangVienEntities db = new QLGiangVienEntities();
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.Show();
        }

        public void register()
        {
            string txtun = txtusername.Text;
            string txtem = txtmail.Text;
            var username = db.users.Where(a => a.username == txtun).FirstOrDefault();
            var email = db.users.Where(a => a.email == txtem).FirstOrDefault();

            if (txtusername.Text == "" || txtpass.Text == "" || txtmail.Text == "")
            {
                txterror.Text = "";
                txtsucces.Text = "";
                txterror.Text = "Vui lòng nhập đầy đủ thông tin !";
            }else if(username != null)
            {
                txterror.Text = "";
                txtsucces.Text = "";
                txterror.Text = "Tài khoản đã tồn tại !";
            }
            else if (email != null)
            {
                txterror.Text = "";
                txtsucces.Text = "";
                txterror.Text = "Email đã tồn tại !";
            }
            else
            {
                txterror.Text = "";
                user us = new user();
                us.username = txtusername.Text;
                us.password = txtpass.Text;
                us.type = "1";
                db.users.Add(us);
                db.SaveChanges();
                txtsucces.Text = "Register account is success!";
               
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            register();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtsdt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                register();
            }
        }

        private void frmRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
