using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace QLGiangVienWithEntity
{
    public partial class frmMonDay : Form
    {
        public frmMonDay()
        {
            InitializeComponent();
        }

        QLGiangVienEntities db  = new QLGiangVienEntities();

        public void reload()
        {
            txterror.Text = "";
            txtmamon.ReadOnly = false;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        public void loadcbbox()
        {
            var cbbox = from cbb in db.GVs select new { magv = cbb.magv, tengv = cbb.hoten };
            var items = cbbox.Select(x => new { Text = x.magv + " - " + x.tengv, Value = x.magv }).ToList();
            txtmagv.DisplayMember = "Text";
            txtmagv.ValueMember = "Value";
            txtmagv.DataSource = items;
        }

        private void dgvMonday_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmamon.ReadOnly = true;
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

            txtmamon.DataBindings.Clear();
            txtmagv.DataBindings.Clear();
            txttenmon.DataBindings.Clear();
            txttrinhdo.DataBindings.Clear();

            txtmamon.DataBindings.Add("Text", dgvMonDay.DataSource, "mamon", true, DataSourceUpdateMode.Never);
            txtmagv.Text = dgvMonDay.CurrentRow.Cells["magv"].Value.ToString() + " - " + dgvMonDay.CurrentRow.Cells["tengv"].Value.ToString(); ;

            txttenmon.DataBindings.Add("Text", dgvMonDay.DataSource, "tenmon", true, DataSourceUpdateMode.Never);
            txttrinhdo.DataBindings.Add("Text", dgvMonDay.DataSource, "trinhdo", true, DataSourceUpdateMode.Never);
        }


        void loaddata()
        {
            dgvMonDay.Visible = true;
            //link
            var data = from dt in db.mondays join d in db.GVs on dt.magv equals d.magv select new { mamon= dt.mamon, magv = dt.magv,tengv = d.hoten, tenmon = dt.tenmon, trinhdo = dt.trinhdo };
            dgvMonDay.DataSource = data.ToList();
            dgvMonDay.ReadOnly = true;
        }
        private void frmMonDay_Load(object sender, EventArgs e)
        {
            loadcbbox();
            reload();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            {
                if (txtmamon.Text == "" || txtmagv.Text == "" || txttenmon.Text == "" || txttrinhdo.Text == "")
                {
                    txterror.Text = "Thiếu dữ liệu đầu vào!!";
                }
                else
                {
                    txterror.Text = "";
                    string mGV = txtmagv.Text;
                    string[] lmGV = mGV.Split('-');
                    string MGV = lmGV[0].Trim();
                    monday md = new monday();
                    md.mamon = txtmamon.Text;
                    md.magv = MGV;
                    md.tenmon = txttenmon.Text;
                    md.trinhdo = txttrinhdo.Text;
                   
                    

                    db.mondays.Add(md);
                    db.SaveChanges();
                    loaddata();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string mGV = txtmagv.Text;
            string[] lmGV = mGV.Split('-');
            string MGV = lmGV[0].Trim();
            monday md = db.mondays.Where(P => P.mamon == txtmamon.Text).SingleOrDefault();
            md.mamon = txtmamon.Text;
            md.magv = MGV;
            md.tenmon = txttenmon.Text;
            md.trinhdo = txttrinhdo.Text;

            db.SaveChanges();
            loaddata();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            monday md = db.mondays.Where(P => P.mamon == txtmamon.Text).SingleOrDefault();
            db.mondays.Remove(md);
            db.SaveChanges();
            loaddata();
        }

       

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            reload();
            txtmamon.ReadOnly = false;
            txtmagv.Text = "";
            txttenmon.Text = "";
            txttrinhdo.Text = "";
            txtmamon.Text = "";
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            loaddata();

        }
    }
}
