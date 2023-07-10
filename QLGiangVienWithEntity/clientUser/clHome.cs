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
    public partial class clHome : Form
    {
        QLGiangVienEntities db = new QLGiangVienEntities();
        public clHome()
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
