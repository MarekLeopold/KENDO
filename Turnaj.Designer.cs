namespace KENDO
{
    partial class Turnaj
    {
        /// <summary> 
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód vygenerovaný pomocí Návrháře komponent

        /// <summary> 
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Grafika = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grafika)).BeginInit();
            this.SuspendLayout();
            // 
            // Grafika
            // 
            this.Grafika.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grafika.Location = new System.Drawing.Point(0, 0);
            this.Grafika.Name = "Grafika";
            this.Grafika.Size = new System.Drawing.Size(778, 524);
            this.Grafika.TabIndex = 0;
            this.Grafika.TabStop = false;
            this.Grafika.Click += new System.EventHandler(this.Grafika_Click);
            this.Grafika.Paint += new System.Windows.Forms.PaintEventHandler(this.Grafika_Paint);
            // 
            // Turnaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Grafika);
            this.Name = "Turnaj";
            this.Size = new System.Drawing.Size(778, 524);
            ((System.ComponentModel.ISupportInitialize)(this.Grafika)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Grafika;
    }
}
