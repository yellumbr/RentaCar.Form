namespace RentACarForm
{
    partial class IslemlerForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IslemlerForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aracIslemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniAracEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aracSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MusteriIslemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KiralamaIslemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imgbtnMin = new Bunifu.UI.WinForms.BunifuImageButton();
            this.imgbtnExit = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.musteriIslemForm1 = new RentACarForm.MusteriIslemForm();
            this.rezervasyonForm1 = new RentACarForm.RezervasyonForm();
            this.kiralamaForm1 = new RentACarForm.KiralamaForm();
            this.girisForm1 = new RentACarForm.GirisForm();
            this.aracGuncelleSilForm1 = new RentACarForm.AracGuncelleSilForm();
            this.aracEkleForm1 = new RentACarForm.AracEkleForm();
            this.RezervelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Firebrick;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aracIslemleriToolStripMenuItem,
            this.MusteriIslemleriToolStripMenuItem,
            this.KiralamaIslemleriToolStripMenuItem,
            this.RezervelerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(783, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aracIslemleriToolStripMenuItem
            // 
            this.aracIslemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniAracEkleToolStripMenuItem,
            this.aracSilToolStripMenuItem});
            this.aracIslemleriToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aracIslemleriToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.aracIslemleriToolStripMenuItem.Image = global::RentACarForm.Properties.Resources.iconfinder_aiga_taxi_134116;
            this.aracIslemleriToolStripMenuItem.Name = "aracIslemleriToolStripMenuItem";
            this.aracIslemleriToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.aracIslemleriToolStripMenuItem.Text = "ARAÇ İŞLEMLERİ";
            // 
            // yeniAracEkleToolStripMenuItem
            // 
            this.yeniAracEkleToolStripMenuItem.Image = global::RentACarForm.Properties.Resources.iconfinder_plus_add_blue_61657;
            this.yeniAracEkleToolStripMenuItem.Name = "yeniAracEkleToolStripMenuItem";
            this.yeniAracEkleToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.yeniAracEkleToolStripMenuItem.Text = "Yeni Araç Ekle";
            this.yeniAracEkleToolStripMenuItem.Click += new System.EventHandler(this.yeniAracEkleToolStripMenuItem_Click);
            // 
            // aracSilToolStripMenuItem
            // 
            this.aracSilToolStripMenuItem.Image = global::RentACarForm.Properties.Resources.iconfinder_update_64935;
            this.aracSilToolStripMenuItem.Name = "aracSilToolStripMenuItem";
            this.aracSilToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.aracSilToolStripMenuItem.Text = "Araç Bilgi Güncelleme ve Silme";
            this.aracSilToolStripMenuItem.Click += new System.EventHandler(this.aracSilToolStripMenuItem_Click);
            // 
            // MusteriIslemleriToolStripMenuItem
            // 
            this.MusteriIslemleriToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MusteriIslemleriToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MusteriIslemleriToolStripMenuItem.Image = global::RentACarForm.Properties.Resources.iconfinder_engagement_customer_user_interaction_branding_3209311;
            this.MusteriIslemleriToolStripMenuItem.Name = "MusteriIslemleriToolStripMenuItem";
            this.MusteriIslemleriToolStripMenuItem.Size = new System.Drawing.Size(146, 20);
            this.MusteriIslemleriToolStripMenuItem.Text = "MÜŞTERİ İŞLEMLERİ";
            this.MusteriIslemleriToolStripMenuItem.Click += new System.EventHandler(this.MusteriIslemleriToolStripMenuItem_Click);
            // 
            // KiralamaIslemleriToolStripMenuItem
            // 
            this.KiralamaIslemleriToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KiralamaIslemleriToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.KiralamaIslemleriToolStripMenuItem.Image = global::RentACarForm.Properties.Resources.iconfinder_buy_103428;
            this.KiralamaIslemleriToolStripMenuItem.Name = "KiralamaIslemleriToolStripMenuItem";
            this.KiralamaIslemleriToolStripMenuItem.Size = new System.Drawing.Size(153, 20);
            this.KiralamaIslemleriToolStripMenuItem.Text = "KİRALAMA İŞLEMLERİ";
            this.KiralamaIslemleriToolStripMenuItem.Click += new System.EventHandler(this.KiralamaIslemleriToolStripMenuItem_Click);
            // 
            // imgbtnMin
            // 
            this.imgbtnMin.ActiveImage = null;
            this.imgbtnMin.AllowAnimations = true;
            this.imgbtnMin.AllowZooming = true;
            this.imgbtnMin.BackColor = System.Drawing.Color.Transparent;
            this.imgbtnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imgbtnMin.ErrorImage = ((System.Drawing.Image)(resources.GetObject("imgbtnMin.ErrorImage")));
            this.imgbtnMin.FadeWhenInactive = false;
            this.imgbtnMin.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.imgbtnMin.ForeColor = System.Drawing.Color.Transparent;
            this.imgbtnMin.Image = global::RentACarForm.Properties.Resources.iconfinder_minus_1814110;
            this.imgbtnMin.ImageActive = null;
            this.imgbtnMin.ImageLocation = null;
            this.imgbtnMin.ImageMargin = 40;
            this.imgbtnMin.ImageSize = new System.Drawing.Size(-19, -20);
            this.imgbtnMin.ImageZoomSize = new System.Drawing.Size(21, 20);
            this.imgbtnMin.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgbtnMin.InitialImage")));
            this.imgbtnMin.Location = new System.Drawing.Point(735, 0);
            this.imgbtnMin.Name = "imgbtnMin";
            this.imgbtnMin.Rotation = 0;
            this.imgbtnMin.ShowActiveImage = true;
            this.imgbtnMin.ShowCursorChanges = true;
            this.imgbtnMin.ShowImageBorders = true;
            this.imgbtnMin.ShowSizeMarkers = false;
            this.imgbtnMin.Size = new System.Drawing.Size(21, 20);
            this.imgbtnMin.TabIndex = 4;
            this.imgbtnMin.ToolTipText = "";
            this.imgbtnMin.WaitOnLoad = false;
            this.imgbtnMin.Zoom = 40;
            this.imgbtnMin.ZoomSpeed = 10;
            this.imgbtnMin.Click += new System.EventHandler(this.imgbtnMin_Click);
            // 
            // imgbtnExit
            // 
            this.imgbtnExit.ActiveImage = null;
            this.imgbtnExit.AllowAnimations = true;
            this.imgbtnExit.AllowZooming = true;
            this.imgbtnExit.BackColor = System.Drawing.Color.Transparent;
            this.imgbtnExit.ErrorImage = ((System.Drawing.Image)(resources.GetObject("imgbtnExit.ErrorImage")));
            this.imgbtnExit.FadeWhenInactive = false;
            this.imgbtnExit.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.imgbtnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.imgbtnExit.Image = global::RentACarForm.Properties.Resources.iconfinder_close2_1814078;
            this.imgbtnExit.ImageActive = null;
            this.imgbtnExit.ImageLocation = null;
            this.imgbtnExit.ImageMargin = 40;
            this.imgbtnExit.ImageSize = new System.Drawing.Size(-19, -20);
            this.imgbtnExit.ImageZoomSize = new System.Drawing.Size(21, 20);
            this.imgbtnExit.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgbtnExit.InitialImage")));
            this.imgbtnExit.Location = new System.Drawing.Point(762, 0);
            this.imgbtnExit.Name = "imgbtnExit";
            this.imgbtnExit.Rotation = 0;
            this.imgbtnExit.ShowActiveImage = true;
            this.imgbtnExit.ShowCursorChanges = true;
            this.imgbtnExit.ShowImageBorders = true;
            this.imgbtnExit.ShowSizeMarkers = false;
            this.imgbtnExit.Size = new System.Drawing.Size(21, 20);
            this.imgbtnExit.TabIndex = 3;
            this.imgbtnExit.ToolTipText = "";
            this.imgbtnExit.WaitOnLoad = false;
            this.imgbtnExit.Zoom = 40;
            this.imgbtnExit.ZoomSpeed = 10;
            this.imgbtnExit.Click += new System.EventHandler(this.bunifuImageButton1_Click);
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
            // musteriIslemForm1
            // 
            this.musteriIslemForm1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("musteriIslemForm1.BackgroundImage")));
            this.musteriIslemForm1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.musteriIslemForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.musteriIslemForm1.Location = new System.Drawing.Point(0, 24);
            this.musteriIslemForm1.Name = "musteriIslemForm1";
            this.musteriIslemForm1.Size = new System.Drawing.Size(783, 378);
            this.musteriIslemForm1.TabIndex = 9;
            // 
            // rezervasyonForm1
            // 
            this.rezervasyonForm1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rezervasyonForm1.BackgroundImage")));
            this.rezervasyonForm1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rezervasyonForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rezervasyonForm1.Location = new System.Drawing.Point(0, 24);
            this.rezervasyonForm1.Name = "rezervasyonForm1";
            this.rezervasyonForm1.Size = new System.Drawing.Size(783, 378);
            this.rezervasyonForm1.TabIndex = 7;
            // 
            // kiralamaForm1
            // 
            this.kiralamaForm1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kiralamaForm1.BackgroundImage")));
            this.kiralamaForm1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.kiralamaForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kiralamaForm1.Location = new System.Drawing.Point(0, 24);
            this.kiralamaForm1.Name = "kiralamaForm1";
            this.kiralamaForm1.Size = new System.Drawing.Size(783, 378);
            this.kiralamaForm1.TabIndex = 6;
            // 
            // girisForm1
            // 
            this.girisForm1.BackgroundImage = global::RentACarForm.Properties.Resources.mesh_1430108_12801;
            this.girisForm1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.girisForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.girisForm1.Location = new System.Drawing.Point(0, 24);
            this.girisForm1.Name = "girisForm1";
            this.girisForm1.Size = new System.Drawing.Size(783, 378);
            this.girisForm1.TabIndex = 5;
            this.girisForm1.Load += new System.EventHandler(this.girisForm1_Load);
            // 
            // aracGuncelleSilForm1
            // 
            this.aracGuncelleSilForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aracGuncelleSilForm1.Location = new System.Drawing.Point(0, 24);
            this.aracGuncelleSilForm1.Name = "aracGuncelleSilForm1";
            this.aracGuncelleSilForm1.Size = new System.Drawing.Size(783, 378);
            this.aracGuncelleSilForm1.TabIndex = 2;
            // 
            // aracEkleForm1
            // 
            this.aracEkleForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aracEkleForm1.Location = new System.Drawing.Point(0, 24);
            this.aracEkleForm1.Name = "aracEkleForm1";
            this.aracEkleForm1.Size = new System.Drawing.Size(783, 378);
            this.aracEkleForm1.TabIndex = 1;
            // 
            // RezervelerToolStripMenuItem
            // 
            this.RezervelerToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RezervelerToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.RezervelerToolStripMenuItem.Image = global::RentACarForm.Properties.Resources.iconfinder_12___Invoice_2102048;
            this.RezervelerToolStripMenuItem.Name = "RezervelerToolStripMenuItem";
            this.RezervelerToolStripMenuItem.Size = new System.Drawing.Size(179, 20);
            this.RezervelerToolStripMenuItem.Text = "REZERVASYON İŞLEMLERİ";
            this.RezervelerToolStripMenuItem.Click += new System.EventHandler(this.RezervelerToolStripMenuItem_Click);
            // 
            // IslemlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 402);
            this.Controls.Add(this.imgbtnMin);
            this.Controls.Add(this.musteriIslemForm1);
            this.Controls.Add(this.rezervasyonForm1);
            this.Controls.Add(this.kiralamaForm1);
            this.Controls.Add(this.girisForm1);
            this.Controls.Add(this.imgbtnExit);
            this.Controls.Add(this.aracGuncelleSilForm1);
            this.Controls.Add(this.aracEkleForm1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IslemlerForm";
            this.Text = "IslemlerForm";
            this.Load += new System.EventHandler(this.IslemlerForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aracIslemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniAracEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aracSilToolStripMenuItem;
        private AracEkleForm aracEkleForm1;
        private AracGuncelleSilForm aracGuncelleSilForm1;
        private Bunifu.UI.WinForms.BunifuImageButton imgbtnExit;
        private Bunifu.UI.WinForms.BunifuImageButton imgbtnMin;
        private GirisForm girisForm1;
        private System.Windows.Forms.ToolStripMenuItem KiralamaIslemleriToolStripMenuItem;
        private KiralamaForm kiralamaForm1;
        private RezervasyonForm rezervasyonForm1;
        private System.Windows.Forms.ToolStripMenuItem MusteriIslemleriToolStripMenuItem;
        private MusteriIslemForm musteriIslemForm1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ToolStripMenuItem RezervelerToolStripMenuItem;
    }
}