namespace Npd_proje_hasan_berat_söke_b181200046
{
    partial class giris_ekrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giris_ekrani));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cıkıs = new System.Windows.Forms.Button();
            this.giris = new System.Windows.Forms.Button();
            this.kullanici_adi_txt = new System.Windows.Forms.TextBox();
            this.sifre_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabelÜyeol = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(798, 476);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cıkıs
            // 
            this.cıkıs.Location = new System.Drawing.Point(631, 309);
            this.cıkıs.Name = "cıkıs";
            this.cıkıs.Size = new System.Drawing.Size(88, 26);
            this.cıkıs.TabIndex = 1;
            this.cıkıs.Text = "Çıkış";
            this.cıkıs.UseVisualStyleBackColor = true;
            this.cıkıs.Click += new System.EventHandler(this.cıkıs_Click);
            // 
            // giris
            // 
            this.giris.Location = new System.Drawing.Point(496, 309);
            this.giris.Name = "giris";
            this.giris.Size = new System.Drawing.Size(88, 26);
            this.giris.TabIndex = 2;
            this.giris.Text = "Giriş yap";
            this.giris.UseVisualStyleBackColor = true;
            this.giris.Click += new System.EventHandler(this.giris_Click);
            // 
            // kullanici_adi_txt
            // 
            this.kullanici_adi_txt.Location = new System.Drawing.Point(496, 131);
            this.kullanici_adi_txt.Name = "kullanici_adi_txt";
            this.kullanici_adi_txt.Size = new System.Drawing.Size(223, 20);
            this.kullanici_adi_txt.TabIndex = 5;
            // 
            // sifre_txt
            // 
            this.sifre_txt.Location = new System.Drawing.Point(496, 204);
            this.sifre_txt.Name = "sifre_txt";
            this.sifre_txt.PasswordChar = '*';
            this.sifre_txt.Size = new System.Drawing.Size(223, 20);
            this.sifre_txt.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(496, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mail Adresi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(496, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Şifre";
            // 
            // linkLabelÜyeol
            // 
            this.linkLabelÜyeol.AutoSize = true;
            this.linkLabelÜyeol.Location = new System.Drawing.Point(636, 362);
            this.linkLabelÜyeol.Name = "linkLabelÜyeol";
            this.linkLabelÜyeol.Size = new System.Drawing.Size(37, 13);
            this.linkLabelÜyeol.TabIndex = 9;
            this.linkLabelÜyeol.TabStop = true;
            this.linkLabelÜyeol.Text = "Üye ol";
            this.linkLabelÜyeol.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelÜyeol_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(496, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Üye olmak için tıklayın";
            // 
            // giris_ekrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 476);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabelÜyeol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sifre_txt);
            this.Controls.Add(this.kullanici_adi_txt);
            this.Controls.Add(this.giris);
            this.Controls.Add(this.cıkıs);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "giris_ekrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı giriş ekranı";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cıkıs;
        private System.Windows.Forms.Button giris;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox kullanici_adi_txt;
        private System.Windows.Forms.TextBox sifre_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabelÜyeol;
        private System.Windows.Forms.Label label3;
    }
}

