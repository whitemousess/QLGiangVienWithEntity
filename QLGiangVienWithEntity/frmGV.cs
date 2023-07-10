using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Input;


namespace QLGiangVienWithEntity
{
    public partial class frmGV : Form
    {
        QLGiangVienEntities db = new QLGiangVienEntities();
        Image ByteArrayToImage(byte[] b)
        {
            MemoryStream m = new MemoryStream(b);
            return Image.FromStream(m);
        }
        public frmGV()
        {
            InitializeComponent();
        }

        public void loaddata()
        {
            dgv.Visible = true;
            //link
            var data = from dt in db.GVs select new { magv = dt.magv, hoten = dt.hoten, gioitinh = dt.gioitinh, sdt = dt.sdt, ghichu = dt.ghichu, namsinh = dt.ngaysinh, diachi = dt.diachi, hinhanh = dt.hinhanh };
            dgv.DataSource = data.ToList();
            dgv.ReadOnly = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        public void refresh()
        {
            MaGV.ReadOnly = false;
            button2.Enabled = true;
            MaGV.Text = "";
            HVT.Text = "";
            GT.Text = "";
            SDT.Text = "";
            GC.Text = "";
            DC.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (MaGV.Text == "" || HVT.Text == "" || GT.Text == "")
            {
                txterror.Text = "Thiếu dữ liệu đầu vào !!!";
            }
            else
            {
                ///sinhvien là tên bảng
                GV gv = new GV();
                gv.magv = MaGV.Text;
                gv.hoten = HVT.Text;
                gv.gioitinh = GT.Text;
                gv.sdt = SDT.Text;
                gv.ghichu = GC.Text;
                gv.ngaysinh = NS.Value.Date;
                gv.diachi = DC.Text;
                if (anh.Image == null)
                {

                    gv.hinhanh = null;
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
                    byte[] b = ImageToByteArray(anh.Image);
                    gv.hinhanh = b;
                }

                txterror.Text = "";

                refresh();
                db.GVs.Add(gv);
                db.SaveChanges();
                loaddata();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            GV gv = db.GVs.Where(P => P.magv == MaGV.Text).SingleOrDefault();
            gv.magv = MaGV.Text;
            gv.hoten = HVT.Text;
            gv.gioitinh = GT.Text;
            gv.sdt = SDT.Text;
            gv.ghichu = GC.Text;
            gv.ngaysinh = NS.Value.Date;
            gv.diachi = DC.Text;
            if (anh.Image == null)
            {

                gv.hinhanh = null;
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
                byte[] b = ImageToByteArray(anh.Image);
                gv.hinhanh = b;
            }
                refresh();
            db.SaveChanges();
            loaddata();
        }
                  // P là csai gì đấy nhỉ no biet mở csai bài t nhờ gửi lên cái

        private void button3_Click(object sender, EventArgs e)
        {
            GV gv = db.GVs.Where((P) => P.magv == MaGV.Text).SingleOrDefault();
            db.GVs.Remove(gv);
            db.SaveChanges();
            loaddata();
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void anh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                anh.Image = Image.FromFile(open.FileName);
                this.Text = open.FileName;
            }
        }

        private void btnload_Click(object sender, EventArgs e)
        {
           loaddata();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MaGV.DataBindings.Clear();
            HVT.DataBindings.Clear();
            GT.DataBindings.Clear();
            SDT.DataBindings.Clear();
            GC.DataBindings.Clear();
            NS.DataBindings.Clear();
            DC.DataBindings.Clear();
            anh.DataBindings.Clear();

            button2.Enabled = false;
            button1.Enabled = true;
            button3.Enabled = true;
            MaGV.ReadOnly = true;


            MaGV.DataBindings.Add("Text", dgv.DataSource, "magv", true, DataSourceUpdateMode.Never);
            HVT.DataBindings.Add("Text", dgv.DataSource, "hoten", true, DataSourceUpdateMode.Never);
            GT.DataBindings.Add("Text", dgv.DataSource, "gioitinh", true, DataSourceUpdateMode.Never);
            SDT.DataBindings.Add("Text", dgv.DataSource, "sdt", true, DataSourceUpdateMode.Never);
            GC.DataBindings.Add("Text", dgv.DataSource, "ghichu", true, DataSourceUpdateMode.Never);
            NS.DataBindings.Add("Text", dgv.DataSource, "namsinh", true, DataSourceUpdateMode.Never);
            DC.DataBindings.Add("Text", dgv.DataSource, "diachi", true, DataSourceUpdateMode.Never);
            anh.DataBindings.Add("Image", dgv.DataSource, "hinhanh", true, DataSourceUpdateMode.Never);
        }

        private void btnref_Click(object sender, EventArgs e)
        {
            refresh();

        }
    }
}
                                                                                                                        