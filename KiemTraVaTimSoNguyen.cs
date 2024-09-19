using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace ThaiThanhNhat_Buoi1_NhapdaysoTinhtong
{
    public partial class KiemTraVaTimSoNguyen : Form
    {
        public KiemTraVaTimSoNguyen()
        {
            InitializeComponent();
        }
        public bool KtraSNT(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kq = string.Empty;
            if (txtn.Text != string.Empty)
            {
                if (KtraSNT(int.Parse(txtn.Text)))

                {
                    txtsnt.Text = "Là Số Nguyên Tố";
                }
                else
                {
                    txtsnt.Text = "Không Phải số nguyên Tố";
                }
                for (int i = 2; i < int.Parse(txtn.Text); i++)
                {
                    if (KtraSNT(i))
                    {
                        kq += " " + i;
                    }
                }
                txtsntn.Text = kq;
            }
        }
    }
}
