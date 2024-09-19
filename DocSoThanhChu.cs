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
    public partial class DocSoThanhChu : Form
    {
        public DocSoThanhChu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ TextBox
            if (int.TryParse(txtso.Text, out int number))
            {
                string result = ConvertNumberToWords(number);
                txtkq.Text = result;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ từ 1 đến 9.");
            }
        }
        private string ConvertNumberToWords(int number)
        {
            switch (number)
            {
                case 1: return "Một";
                case 2: return "Hai";
                case 3: return "Ba";
                case 4: return "Bốn";
                case 5: return "Năm";
                case 6: return "Sáu";
                case 7: return "Bảy";
                case 8: return "Tám";
                case 9: return "Chín";
                default: return "Số không hợp lệ. Vui lòng nhập từ 1 đến 9.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
