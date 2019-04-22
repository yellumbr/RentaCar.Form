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
            this.lstboxRezervasyon = new DevExpress.XtraScheduler.UI.ResourcesCheckedListBoxControl();
            this.btnRezerveKirala = new System.Windows.Forms.Button();
            this.btnRezerveSil = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.lstboxRezervasyon)).BeginInit();
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
            // lstboxRezervasyon
            // 
            this.lstboxRezervasyon.Appearance.BackColor = System.Drawing.Color.Violet;
            this.lstboxRezervasyon.Appearance.Options.UseBackColor = true;
            this.lstboxRezervasyon.Location = new System.Drawing.Point(91, 56);
            this.lstboxRezervasyon.Name = "lstboxRezervasyon";
            this.lstboxRezervasyon.Size = new System.Drawing.Size(521, 215);
            this.lstboxRezervasyon.TabIndex = 1;
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
            // RezervasyonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RentACarForm.Properties.Resources.triangles_1430105_1280;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnRezerveSil);
            this.Controls.Add(this.btnRezerveKirala);
            this.Controls.Add(this.lstboxRezervasyon);
            this.Controls.Add(this.lblRezervasyon);
            this.DoubleBuffered = true;
            this.Name = "RezervasyonForm";
            this.Size = new System.Drawing.Size(732, 363);
            ((System.ComponentModel.ISupportInitialize)(this.lstboxRezervasyon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRezervasyon;
        private DevExpress.XtraScheduler.UI.ResourcesCheckedListBoxControl lstboxRezervasyon;
        private System.Windows.Forms.Button btnRezerveKirala;
        private System.Windows.Forms.Button btnRezerveSil;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}
