
namespace SS2
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
            this.btnKareAl = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnKareAl
            // 
            this.btnKareAl.Location = new System.Drawing.Point(32, 48);
            this.btnKareAl.Name = "btnKareAl";
            this.btnKareAl.Size = new System.Drawing.Size(90, 23);
            this.btnKareAl.TabIndex = 0;
            this.btnKareAl.Text = "Karesini Al";
            this.btnKareAl.UseVisualStyleBackColor = true;
            this.btnKareAl.Click += new System.EventHandler(this.btnKareAl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sayı Giriniz: ";
            // 
            // txtSayi
            // 
            this.txtSayi.Location = new System.Drawing.Point(87, 22);
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(35, 20);
            this.txtSayi.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(153, 87);
            this.Controls.Add(this.txtSayi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKareAl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKareAl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSayi;
    }
}

