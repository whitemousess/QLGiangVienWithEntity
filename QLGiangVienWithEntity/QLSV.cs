using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGiangVienWithEntity
{
    public partial class QLSV : Form
    {
        QLGiangVienEntities db = new QLGiangVienEntities();
        public QLSV()
        {
            InitializeComponent();
        }


        public void loaddata()
        {
            dgv.Visible = true;
                //link
                var data = from dt in db.sinhviens join d in db.lops on dt.malop equals d.Malop select new { 
                    masv = dt.masv, hoten = dt.hoten, gender = dt.gender, dob = dt.dob, sdt = dt.sdt, malop = dt.malop, tenlop = d.Tenlop, address = dt.address, anhthe = dt.anhthe };
                    dgv.DataSource = data.ToList();
                    dgv.ReadOnly = true;
            
        }

        public void loadcbbox()
        {
                var cbbox = from cbb in db.lops select new { malop = cbb.Malop, tenlop = cbb.Tenlop };
                var items = cbbox.Select(x => new { Text = x.malop + " - " + x.tenlop, Value = x.malop }).ToList();
                cbmalop.DisplayMember = "Text";
                cbmalop.ValueMember = "Value";
                cbmalop.DataSource = items;
            
        }

        public void reload()
        {
            btnadd.Enabled = true;
            btndel.Enabled = false;
            btnedit.Enabled = false;
            txtmasv.ReadOnly = false;
            txtmasv.Text = "";
            txthoten.Text = "";
            txtsdt.Text = "";
            cbmalop.Text = "";
            txtaddress.Text = "";
            txtdob.Text = "";
            image.Image = null; txterror.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reload();
            loadcbbox();
        }



        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtmasv.Text == "" || txthoten.Text == "" || txtsdt.Text == "" || cbmalop.Text == "")
            {
                txterror.Text = "Thiếu dữ liệu đầu vào !!!";
            }
            else
            {
                txterror.Text = "";
                string mlop = cbmalop.Text;
                string[] lml = mlop.Split('-');
                string MLop = lml[0].Trim();

                sinhvien sv = new sinhvien();
                sv.masv = txtmasv.Text;
                sv.hoten = txthoten.Text;
                sv.gender = cbgender.Text;
                sv.dob = txtdob.Value.Date;
                if (txtsdt.TextLength > 11)
                {
                    txterror.Text = "Số điện thoại không khả dụng";
                }
                else
                {
                    sv.sdt = txtsdt.Text;
                }
                sv.malop = MLop;
                sv.address = txtaddress.Text;
                if (image.Image == null)
                {

                    sv.anhthe = null;
                }
                else
                {
                    byte[] ImageToByteArray(Image img)
                    {
                        MemoryStream m = new MemoryStream();
                        img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
                        img.Save(m, System.Drawing.Imaging.ImageFormat.Jpeg);
                        return m.ToArray();
                    }
                    byte[] b = ImageToByteArray(image.Image);
                    sv.anhthe = b;
                }

                db.sinhviens.Add(sv);
                db.SaveChanges();
                loaddata();
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (txtmasv.Text == "" || txthoten.Text == "" || txtsdt.Text == "" || cbmalop.Text == "")
            {
                txterror.Text = "Thiếu dữ liệu đầu vào !!!";
            }
            else
            {
                string mlop = cbmalop.Text;
                string[] lml = mlop.Split('-');
                string MLop = lml[0].Trim();
                sinhvien sv = db.sinhviens.Where(P => P.masv == txtmasv.Text).SingleOrDefault();
                sv.masv = txtmasv.Text;
                sv.hoten = txthoten.Text;
                sv.gender = cbgender.Text;
                sv.dob = txtdob.Value.Date;
                if (txtsdt.TextLength > 11)
                {
                    txterror.Text = "Số điện thoại không khả dụng";
                }
                else
                {
                    sv.sdt = txtsdt.Text;
                }
                sv.malop = MLop;
                sv.address = txtaddress.Text;
                if (image.Image == null)
                {

                    sv.anhthe = null;
                }
                else
                {
                    byte[] ImageToByteArray(Image img)
                    {
                        MemoryStream m = new MemoryStream();
                        img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
                        img.Save(m, System.Drawing.Imaging.ImageFormat.Jpeg);
                        return m.ToArray();
                    }
                    byte[] b = ImageToByteArray(image.Image);
                    sv.anhthe = b;
                }
            }
            db.SaveChanges();
            loaddata();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            loaddata();
        }



        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmasv.DataBindings.Clear();
            txthoten.DataBindings.Clear();
            txtdob.DataBindings.Clear();
            txtsdt.DataBindings.Clear();
            cbmalop.DataBindings.Clear();
            txtaddress.DataBindings.Clear();
            cbgender.DataBindings.Clear();
            image.DataBindings.Clear();

            btnadd.Enabled = false;
            btndel.Enabled = true;
            btnedit.Enabled = true;
            txtmasv.ReadOnly = true;
            

            txtmasv.DataBindings.Add("Text", dgv.DataSource, "masv", true, DataSourceUpdateMode.Never);
            txthoten.DataBindings.Add("Text", dgv.DataSource, "hoten", true, DataSourceUpdateMode.Never);
            cbgender.DataBindings.Add("Text", dgv.DataSource, "gender", true, DataSourceUpdateMode.Never);
            txtdob.DataBindings.Add("Text", dgv.DataSource, "dob", true, DataSourceUpdateMode.Never);
            txtsdt.DataBindings.Add("Text", dgv.DataSource, "sdt", true, DataSourceUpdateMode.Never);
            cbmalop.Text = dgv.CurrentRow.Cells["malop"].Value.ToString() + " - " + dgv.CurrentRow.Cells["tenlop"].Value.ToString(); ;
            txtaddress.DataBindings.Add("Text", dgv.DataSource, "address", true, DataSourceUpdateMode.Never);
            image.DataBindings.Add("Image", dgv.DataSource, "anhthe", true, DataSourceUpdateMode.Never);
        }


        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            string key = txtsearch.Text.Trim();
            var data = from dt in db.sinhviens join d in db.lops on dt.malop equals d.Malop select new { masv = dt.masv, hoten = dt.hoten, gender = dt.gender, dob = dt.dob, sdt = dt.sdt, malop = dt.malop, tenlop = d.Tenlop, address = dt.address, anhthe = dt.anhthe };
            dgv.DataSource = data.Where(P => P.masv.Contains(key)).ToList();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnreload_Click(object sender, EventArgs e)
        {
            reload();
            loaddata();
        }


        private void btndel_Click(object sender, EventArgs e)
        {

            sinhvien sv = db.sinhviens.Where(P => P.masv == txtmasv.Text).SingleOrDefault();
            db.sinhviens.Remove(sv);
            db.SaveChanges();
            reload();
            loaddata();
        }

        private void image_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                image.Image = Image.FromFile(open.FileName);
                this.Text = open.FileName;
            }
        }

        private void cbgender_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}