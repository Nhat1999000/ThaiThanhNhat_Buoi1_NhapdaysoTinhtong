namespace ThaiThanhNhat_Buoi1_NhapdaysoTinhtong
{
    partial class KiemTraVaTimSoNguyen
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
            txtn = new TextBox();
            txtsnt = new TextBox();
            txtsntn = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(171, 26);
            label1.Name = "label1";
            label1.Size = new Size(451, 41);
            label1.TabIndex = 0;
            label1.Text = "Tìm Và Kiểm Tra Số Nguyên Tố";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 138);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 1;
            label2.Text = "Nhập n:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 196);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 2;
            label3.Text = "Kiểm Tra SNT:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 253);
            label4.Name = "label4";
            label4.Size = new Size(144, 20);
            label4.TabIndex = 3;
            label4.Text = "Tìm SNT Nhỏ Hơn n:";
            // 
            // txtn
            // 
            txtn.Location = new Point(215, 138);
            txtn.Name = "txtn";
            txtn.Size = new Size(170, 27);
            txtn.TabIndex = 4;
            // 
            // txtsnt
            // 
            txtsnt.Location = new Point(215, 196);
            txtsnt.Name = "txtsnt";
            txtsnt.Size = new Size(319, 27);
            txtsnt.TabIndex = 5;
            // 
            // txtsntn
            // 
            txtsntn.Location = new Point(215, 253);
            txtsntn.Name = "txtsntn";
            txtsntn.Size = new Size(319, 27);
            txtsntn.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(422, 138);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // KiemTraVaTimSoNguyen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtsntn);
            Controls.Add(txtsnt);
            Controls.Add(txtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "KiemTraVaTimSoNguyen";
            Text = "KiemTraVaTimSoNguyen";
         
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtn;
        private TextBox txtsnt;
        private TextBox txtsntn;
        private Button button1;
    }
}