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
    public partial class clLop : Form
    {
        QLGiangVienEntities db = new QLGiangVienEntities();
        public clLop()
        {
            InitializeComponent();
            loadcbb();
        }

        public void loaddata()
        {
            dgv.Visible = true;
            //link
            var data = from dt in db.lops
                       join gv in db.GVs on dt.magv equals gv.magv
                       join k in db.Khoas on dt.makhoa equals k.maKhoa
                       select new { Tenlop = dt.Tenlop,tengv = gv.hoten, tenkhoa = k.tenKhoa, nienkhoa = dt.NienKhoa };
            dgv.DataSource = data.ToList();
            dgv.ReadOnly = true;
        }

        public void loadcbb()
        {
            var cbkhoa = from dt in db.Khoas select new { makhoa = dt.maKhoa, tenkhoa = dt.tenKhoa };
            var iKhoa = cbkhoa.Select(x => new { Text = x.tenkhoa }).ToList();
            cbbKhoa.DisplayMember = "Text";
            cbbKhoa.DataSource = iKhoa;
        }

        public void search()
        {
            var data = from dt in db.lops
                       join gv in db.GVs on dt.magv equals gv.magv
                       join k in db.Khoas on dt.makhoa equals k.maKhoa
                       select new { Tenlop = dt.Tenlop, tengv = gv.hoten, tenkhoa = k.tenKhoa, nienkhoa = dt.NienKhoa };

            dgv.DataSource = data.Where(P => P.tenkhoa.Contains(cbbKhoa.Text)).ToList();

        }

        private void menuSV_Click(object sender, EventArgs e)
        {
            Close();
            clSV sV = new clSV();
            sV.Show();
        }

        private void menudiem_Click(object sender, EventArgs e)
        {
            Close();
            clDiemsv diem = new clDiemsv();
            diem.Show();
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            loaddata();
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
