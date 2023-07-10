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
    public partial class clDiemsv : Form
    {
        QLGiangVienEntities db = new QLGiangVienEntities();
        public clDiemsv()
        {
            InitializeComponent();
            loadcbb();
        }

        public void loaddata()
        {
            dgv.Visible = true;
            //link
            var data = from dt in db.diemsvs
                       join sv in db.sinhviens on dt.masv equals sv.masv
                       join m in db.mondays on dt.mamon equals m.mamon
                       select new {masv = dt.masv, tensv = sv.hoten,tenmon = m.tenmon, diemthi = dt.diemthi, diemquatrinh = dt.diemquatrinh, diemtrungbinh = dt.diemtrungbinh , trangthai = dt.trangthai  };
            dgv.DataSource = data.ToList();
            dgv.ReadOnly = true;
        }

        public void loadcbb()
        {
            var cbSV = from dt in db.sinhviens select new { masv = dt.masv, tensv = dt.hoten };
            var iSV = cbSV.Select(x => new { Text = x.masv + " - " + x.tensv }).ToList();
            cbb.DisplayMember = "Text";
            cbb.DataSource = iSV;
        }

        public void search()
        {
            string mSV = cbb.Text;
            string[] lmSV = mSV.Split('-');
            string MSV = lmSV[0].Trim();

            var data = from dt in db.diemsvs
                       join sv in db.sinhviens on dt.masv equals sv.masv
                       join m in db.mondays on dt.mamon equals m.mamon
                       select new { masv = dt.masv, tensv = sv.hoten, tenmon = m.tenmon, diemthi = dt.diemthi, diemquatrinh = dt.diemquatrinh, diemtrungbinh = dt.diemtrungbinh, trangthai = dt.trangthai };

            dgv.DataSource = data.Where(P => P.masv.Contains(MSV)).ToList();

        }

        private void btnload_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void menusv_Click(object sender, EventArgs e)
        {
            Close();
            clSV sv = new clSV();
            sv.Show();
        }

        private void menulop_Click(object sender, EventArgs e)
        {
            Close();
            clLop lop = new clLop();
            lop.Show();
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
