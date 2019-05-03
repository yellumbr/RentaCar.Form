namespace RentACarForm
{
    partial class RezervasyonForm
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
            this.lblRezervasyon = new System.Windows.Forms.Label();
            this.btnRezerveKirala = new System.Windows.Forms.Button();
            this.btnRezerveSil = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.lstRezervasyon = new System.Windows.Forms.ListView();
            this.KullaniciAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Soyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Plaka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TeslimAlmaTarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TeslimEtmeTarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.musteriId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblRezervasyon
            // 
            this.lblRezervasyon.BackColor = System.Drawing.Color.Transparent;
            this.lblRezervasyon.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRezervasyon.Image = global::RentACarForm.Properties.Resources.iconfinder_reservation_4172165;
            this.lblRezervasyon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRezervasyon.Location = new System.Drawing.Point(37, 9);
            this.lblRezervasyon.Name = "lblRezervasyon";
            this.lblRezervasyon.Size = new System.Drawing.Size(310, 29);
            this.lblRezervasyon.TabIndex = 0;
            this.lblRezervasyon.Text = "Rezervasyon İşlemi Olan Araçlar";
            this.lblRezervasyon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnRezerveKirala
            // 
            this.btnRezerveKirala.BackColor = System.Drawing.Color.Plum;
            this.btnRezerveKirala.Image = global::RentACarForm.Properties.Resources.iconfinder_reservation_41721651;
            this.btnRezerveKirala.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRezerveKirala.Location = new System.Drawing.Point(299, 300);
            this.btnRezerveKirala.Name = "btnRezerveKirala";
            this.btnRezerveKirala.Size = new System.Drawing.Size(163, 31);
            this.btnRezerveKirala.TabIndex = 2;
            this.btnRezerveKirala.Text = "Seçili Rezervasyonu Kirala";
            this.btnRezerveKirala.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRezerveKirala.UseVisualStyleBackColor = false;
            this.btnRezerveKirala.Click += new System.EventHandler(this.BtnRezerveKirala_Click);
            // 
            // btnRezerveSil
            // 
            this.btnRezerveSil.BackColor = System.Drawing.Color.Plum;
            this.btnRezerveSil.Image = global::RentACarForm.Properties.Resources.iconfinder_basket_1814090;
            this.btnRezerveSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRezerveSil.Location = new System.Drawing.Point(468, 300);
            this.btnRezerveSil.Name = "btnRezerveSil";
            this.btnRezerveSil.Size = new System.Drawing.Size(144, 31);
            this.btnRezerveSil.TabIndex = 3;
            this.btnRezerveSil.Text = "Seçili Rezervasyonu Sil";
            this.btnRezerveSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRezerveSil.UseVisualStyleBackColor = false;
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
            // lstRezervasyon
            // 
            this.lstRezervasyon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.musteriId,
            this.KullaniciAdi,
            this.Ad,
            this.Soyad,
            this.Plaka,
            this.TeslimAlmaTarihi,
            this.TeslimEtmeTarihi});
            this.lstRezervasyon.FullRowSelect = true;
            this.lstRezervasyon.Location = new System.Drawing.Point(41, 63);
            this.lstRezervasyon.Name = "lstRezervasyon";
            this.lstRezervasyon.Size = new System.Drawing.Size(666, 212);
            this.lstRezervasyon.TabIndex = 5;
            this.lstRezervasyon.UseCompatibleStateImageBehavior = false;
            this.lstRezervasyon.View = System.Windows.Forms.View.Details;
            this.lstRezervasyon.SelectedIndexChanged += new System.EventHandler(this.LstRezervasyon_SelectedIndexChanged);
            // 
            // KullaniciAdi
            // 
            this.KullaniciAdi.Text = "Kullanıcı Adı";
            this.KullaniciAdi.Width = 107;
            // 
            // Ad
            // 
            this.Ad.Text = "Ad";
            this.Ad.Width = 95;
            // 
            // Soyad
            // 
            this.Soyad.Text = "Soyad";
            this.Soyad.Width = 74;
            // 
            // Plaka
            // 
            this.Plaka.Text = "Plaka";
            this.Plaka.Width = 82;
            // 
            // TeslimAlmaTarihi
            // 
            this.TeslimAlmaTarihi.Text = "Teslim Alma Tarihi";
            this.TeslimAlmaTarihi.Width = 128;
            // 
            // TeslimEtmeTarihi
            // 
            this.TeslimEtmeTarihi.Text = "Teslim Etme Tarihi";
            this.TeslimEtmeTarihi.Width = 116;
            // 
            // musteriId
            // 
            this.musteriId.Text = "MusteriId";
            this.musteriId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // RezervasyonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RentACarForm.Properties.Resources.triangles_1430105_1280;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lstRezervasyon);
            this.Controls.Add(this.btnRezerveSil);
            this.Controls.Add(this.btnRezerveKirala);
            this.Controls.Add(this.lblRezervasyon);
            this.DoubleBuffered = true;
            this.Name = "RezervasyonForm";
            this.Size = new System.Drawing.Size(732, 363);
            this.Load += new System.EventHandler(this.RezervasyonForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRezervasyon;
        private System.Windows.Forms.Button btnRezerveKirala;
        private System.Windows.Forms.Button btnRezerveSil;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.ListView lstRezervasyon;
        private System.Windows.Forms.ColumnHeader KullaniciAdi;
        private System.Windows.Forms.ColumnHeader Ad;
        private System.Windows.Forms.ColumnHeader Soyad;
        private System.Windows.Forms.ColumnHeader Plaka;
        private System.Windows.Forms.ColumnHeader TeslimAlmaTarihi;
        private System.Windows.Forms.ColumnHeader TeslimEtmeTarihi;
        private System.Windows.Forms.ColumnHeader musteriId;
    }
}
