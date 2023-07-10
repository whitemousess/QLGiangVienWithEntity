using QLGiangVienWithEntity.clientUser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGiangVienWithEntity
{
    public partial class clMain : Form
    {

        string strNhan;

        public clMain(string giatrinhan) : this()
        {
            strNhan = giatrinhan;
            author.Text = strNhan;
        }

        public clMain()
        {
            InitializeComponent();
            chillform(new clHome());
        }

        public void chillform(Form form)
        {
            // Đặt thuộc tính cơ bản của form
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            // Thêm form vào panel
            panel.Controls.Clear();  // Xóa toàn bộ controls hiện có trong panel
            panel.Controls.Add(form);

            // Thiết lập kích thước Size bằng với panel
            form.Size = panel.ClientSize;

            // Hiển thị form trong panel
            form.Show();
        }

        private void clMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            chillform(new clHome());
        }

        private void btnsv_Click(object sender, EventArgs e)
        {
            chillform(new clSV());
        }

        private void btnlop_Click(object sender, EventArgs e)
        {
            chillform(new clLop());
        }

        private void btndiem_Click(object sender, EventArgs e)
        {
            chillform(new clDiemsv());
        }

        private void logout_LinkClicked(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void feedback_Click(object sender, EventArgs e)
        {
            chillform(new clFeedBack(author.Text));
        }
    }
}
