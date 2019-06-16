namespace Tukkan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnHesapla = new System.Windows.Forms.Button();
            this.btnSiparisEkle = new System.Windows.Forms.Button();
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSiparisler = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbMenuAdet = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkAciSos = new System.Windows.Forms.CheckBox();
            this.chkPatates = new System.Windows.Forms.CheckBox();
            this.chkHardal = new System.Windows.Forms.CheckBox();
            this.chkRanch = new System.Windows.Forms.CheckBox();
            this.chkSogan = new System.Windows.Forms.CheckBox();
            this.chkTursu = new System.Windows.Forms.CheckBox();
            this.ChkMayonez = new System.Windows.Forms.CheckBox();
            this.chkKetcap = new System.Windows.Forms.CheckBox();
            this.cmbMenu = new System.Windows.Forms.ComboBox();
            this.rdButonTam = new System.Windows.Forms.RadioButton();
            this.rdButonYarim = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(616, 311);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 0;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // btnSiparisEkle
            // 
            this.btnSiparisEkle.Location = new System.Drawing.Point(697, 311);
            this.btnSiparisEkle.Name = "btnSiparisEkle";
            this.btnSiparisEkle.Size = new System.Drawing.Size(75, 23);
            this.btnSiparisEkle.TabIndex = 1;
            this.btnSiparisEkle.Text = "Sipariş Ekle";
            this.btnSiparisEkle.UseVisualStyleBackColor = true;
            this.btnSiparisEkle.Click += new System.EventHandler(this.btnSiparisEkle_Click);
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Location = new System.Drawing.Point(443, 311);
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.ReadOnly = true;
            this.txtToplamTutar.Size = new System.Drawing.Size(158, 20);
            this.txtToplamTutar.TabIndex = 2;
            this.txtToplamTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(443, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Toplam Tutar";
            // 
            // txtSiparisler
            // 
            this.txtSiparisler.Location = new System.Drawing.Point(4, 14);
            this.txtSiparisler.Name = "txtSiparisler";
            this.txtSiparisler.ReadOnly = true;
            this.txtSiparisler.Size = new System.Drawing.Size(382, 230);
            this.txtSiparisler.TabIndex = 4;
            this.txtSiparisler.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSiparisler);
            this.groupBox1.Location = new System.Drawing.Point(432, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 244);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Siparişler";
            // 
            // cmbMenuAdet
            // 
            this.cmbMenuAdet.FormattingEnabled = true;
            this.cmbMenuAdet.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbMenuAdet.Location = new System.Drawing.Point(6, 28);
            this.cmbMenuAdet.Name = "cmbMenuAdet";
            this.cmbMenuAdet.Size = new System.Drawing.Size(188, 21);
            this.cmbMenuAdet.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkAciSos);
            this.groupBox2.Controls.Add(this.chkPatates);
            this.groupBox2.Controls.Add(this.chkHardal);
            this.groupBox2.Controls.Add(this.chkRanch);
            this.groupBox2.Controls.Add(this.chkSogan);
            this.groupBox2.Controls.Add(this.chkTursu);
            this.groupBox2.Controls.Add(this.ChkMayonez);
            this.groupBox2.Controls.Add(this.chkKetcap);
            this.groupBox2.Location = new System.Drawing.Point(207, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 148);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ekstralar";
            // 
            // chkAciSos
            // 
            this.chkAciSos.AutoSize = true;
            this.chkAciSos.Location = new System.Drawing.Point(93, 32);
            this.chkAciSos.Name = "chkAciSos";
            this.chkAciSos.Size = new System.Drawing.Size(62, 17);
            this.chkAciSos.TabIndex = 0;
            this.chkAciSos.Text = "Acı Sos";
            this.chkAciSos.UseVisualStyleBackColor = true;
            // 
            // chkPatates
            // 
            this.chkPatates.AutoSize = true;
            this.chkPatates.Location = new System.Drawing.Point(92, 59);
            this.chkPatates.Name = "chkPatates";
            this.chkPatates.Size = new System.Drawing.Size(62, 17);
            this.chkPatates.TabIndex = 0;
            this.chkPatates.Text = "Patates";
            this.chkPatates.UseVisualStyleBackColor = true;
            // 
            // chkHardal
            // 
            this.chkHardal.AutoSize = true;
            this.chkHardal.Location = new System.Drawing.Point(92, 83);
            this.chkHardal.Name = "chkHardal";
            this.chkHardal.Size = new System.Drawing.Size(57, 17);
            this.chkHardal.TabIndex = 0;
            this.chkHardal.Text = "Hardal";
            this.chkHardal.UseVisualStyleBackColor = true;
            // 
            // chkRanch
            // 
            this.chkRanch.AutoSize = true;
            this.chkRanch.Location = new System.Drawing.Point(92, 106);
            this.chkRanch.Name = "chkRanch";
            this.chkRanch.Size = new System.Drawing.Size(79, 17);
            this.chkRanch.TabIndex = 0;
            this.chkRanch.Text = "Ranch Sos";
            this.chkRanch.UseVisualStyleBackColor = true;
            // 
            // chkSogan
            // 
            this.chkSogan.AutoSize = true;
            this.chkSogan.Location = new System.Drawing.Point(6, 99);
            this.chkSogan.Name = "chkSogan";
            this.chkSogan.Size = new System.Drawing.Size(57, 17);
            this.chkSogan.TabIndex = 0;
            this.chkSogan.Text = "Soğan";
            this.chkSogan.UseVisualStyleBackColor = true;
            // 
            // chkTursu
            // 
            this.chkTursu.AutoSize = true;
            this.chkTursu.Location = new System.Drawing.Point(6, 78);
            this.chkTursu.Name = "chkTursu";
            this.chkTursu.Size = new System.Drawing.Size(53, 17);
            this.chkTursu.TabIndex = 0;
            this.chkTursu.Text = "Turşu";
            this.chkTursu.UseVisualStyleBackColor = true;
            // 
            // ChkMayonez
            // 
            this.ChkMayonez.AutoSize = true;
            this.ChkMayonez.Location = new System.Drawing.Point(6, 55);
            this.ChkMayonez.Name = "ChkMayonez";
            this.ChkMayonez.Size = new System.Drawing.Size(69, 17);
            this.ChkMayonez.TabIndex = 0;
            this.ChkMayonez.Text = "Mayonez";
            this.ChkMayonez.UseVisualStyleBackColor = true;
            // 
            // chkKetcap
            // 
            this.chkKetcap.AutoSize = true;
            this.chkKetcap.Location = new System.Drawing.Point(7, 32);
            this.chkKetcap.Name = "chkKetcap";
            this.chkKetcap.Size = new System.Drawing.Size(60, 17);
            this.chkKetcap.TabIndex = 0;
            this.chkKetcap.Text = "Ketçap";
            this.chkKetcap.UseVisualStyleBackColor = true;
            // 
            // cmbMenu
            // 
            this.cmbMenu.FormattingEnabled = true;
            this.cmbMenu.Items.AddRange(new object[] {
            "Tavuk Menü",
            "Et Döner Menü",
            "Tombik Döner",
            "Pirzola Menü"});
            this.cmbMenu.Location = new System.Drawing.Point(7, 14);
            this.cmbMenu.Name = "cmbMenu";
            this.cmbMenu.Size = new System.Drawing.Size(187, 21);
            this.cmbMenu.TabIndex = 10;
            // 
            // rdButonTam
            // 
            this.rdButonTam.AutoSize = true;
            this.rdButonTam.Location = new System.Drawing.Point(17, 19);
            this.rdButonTam.Name = "rdButonTam";
            this.rdButonTam.Size = new System.Drawing.Size(46, 17);
            this.rdButonTam.TabIndex = 11;
            this.rdButonTam.TabStop = true;
            this.rdButonTam.Text = "Tam";
            this.rdButonTam.UseVisualStyleBackColor = true;
            // 
            // rdButonYarim
            // 
            this.rdButonYarim.AutoSize = true;
            this.rdButonYarim.Location = new System.Drawing.Point(115, 19);
            this.rdButonYarim.Name = "rdButonYarim";
            this.rdButonYarim.Size = new System.Drawing.Size(51, 17);
            this.rdButonYarim.TabIndex = 11;
            this.rdButonYarim.TabStop = true;
            this.rdButonYarim.Text = "Yarım";
            this.rdButonYarim.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbMenuAdet);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(207, 280);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 53);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Menü Adedi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(284, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(389, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "TÜKKAN SİPARİŞ ÜCRETLENDİRME SİSTEMİ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdButonTam);
            this.groupBox4.Controls.Add(this.rdButonYarim);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(207, 75);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 46);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Porsiyon";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cmbMenu);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox5.Location = new System.Drawing.Point(207, 30);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 39);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Menü";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 259);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(842, 355);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtToplamTutar);
            this.Controls.Add(this.btnSiparisEkle);
            this.Controls.Add(this.btnHesapla);
            this.Name = "Form1";
            this.Text = "Tükkan Sistem";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Button btnSiparisEkle;
        private System.Windows.Forms.TextBox txtToplamTutar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtSiparisler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbMenuAdet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkAciSos;
        private System.Windows.Forms.CheckBox chkPatates;
        private System.Windows.Forms.CheckBox chkHardal;
        private System.Windows.Forms.CheckBox chkRanch;
        private System.Windows.Forms.CheckBox chkSogan;
        private System.Windows.Forms.CheckBox chkTursu;
        private System.Windows.Forms.CheckBox ChkMayonez;
        private System.Windows.Forms.CheckBox chkKetcap;
        private System.Windows.Forms.ComboBox cmbMenu;
        private System.Windows.Forms.RadioButton rdButonTam;
        private System.Windows.Forms.RadioButton rdButonYarim;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

