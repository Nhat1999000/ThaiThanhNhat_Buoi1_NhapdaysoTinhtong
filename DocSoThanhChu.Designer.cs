namespace ThaiThanhNhat_Buoi1_NhapdaysoTinhtong
{
    partial class DocSoThanhChu
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
            txtso = new TextBox();
            txtkq = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(248, 36);
            label1.Name = "label1";
            label1.Size = new Size(276, 41);
            label1.TabIndex = 0;
            label1.Text = "Đọc Số Thành Chữ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 137);
            label2.Name = "label2";
            label2.Size = new Size(142, 20);
            label2.TabIndex = 1;
            label2.Text = "Nhập n(Từ 1 Đến 9):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(146, 189);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 2;
            label3.Text = "KẾT QUẢ:";
            // 
            // txtso
            // 
            txtso.Location = new Point(303, 132);
            txtso.Name = "txtso";
            txtso.Size = new Size(104, 27);
            txtso.TabIndex = 3;
            // 
            // txtkq
            // 
            txtkq.Location = new Point(238, 186);
            txtkq.Name = "txtkq";
            txtkq.Size = new Size(170, 27);
            txtkq.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(146, 245);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Thực Hiện";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(314, 245);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 6;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // DocSoThanhChu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtkq);
            Controls.Add(txtso);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DocSoThanhChu";
            Text = "DocSoThanhChu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtso;
        private TextBox txtkq;
        private Button button1;
        private Button button2;
    }
}