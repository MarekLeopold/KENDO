namespace KENDO
{
    partial class SeznamZapasniku
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.zapasniciSeznam = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jmeno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prijmeni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uroven = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oznaceni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smazatZapasnika = new System.Windows.Forms.Button();
            this.vytvoritZapasnika = new System.Windows.Forms.Button();
            this.pridatDoTurnaje = new System.Windows.Forms.Button();
            this.odebratZTurnaje = new System.Windows.Forms.Button();
            this.omezeniStupneOd = new System.Windows.Forms.ComboBox();
            this.omezeniStupneDo = new System.Windows.Forms.ComboBox();
            this.omezeniVekuOd = new System.Windows.Forms.TextBox();
            this.omezeniVekuDo = new System.Windows.Forms.TextBox();
            this.infoGroupBox1 = new System.Windows.Forms.GroupBox();
            this.infoLabelDo1 = new System.Windows.Forms.Label();
            this.infoLabelOd1 = new System.Windows.Forms.Label();
            this.editovatZapasnika = new System.Windows.Forms.Button();
            this.infoGroupBox2 = new System.Windows.Forms.GroupBox();
            this.infoLabelDo2 = new System.Windows.Forms.Label();
            this.infoLabelOd2 = new System.Windows.Forms.Label();
            this.resetovatFiltry = new System.Windows.Forms.Button();
            this.vycistitVyber = new System.Windows.Forms.Button();
            this.prejitKTurnaji = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.zapasniciSeznam)).BeginInit();
            this.infoGroupBox1.SuspendLayout();
            this.infoGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // zapasniciSeznam
            // 
            this.zapasniciSeznam.AllowUserToAddRows = false;
            this.zapasniciSeznam.AllowUserToDeleteRows = false;
            this.zapasniciSeznam.AllowUserToResizeColumns = false;
            this.zapasniciSeznam.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.zapasniciSeznam.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.zapasniciSeznam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zapasniciSeznam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.zapasniciSeznam.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.zapasniciSeznam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zapasniciSeznam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.jmeno,
            this.prijmeni,
            this.vek,
            this.uroven,
            this.oznaceni});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.zapasniciSeznam.DefaultCellStyle = dataGridViewCellStyle8;
            this.zapasniciSeznam.Location = new System.Drawing.Point(3, 95);
            this.zapasniciSeznam.MultiSelect = false;
            this.zapasniciSeznam.Name = "zapasniciSeznam";
            this.zapasniciSeznam.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.zapasniciSeznam.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.zapasniciSeznam.RowHeadersVisible = false;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.zapasniciSeznam.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.zapasniciSeznam.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.zapasniciSeznam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.zapasniciSeznam.ShowCellErrors = false;
            this.zapasniciSeznam.ShowCellToolTips = false;
            this.zapasniciSeznam.ShowEditingIcon = false;
            this.zapasniciSeznam.ShowRowErrors = false;
            this.zapasniciSeznam.Size = new System.Drawing.Size(857, 321);
            this.zapasniciSeznam.StandardTab = true;
            this.zapasniciSeznam.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // jmeno
            // 
            this.jmeno.HeaderText = "Jméno";
            this.jmeno.Name = "jmeno";
            this.jmeno.ReadOnly = true;
            // 
            // prijmeni
            // 
            this.prijmeni.HeaderText = "Příjmení";
            this.prijmeni.Name = "prijmeni";
            this.prijmeni.ReadOnly = true;
            // 
            // vek
            // 
            this.vek.HeaderText = "Věk";
            this.vek.Name = "vek";
            this.vek.ReadOnly = true;
            // 
            // uroven
            // 
            this.uroven.HeaderText = "Úroveň";
            this.uroven.Name = "uroven";
            this.uroven.ReadOnly = true;
            // 
            // oznaceni
            // 
            this.oznaceni.HeaderText = "oznaceni";
            this.oznaceni.MaxInputLength = 1;
            this.oznaceni.Name = "oznaceni";
            this.oznaceni.ReadOnly = true;
            this.oznaceni.Visible = false;
            // 
            // smazatZapasnika
            // 
            this.smazatZapasnika.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.smazatZapasnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.smazatZapasnika.Location = new System.Drawing.Point(3, 422);
            this.smazatZapasnika.Name = "smazatZapasnika";
            this.smazatZapasnika.Size = new System.Drawing.Size(161, 33);
            this.smazatZapasnika.TabIndex = 1;
            this.smazatZapasnika.Text = "Smazat zápasníka";
            this.smazatZapasnika.UseVisualStyleBackColor = true;
            this.smazatZapasnika.Click += new System.EventHandler(this.smazatZapasnika_Click);
            // 
            // vytvoritZapasnika
            // 
            this.vytvoritZapasnika.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.vytvoritZapasnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vytvoritZapasnika.Location = new System.Drawing.Point(351, 422);
            this.vytvoritZapasnika.Name = "vytvoritZapasnika";
            this.vytvoritZapasnika.Size = new System.Drawing.Size(161, 33);
            this.vytvoritZapasnika.TabIndex = 2;
            this.vytvoritZapasnika.Text = "Vytvořit zápasníka";
            this.vytvoritZapasnika.UseVisualStyleBackColor = true;
            this.vytvoritZapasnika.Click += new System.EventHandler(this.vytvoritZapasnika_Click);
            // 
            // pridatDoTurnaje
            // 
            this.pridatDoTurnaje.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pridatDoTurnaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pridatDoTurnaje.Location = new System.Drawing.Point(525, 422);
            this.pridatDoTurnaje.Name = "pridatDoTurnaje";
            this.pridatDoTurnaje.Size = new System.Drawing.Size(161, 33);
            this.pridatDoTurnaje.TabIndex = 3;
            this.pridatDoTurnaje.Text = "Přidat do turnaje";
            this.pridatDoTurnaje.UseVisualStyleBackColor = true;
            this.pridatDoTurnaje.Click += new System.EventHandler(this.pridatDoTurnaje_Click);
            // 
            // odebratZTurnaje
            // 
            this.odebratZTurnaje.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.odebratZTurnaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odebratZTurnaje.Location = new System.Drawing.Point(699, 422);
            this.odebratZTurnaje.Name = "odebratZTurnaje";
            this.odebratZTurnaje.Size = new System.Drawing.Size(161, 33);
            this.odebratZTurnaje.TabIndex = 4;
            this.odebratZTurnaje.Text = "Odebrat z turnaje";
            this.odebratZTurnaje.UseVisualStyleBackColor = true;
            this.odebratZTurnaje.Click += new System.EventHandler(this.odebratZTurnaje_Click);
            // 
            // omezeniStupneOd
            // 
            this.omezeniStupneOd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.omezeniStupneOd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.omezeniStupneOd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.omezeniStupneOd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.omezeniStupneOd.FormattingEnabled = true;
            this.omezeniStupneOd.Items.AddRange(new object[] {
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
            this.omezeniStupneOd.Location = new System.Drawing.Point(42, 26);
            this.omezeniStupneOd.Name = "omezeniStupneOd";
            this.omezeniStupneOd.Size = new System.Drawing.Size(121, 28);
            this.omezeniStupneOd.TabIndex = 9;
            this.omezeniStupneOd.SelectedIndexChanged += new System.EventHandler(this.omezeniStupneOd_SelectedIndexChanged);
            // 
            // omezeniStupneDo
            // 
            this.omezeniStupneDo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.omezeniStupneDo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.omezeniStupneDo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.omezeniStupneDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.omezeniStupneDo.FormattingEnabled = true;
            this.omezeniStupneDo.Items.AddRange(new object[] {
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
            this.omezeniStupneDo.Location = new System.Drawing.Point(206, 26);
            this.omezeniStupneDo.Name = "omezeniStupneDo";
            this.omezeniStupneDo.Size = new System.Drawing.Size(121, 28);
            this.omezeniStupneDo.TabIndex = 10;
            this.omezeniStupneDo.SelectedIndexChanged += new System.EventHandler(this.omezeniStupneDo_SelectedIndexChanged);
            // 
            // omezeniVekuOd
            // 
            this.omezeniVekuOd.Location = new System.Drawing.Point(42, 27);
            this.omezeniVekuOd.Name = "omezeniVekuOd";
            this.omezeniVekuOd.Size = new System.Drawing.Size(100, 26);
            this.omezeniVekuOd.TabIndex = 11;
            this.omezeniVekuOd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.omezeniVekuOd_KeyPress);
            this.omezeniVekuOd.Leave += new System.EventHandler(this.omezeniVekuOd_Leave);
            // 
            // omezeniVekuDo
            // 
            this.omezeniVekuDo.Location = new System.Drawing.Point(185, 26);
            this.omezeniVekuDo.Name = "omezeniVekuDo";
            this.omezeniVekuDo.Size = new System.Drawing.Size(100, 26);
            this.omezeniVekuDo.TabIndex = 12;
            this.omezeniVekuDo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.omezeniVekuDo_KeyPress);
            this.omezeniVekuDo.Leave += new System.EventHandler(this.omezeniVekuDo_Leave);
            // 
            // infoGroupBox1
            // 
            this.infoGroupBox1.Controls.Add(this.infoLabelDo1);
            this.infoGroupBox1.Controls.Add(this.infoLabelOd1);
            this.infoGroupBox1.Controls.Add(this.omezeniStupneOd);
            this.infoGroupBox1.Controls.Add(this.omezeniStupneDo);
            this.infoGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.infoGroupBox1.Location = new System.Drawing.Point(3, 3);
            this.infoGroupBox1.Name = "infoGroupBox1";
            this.infoGroupBox1.Size = new System.Drawing.Size(343, 71);
            this.infoGroupBox1.TabIndex = 13;
            this.infoGroupBox1.TabStop = false;
            this.infoGroupBox1.Text = "Rozmezí stupňů";
            // 
            // infoLabelDo1
            // 
            this.infoLabelDo1.AutoSize = true;
            this.infoLabelDo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.infoLabelDo1.Location = new System.Drawing.Point(169, 30);
            this.infoLabelDo1.Name = "infoLabelDo1";
            this.infoLabelDo1.Size = new System.Drawing.Size(31, 20);
            this.infoLabelDo1.TabIndex = 12;
            this.infoLabelDo1.Text = "do:";
            // 
            // infoLabelOd1
            // 
            this.infoLabelOd1.AutoSize = true;
            this.infoLabelOd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.infoLabelOd1.Location = new System.Drawing.Point(6, 30);
            this.infoLabelOd1.Name = "infoLabelOd1";
            this.infoLabelOd1.Size = new System.Drawing.Size(30, 20);
            this.infoLabelOd1.TabIndex = 11;
            this.infoLabelOd1.Text = "Od";
            // 
            // editovatZapasnika
            // 
            this.editovatZapasnika.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.editovatZapasnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.editovatZapasnika.Location = new System.Drawing.Point(177, 422);
            this.editovatZapasnika.Name = "editovatZapasnika";
            this.editovatZapasnika.Size = new System.Drawing.Size(161, 33);
            this.editovatZapasnika.TabIndex = 14;
            this.editovatZapasnika.Text = "Editovat zápasníka";
            this.editovatZapasnika.UseVisualStyleBackColor = true;
            this.editovatZapasnika.Click += new System.EventHandler(this.editovatZapasnika_Click);
            // 
            // infoGroupBox2
            // 
            this.infoGroupBox2.Controls.Add(this.infoLabelDo2);
            this.infoGroupBox2.Controls.Add(this.infoLabelOd2);
            this.infoGroupBox2.Controls.Add(this.omezeniVekuOd);
            this.infoGroupBox2.Controls.Add(this.omezeniVekuDo);
            this.infoGroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.infoGroupBox2.Location = new System.Drawing.Point(352, 3);
            this.infoGroupBox2.Name = "infoGroupBox2";
            this.infoGroupBox2.Size = new System.Drawing.Size(300, 71);
            this.infoGroupBox2.TabIndex = 15;
            this.infoGroupBox2.TabStop = false;
            this.infoGroupBox2.Text = "Rozmezí věku";
            // 
            // infoLabelDo2
            // 
            this.infoLabelDo2.AutoSize = true;
            this.infoLabelDo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.infoLabelDo2.Location = new System.Drawing.Point(148, 30);
            this.infoLabelDo2.Name = "infoLabelDo2";
            this.infoLabelDo2.Size = new System.Drawing.Size(31, 20);
            this.infoLabelDo2.TabIndex = 12;
            this.infoLabelDo2.Text = "do:";
            // 
            // infoLabelOd2
            // 
            this.infoLabelOd2.AutoSize = true;
            this.infoLabelOd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.infoLabelOd2.Location = new System.Drawing.Point(6, 30);
            this.infoLabelOd2.Name = "infoLabelOd2";
            this.infoLabelOd2.Size = new System.Drawing.Size(30, 20);
            this.infoLabelOd2.TabIndex = 11;
            this.infoLabelOd2.Text = "Od";
            // 
            // resetovatFiltry
            // 
            this.resetovatFiltry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resetovatFiltry.Location = new System.Drawing.Point(658, 27);
            this.resetovatFiltry.Name = "resetovatFiltry";
            this.resetovatFiltry.Size = new System.Drawing.Size(161, 33);
            this.resetovatFiltry.TabIndex = 16;
            this.resetovatFiltry.Text = "Resetovat filtry";
            this.resetovatFiltry.UseVisualStyleBackColor = true;
            this.resetovatFiltry.Click += new System.EventHandler(this.resetovatFiltry_Click);
            // 
            // vycistitVyber
            // 
            this.vycistitVyber.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.vycistitVyber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vycistitVyber.Location = new System.Drawing.Point(525, 461);
            this.vycistitVyber.Name = "vycistitVyber";
            this.vycistitVyber.Size = new System.Drawing.Size(335, 33);
            this.vycistitVyber.TabIndex = 17;
            this.vycistitVyber.Text = "Vyčistit výběr";
            this.vycistitVyber.UseVisualStyleBackColor = true;
            this.vycistitVyber.Click += new System.EventHandler(this.vycistitVyber_Click);
            // 
            // prejitKTurnaji
            // 
            this.prejitKTurnaji.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.prejitKTurnaji.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prejitKTurnaji.Location = new System.Drawing.Point(3, 461);
            this.prejitKTurnaji.Name = "prejitKTurnaji";
            this.prejitKTurnaji.Size = new System.Drawing.Size(509, 33);
            this.prejitKTurnaji.TabIndex = 18;
            this.prejitKTurnaji.Text = "Přejít k turnaji";
            this.prejitKTurnaji.UseVisualStyleBackColor = true;
            this.prejitKTurnaji.Click += new System.EventHandler(this.prejitKTurnaji_Click);
            // 
            // SeznamZapasniku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.prejitKTurnaji);
            this.Controls.Add(this.vycistitVyber);
            this.Controls.Add(this.resetovatFiltry);
            this.Controls.Add(this.infoGroupBox2);
            this.Controls.Add(this.editovatZapasnika);
            this.Controls.Add(this.infoGroupBox1);
            this.Controls.Add(this.odebratZTurnaje);
            this.Controls.Add(this.pridatDoTurnaje);
            this.Controls.Add(this.vytvoritZapasnika);
            this.Controls.Add(this.smazatZapasnika);
            this.Controls.Add(this.zapasniciSeznam);
            this.Name = "SeznamZapasniku";
            this.Size = new System.Drawing.Size(866, 497);
            ((System.ComponentModel.ISupportInitialize)(this.zapasniciSeznam)).EndInit();
            this.infoGroupBox1.ResumeLayout(false);
            this.infoGroupBox1.PerformLayout();
            this.infoGroupBox2.ResumeLayout(false);
            this.infoGroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView zapasniciSeznam;
        private System.Windows.Forms.Button smazatZapasnika;
        private System.Windows.Forms.Button vytvoritZapasnika;
        private System.Windows.Forms.Button pridatDoTurnaje;
        private System.Windows.Forms.Button odebratZTurnaje;
        private System.Windows.Forms.ComboBox omezeniStupneOd;
        private System.Windows.Forms.ComboBox omezeniStupneDo;
        private System.Windows.Forms.TextBox omezeniVekuOd;
        private System.Windows.Forms.TextBox omezeniVekuDo;
        private System.Windows.Forms.GroupBox infoGroupBox1;
        private System.Windows.Forms.Label infoLabelDo1;
        private System.Windows.Forms.Label infoLabelOd1;
        private System.Windows.Forms.Button editovatZapasnika;
        private System.Windows.Forms.GroupBox infoGroupBox2;
        private System.Windows.Forms.Label infoLabelDo2;
        private System.Windows.Forms.Label infoLabelOd2;
        private System.Windows.Forms.Button resetovatFiltry;
        private System.Windows.Forms.Button vycistitVyber;
        private System.Windows.Forms.Button prejitKTurnaji;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn jmeno;
        private System.Windows.Forms.DataGridViewTextBoxColumn prijmeni;
        private System.Windows.Forms.DataGridViewTextBoxColumn vek;
        private System.Windows.Forms.DataGridViewTextBoxColumn uroven;
        private System.Windows.Forms.DataGridViewTextBoxColumn oznaceni;
    }
}
