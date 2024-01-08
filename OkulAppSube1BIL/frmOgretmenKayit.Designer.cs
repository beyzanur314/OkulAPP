namespace OkulAppSube1BIL
{
    partial class frmOgretmenKayit
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
            this.grpOgretmen = new System.Windows.Forms.GroupBox();
            this.lblOgrtmnTc = new System.Windows.Forms.Label();
            this.lblOgrtmnSoyad = new System.Windows.Forms.Label();
            this.lblOgrtmnAd = new System.Windows.Forms.Label();
            this.txtOgrtmnTc = new System.Windows.Forms.TextBox();
            this.txtOgrtmnSoyad = new System.Windows.Forms.TextBox();
            this.txtOgrtmnAd = new System.Windows.Forms.TextBox();
            this.btnOgrtmnKaydet = new System.Windows.Forms.Button();
            this.grpOgretmen.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOgretmen
            // 
            this.grpOgretmen.Controls.Add(this.lblOgrtmnTc);
            this.grpOgretmen.Controls.Add(this.lblOgrtmnSoyad);
            this.grpOgretmen.Controls.Add(this.lblOgrtmnAd);
            this.grpOgretmen.Controls.Add(this.txtOgrtmnTc);
            this.grpOgretmen.Controls.Add(this.txtOgrtmnSoyad);
            this.grpOgretmen.Controls.Add(this.txtOgrtmnAd);
            this.grpOgretmen.Location = new System.Drawing.Point(42, 36);
            this.grpOgretmen.Margin = new System.Windows.Forms.Padding(2);
            this.grpOgretmen.Name = "grpOgretmen";
            this.grpOgretmen.Padding = new System.Windows.Forms.Padding(2);
            this.grpOgretmen.Size = new System.Drawing.Size(347, 209);
            this.grpOgretmen.TabIndex = 1;
            this.grpOgretmen.TabStop = false;
            this.grpOgretmen.Text = "Öğretmen Bilgileri";
            // 
            // lblOgrtmnTc
            // 
            this.lblOgrtmnTc.AutoSize = true;
            this.lblOgrtmnTc.Location = new System.Drawing.Point(34, 117);
            this.lblOgrtmnTc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOgrtmnTc.Name = "lblOgrtmnTc";
            this.lblOgrtmnTc.Size = new System.Drawing.Size(91, 13);
            this.lblOgrtmnTc.TabIndex = 5;
            this.lblOgrtmnTc.Text = "TcKimlikNumarası";
            // 
            // lblOgrtmnSoyad
            // 
            this.lblOgrtmnSoyad.AutoSize = true;
            this.lblOgrtmnSoyad.Location = new System.Drawing.Point(34, 82);
            this.lblOgrtmnSoyad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOgrtmnSoyad.Name = "lblOgrtmnSoyad";
            this.lblOgrtmnSoyad.Size = new System.Drawing.Size(37, 13);
            this.lblOgrtmnSoyad.TabIndex = 4;
            this.lblOgrtmnSoyad.Text = "Soyad";
            // 
            // lblOgrtmnAd
            // 
            this.lblOgrtmnAd.AutoSize = true;
            this.lblOgrtmnAd.Location = new System.Drawing.Point(34, 51);
            this.lblOgrtmnAd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOgrtmnAd.Name = "lblOgrtmnAd";
            this.lblOgrtmnAd.Size = new System.Drawing.Size(20, 13);
            this.lblOgrtmnAd.TabIndex = 3;
            this.lblOgrtmnAd.Text = "Ad";
            // 
            // txtOgrtmnTc
            // 
            this.txtOgrtmnTc.Location = new System.Drawing.Point(145, 117);
            this.txtOgrtmnTc.Margin = new System.Windows.Forms.Padding(2);
            this.txtOgrtmnTc.Name = "txtOgrtmnTc";
            this.txtOgrtmnTc.Size = new System.Drawing.Size(76, 20);
            this.txtOgrtmnTc.TabIndex = 2;
            // 
            // txtOgrtmnSoyad
            // 
            this.txtOgrtmnSoyad.Location = new System.Drawing.Point(145, 82);
            this.txtOgrtmnSoyad.Margin = new System.Windows.Forms.Padding(2);
            this.txtOgrtmnSoyad.Name = "txtOgrtmnSoyad";
            this.txtOgrtmnSoyad.Size = new System.Drawing.Size(76, 20);
            this.txtOgrtmnSoyad.TabIndex = 1;
            // 
            // txtOgrtmnAd
            // 
            this.txtOgrtmnAd.Location = new System.Drawing.Point(145, 51);
            this.txtOgrtmnAd.Margin = new System.Windows.Forms.Padding(2);
            this.txtOgrtmnAd.Name = "txtOgrtmnAd";
            this.txtOgrtmnAd.Size = new System.Drawing.Size(76, 20);
            this.txtOgrtmnAd.TabIndex = 0;
            // 
            // btnOgrtmnKaydet
            // 
            this.btnOgrtmnKaydet.Location = new System.Drawing.Point(187, 284);
            this.btnOgrtmnKaydet.Margin = new System.Windows.Forms.Padding(2);
            this.btnOgrtmnKaydet.Name = "btnOgrtmnKaydet";
            this.btnOgrtmnKaydet.Size = new System.Drawing.Size(178, 32);
            this.btnOgrtmnKaydet.TabIndex = 2;
            this.btnOgrtmnKaydet.Text = "Kaydet";
            this.btnOgrtmnKaydet.UseVisualStyleBackColor = true;
            this.btnOgrtmnKaydet.Click += new System.EventHandler(this.btnOgrtmnKaydet_Click);
            // 
            // frmOgretmenKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOgrtmnKaydet);
            this.Controls.Add(this.grpOgretmen);
            this.Name = "frmOgretmenKayit";
            this.Text = "frmOgretmenKayit";
            this.Load += new System.EventHandler(this.frmOgretmenKayit_Load);
            this.grpOgretmen.ResumeLayout(false);
            this.grpOgretmen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOgretmen;
        private System.Windows.Forms.Label lblOgrtmnTc;
        private System.Windows.Forms.Label lblOgrtmnSoyad;
        private System.Windows.Forms.Label lblOgrtmnAd;
        private System.Windows.Forms.TextBox txtOgrtmnTc;
        private System.Windows.Forms.TextBox txtOgrtmnSoyad;
        private System.Windows.Forms.TextBox txtOgrtmnAd;
        private System.Windows.Forms.Button btnOgrtmnKaydet;
    }
}