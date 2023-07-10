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
using static System.Net.Mime.MediaTypeNames;

namespace QLGiangVienWithEntity
{
    public partial class frmKhoa : Form
    {
        public frmKhoa()
        {
            InitializeComponent();
        }
        QLGiangVienEntities db = new QLGiangVienEntities();


        void loaddata()
        {
            dgv.Visible = true;

            var data = from dt in db.Khoas select new { maKhoa = dt.maKhoa, tenKhoa = dt.tenKhoa };
            dgv.DataSource = data.ToList();
            dgv.ReadOnly = true;
        }


        private void QLGV_Load(object sender, EventArgs e)
        {
        }

        private void dgvKhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmakhoa.ReadOnly = true;
            int i;
            i = dgv.CurrentRow.Index;
            txtmakhoa.Text = dgv.Rows[i].Cells[0].Value.ToString();
            txttenkhoa.Text = dgv.Rows[i].Cells[1].Value.ToString();
        }

        private void thembt_Click(object sender, EventArgs e)
        {
            if (txtmakhoa.Text == "" || txttenkhoa.Text == "")
            {
                txterror.Text = "Thiếu dữ liệu đầu vào!!";
            }
            else
            {
                Khoa mk = new Khoa();
                mk.maKhoa = txtmakhoa.Text;
                mk.tenKhoa = txttenkhoa.Text;
                txterror.Text = "";

                db.Khoas.Add(mk);
                db.SaveChanges();
                loaddata();
            }
        }
        private void sua_Click(object sender, EventArgs e)
        {
            Khoa sv = db.Khoas.Where(P => P.maKhoa == txtmakhoa.Text).SingleOrDefault();
            sv.maKhoa = txtmakhoa.Text;
            sv.tenKhoa = txttenkhoa.Text;
            db.SaveChanges();
            loaddata();

        }

        private void xoa_Click(object sender, EventArgs e)
        {
            Khoa sv = db.Khoas.Where(P => P.maKhoa == txtmakhoa.Text).SingleOrDefault();
            db.Khoas.Remove(sv);
            db.SaveChanges();
            loaddata();
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lammoi_Click(object sender, EventArgs e)
        {
            txtmakhoa.ReadOnly = false;
            txtmakhoa.Text = "";
            txttenkhoa.Text = ""; txterror.Text = "";

        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            loaddata();
        }
    }
}

