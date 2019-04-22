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
            this.lblRezervasyon = new System.Windows.Forms.Label();
            this.lstboxRezervasyon = new DevExpress.XtraScheduler.UI.ResourcesCheckedListBoxControl();
            this.btnRezerveKirala = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lstboxRezervasyon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRezervasyon
            // 
            this.lblRezervasyon.AutoSize = true;
            this.lblRezervasyon.BackColor = System.Drawing.Color.Transparent;
            this.lblRezervasyon.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRezervasyon.Location = new System.Drawing.Point(45, 19);
            this.lblRezervasyon.Name = "lblRezervasyon";
            this.lblRezervasyon.Size = new System.Drawing.Size(320, 23);
            this.lblRezervasyon.TabIndex = 0;
            this.lblRezervasyon.Text = "Rezervasyon İşlemi Olan Araçlar";
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
            this.btnRezerveKirala.Location = new System.Drawing.Point(318, 300);
            this.btnRezerveKirala.Name = "btnRezerveKirala";
            this.btnRezerveKirala.Size = new System.Drawing.Size(143, 23);
            this.btnRezerveKirala.TabIndex = 2;
            this.btnRezerveKirala.Text = "Seçili Rezervasyonu Kirala";
            this.btnRezerveKirala.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Plum;
            this.button2.Location = new System.Drawing.Point(483, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Seçili Rezervasyonu Sil";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // RezervasyonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RentACarForm.Properties.Resources.triangles_1430105_1280;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnRezerveKirala);
            this.Controls.Add(this.lstboxRezervasyon);
            this.Controls.Add(this.lblRezervasyon);
            this.DoubleBuffered = true;
            this.Name = "RezervasyonForm";
            this.Size = new System.Drawing.Size(732, 363);
            ((System.ComponentModel.ISupportInitialize)(this.lstboxRezervasyon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRezervasyon;
        private DevExpress.XtraScheduler.UI.ResourcesCheckedListBoxControl lstboxRezervasyon;
        private System.Windows.Forms.Button btnRezerveKirala;
        private System.Windows.Forms.Button button2;
    }
}
