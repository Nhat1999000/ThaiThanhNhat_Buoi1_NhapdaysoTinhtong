namespace ThaiThanhNhat_Buoi1_NhapdaysoTinhtong
{
    partial class NhapDaySoTinhTong
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnnhapso = new Button();
            btntieptuc = new Button();
            btnthoat = new Button();
            txtnhapso = new TextBox();
            txtdayvuanhap = new TextBox();
            txttongcacdayso = new TextBox();
            txttongchan = new TextBox();
            txttongle = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(200, 32);
            label1.Name = "label1";
            label1.Size = new Size(394, 41);
            label1.TabIndex = 0;
            label1.Text = "Nhập Dãy Số Và Tính Tổng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F);
            label2.Location = new Point(87, 108);
            label2.Name = "label2";
            label2.Size = new Size(67, 17);
            label2.TabIndex = 1;
            label2.Text = "Nhập Số:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 168);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 2;
            label3.Text = "Dãy Vừa Nhập:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(87, 225);
            label4.Name = "label4";
            label4.Size = new Size(203, 20);
            label4.TabIndex = 3;
            label4.Text = "Tổng Các Phần Tử Trong Dãy:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(87, 282);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 4;
            label5.Text = "Tổng Chẳn: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(284, 282);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 5;
            label6.Text = "Tổng Lẻ:";
            // 
            // btnnhapso
            // 
            btnnhapso.Location = new Point(484, 102);
            btnnhapso.Name = "btnnhapso";
            btnnhapso.Size = new Size(94, 29);
            btnnhapso.TabIndex = 6;
            btnnhapso.Text = "Nhập";
            btnnhapso.UseVisualStyleBackColor = true;
            btnnhapso.Click += btnnhapso_Click;
            // 
            // btntieptuc
            // 
            btntieptuc.Location = new Point(215, 341);
            btntieptuc.Name = "btntieptuc";
            btntieptuc.Size = new Size(94, 29);
            btntieptuc.TabIndex = 7;
            btntieptuc.Text = "Tiếp Tục";
            btntieptuc.UseVisualStyleBackColor = true;
            btntieptuc.Click += btntieptuc_Click;
            // 
            // btnthoat
            // 
            btnthoat.Location = new Point(382, 341);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(94, 29);
            btnthoat.TabIndex = 8;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = true;
            btnthoat.Click += btnthoat_Click;
            // 
            // txtnhapso
            // 
            txtnhapso.Location = new Point(215, 102);
            txtnhapso.Name = "txtnhapso";
            txtnhapso.Size = new Size(230, 27);
            txtnhapso.TabIndex = 9;
            // 
            // txtdayvuanhap
            // 
            txtdayvuanhap.Location = new Point(215, 168);
            txtdayvuanhap.Name = "txtdayvuanhap";
            txtdayvuanhap.Size = new Size(230, 27);
            txtdayvuanhap.TabIndex = 10;
            // 
            // txttongcacdayso
            // 
            txttongcacdayso.Location = new Point(316, 224);
            txttongcacdayso.Name = "txttongcacdayso";
            txttongcacdayso.Size = new Size(230, 27);
            txttongcacdayso.TabIndex = 11;
            txttongcacdayso.TextChanged += textBox3_TextChanged;
            // 
            // txttongchan
            // 
            txttongchan.Location = new Point(180, 279);
            txttongchan.Name = "txttongchan";
            txttongchan.Size = new Size(87, 27);
            txttongchan.TabIndex = 12;
            // 
            // txttongle
            // 
            txttongle.Location = new Point(360, 279);
            txttongle.Name = "txttongle";
            txttongle.Size = new Size(90, 27);
            txttongle.TabIndex = 13;
            // 
            // NhapDaySoTinhTong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txttongle);
            Controls.Add(txttongchan);
            Controls.Add(txttongcacdayso);
            Controls.Add(txtdayvuanhap);
            Controls.Add(txtnhapso);
            Controls.Add(btnthoat);
            Controls.Add(btntieptuc);
            Controls.Add(btnnhapso);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NhapDaySoTinhTong";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnnhapso;
        private Button btntieptuc;
        private Button btnthoat;
        private TextBox txtnhapso;
        private TextBox txtdayvuanhap;
        private TextBox txttongcacdayso;
        private TextBox txttongchan;
        private TextBox txttongle;
    }
}
