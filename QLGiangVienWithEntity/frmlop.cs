using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace QLGiangVienWithEntity
{
    public partial class frmlop : Form
    {
        QLGiangVienEntities db = new QLGiangVienEntities();
        public frmlop()
        {
            InitializeComponent();
        }
        private void frmlop_Load(object sender, EventArgs e)
        {
            reload();
            loadcbb();
        }

        public void reload()
        {
            txtmalop.ReadOnly = false;
            them.Enabled = true;
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
        }

        public void loaddata()
        {
            dgv.Visible = true;

            //link
            var data = from dt in db.lops join gv in db.GVs on dt.magv equals gv.magv
                       join k in db.Khoas on dt.makhoa equals k.maKhoa select new { Malop = dt.Malop, Tenlop = dt.Tenlop, magv = dt.magv,tengv = gv.hoten, makhoa = dt.makhoa,tenkhoa = k.tenKhoa,  nienkhoa = dt.NienKhoa };
            dgv.DataSource = data.ToList();
            dgv.ReadOnly = true;
        }

        public void loadcbb()
        {
            var cbgv = from gv in db.GVs select new { magv = gv.magv, tengv = gv.hoten };
            var iGV = cbgv.Select(x => new { Text = x.magv + " - " + x.tengv, Value = x.magv }).ToList();
            txtmagv.DisplayMember = "Text";
            txtmagv.ValueMember = "Value";
            txtmagv.DataSource = iGV;

            var cbkhoa = from khoa in db.Khoas select new { makhoa = khoa.maKhoa, tenkhoa = khoa.tenKhoa };
            var iKhoa = cbkhoa.Select(x => new { Text = x.makhoa + " - " + x.tenkhoa, Value = x.makhoa }).ToList();
            txtmakhoa.DisplayMember = "Text";
            txtmakhoa.ValueMember = "Value";
            txtmakhoa.DataSource = iKhoa;
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txterror.Text = "";
            txtmalop.Text = "";
            txttenlop.Text = "";
            txtmagv.Text = "";
            txtnienkhoa.Text = "";
            txtmakhoa.Text = ""; 
            reload();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void them_Click(object sender, EventArgs e)
        {
            if (txtmalop.Text == "" || txttenlop.Text == "" || txtnienkhoa.Text == "" || txtmagv.Text == "" || txtmakhoa.Text == "")
            {
                txterror.Text = "Thiếu dữ liệu đầu vào!!";    
            }
            else
            {
                                   //GV
                string mGV= txtmagv.Text;
                string[] lmGV = mGV.Split('-');
                string MGV = lmGV[0].Trim();
                                  //Khoa
                string mKhoa = txtmakhoa.Text;
                string[] lmKhoa = mKhoa.Split('-');
                string MKhoa = lmKhoa[0].Trim();

                lop d = new lop();
                d.Malop = txtmalop.Text;
                d.Tenlop = txttenlop.Text;
                d.NienKhoa = txtnienkhoa.Text;
                d.magv = MGV;
                d.makhoa = MKhoa;
                txterror.Text = "";
                db.lops.Add(d);
                db.SaveChanges();
                loaddata();
            }
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            {
                //GV
                string mGV = txtmagv.Text;
                string[] lmGV = mGV.Split('-');
                string MGV = lmGV[0].Trim();
                //Khoa
                string mKhoa = txtmakhoa.Text;
                string[] lmKhoa = mKhoa.Split('-');
                string MKhoa = lmKhoa[0].Trim();
                lop d = db.lops.Where(P => P.Malop == txtmalop.Text).SingleOrDefault();
                d.Malop = txtmalop.Text;
                d.Tenlop = txttenlop.Text;
                d.NienKhoa = txtnienkhoa.Text;
                d.magv = MGV;
                d.makhoa = MKhoa;
                db.SaveChanges();
                loaddata();

            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            lop d = db.lops.Where((P) => P.Malop == txtmalop.Text).SingleOrDefault();
            db.lops.Remove(d);
            db.SaveChanges();
            loaddata();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmalop.ReadOnly = true;
            them.Enabled = false;
            btnxoa.Enabled = true;
            btnsua.Enabled = true;

            txtmalop.DataBindings.Clear();
            txttenlop.DataBindings.Clear();
            txtnienkhoa.DataBindings.Clear();
            txtmagv.DataBindings.Clear();
            txtmakhoa.DataBindings.Clear();

            txtmalop.DataBindings.Add("Text", dgv.DataSource, "malop", true, DataSourceUpdateMode.Never);
            txttenlop.DataBindings.Add("Text", dgv.DataSource, "tenlop", true, DataSourceUpdateMode.Never);
            txtnienkhoa.DataBindings.Add("Text", dgv.DataSource, "nienkhoa", true, DataSourceUpdateMode.Never);
            txtmagv.Text = dgv.CurrentRow.Cells["magv"].Value.ToString() + " - " + dgv.CurrentRow.Cells["tengv"].Value.ToString(); ;
            txtmakhoa.Text = dgv.CurrentRow.Cells["makhoa"].Value.ToString() + " - " + dgv.CurrentRow.Cells["tenkhoa"].Value.ToString(); ;
        }

    }
}
