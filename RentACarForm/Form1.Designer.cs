namespace RentACarForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGirisYap = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtGirisSifre = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txtGirisKimlikNo = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::RentACarForm.Properties.Resources.bot_day_background_700x600_ce7fb2df41cfbf6c827cf229da02882a;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.bunifuImageButton2);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 414);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Image = global::RentACarForm.Properties.Resources.iconfinder_24_icons_2191530;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(531, 3);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(31, 25);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 2;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::RentACarForm.Properties.Resources.iconfinder_revisi_04_2191538;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(568, 3);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(31, 25);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnGirisYap);
            this.panel2.Controls.Add(this.txtGirisSifre);
            this.panel2.Controls.Add(this.txtGirisKimlikNo);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(189, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(259, 227);
            this.panel2.TabIndex = 0;
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.BackColor = System.Drawing.Color.Transparent;
            this.btnGirisYap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGirisYap.BackgroundImage")));
            this.btnGirisYap.ButtonText = "GİRİŞ";
            this.btnGirisYap.ButtonTextMarginLeft = 0;
            this.btnGirisYap.DisabledBorderColor = System.Drawing.Color.DimGray;
            this.btnGirisYap.DisabledFillColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnGirisYap.DisabledForecolor = System.Drawing.Color.White;
            this.btnGirisYap.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGirisYap.ForeColor = System.Drawing.Color.White;
            this.btnGirisYap.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnGirisYap.IconPadding = 10;
            this.btnGirisYap.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnGirisYap.IdleBorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnGirisYap.IdleBorderRadius = 1;
            this.btnGirisYap.IdleBorderThickness = 0;
            this.btnGirisYap.IdleFillColor = System.Drawing.SystemColors.WindowFrame;
            this.btnGirisYap.IdleIconLeftImage = null;
            this.btnGirisYap.IdleIconRightImage = null;
            this.btnGirisYap.Location = new System.Drawing.Point(34, 175);
            this.btnGirisYap.Name = "btnGirisYap";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnGirisYap.onHoverState = stateProperties1;
            this.btnGirisYap.Size = new System.Drawing.Size(200, 30);
            this.btnGirisYap.TabIndex = 3;
            this.btnGirisYap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtGirisSifre
            // 
            this.txtGirisSifre.AcceptsReturn = false;
            this.txtGirisSifre.AcceptsTab = false;
            this.txtGirisSifre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtGirisSifre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtGirisSifre.BackColor = System.Drawing.Color.Transparent;
            this.txtGirisSifre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtGirisSifre.BackgroundImage")));
            this.txtGirisSifre.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.txtGirisSifre.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtGirisSifre.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(38)))), ((int)(((byte)(157)))));
            this.txtGirisSifre.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtGirisSifre.BorderRadius = 1;
            this.txtGirisSifre.BorderThickness = 2;
            this.txtGirisSifre.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtGirisSifre.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGirisSifre.DefaultText = "";
            this.txtGirisSifre.FillColor = System.Drawing.Color.White;
            this.txtGirisSifre.HideSelection = false;
            this.txtGirisSifre.IconLeft = null;
            this.txtGirisSifre.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtGirisSifre.IconPadding = 10;
            this.txtGirisSifre.IconRight = global::RentACarForm.Properties.Resources.iconfinder_key_309058;
            this.txtGirisSifre.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtGirisSifre.Location = new System.Drawing.Point(34, 113);
            this.txtGirisSifre.MaxLength = 32767;
            this.txtGirisSifre.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtGirisSifre.Modified = false;
            this.txtGirisSifre.Name = "txtGirisSifre";
            this.txtGirisSifre.PasswordChar = '*';
            this.txtGirisSifre.ReadOnly = false;
            this.txtGirisSifre.SelectedText = "";
            this.txtGirisSifre.SelectionLength = 0;
            this.txtGirisSifre.SelectionStart = 0;
            this.txtGirisSifre.ShortcutsEnabled = true;
            this.txtGirisSifre.Size = new System.Drawing.Size(200, 35);
            this.txtGirisSifre.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtGirisSifre.TabIndex = 2;
            this.txtGirisSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtGirisSifre.TextMarginLeft = 5;
            this.txtGirisSifre.TextPlaceholder = "Şifre";
            this.txtGirisSifre.UseSystemPasswordChar = false;
            // 
            // txtGirisKimlikNo
            // 
            this.txtGirisKimlikNo.AcceptsReturn = false;
            this.txtGirisKimlikNo.AcceptsTab = false;
            this.txtGirisKimlikNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtGirisKimlikNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtGirisKimlikNo.BackColor = System.Drawing.Color.Transparent;
            this.txtGirisKimlikNo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtGirisKimlikNo.BackgroundImage")));
            this.txtGirisKimlikNo.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.txtGirisKimlikNo.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtGirisKimlikNo.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(38)))), ((int)(((byte)(157)))));
            this.txtGirisKimlikNo.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtGirisKimlikNo.BorderRadius = 1;
            this.txtGirisKimlikNo.BorderThickness = 2;
            this.txtGirisKimlikNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtGirisKimlikNo.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGirisKimlikNo.DefaultText = "";
            this.txtGirisKimlikNo.FillColor = System.Drawing.Color.White;
            this.txtGirisKimlikNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtGirisKimlikNo.HideSelection = true;
            this.txtGirisKimlikNo.IconLeft = null;
            this.txtGirisKimlikNo.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtGirisKimlikNo.IconPadding = 10;
            this.txtGirisKimlikNo.IconRight = global::RentACarForm.Properties.Resources.iconfinder_00_ELASTOFONT_STORE_READY_user_2703063;
            this.txtGirisKimlikNo.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtGirisKimlikNo.Location = new System.Drawing.Point(34, 48);
            this.txtGirisKimlikNo.MaxLength = 32767;
            this.txtGirisKimlikNo.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtGirisKimlikNo.Modified = false;
            this.txtGirisKimlikNo.Name = "txtGirisKimlikNo";
            this.txtGirisKimlikNo.PasswordChar = '\0';
            this.txtGirisKimlikNo.ReadOnly = false;
            this.txtGirisKimlikNo.SelectedText = "";
            this.txtGirisKimlikNo.SelectionLength = 0;
            this.txtGirisKimlikNo.SelectionStart = 0;
            this.txtGirisKimlikNo.ShortcutsEnabled = true;
            this.txtGirisKimlikNo.Size = new System.Drawing.Size(200, 35);
            this.txtGirisKimlikNo.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtGirisKimlikNo.TabIndex = 1;
            this.txtGirisKimlikNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtGirisKimlikNo.TextMarginLeft = 5;
            this.txtGirisKimlikNo.TextPlaceholder = "Kimlik Numarası";
            this.txtGirisKimlikNo.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(78, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "GİRİŞ YAP";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 414);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtGirisKimlikNo;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtGirisSifre;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnGirisYap;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}

