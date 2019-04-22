namespace RentACarForm
{
    partial class GirisForm
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
            this.lblFirmaAdi = new System.Windows.Forms.Label();
            this.pbFirmaLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGirisYapan = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbFirmaLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFirmaAdi
            // 
            this.lblFirmaAdi.AutoSize = true;
            this.lblFirmaAdi.BackColor = System.Drawing.Color.Transparent;
            this.lblFirmaAdi.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFirmaAdi.Location = new System.Drawing.Point(284, 28);
            this.lblFirmaAdi.Name = "lblFirmaAdi";
            this.lblFirmaAdi.Size = new System.Drawing.Size(163, 42);
            this.lblFirmaAdi.TabIndex = 0;
            this.lblFirmaAdi.Text = "Firma Adı";
            // 
            // pbFirmaLogo
            // 
            this.pbFirmaLogo.Location = new System.Drawing.Point(33, 20);
            this.pbFirmaLogo.Name = "pbFirmaLogo";
            this.pbFirmaLogo.Size = new System.Drawing.Size(100, 50);
            this.pbFirmaLogo.TabIndex = 1;
            this.pbFirmaLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(274, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "HOŞGELDİNİZ";
            // 
            // lblGirisYapan
            // 
            this.lblGirisYapan.AutoSize = true;
            this.lblGirisYapan.BackColor = System.Drawing.Color.Transparent;
            this.lblGirisYapan.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGirisYapan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGirisYapan.Location = new System.Drawing.Point(266, 223);
            this.lblGirisYapan.Name = "lblGirisYapan";
            this.lblGirisYapan.Size = new System.Drawing.Size(201, 23);
            this.lblGirisYapan.TabIndex = 3;
            this.lblGirisYapan.Text = "GİRİŞ YAPAN KİŞİ ADI";
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
            // GirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RentACarForm.Properties.Resources.mesh_1430108_1280;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lblGirisYapan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbFirmaLogo);
            this.Controls.Add(this.lblFirmaAdi);
            this.DoubleBuffered = true;
            this.Name = "GirisForm";
            this.Size = new System.Drawing.Size(707, 367);
            ((System.ComponentModel.ISupportInitialize)(this.pbFirmaLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirmaAdi;
        private System.Windows.Forms.PictureBox pbFirmaLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGirisYapan;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}
