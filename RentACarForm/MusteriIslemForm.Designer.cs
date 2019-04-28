namespace RentACarForm
{
    partial class MusteriIslemForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblMusteriEkle = new System.Windows.Forms.Label();
            this.lblMusteriSil = new System.Windows.Forms.Label();
            this.dtpMusteriDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtMusteriEhliyetTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtMusteriEhliyetTipi = new System.Windows.Forms.MaskedTextBox();
            this.txtMusteriAdres = new System.Windows.Forms.TextBox();
            this.lblEhliyetTipi = new System.Windows.Forms.Label();
            this.lblEhliyetTarihi = new System.Windows.Forms.Label();
            this.lblDogumTarihi = new System.Windows.Forms.Label();
            this.txtMusteriTel = new System.Windows.Forms.TextBox();
            this.txtMusteriTc = new System.Windows.Forms.TextBox();
            this.txtMusteriSoyad = new System.Windows.Forms.TextBox();
            this.txtMusteriAd = new System.Windows.Forms.TextBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblTelNo = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.cmbKayitliMusteriSil = new System.Windows.Forms.ComboBox();
            this.lblKayitliMusteriler = new System.Windows.Forms.Label();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.btnMusteriSil = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnMusteriGuncelle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMusteriEkle
            // 
            this.lblMusteriEkle.BackColor = System.Drawing.Color.Transparent;
            this.lblMusteriEkle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteriEkle.Image = global::RentACarForm.Properties.Resources.iconfinder_add_user_3802;
            this.lblMusteriEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMusteriEkle.Location = new System.Drawing.Point(45, 26);
            this.lblMusteriEkle.Name = "lblMusteriEkle";
            this.lblMusteriEkle.Size = new System.Drawing.Size(303, 26);
            this.lblMusteriEkle.TabIndex = 0;
            this.lblMusteriEkle.Text = "Müşteri Ekle ve Müşteri Güncelle";
            this.lblMusteriEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMusteriSil
            // 
            this.lblMusteriSil.BackColor = System.Drawing.Color.Transparent;
            this.lblMusteriSil.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteriSil.Image = global::RentACarForm.Properties.Resources.iconfinder_delete_user_18618;
            this.lblMusteriSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMusteriSil.Location = new System.Drawing.Point(54, 266);
            this.lblMusteriSil.Name = "lblMusteriSil";
            this.lblMusteriSil.Size = new System.Drawing.Size(126, 25);
            this.lblMusteriSil.TabIndex = 1;
            this.lblMusteriSil.Text = "Müşteri Sil";
            this.lblMusteriSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpMusteriDogumTarihi
            // 
            this.dtpMusteriDogumTarihi.Location = new System.Drawing.Point(448, 151);
            this.dtpMusteriDogumTarihi.Name = "dtpMusteriDogumTarihi";
            this.dtpMusteriDogumTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtpMusteriDogumTarihi.TabIndex = 38;
            // 
            // dtMusteriEhliyetTarihi
            // 
            this.dtMusteriEhliyetTarihi.Location = new System.Drawing.Point(448, 205);
            this.dtMusteriEhliyetTarihi.Name = "dtMusteriEhliyetTarihi";
            this.dtMusteriEhliyetTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtMusteriEhliyetTarihi.TabIndex = 37;
            // 
            // txtMusteriEhliyetTipi
            // 
            this.txtMusteriEhliyetTipi.Location = new System.Drawing.Point(448, 177);
            this.txtMusteriEhliyetTipi.Name = "txtMusteriEhliyetTipi";
            this.txtMusteriEhliyetTipi.Size = new System.Drawing.Size(100, 20);
            this.txtMusteriEhliyetTipi.TabIndex = 36;
            // 
            // txtMusteriAdres
            // 
            this.txtMusteriAdres.Location = new System.Drawing.Point(448, 70);
            this.txtMusteriAdres.Multiline = true;
            this.txtMusteriAdres.Name = "txtMusteriAdres";
            this.txtMusteriAdres.Size = new System.Drawing.Size(200, 47);
            this.txtMusteriAdres.TabIndex = 35;
            // 
            // lblEhliyetTipi
            // 
            this.lblEhliyetTipi.AutoSize = true;
            this.lblEhliyetTipi.BackColor = System.Drawing.Color.Transparent;
            this.lblEhliyetTipi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEhliyetTipi.Location = new System.Drawing.Point(341, 181);
            this.lblEhliyetTipi.Name = "lblEhliyetTipi";
            this.lblEhliyetTipi.Size = new System.Drawing.Size(70, 16);
            this.lblEhliyetTipi.TabIndex = 34;
            this.lblEhliyetTipi.Text = "Ehliyet Tipi";
            // 
            // lblEhliyetTarihi
            // 
            this.lblEhliyetTarihi.AutoSize = true;
            this.lblEhliyetTarihi.BackColor = System.Drawing.Color.Transparent;
            this.lblEhliyetTarihi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEhliyetTarihi.Location = new System.Drawing.Point(340, 207);
            this.lblEhliyetTarihi.Name = "lblEhliyetTarihi";
            this.lblEhliyetTarihi.Size = new System.Drawing.Size(82, 16);
            this.lblEhliyetTarihi.TabIndex = 33;
            this.lblEhliyetTarihi.Text = "Ehliyet Tarihi";
            // 
            // lblDogumTarihi
            // 
            this.lblDogumTarihi.AutoSize = true;
            this.lblDogumTarihi.BackColor = System.Drawing.Color.Transparent;
            this.lblDogumTarihi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDogumTarihi.Location = new System.Drawing.Point(340, 155);
            this.lblDogumTarihi.Name = "lblDogumTarihi";
            this.lblDogumTarihi.Size = new System.Drawing.Size(85, 16);
            this.lblDogumTarihi.TabIndex = 32;
            this.lblDogumTarihi.Text = "Doğum Tarihi";
            // 
            // txtMusteriTel
            // 
            this.txtMusteriTel.Location = new System.Drawing.Point(140, 151);
            this.txtMusteriTel.Name = "txtMusteriTel";
            this.txtMusteriTel.Size = new System.Drawing.Size(100, 20);
            this.txtMusteriTel.TabIndex = 31;
            // 
            // txtMusteriTc
            // 
            this.txtMusteriTc.Location = new System.Drawing.Point(140, 74);
            this.txtMusteriTc.Name = "txtMusteriTc";
            this.txtMusteriTc.Size = new System.Drawing.Size(100, 20);
            this.txtMusteriTc.TabIndex = 30;
            // 
            // txtMusteriSoyad
            // 
            this.txtMusteriSoyad.Location = new System.Drawing.Point(140, 125);
            this.txtMusteriSoyad.Name = "txtMusteriSoyad";
            this.txtMusteriSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtMusteriSoyad.TabIndex = 29;
            // 
            // txtMusteriAd
            // 
            this.txtMusteriAd.Location = new System.Drawing.Point(140, 99);
            this.txtMusteriAd.Name = "txtMusteriAd";
            this.txtMusteriAd.Size = new System.Drawing.Size(100, 20);
            this.txtMusteriAd.TabIndex = 28;
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.BackColor = System.Drawing.Color.Transparent;
            this.lblAdres.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdres.Location = new System.Drawing.Point(341, 74);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(41, 16);
            this.lblAdres.TabIndex = 27;
            this.lblAdres.Text = "Adres";
            // 
            // lblTelNo
            // 
            this.lblTelNo.AutoSize = true;
            this.lblTelNo.BackColor = System.Drawing.Color.Transparent;
            this.lblTelNo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTelNo.Location = new System.Drawing.Point(46, 155);
            this.lblTelNo.Name = "lblTelNo";
            this.lblTelNo.Size = new System.Drawing.Size(70, 16);
            this.lblTelNo.TabIndex = 26;
            this.lblTelNo.Text = "Telefon No";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.BackColor = System.Drawing.Color.Transparent;
            this.lblTC.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTC.Location = new System.Drawing.Point(46, 74);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(60, 16);
            this.lblTC.TabIndex = 25;
            this.lblTC.Text = "Kimlik No";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.BackColor = System.Drawing.Color.Transparent;
            this.lblSoyad.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.Location = new System.Drawing.Point(46, 126);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(43, 16);
            this.lblSoyad.TabIndex = 24;
            this.lblSoyad.Text = "Soyad";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.BackColor = System.Drawing.Color.Transparent;
            this.lblAd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(46, 100);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(23, 16);
            this.lblAd.TabIndex = 23;
            this.lblAd.Text = "Ad";
            // 
            // cmbKayitliMusteriSil
            // 
            this.cmbKayitliMusteriSil.FormattingEnabled = true;
            this.cmbKayitliMusteriSil.Location = new System.Drawing.Point(149, 315);
            this.cmbKayitliMusteriSil.Name = "cmbKayitliMusteriSil";
            this.cmbKayitliMusteriSil.Size = new System.Drawing.Size(121, 21);
            this.cmbKayitliMusteriSil.TabIndex = 40;
            this.cmbKayitliMusteriSil.SelectedIndexChanged += new System.EventHandler(this.CmbKayitliMusteriSil_SelectedIndexChanged);
            // 
            // lblKayitliMusteriler
            // 
            this.lblKayitliMusteriler.AutoSize = true;
            this.lblKayitliMusteriler.BackColor = System.Drawing.Color.Transparent;
            this.lblKayitliMusteriler.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKayitliMusteriler.Location = new System.Drawing.Point(55, 316);
            this.lblKayitliMusteriler.Name = "lblKayitliMusteriler";
            this.lblKayitliMusteriler.Size = new System.Drawing.Size(87, 16);
            this.lblKayitliMusteriler.TabIndex = 39;
            this.lblKayitliMusteriler.Text = "Kayıtlı Müşteri";
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.BackColor = System.Drawing.Color.Bisque;
            this.btnMusteriEkle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriEkle.Image = global::RentACarForm.Properties.Resources.iconfinder_user_add_216490;
            this.btnMusteriEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusteriEkle.Location = new System.Drawing.Point(539, 231);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(109, 33);
            this.btnMusteriEkle.TabIndex = 41;
            this.btnMusteriEkle.Text = "Müşteri Ekle";
            this.btnMusteriEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMusteriEkle.UseVisualStyleBackColor = false;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // btnMusteriSil
            // 
            this.btnMusteriSil.BackColor = System.Drawing.Color.Bisque;
            this.btnMusteriSil.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriSil.Image = global::RentACarForm.Properties.Resources.iconfinder_user_delete_216494;
            this.btnMusteriSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusteriSil.Location = new System.Drawing.Point(176, 362);
            this.btnMusteriSil.Name = "btnMusteriSil";
            this.btnMusteriSil.Size = new System.Drawing.Size(94, 32);
            this.btnMusteriSil.TabIndex = 42;
            this.btnMusteriSil.Text = "Müşteri Sil";
            this.btnMusteriSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMusteriSil.UseVisualStyleBackColor = false;
            this.btnMusteriSil.Click += new System.EventHandler(this.btnMusteriSil_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.BackColor = System.Drawing.Color.Transparent;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciAdi.Location = new System.Drawing.Point(46, 181);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(76, 16);
            this.lblKullaniciAdi.TabIndex = 43;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(140, 177);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(100, 20);
            this.txtKullaniciAdi.TabIndex = 44;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.BackColor = System.Drawing.Color.Transparent;
            this.lblSifre.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.Location = new System.Drawing.Point(46, 205);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(35, 16);
            this.lblSifre.TabIndex = 45;
            this.lblSifre.Text = "Şifre";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(140, 203);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(100, 20);
            this.txtSifre.TabIndex = 46;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmail.Location = new System.Drawing.Point(341, 129);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(71, 16);
            this.lblEmail.TabIndex = 47;
            this.lblEmail.Text = "Mail Adresi";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(448, 125);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 48;
            // 
            // btnMusteriGuncelle
            // 
            this.btnMusteriGuncelle.BackColor = System.Drawing.Color.Bisque;
            this.btnMusteriGuncelle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriGuncelle.Image = global::RentACarForm.Properties.Resources.iconfinder_44_refresh_4201253;
            this.btnMusteriGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusteriGuncelle.Location = new System.Drawing.Point(391, 231);
            this.btnMusteriGuncelle.Name = "btnMusteriGuncelle";
            this.btnMusteriGuncelle.Size = new System.Drawing.Size(129, 33);
            this.btnMusteriGuncelle.TabIndex = 49;
            this.btnMusteriGuncelle.Text = "Müşteri Güncelle";
            this.btnMusteriGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMusteriGuncelle.UseVisualStyleBackColor = false;
            this.btnMusteriGuncelle.Click += new System.EventHandler(this.BtnMusteriGuncelle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(276, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Müşteri bilgilerini güncellemek için müşteri seçiniz";
            // 
            // MusteriIslemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RentACarForm.Properties.Resources.wall_1851061_1280;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMusteriGuncelle);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.btnMusteriSil);
            this.Controls.Add(this.btnMusteriEkle);
            this.Controls.Add(this.cmbKayitliMusteriSil);
            this.Controls.Add(this.lblKayitliMusteriler);
            this.Controls.Add(this.dtpMusteriDogumTarihi);
            this.Controls.Add(this.dtMusteriEhliyetTarihi);
            this.Controls.Add(this.txtMusteriEhliyetTipi);
            this.Controls.Add(this.txtMusteriAdres);
            this.Controls.Add(this.lblEhliyetTipi);
            this.Controls.Add(this.lblEhliyetTarihi);
            this.Controls.Add(this.lblDogumTarihi);
            this.Controls.Add(this.txtMusteriTel);
            this.Controls.Add(this.txtMusteriTc);
            this.Controls.Add(this.txtMusteriSoyad);
            this.Controls.Add(this.txtMusteriAd);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblTelNo);
            this.Controls.Add(this.lblTC);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.lblMusteriSil);
            this.Controls.Add(this.lblMusteriEkle);
            this.Name = "MusteriIslemForm";
            this.Size = new System.Drawing.Size(691, 416);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMusteriEkle;
        private System.Windows.Forms.Label lblMusteriSil;
        private System.Windows.Forms.DateTimePicker dtpMusteriDogumTarihi;
        private System.Windows.Forms.DateTimePicker dtMusteriEhliyetTarihi;
        private System.Windows.Forms.MaskedTextBox txtMusteriEhliyetTipi;
        private System.Windows.Forms.TextBox txtMusteriAdres;
        private System.Windows.Forms.Label lblEhliyetTipi;
        private System.Windows.Forms.Label lblEhliyetTarihi;
        private System.Windows.Forms.Label lblDogumTarihi;
        private System.Windows.Forms.TextBox txtMusteriTel;
        private System.Windows.Forms.TextBox txtMusteriTc;
        private System.Windows.Forms.TextBox txtMusteriSoyad;
        private System.Windows.Forms.TextBox txtMusteriAd;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblTelNo;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.ComboBox cmbKayitliMusteriSil;
        private System.Windows.Forms.Label lblKayitliMusteriler;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.Button btnMusteriSil;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnMusteriGuncelle;
        private System.Windows.Forms.Label label2;
    }
}
