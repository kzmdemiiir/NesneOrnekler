
namespace GoldSoru2
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
            this.btnIndirimYap = new System.Windows.Forms.Button();
            this.txtEtiket = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIndirimOrani = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIndirimYap
            // 
            this.btnIndirimYap.BackColor = System.Drawing.Color.Salmon;
            this.btnIndirimYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIndirimYap.Location = new System.Drawing.Point(208, 19);
            this.btnIndirimYap.Name = "btnIndirimYap";
            this.btnIndirimYap.Size = new System.Drawing.Size(134, 43);
            this.btnIndirimYap.TabIndex = 12;
            this.btnIndirimYap.Text = "İndirim Yap";
            this.btnIndirimYap.UseVisualStyleBackColor = false;
            this.btnIndirimYap.Click += new System.EventHandler(this.btnIndirimYap_Click);
            // 
            // txtEtiket
            // 
            this.txtEtiket.Location = new System.Drawing.Point(102, 19);
            this.txtEtiket.Name = "txtEtiket";
            this.txtEtiket.Size = new System.Drawing.Size(100, 20);
            this.txtEtiket.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.ForestGreen;
            this.label3.Location = new System.Drawing.Point(104, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "İndirim Fiyatı: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Etiket Fiyatı: ";
            // 
            // txtIndirimOrani
            // 
            this.txtIndirimOrani.Location = new System.Drawing.Point(102, 42);
            this.txtIndirimOrani.Name = "txtIndirimOrani";
            this.txtIndirimOrani.Size = new System.Drawing.Size(100, 20);
            this.txtIndirimOrani.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "İndirim Oranı: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 114);
            this.Controls.Add(this.txtIndirimOrani);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnIndirimYap);
            this.Controls.Add(this.txtEtiket);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnIndirimYap;
        private System.Windows.Forms.TextBox txtEtiket;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIndirimOrani;
        private System.Windows.Forms.Label label4;
    }
}

