using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace QLGiangVienWithEntity
{
    public partial class Form1 : Form
    {
        QLGiangVienEntities db = new QLGiangVienEntities();
        public Form1()
        {
            InitializeComponent();
        }

        public void loaddata()
        {
            dgv.Visible = true;
            //link
            var data = from dt in db.diemsvs
                       join sv in db.sinhviens on dt.masv equals sv.masv
                       join m in db.mondays on dt.mamon equals m.mamon
                       select new { id = dt.id, masv = dt.masv, tensv = sv.hoten, mamon = dt.mamon, tenmon = m.tenmon, diemthi = dt.diemthi, diemquatrinh = dt.diemquatrinh, diemtrungbinh = dt.diemtrungbinh, trangthai = dt.trangthai };
            dgv.DataSource = data.ToList();
            dgv.ReadOnly = true;
        }

        public void loadcbb()
        {
            var cbsv = from cbb in db.sinhviens select new { masv = cbb.masv, tensv = cbb.hoten };
            var sv = cbsv.Select(x => new { Text = x.masv + " - " + x.tensv, Value = x.masv }).ToList();
            txtmasv.DisplayMember = "Text";
            txtmasv.ValueMember = "Value";
            txtmasv.DataSource = sv;

            var cbmm = from cbb in db.mondays select new { mamon = cbb.mamon, tenmon = cbb.tenmon };
            var mm = cbmm.Select(x => new { Text = x.mamon + " - " + x.tenmon, Value = x.mamon }).ToList();
            txtmonhoc.DisplayMember = "Text";
            txtmonhoc.ValueMember = "Value";
            txtmonhoc.DataSource = mm;

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            reload();
            loadcbb();
        }

        public void reload()
        {
            txterror.Text = "";
            txtid.Text = "";
            txtmasv.Text = "";
            txtmonhoc.Text = "";
            txtdiemthi.Text = "";
            txtdiemquatrinh.Text = "";
            txtdiemtb.Text = "";
            txtchecked.Text = "";
            txtmasv.Enabled = true;
            txtmonhoc.Enabled = true;
            btnthem.Enabled = false;
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
        }


        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txtmasv.Text == "" || txtmonhoc.Text == "" || txtmasv.Text == "")
            {
                txterror.Text = "Thiếu dữ liệu đầu vào !!!";
            }
            else
            {
                txterror.Text = "";
                string msv = txtmasv.Text;
                string ml = txtmonhoc.Text;
                string[] lml = msv.Split('-');
                string[] lmm = ml.Split('-');
                string Msv = lml[0].Trim();
                string Mm = lmm[0].Trim();
                diemsv d = new diemsv();
                d.masv = Msv;
                d.mamon = Mm;
                d.diemthi = txtdiemthi.Text;
                d.diemquatrinh = txtdiemquatrinh.Text;
                d.diemtrungbinh = txtdiemtb.Text;
                d.trangthai = txtchecked.Text;
                db.diemsvs.Add(d);
                db.SaveChanges();
                reload();
                loaddata();
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            reload();
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            {
                var idpoint = Convert.ToInt32(txtid.Text);
                diemsv d = db.diemsvs.Where(P => P.id == idpoint).SingleOrDefault();
                string msv = txtmasv.Text;
                string ml = txtmonhoc.Text;
                string[] lml = msv.Split('-');
                string[] lmm = ml.Split('-');
                string Msv = lml[0].Trim();
                string Mm = lmm[0].Trim();
                d.masv = Msv;
                d.mamon = Mm;
                d.diemthi = txtdiemthi.Text;
                d.diemquatrinh = txtdiemquatrinh.Text;
                d.diemtrungbinh = txtdiemtb.Text;
                d.trangthai = txtchecked.Text;
                db.SaveChanges();
                reload();
                loaddata();

            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            var idpoint = Convert.ToInt32(txtid.Text);
            diemsv d = db.diemsvs.Where((P) => P.id == idpoint).SingleOrDefault();
            db.diemsvs.Remove(d);
            db.SaveChanges();
            reload();
            loaddata();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.DataBindings.Clear();
            txtmasv.DataBindings.Clear();
            txtmonhoc.DataBindings.Clear();
            txtdiemthi.DataBindings.Clear();
            txtdiemquatrinh.DataBindings.Clear();
            txtdiemtb.DataBindings.Clear();
            txtchecked.DataBindings.Clear();

            txtmasv.Enabled = false;
            txtmonhoc.Enabled = false;
            btnthem.Enabled = false;
            btnxoa.Enabled = true;
            btnsua.Enabled = true;


            txtid.DataBindings.Add("Text", dgv.DataSource, "id", true, DataSourceUpdateMode.Never);
            txtmasv.Text = dgv.CurrentRow.Cells["masv"].Value.ToString() + " - " + dgv.CurrentRow.Cells["tensv"].Value.ToString(); ;
            txtmonhoc.Text = dgv.CurrentRow.Cells["mamon"].Value.ToString() + " - " + dgv.CurrentRow.Cells["tenmon"].Value.ToString(); ;
            txtdiemthi.DataBindings.Add("Text", dgv.DataSource, "diemthi", true, DataSourceUpdateMode.Never);
            txtdiemquatrinh.DataBindings.Add("Text", dgv.DataSource, "diemquatrinh", true, DataSourceUpdateMode.Never);
            txtdiemtb.DataBindings.Add("Text", dgv.DataSource, "diemtrungbinh", true, DataSourceUpdateMode.Never);
            txtchecked.DataBindings.Add("Text", dgv.DataSource, "trangthai", true, DataSourceUpdateMode.Never);
            if (txtchecked.Text == "Đạt")
            {
                txtchecked.ForeColor = Color.Green;
            }
            else
            {
                txtchecked.ForeColor = Color.Red;
            }
        }

        private void checkbtn_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(txtdiemthi.Text);
            int b = Int32.Parse(txtdiemquatrinh.Text);

            double avg = ((a * 0.6) + (b * 0.4));

            txtdiemtb.Text = avg.ToString();

            if (avg > 4)
            {
                txtchecked.Text = "Đạt";
                txtchecked.ForeColor = Color.Green;
            }
            else
            {
                txtchecked.Text = "Rớt";
                txtchecked.ForeColor = Color.Red;
            }
            btnthem.Enabled = true;
        }

        private void checkbtn_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Tính điểm trung bình", checkbtn);
        }
    }
}
