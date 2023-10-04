namespace HuynhThaoNguyen_2033210471
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNhapSo = new System.Windows.Forms.TextBox();
            this.txtIn = new System.Windows.Forms.TextBox();
            this.txtTinhTong = new System.Windows.Forms.TextBox();
            this.txtTongLe = new System.Windows.Forms.TextBox();
            this.txtTongChan = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhap so";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NHAP DAY SO VA TINH TONG";
            // 
            // txtNhapSo
            // 
            this.txtNhapSo.Location = new System.Drawing.Point(82, 46);
            this.txtNhapSo.Name = "txtNhapSo";
            this.txtNhapSo.Size = new System.Drawing.Size(100, 20);
            this.txtNhapSo.TabIndex = 2;
            this.txtNhapSo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtIn
            // 
            this.txtIn.Location = new System.Drawing.Point(104, 83);
            this.txtIn.Name = "txtIn";
            this.txtIn.Size = new System.Drawing.Size(180, 20);
            this.txtIn.TabIndex = 3;
            // 
            // txtTinhTong
            // 
            this.txtTinhTong.Location = new System.Drawing.Point(184, 129);
            this.txtTinhTong.Name = "txtTinhTong";
            this.txtTinhTong.Size = new System.Drawing.Size(100, 20);
            this.txtTinhTong.TabIndex = 4;
            // 
            // txtTongLe
            // 
            this.txtTongLe.Location = new System.Drawing.Point(239, 165);
            this.txtTongLe.Name = "txtTongLe";
            this.txtTongLe.Size = new System.Drawing.Size(100, 20);
            this.txtTongLe.TabIndex = 5;
            // 
            // txtTongChan
            // 
            this.txtTongChan.Location = new System.Drawing.Point(82, 165);
            this.txtTongChan.Name = "txtTongChan";
            this.txtTongChan.Size = new System.Drawing.Size(79, 20);
            this.txtTongChan.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Tiep tuc";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(209, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Thoat";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Day vua nhap";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tong cac phan tu trong day";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tong chan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(181, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tong le";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(209, 44);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Nhap";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 261);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTongChan);
            this.Controls.Add(this.txtTongLe);
            this.Controls.Add(this.txtTinhTong);
            this.Controls.Add(this.txtIn);
            this.Controls.Add(this.txtNhapSo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "   ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNhapSo;
        private System.Windows.Forms.TextBox txtIn;
        private System.Windows.Forms.TextBox txtTinhTong;
        private System.Windows.Forms.TextBox txtTongLe;
        private System.Windows.Forms.TextBox txtTongChan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
    }
}

