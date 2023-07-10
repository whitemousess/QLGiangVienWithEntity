using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace QLGiangVienWithEntity
{
    public partial class frmhome : Form
    {
        QLGiangVienEntities db = new QLGiangVienEntities();

        public frmhome()
        {
            InitializeComponent();
            sum();
        }

        public void sum()
        {
            int clop = db.lops.Count();
            int ckhoa = db.Khoas.Count();
            int cGV = db.GVs.Count();
            int cSv = db.sinhviens.Count();

            sclass.Text = clop.ToString();
            skhoa.Text = ckhoa.ToString();
            sGV.Text = cGV.ToString();
            sSV.Text = cSv.ToString();
        }

    }
}
