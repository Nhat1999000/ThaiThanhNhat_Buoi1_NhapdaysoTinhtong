namespace ThaiThanhNhat_Buoi1_NhapdaysoTinhtong
{
    public partial class NhapDaySoTinhTong : Form
    {
        public NhapDaySoTinhTong()
        {
            InitializeComponent();
        }
        List<int> arr_dayso = new List<int>();


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnnhapso_Click(object sender, EventArgs e)
        {
            int sonhap = int.Parse(txtnhapso.Text);
            int tong = 0;
            arr_dayso.Add(sonhap);
            txtdayvuanhap.Text = "";
            foreach (int i in arr_dayso)
            {
                txtdayvuanhap.Text += i + " ";
                tong += i;
            }
            string input = txtdayvuanhap.Text;
            string[] numbers = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int totalSum = 0, evenSum = 0, oddSum = 0;
            foreach (var number in numbers)
            {
                if (int.TryParse(number, out int num))
                {
                    totalSum += num;
                    if (num % 2 == 0)
                    {
                        evenSum += num; // Cộng vào tổng số chẵn
                    }
                    else
                    {
                        oddSum += num; // Cộng vào tổng số lẻ
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số hợp lệ.");
                    return;
                }
            }

            // Hiển thị kết quả
            txttongcacdayso.Text = " " + totalSum.ToString();
            txttongchan.Text = " " + evenSum.ToString();
            txttongle.Text = " " + oddSum.ToString();
            txtnhapso.Text = "";
        }

        private void btntieptuc_Click(object sender, EventArgs e)
        {
            txtnhapso.Clear();
            txttongcacdayso.Text = " ";
            txttongchan.Text = " ";
            txttongle.Text = " ";
            txtdayvuanhap.Text = " ";
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
