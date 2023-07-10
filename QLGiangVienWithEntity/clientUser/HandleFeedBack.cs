using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGiangVienWithEntity.clientUser
{
    public partial class HandleFeedBack : Form
    {

        QLGiangVienEntities db = new QLGiangVienEntities();

        public HandleFeedBack(string giatrinhan) : this()
        {
            string strNhan;
            strNhan = giatrinhan;
            author.Text = strNhan;
        }

        public HandleFeedBack()
        {
            InitializeComponent();
        }

        private void btnsent_Click(object sender, EventArgs e)
        {
            if (txtdesp.Text == "")
            {
                txterror.Visible = true;
                txterror.Text = "Thiếu dữ liệu đầu vào!!";
                txterror.ForeColor = Color.Red;
            }
            else
            {
                feedback fb = new feedback();
                fb.username = author.Text;
                fb.Description = txtdesp.Text;
                txterror.Visible = true;
                txterror.Text = "Đã báo cáo !";
                txterror.ForeColor = Color.Green;

                db.feedbacks.Add(fb);
                db.SaveChanges();
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
