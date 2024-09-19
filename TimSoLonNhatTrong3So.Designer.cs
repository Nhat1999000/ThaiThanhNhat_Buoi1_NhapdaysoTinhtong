namespace ThaiThanhNhat_Buoi1_NhapdaysoTinhtong
{
    partial class TimSoLonNhatTrong3So
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txta = new TextBox();
            txtb = new TextBox();
            txtc = new TextBox();
            txtkq = new TextBox();
            btnthuchien = new Button();
            btntieptuc = new Button();
            btnthoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(163, 24);
            label1.Name = "label1";
            label1.Size = new Size(481, 41);
            label1.TabIndex = 0;
            label1.Text = "Kiểm Tra Số Lớn Nhất Trong 3 Số";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(98, 126);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 1;
            label2.Text = "Nhập A:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(98, 180);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 2;
            label3.Text = "Nhập B:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(98, 229);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 3;
            label4.Text = "Nhập C:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(88, 279);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 4;
            label5.Text = "KẾT QUẢ:";
            // 
            // txta
            // 
            txta.Location = new Point(198, 123);
            txta.Name = "txta";
            txta.Size = new Size(125, 27);
            txta.TabIndex = 5;
            // 
            // txtb
            // 
            txtb.Location = new Point(198, 177);
            txtb.Name = "txtb";
            txtb.Size = new Size(125, 27);
            txtb.TabIndex = 6;
            // 
            // txtc
            // 
            txtc.Location = new Point(198, 229);
            txtc.Name = "txtc";
            txtc.Size = new Size(125, 27);
            txtc.TabIndex = 7;
            // 
            // txtkq
            // 
            txtkq.Location = new Point(198, 279);
            txtkq.Name = "txtkq";
            txtkq.Size = new Size(273, 27);
            txtkq.TabIndex = 8;
            // 
            // btnthuchien
            // 
            btnthuchien.Location = new Point(377, 123);
            btnthuchien.Name = "btnthuchien";
            btnthuchien.Size = new Size(94, 29);
            btnthuchien.TabIndex = 9;
            btnthuchien.Text = "Thực Hiện";
            btnthuchien.UseVisualStyleBackColor = true;
            btnthuchien.Click += btnthuchien_Click;
            // 
            // btntieptuc
            // 
            btntieptuc.Location = new Point(377, 175);
            btntieptuc.Name = "btntieptuc";
            btntieptuc.Size = new Size(94, 29);
            btntieptuc.TabIndex = 10;
            btntieptuc.Text = "Tiếp Tục";
            btntieptuc.UseVisualStyleBackColor = true;
            btntieptuc.Click += btntieptuc_Click;
            // 
            // btnthoat
            // 
            btnthoat.Location = new Point(377, 229);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(94, 29);
            btnthoat.TabIndex = 11;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = true;
            btnthoat.Click += btnthoat_Click;
            // 
            // TimSoLonNhatTrong3So
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnthoat);
            Controls.Add(btntieptuc);
            Controls.Add(btnthuchien);
            Controls.Add(txtkq);
            Controls.Add(txtc);
            Controls.Add(txtb);
            Controls.Add(txta);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TimSoLonNhatTrong3So";
            Text = "TimSoLonNhatTrong3So";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txta;
        private TextBox txtb;
        private TextBox txtc;
        private TextBox txtkq;
        private Button btnthuchien;
        private Button btntieptuc;
        private Button btnthoat;
    }
}