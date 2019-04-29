namespace RentACarForm
{
    partial class KiralamaForm
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
            this.lblAracBilgi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAracPlakalar = new System.Windows.Forms.ComboBox();
            this.lblMusteriBilgi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbKayitliMusteri = new System.Windows.Forms.ComboBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.lblTelNo = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtKimlikNo = new System.Windows.Forms.TextBox();
            this.txtTelNo = new System.Windows.Forms.TextBox();
            this.lblDogumTarihi = new System.Windows.Forms.Label();
            this.lblEhliyetTarihi = new System.Windows.Forms.Label();
            this.lblEhliyetTipi = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtEhliyetTipi = new System.Windows.Forms.MaskedTextBox();
            this.dtpEhliyetTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnAracKirala = new System.Windows.Forms.Button();
            this.pbFirmaLogo = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbFirmaLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAracBilgi
            // 
            this.lblAracBilgi.BackColor = System.Drawing.Color.Transparent;
            this.lblAracBilgi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAracBilgi.Image = global::RentACarForm.Properties.Resources.iconfinder_aiga_taxi_1341161;
            this.lblAracBilgi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAracBilgi.Location = new System.Drawing.Point(57, 27);
            this.lblAracBilgi.Name = "lblAracBilgi";
            this.lblAracBilgi.Size = new System.Drawing.Size(119, 23);
            this.lblAracBilgi.TabIndex = 0;
            this.lblAracBilgi.Text = "Araç Bilgi";
            this.lblAracBilgi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(58, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Araç Plakası";
            // 
            // cmbAracPlakalar
            // 
            this.cmbAracPlakalar.FormattingEnabled = true;
            this.cmbAracPlakalar.Location = new System.Drawing.Point(152, 65);
            this.cmbAracPlakalar.Name = "cmbAracPlakalar";
            this.cmbAracPlakalar.Size = new System.Drawing.Size(121, 21);
            this.cmbAracPlakalar.TabIndex = 2;
            // 
            // lblMusteriBilgi
            // 
            this.lblMusteriBilgi.BackColor = System.Drawing.Color.Transparent;
            this.lblMusteriBilgi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteriBilgi.Image = global::RentACarForm.Properties.Resources.iconfinder_User_Card_22169;
            this.lblMusteriBilgi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMusteriBilgi.Location = new System.Drawing.Point(57, 121);
            this.lblMusteriBilgi.Name = "lblMusteriBilgi";
            this.lblMusteriBilgi.Size = new System.Drawing.Size(143, 25);
            this.lblMusteriBilgi.TabIndex = 3;
            this.lblMusteriBilgi.Text = "Müşteri Bilgi";
            this.lblMusteriBilgi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(58, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kayıtlı Müşteri";
            // 
            // cmbKayitliMusteri
            // 
            this.cmbKayitliMusteri.FormattingEnabled = true;
            this.cmbKayitliMusteri.Location = new System.Drawing.Point(152, 160);
            this.cmbKayitliMusteri.Name = "cmbKayitliMusteri";
            this.cmbKayitliMusteri.Size = new System.Drawing.Size(121, 21);
            this.cmbKayitliMusteri.TabIndex = 5;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.BackColor = System.Drawing.Color.Transparent;
            this.lblAd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(58, 210);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(23, 16);
            this.lblAd.TabIndex = 6;
            this.lblAd.Text = "Ad";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.BackColor = System.Drawing.Color.Transparent;
            this.lblSoyad.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.Location = new System.Drawing.Point(58, 237);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(43, 16);
            this.lblSoyad.TabIndex = 7;
            this.lblSoyad.Text = "Soyad";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.BackColor = System.Drawing.Color.Transparent;
            this.lblTC.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTC.Location = new System.Drawing.Point(58, 265);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(60, 16);
            this.lblTC.TabIndex = 8;
            this.lblTC.Text = "Kimlik No";
            // 
            // lblTelNo
            // 
            this.lblTelNo.AutoSize = true;
            this.lblTelNo.BackColor = System.Drawing.Color.Transparent;
            this.lblTelNo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTelNo.Location = new System.Drawing.Point(58, 291);
            this.lblTelNo.Name = "lblTelNo";
            this.lblTelNo.Size = new System.Drawing.Size(70, 16);
            this.lblTelNo.TabIndex = 9;
            this.lblTelNo.Text = "Telefon No";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.BackColor = System.Drawing.Color.Transparent;
            this.lblAdres.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdres.Location = new System.Drawing.Point(349, 210);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(41, 16);
            this.lblAdres.TabIndex = 10;
            this.lblAdres.Text = "Adres";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(152, 206);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 11;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(152, 233);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSoyad.TabIndex = 12;
            // 
            // txtKimlikNo
            // 
            this.txtKimlikNo.Location = new System.Drawing.Point(152, 261);
            this.txtKimlikNo.Name = "txtKimlikNo";
            this.txtKimlikNo.Size = new System.Drawing.Size(100, 20);
            this.txtKimlikNo.TabIndex = 13;
            // 
            // txtTelNo
            // 
            this.txtTelNo.Location = new System.Drawing.Point(152, 287);
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Size = new System.Drawing.Size(100, 20);
            this.txtTelNo.TabIndex = 14;
            // 
            // lblDogumTarihi
            // 
            this.lblDogumTarihi.AutoSize = true;
            this.lblDogumTarihi.BackColor = System.Drawing.Color.Transparent;
            this.lblDogumTarihi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDogumTarihi.Location = new System.Drawing.Point(349, 237);
            this.lblDogumTarihi.Name = "lblDogumTarihi";
            this.lblDogumTarihi.Size = new System.Drawing.Size(85, 16);
            this.lblDogumTarihi.TabIndex = 15;
            this.lblDogumTarihi.Text = "Doğum Tarihi";
            // 
            // lblEhliyetTarihi
            // 
            this.lblEhliyetTarihi.AutoSize = true;
            this.lblEhliyetTarihi.BackColor = System.Drawing.Color.Transparent;
            this.lblEhliyetTarihi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEhliyetTarihi.Location = new System.Drawing.Point(349, 291);
            this.lblEhliyetTarihi.Name = "lblEhliyetTarihi";
            this.lblEhliyetTarihi.Size = new System.Drawing.Size(82, 16);
            this.lblEhliyetTarihi.TabIndex = 16;
            this.lblEhliyetTarihi.Text = "Ehliyet Tarihi";
            // 
            // lblEhliyetTipi
            // 
            this.lblEhliyetTipi.AutoSize = true;
            this.lblEhliyetTipi.BackColor = System.Drawing.Color.Transparent;
            this.lblEhliyetTipi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEhliyetTipi.Location = new System.Drawing.Point(349, 265);
            this.lblEhliyetTipi.Name = "lblEhliyetTipi";
            this.lblEhliyetTipi.Size = new System.Drawing.Size(70, 16);
            this.lblEhliyetTipi.TabIndex = 17;
            this.lblEhliyetTipi.Text = "Ehliyet Tipi";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(466, 209);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(100, 20);
            this.txtAdres.TabIndex = 18;
            // 
            // txtEhliyetTipi
            // 
            this.txtEhliyetTipi.Location = new System.Drawing.Point(466, 264);
            this.txtEhliyetTipi.Name = "txtEhliyetTipi";
            this.txtEhliyetTipi.Size = new System.Drawing.Size(100, 20);
            this.txtEhliyetTipi.TabIndex = 20;
            // 
            // dtpEhliyetTarihi
            // 
            this.dtpEhliyetTarihi.Location = new System.Drawing.Point(466, 290);
            this.dtpEhliyetTarihi.Name = "dtpEhliyetTarihi";
            this.dtpEhliyetTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtpEhliyetTarihi.TabIndex = 21;
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(466, 235);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtpDogumTarihi.TabIndex = 22;
            // 
            // btnAracKirala
            // 
            this.btnAracKirala.BackColor = System.Drawing.Color.Bisque;
            this.btnAracKirala.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAracKirala.Image = global::RentACarForm.Properties.Resources.iconfinder_Apply_105210;
            this.btnAracKirala.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAracKirala.Location = new System.Drawing.Point(553, 316);
            this.btnAracKirala.Name = "btnAracKirala";
            this.btnAracKirala.Size = new System.Drawing.Size(80, 26);
            this.btnAracKirala.TabIndex = 23;
            this.btnAracKirala.Text = "Kirala";
            this.btnAracKirala.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAracKirala.UseVisualStyleBackColor = false;
            this.btnAracKirala.Click += new System.EventHandler(this.BtnAracKirala_Click);
            // 
            // pbFirmaLogo
            // 
            this.pbFirmaLogo.Location = new System.Drawing.Point(466, 36);
            this.pbFirmaLogo.Name = "pbFirmaLogo";
            this.pbFirmaLogo.Size = new System.Drawing.Size(152, 66);
            this.pbFirmaLogo.TabIndex = 24;
            this.pbFirmaLogo.TabStop = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // KiralamaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RentACarForm.Properties.Resources.geometric;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pbFirmaLogo);
            this.Controls.Add(this.btnAracKirala);
            this.Controls.Add(this.dtpDogumTarihi);
            this.Controls.Add(this.dtpEhliyetTarihi);
            this.Controls.Add(this.txtEhliyetTipi);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.lblEhliyetTipi);
            this.Controls.Add(this.lblEhliyetTarihi);
            this.Controls.Add(this.lblDogumTarihi);
            this.Controls.Add(this.txtTelNo);
            this.Controls.Add(this.txtKimlikNo);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblTelNo);
            this.Controls.Add(this.lblTC);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.cmbKayitliMusteri);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblMusteriBilgi);
            this.Controls.Add(this.cmbAracPlakalar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAracBilgi);
            this.Name = "KiralamaForm";
            this.Size = new System.Drawing.Size(703, 357);
            ((System.ComponentModel.ISupportInitialize)(this.pbFirmaLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAracBilgi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAracPlakalar;
        private System.Windows.Forms.Label lblMusteriBilgi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbKayitliMusteri;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label lblTelNo;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtKimlikNo;
        private System.Windows.Forms.TextBox txtTelNo;
        private System.Windows.Forms.Label lblDogumTarihi;
        private System.Windows.Forms.Label lblEhliyetTarihi;
        private System.Windows.Forms.Label lblEhliyetTipi;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.MaskedTextBox txtEhliyetTipi;
        private System.Windows.Forms.DateTimePicker dtpEhliyetTarihi;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.Button btnAracKirala;
        private System.Windows.Forms.PictureBox pbFirmaLogo;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}
