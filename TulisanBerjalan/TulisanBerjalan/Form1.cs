using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TulisanBerjalan
{
    public partial class frmTulisanBerjalan : Form
    {
        public frmTulisanBerjalan()
        {
            InitializeComponent();
        }

        private void frmTulisanBerjalan_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTulisanBerjalan.Left -= 10;
            if (lblTulisanBerjalan.Left < -lblTulisanBerjalan.Width) lblTulisanBerjalan.Left = this.Width;
        }


        private void btnKeluar_Click(object sender, EventArgs e)
        {

        }

        private void lblTulisanBerjalan_Click(object sender, EventArgs e)
        {

        }
    }
}
