using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLGiangVienWithEntity
{
    public partial class frmLogin : Form
    {
        QLGiangVienEntities db = new QLGiangVienEntities();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
        }

        public void login()
        {
            string username = txtusername.Text;
            string password = txtpass.Text;
            var main = db.users.Where(a => a.username == username && a.password == password && a.type == "0").FirstOrDefault();
            var client = db.users.Where(a => a.username == username && a.password == password && a.type == "1").FirstOrDefault();
            var checkname = db.users.Where(a => a.username == username).FirstOrDefault();

            if (main != null)
            {
                this.Hide();
                frmMain m = new frmMain(txtusername.Text);
                m.Show();
            }
            else if(client != null){
                this.Hide();
                clMain cl = new clMain(txtusername.Text);
                cl.Show();
            }   else if (checkname == null)
            {
                txterror.Text = "";
                txterror.Text = "Tài khoản không tồn tại !!";
            }
            else
            {
                txterror.Text = "";
                txterror.Text = "Mật khẩu không chính xác !!";
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegister res = new frmRegister();
            res.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
