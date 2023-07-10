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
    public partial class clFeedBack : Form
    {
        QLGiangVienEntities db = new QLGiangVienEntities();

        public clFeedBack()
        {
            InitializeComponent();
            loaddata();

        }

        string strNhan;

        public clFeedBack(string giatrinhan) : this()
        {
            strNhan = giatrinhan;
            author.Text = strNhan;
           
        }

        public void loaddata()
        {
            var feedback = from dt in db.feedbacks select new { id = dt.id, username = dt.username, description = dt.Description };
            dgv.DataSource = feedback.Where(P => P.username.Contains(author.Text)).ToList();
            dgv.ReadOnly = true;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            HandleFeedBack hdfb = new HandleFeedBack(author.Text);
            hdfb.ShowDialog();
        }

        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            txtid.DataBindings.Clear();
            txtid.DataBindings.Add("Text", dgv.DataSource, "id", true, DataSourceUpdateMode.Never);
            DialogResult result = MessageBox.Show("Bạn có chắc xóa báo cáo ?", "Xóa báo cáo !", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                var idpoint = Convert.ToInt32(txtid.Text);
                feedback fb = db.feedbacks.Where(P => P.id == idpoint).SingleOrDefault();
                db.feedbacks.Remove(fb);
                db.SaveChanges();
                loaddata();
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            loaddata();
        }
    }
}
