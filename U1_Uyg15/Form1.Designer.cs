
namespace Uyg15
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEtiket = new System.Windows.Forms.TextBox();
            this.btnYuzde10 = new System.Windows.Forms.Button();
            this.btnYuzde25 = new System.Windows.Forms.Button();
            this.btnYuzde50 = new System.Windows.Forms.Button();
            this.btnYuzde75 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Etiket Fiyatı: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "İndirim Fiyatı: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.ForestGreen;
            this.label3.Location = new System.Drawing.Point(101, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // txtEtiket
            // 
            this.txtEtiket.Location = new System.Drawing.Point(96, 16);
            this.txtEtiket.Name = "txtEtiket";
            this.txtEtiket.Size = new System.Drawing.Size(100, 20);
            this.txtEtiket.TabIndex = 3;
            // 
            // btnYuzde10
            // 
            this.btnYuzde10.BackColor = System.Drawing.Color.Salmon;
            this.btnYuzde10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYuzde10.Location = new System.Drawing.Point(18, 48);
            this.btnYuzde10.Name = "btnYuzde10";
            this.btnYuzde10.Size = new System.Drawing.Size(72, 62);
            this.btnYuzde10.TabIndex = 4;
            this.btnYuzde10.Text = "Yüzde 10 İndirim";
            this.btnYuzde10.UseVisualStyleBackColor = false;
            this.btnYuzde10.Click += new System.EventHandler(this.btnYuzde10_Click);
            // 
            // btnYuzde25
            // 
            this.btnYuzde25.BackColor = System.Drawing.Color.Tomato;
            this.btnYuzde25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYuzde25.Location = new System.Drawing.Point(96, 48);
            this.btnYuzde25.Name = "btnYuzde25";
            this.btnYuzde25.Size = new System.Drawing.Size(72, 62);
            this.btnYuzde25.TabIndex = 5;
            this.btnYuzde25.Text = "Yüzde 25 İndirim";
            this.btnYuzde25.UseVisualStyleBackColor = false;
            this.btnYuzde25.Click += new System.EventHandler(this.btnYuzde25_Click);
            // 
            // btnYuzde50
            // 
            this.btnYuzde50.BackColor = System.Drawing.Color.Red;
            this.btnYuzde50.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYuzde50.Location = new System.Drawing.Point(174, 48);
            this.btnYuzde50.Name = "btnYuzde50";
            this.btnYuzde50.Size = new System.Drawing.Size(72, 62);
            this.btnYuzde50.TabIndex = 6;
            this.btnYuzde50.Text = "Yüzde 50 İndirim";
            this.btnYuzde50.UseVisualStyleBackColor = false;
            this.btnYuzde50.Click += new System.EventHandler(this.btnYuzde50_Click);
            // 
            // btnYuzde75
            // 
            this.btnYuzde75.BackColor = System.Drawing.Color.Maroon;
            this.btnYuzde75.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYuzde75.Location = new System.Drawing.Point(252, 48);
            this.btnYuzde75.Name = "btnYuzde75";
            this.btnYuzde75.Size = new System.Drawing.Size(72, 62);
            this.btnYuzde75.TabIndex = 7;
            this.btnYuzde75.Text = "Yüzde 75 İndirim";
            this.btnYuzde75.UseVisualStyleBackColor = false;
            this.btnYuzde75.Click += new System.EventHandler(this.btnYuzde75_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 172);
            this.Controls.Add(this.btnYuzde75);
            this.Controls.Add(this.btnYuzde50);
            this.Controls.Add(this.btnYuzde25);
            this.Controls.Add(this.btnYuzde10);
            this.Controls.Add(this.txtEtiket);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "İndirimli Ürün";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEtiket;
        private System.Windows.Forms.Button btnYuzde10;
        private System.Windows.Forms.Button btnYuzde25;
        private System.Windows.Forms.Button btnYuzde50;
        private System.Windows.Forms.Button btnYuzde75;
    }
}

