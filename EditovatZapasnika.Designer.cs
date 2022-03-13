namespace KENDO
{
    partial class EditovatZapasnika
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
            this.components = new System.ComponentModel.Container();
            this.infoLabel1 = new System.Windows.Forms.Label();
            this.jmeno = new System.Windows.Forms.TextBox();
            this.prijmeni = new System.Windows.Forms.TextBox();
            this.vek = new System.Windows.Forms.TextBox();
            this.infoLabelJmeno = new System.Windows.Forms.Label();
            this.infoLabelPrijmeni = new System.Windows.Forms.Label();
            this.infoLabelVek = new System.Windows.Forms.Label();
            this.infoLabelUroven = new System.Windows.Forms.Label();
            this.uroven = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // infoLabel1
            // 
            this.infoLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.infoLabel1.AutoSize = true;
            this.infoLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.infoLabel1.Location = new System.Drawing.Point(152, 13);
            this.infoLabel1.Name = "infoLabel1";
            this.infoLabel1.Size = new System.Drawing.Size(194, 25);
            this.infoLabel1.TabIndex = 0;
            this.infoLabel1.Text = "Editovat zápasníka";
            // 
            // jmeno
            // 
            this.jmeno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.jmeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.jmeno.Location = new System.Drawing.Point(180, 70);
            this.jmeno.Name = "jmeno";
            this.jmeno.Size = new System.Drawing.Size(209, 26);
            this.jmeno.TabIndex = 1;
            // 
            // prijmeni
            // 
            this.prijmeni.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.prijmeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prijmeni.Location = new System.Drawing.Point(180, 102);
            this.prijmeni.Name = "prijmeni";
            this.prijmeni.Size = new System.Drawing.Size(209, 26);
            this.prijmeni.TabIndex = 2;
            // 
            // vek
            // 
            this.vek.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.vek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vek.Location = new System.Drawing.Point(180, 134);
            this.vek.Name = "vek";
            this.vek.Size = new System.Drawing.Size(65, 26);
            this.vek.TabIndex = 3;
            this.vek.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vek_KeyPress);
            // 
            // infoLabelJmeno
            // 
            this.infoLabelJmeno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.infoLabelJmeno.AutoSize = true;
            this.infoLabelJmeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.infoLabelJmeno.Location = new System.Drawing.Point(98, 73);
            this.infoLabelJmeno.Name = "infoLabelJmeno";
            this.infoLabelJmeno.Size = new System.Drawing.Size(65, 20);
            this.infoLabelJmeno.TabIndex = 4;
            this.infoLabelJmeno.Text = "Jméno: ";
            // 
            // infoLabelPrijmeni
            // 
            this.infoLabelPrijmeni.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.infoLabelPrijmeni.AutoSize = true;
            this.infoLabelPrijmeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.infoLabelPrijmeni.Location = new System.Drawing.Point(91, 105);
            this.infoLabelPrijmeni.Name = "infoLabelPrijmeni";
            this.infoLabelPrijmeni.Size = new System.Drawing.Size(72, 20);
            this.infoLabelPrijmeni.TabIndex = 5;
            this.infoLabelPrijmeni.Text = "Příjmení: ";
            // 
            // infoLabelVek
            // 
            this.infoLabelVek.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.infoLabelVek.AutoSize = true;
            this.infoLabelVek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.infoLabelVek.Location = new System.Drawing.Point(122, 137);
            this.infoLabelVek.Name = "infoLabelVek";
            this.infoLabelVek.Size = new System.Drawing.Size(41, 20);
            this.infoLabelVek.TabIndex = 6;
            this.infoLabelVek.Text = "Věk:";
            // 
            // infoLabelUroven
            // 
            this.infoLabelUroven.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.infoLabelUroven.AutoSize = true;
            this.infoLabelUroven.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.infoLabelUroven.Location = new System.Drawing.Point(94, 170);
            this.infoLabelUroven.Name = "infoLabelUroven";
            this.infoLabelUroven.Size = new System.Drawing.Size(69, 20);
            this.infoLabelUroven.TabIndex = 7;
            this.infoLabelUroven.Text = "Stupeň: ";
            // 
            // uroven
            // 
            this.uroven.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uroven.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.uroven.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.uroven.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uroven.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uroven.FormattingEnabled = true;
            this.uroven.Items.AddRange(new object[] {
            "10 kjú",
            "9 kjú",
            "8 kjú",
            "7 kjú",
            "6 kjú",
            "5 kjú",
            "4 kjú",
            "3 kjú",
            "2 kjú",
            "1 kjú",
            "1 dan",
            "2 dan",
            "3 dan",
            "4 dan",
            "5 dan",
            "6 dan",
            "7 dan",
            "8 dan",
            "9 dan",
            "10 dan"});
            this.uroven.Location = new System.Drawing.Point(180, 166);
            this.uroven.Name = "uroven";
            this.uroven.Size = new System.Drawing.Size(121, 28);
            this.uroven.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(180, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 28);
            this.button1.TabIndex = 9;
            this.button1.Text = "Uložit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // EditovatZapasnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uroven);
            this.Controls.Add(this.infoLabelUroven);
            this.Controls.Add(this.infoLabelVek);
            this.Controls.Add(this.infoLabelPrijmeni);
            this.Controls.Add(this.infoLabelJmeno);
            this.Controls.Add(this.vek);
            this.Controls.Add(this.prijmeni);
            this.Controls.Add(this.jmeno);
            this.Controls.Add(this.infoLabel1);
            this.Name = "EditovatZapasnika";
            this.Size = new System.Drawing.Size(500, 268);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infoLabel1;
        private System.Windows.Forms.TextBox jmeno;
        private System.Windows.Forms.TextBox prijmeni;
        private System.Windows.Forms.TextBox vek;
        private System.Windows.Forms.Label infoLabelJmeno;
        private System.Windows.Forms.Label infoLabelPrijmeni;
        private System.Windows.Forms.Label infoLabelVek;
        private System.Windows.Forms.Label infoLabelUroven;
        private System.Windows.Forms.ComboBox uroven;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
