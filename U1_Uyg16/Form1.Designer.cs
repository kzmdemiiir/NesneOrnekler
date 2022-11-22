
namespace Uyg16
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtMatN = new System.Windows.Forms.TextBox();
            this.txtTürkceN = new System.Windows.Forms.TextBox();
            this.txtMatY = new System.Windows.Forms.TextBox();
            this.txtTürkceY = new System.Windows.Forms.TextBox();
            this.txtMatD = new System.Windows.Forms.TextBox();
            this.txtTürkceD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHesapla);
            this.groupBox1.Controls.Add(this.txtMatN);
            this.groupBox1.Controls.Add(this.txtTürkceN);
            this.groupBox1.Controls.Add(this.txtMatY);
            this.groupBox1.Controls.Add(this.txtTürkceY);
            this.groupBox1.Controls.Add(this.txtMatD);
            this.groupBox1.Controls.Add(this.txtTürkceD);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 141);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sınav 1.Oturum";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(265, 103);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(100, 23);
            this.btnHesapla.TabIndex = 7;
            this.btnHesapla.Text = "NET HESAPLA";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // txtMatN
            // 
            this.txtMatN.Enabled = false;
            this.txtMatN.Location = new System.Drawing.Point(326, 63);
            this.txtMatN.Name = "txtMatN";
            this.txtMatN.Size = new System.Drawing.Size(39, 20);
            this.txtMatN.TabIndex = 6;
            // 
            // txtTürkceN
            // 
            this.txtTürkceN.Enabled = false;
            this.txtTürkceN.Location = new System.Drawing.Point(326, 37);
            this.txtTürkceN.Name = "txtTürkceN";
            this.txtTürkceN.Size = new System.Drawing.Size(39, 20);
            this.txtTürkceN.TabIndex = 3;
            // 
            // txtMatY
            // 
            this.txtMatY.Location = new System.Drawing.Point(258, 63);
            this.txtMatY.Name = "txtMatY";
            this.txtMatY.Size = new System.Drawing.Size(42, 20);
            this.txtMatY.TabIndex = 5;
            // 
            // txtTürkceY
            // 
            this.txtTürkceY.Location = new System.Drawing.Point(258, 37);
            this.txtTürkceY.Name = "txtTürkceY";
            this.txtTürkceY.Size = new System.Drawing.Size(42, 20);
            this.txtTürkceY.TabIndex = 2;
            // 
            // txtMatD
            // 
            this.txtMatD.Location = new System.Drawing.Point(177, 63);
            this.txtMatD.Name = "txtMatD";
            this.txtMatD.Size = new System.Drawing.Size(44, 20);
            this.txtMatD.TabIndex = 4;
            // 
            // txtTürkceD
            // 
            this.txtTürkceD.Location = new System.Drawing.Point(177, 37);
            this.txtTürkceD.Name = "txtTürkceD";
            this.txtTürkceD.Size = new System.Drawing.Size(44, 20);
            this.txtTürkceD.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(329, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "NET";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "YANLIŞ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "DOĞRU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "MATEMATİK (40 SORU)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÜRKÇE (40 SORU)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(406, 165);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Net Hesaplama";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtMatN;
        private System.Windows.Forms.TextBox txtTürkceN;
        private System.Windows.Forms.TextBox txtMatY;
        private System.Windows.Forms.TextBox txtTürkceY;
        private System.Windows.Forms.TextBox txtMatD;
        private System.Windows.Forms.TextBox txtTürkceD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

