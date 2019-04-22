namespace RentACarForm
{
    partial class RaporForm
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
            this.lblRapor = new System.Windows.Forms.Label();
            this.lbRapor = new System.Windows.Forms.ListBox();
            this.btnMail = new System.Windows.Forms.Button();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.SuspendLayout();
            // 
            // lblRapor
            // 
            this.lblRapor.BackColor = System.Drawing.Color.Transparent;
            this.lblRapor.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRapor.Image = global::RentACarForm.Properties.Resources.iconfinder_seo_report_2944876;
            this.lblRapor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRapor.Location = new System.Drawing.Point(24, 9);
            this.lblRapor.Name = "lblRapor";
            this.lblRapor.Size = new System.Drawing.Size(107, 29);
            this.lblRapor.TabIndex = 0;
            this.lblRapor.Text = "Rapor";
            this.lblRapor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbRapor
            // 
            this.lbRapor.BackColor = System.Drawing.Color.Bisque;
            this.lbRapor.FormattingEnabled = true;
            this.lbRapor.Location = new System.Drawing.Point(74, 55);
            this.lbRapor.Name = "lbRapor";
            this.lbRapor.Size = new System.Drawing.Size(443, 199);
            this.lbRapor.TabIndex = 1;
            // 
            // btnMail
            // 
            this.btnMail.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMail.Image = global::RentACarForm.Properties.Resources.iconfinder_mail_24_103176;
            this.btnMail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMail.Location = new System.Drawing.Point(354, 275);
            this.btnMail.Name = "btnMail";
            this.btnMail.Size = new System.Drawing.Size(71, 23);
            this.btnMail.TabIndex = 2;
            this.btnMail.Text = "Mail At";
            this.btnMail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMail.UseVisualStyleBackColor = true;
            // 
            // btnYazdir
            // 
            this.btnYazdir.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazdir.Image = global::RentACarForm.Properties.Resources.iconfinder_office_19_809604;
            this.btnYazdir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYazdir.Location = new System.Drawing.Point(447, 275);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(70, 23);
            this.btnYazdir.TabIndex = 3;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYazdir.UseVisualStyleBackColor = true;
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
            // RaporForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RentACarForm.Properties.Resources.texture_2659241_1280;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.btnMail);
            this.Controls.Add(this.lbRapor);
            this.Controls.Add(this.lblRapor);
            this.Name = "RaporForm";
            this.Size = new System.Drawing.Size(665, 345);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRapor;
        private System.Windows.Forms.ListBox lbRapor;
        private System.Windows.Forms.Button btnMail;
        private System.Windows.Forms.Button btnYazdir;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}
