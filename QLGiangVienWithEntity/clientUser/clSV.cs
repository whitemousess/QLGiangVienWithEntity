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
    public partial class clSV : Form
    {

        QLGiangVienEntities client = new QLGiangVienEntities();
            
        public clSV()
        {
            InitializeComponent();
            loadcbb();
        }

        public void loadsv()
        {
            dgvSinhvien.Visible = true;
           var data = from dt in client.sinhviens 
                      join l in client.lops on dt.malop equals l.Malop
                      select new { masv = dt.masv, hoten = dt.hoten, gender = dt.gender, dob = dt.dob , sdt = dt.sdt, tenlop = l.Tenlop };
            dgvSinhvien.DataSource = data.ToList();
            dgvSinhvien.ReadOnly = true;
        }

        public void loadcbb()
        {
            var cbL = from dt in client.lops select new { malop = dt.Malop, tenlop = dt.Tenlop };
            var iL = cbL.Select(x => new { Text = x.tenlop }).ToList();
            cbb.DisplayMember = "Text";
            cbb.DataSource = iL;
        }

        public void search()
        {
            var data = from dt in client.sinhviens
                       join l in client.lops on dt.malop equals l.Malop
                       select new { masv = dt.masv, hoten = dt.hoten, gender = dt.gender, dob = dt.dob, sdt = dt.sdt,  tenlop = l.Tenlop };

            dgvSinhvien.DataSource = data.Where(P => P.tenlop.Contains(cbb.Text)).ToList();

        }

        private void btnsv_Click(object sender, EventArgs e)
        {
            loadsv();
        }

       
        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menulop_Click(object sender, EventArgs e)
        {
            Close();
            clLop lop = new clLop();
            lop.Show();
        }

        private void menudiem_Click(object sender, EventArgs e)
        {
            Close();
            clDiemsv diemsv = new clDiemsv();
            diemsv.Show();
        }

        private void thoátToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void đăngNhậpToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
        }


        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            search();
        }
    }
}
