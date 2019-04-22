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
            this.lblRapor = new System.Windows.Forms.Label();
            this.lbRapor = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblRapor
            // 
            this.lblRapor.AutoSize = true;
            this.lblRapor.BackColor = System.Drawing.Color.Transparent;
            this.lblRapor.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRapor.Location = new System.Drawing.Point(24, 9);
            this.lblRapor.Name = "lblRapor";
            this.lblRapor.Size = new System.Drawing.Size(84, 29);
            this.lblRapor.TabIndex = 0;
            this.lblRapor.Text = "Rapor";
            // 
            // lbRapor
            // 
            this.lbRapor.FormattingEnabled = true;
            this.lbRapor.Location = new System.Drawing.Point(99, 63);
            this.lbRapor.Name = "lbRapor";
            this.lbRapor.Size = new System.Drawing.Size(443, 199);
            this.lbRapor.TabIndex = 1;
            // 
            // RaporForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RentACarForm.Properties.Resources.texture_2659241_1280;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lbRapor);
            this.Controls.Add(this.lblRapor);
            this.Name = "RaporForm";
            this.Size = new System.Drawing.Size(665, 345);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRapor;
        private System.Windows.Forms.ListBox lbRapor;
    }
}
