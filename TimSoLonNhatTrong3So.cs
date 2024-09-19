using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThaiThanhNhat_Buoi1_NhapdaysoTinhtong
{
    public partial class TimSoLonNhatTrong3So : Form
    {
        public TimSoLonNhatTrong3So()
        {
            InitializeComponent();
        }

        private void btnthuchien_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ các TextBox
            if (int.TryParse(txta.Text, out int a) &&
                int.TryParse(txtb.Text, out int b) &&
                int.TryParse(txtc.Text, out int c))
            {
                // Tìm số lớn nhất
                int max = Math.Max(a, Math.Max(b, c));

                // Hiển thị kết quả
                txtkq.Text = "Số lớn nhất: " + max.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ.");
            }
        }

        private void btntieptuc_Click(object sender, EventArgs e)
        {
            txta.Text = " ";
            txtb.Text = " ";
            txtc.Text = " ";
            txtkq.Text = " ";
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
