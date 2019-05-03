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
            this.btnAracKirala = new System.Windows.Forms.Button();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpKiralanmaTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtpKiradanDonusTarihi = new System.Windows.Forms.DateTimePicker();
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
            this.cmbAracPlakalar.Location = new System.Drawing.Point(186, 66);
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
            this.lblMusteriBilgi.Location = new System.Drawing.Point(57, 178);
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
            this.label4.Location = new System.Drawing.Point(58, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kayıtlı Müşteri";
            // 
            // cmbKayitliMusteri
            // 
            this.cmbKayitliMusteri.FormattingEnabled = true;
            this.cmbKayitliMusteri.Location = new System.Drawing.Point(152, 217);
            this.cmbKayitliMusteri.Name = "cmbKayitliMusteri";
            this.cmbKayitliMusteri.Size = new System.Drawing.Size(121, 21);
            this.cmbKayitliMusteri.TabIndex = 5;
            // 
            // btnAracKirala
            // 
            this.btnAracKirala.BackColor = System.Drawing.Color.Bisque;
            this.btnAracKirala.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAracKirala.Image = global::RentACarForm.Properties.Resources.iconfinder_Apply_105210;
            this.btnAracKirala.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAracKirala.Location = new System.Drawing.Point(193, 255);
            this.btnAracKirala.Name = "btnAracKirala";
            this.btnAracKirala.Size = new System.Drawing.Size(80, 26);
            this.btnAracKirala.TabIndex = 23;
            this.btnAracKirala.Text = "Kirala";
            this.btnAracKirala.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAracKirala.UseVisualStyleBackColor = false;
            this.btnAracKirala.Click += new System.EventHandler(this.BtnAracKirala_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Kiralanma Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Kiradan Dönüş Tarihi";
            // 
            // dtpKiralanmaTarihi
            // 
            this.dtpKiralanmaTarihi.Location = new System.Drawing.Point(186, 102);
            this.dtpKiralanmaTarihi.Name = "dtpKiralanmaTarihi";
            this.dtpKiralanmaTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtpKiralanmaTarihi.TabIndex = 27;
            // 
            // dtpKiradanDonusTarihi
            // 
            this.dtpKiradanDonusTarihi.Location = new System.Drawing.Point(186, 135);
            this.dtpKiradanDonusTarihi.Name = "dtpKiradanDonusTarihi";
            this.dtpKiradanDonusTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtpKiradanDonusTarihi.TabIndex = 28;
            // 
            // KiralamaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RentACarForm.Properties.Resources.geometric;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.dtpKiradanDonusTarihi);
            this.Controls.Add(this.dtpKiralanmaTarihi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAracKirala);
            this.Controls.Add(this.cmbKayitliMusteri);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblMusteriBilgi);
            this.Controls.Add(this.cmbAracPlakalar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAracBilgi);
            this.Name = "KiralamaForm";
            this.Size = new System.Drawing.Size(703, 357);
            this.Load += new System.EventHandler(this.KiralamaForm_Load);
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
        private System.Windows.Forms.Button btnAracKirala;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.DateTimePicker dtpKiradanDonusTarihi;
        private System.Windows.Forms.DateTimePicker dtpKiralanmaTarihi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}
