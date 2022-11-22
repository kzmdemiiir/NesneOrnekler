
namespace Odev1
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
            this.rbKare = new System.Windows.Forms.RadioButton();
            this.rbDaire = new System.Windows.Forms.RadioButton();
            this.rbDikdortgen = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKenar1 = new System.Windows.Forms.TextBox();
            this.txtKenar2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDikdortgen);
            this.groupBox1.Controls.Add(this.rbDaire);
            this.groupBox1.Controls.Add(this.rbKare);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(117, 97);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alan Hesaplama";
            // 
            // rbKare
            // 
            this.rbKare.AutoSize = true;
            this.rbKare.Location = new System.Drawing.Point(6, 19);
            this.rbKare.Name = "rbKare";
            this.rbKare.Size = new System.Drawing.Size(47, 17);
            this.rbKare.TabIndex = 0;
            this.rbKare.TabStop = true;
            this.rbKare.Text = "Kare";
            this.rbKare.UseVisualStyleBackColor = true;
            this.rbKare.CheckedChanged += new System.EventHandler(this.rbKare_CheckedChanged);
            // 
            // rbDaire
            // 
            this.rbDaire.AutoSize = true;
            this.rbDaire.Location = new System.Drawing.Point(6, 42);
            this.rbDaire.Name = "rbDaire";
            this.rbDaire.Size = new System.Drawing.Size(50, 17);
            this.rbDaire.TabIndex = 1;
            this.rbDaire.TabStop = true;
            this.rbDaire.Text = "Daire";
            this.rbDaire.UseVisualStyleBackColor = true;
            this.rbDaire.CheckedChanged += new System.EventHandler(this.rbDaire_CheckedChanged);
            // 
            // rbDikdortgen
            // 
            this.rbDikdortgen.AutoSize = true;
            this.rbDikdortgen.Location = new System.Drawing.Point(6, 65);
            this.rbDikdortgen.Name = "rbDikdortgen";
            this.rbDikdortgen.Size = new System.Drawing.Size(77, 17);
            this.rbDikdortgen.TabIndex = 2;
            this.rbDikdortgen.TabStop = true;
            this.rbDikdortgen.Text = "Dikdörtgen";
            this.rbDikdortgen.UseVisualStyleBackColor = true;
            this.rbDikdortgen.CheckedChanged += new System.EventHandler(this.rbDikdortgen_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtKenar2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtKenar1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(135, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(140, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kenarlık Değer Girişi";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "1.Kenar";
            this.label1.Visible = false;
            // 
            // txtKenar1
            // 
            this.txtKenar1.Location = new System.Drawing.Point(80, 17);
            this.txtKenar1.Name = "txtKenar1";
            this.txtKenar1.Size = new System.Drawing.Size(54, 20);
            this.txtKenar1.TabIndex = 2;
            this.txtKenar1.Visible = false;
            // 
            // txtKenar2
            // 
            this.txtKenar2.Location = new System.Drawing.Point(80, 45);
            this.txtKenar2.Name = "txtKenar2";
            this.txtKenar2.Size = new System.Drawing.Size(54, 20);
            this.txtKenar2.TabIndex = 4;
            this.txtKenar2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "2.Kenar";
            this.label2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(295, 120);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Ödev-1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDikdortgen;
        private System.Windows.Forms.RadioButton rbDaire;
        private System.Windows.Forms.RadioButton rbKare;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtKenar2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKenar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

