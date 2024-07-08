namespace Hausverwaltung
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            tpMieter = new TabPage();
            btnSuchen = new Button();
            tbWNr = new TextBox();
            tbEinzug = new TextBox();
            tbMiete = new TextBox();
            tbAnzRaum = new TextBox();
            tbGr = new TextBox();
            tbStockwerk = new TextBox();
            tbHausNr = new TextBox();
            tbLSId = new TextBox();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            label17 = new Label();
            label18 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label12 = new Label();
            tbMSuchen = new TextBox();
            dgvMieter = new DataGridView();
            MMieterIdCol = new DataGridViewTextBoxColumn();
            MNameCol = new DataGridViewTextBoxColumn();
            MVornameCol = new DataGridViewTextBoxColumn();
            MAdresseCol = new DataGridViewTextBoxColumn();
            tpLiegenschaft = new TabPage();
            tbGesamtGr = new TextBox();
            label10 = new Label();
            dgvLS = new DataGridView();
            LSIdCol = new DataGridViewTextBoxColumn();
            LSStrasseCol = new DataGridViewTextBoxColumn();
            LSNrCol = new DataGridViewTextBoxColumn();
            LSPLZCol = new DataGridViewTextBoxColumn();
            LSOrtCol = new DataGridViewTextBoxColumn();
            LSGroesseCol = new DataGridViewTextBoxColumn();
            tabControl1.SuspendLayout();
            tpMieter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMieter).BeginInit();
            tpLiegenschaft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLS).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpMieter);
            tabControl1.Controls.Add(tpLiegenschaft);
            tabControl1.Location = new Point(37, 27);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(715, 512);
            tabControl1.TabIndex = 0;
            // 
            // tpMieter
            // 
            tpMieter.BackColor = Color.RosyBrown;
            tpMieter.Controls.Add(btnSuchen);
            tpMieter.Controls.Add(tbWNr);
            tpMieter.Controls.Add(tbEinzug);
            tpMieter.Controls.Add(tbMiete);
            tpMieter.Controls.Add(tbAnzRaum);
            tpMieter.Controls.Add(tbGr);
            tpMieter.Controls.Add(tbStockwerk);
            tpMieter.Controls.Add(tbHausNr);
            tpMieter.Controls.Add(tbLSId);
            tpMieter.Controls.Add(label21);
            tpMieter.Controls.Add(label20);
            tpMieter.Controls.Add(label19);
            tpMieter.Controls.Add(label17);
            tpMieter.Controls.Add(label18);
            tpMieter.Controls.Add(label16);
            tpMieter.Controls.Add(label15);
            tpMieter.Controls.Add(label14);
            tpMieter.Controls.Add(label12);
            tpMieter.Controls.Add(tbMSuchen);
            tpMieter.Controls.Add(dgvMieter);
            tpMieter.Location = new Point(4, 24);
            tpMieter.Name = "tpMieter";
            tpMieter.Padding = new Padding(3);
            tpMieter.Size = new Size(707, 484);
            tpMieter.TabIndex = 1;
            tpMieter.Text = "Mieter";
            //tpMieter.Click += tpMieter_Click;
            // 
            // btnSuchen
            // 
            btnSuchen.BackColor = Color.Salmon;
            btnSuchen.Location = new Point(229, 25);
            btnSuchen.Name = "btnSuchen";
            btnSuchen.Size = new Size(75, 23);
            btnSuchen.TabIndex = 37;
            btnSuchen.Text = "Suchen";
            btnSuchen.UseVisualStyleBackColor = false;
            btnSuchen.Click += btnSuchen_Click;
            // 
            // tbWNr
            // 
            tbWNr.Location = new Point(333, 306);
            tbWNr.Name = "tbWNr";
            tbWNr.Size = new Size(67, 23);
            tbWNr.TabIndex = 32;
            // 
            // tbEinzug
            // 
            tbEinzug.Location = new Point(201, 247);
            tbEinzug.Name = "tbEinzug";
            tbEinzug.Size = new Size(91, 23);
            tbEinzug.TabIndex = 31;
            // 
            // tbMiete
            // 
            tbMiete.Location = new Point(446, 412);
            tbMiete.Name = "tbMiete";
            tbMiete.Size = new Size(93, 23);
            tbMiete.TabIndex = 29;
            // 
            // tbAnzRaum
            // 
            tbAnzRaum.Location = new Point(446, 376);
            tbAnzRaum.Name = "tbAnzRaum";
            tbAnzRaum.Size = new Size(93, 23);
            tbAnzRaum.TabIndex = 28;
            // 
            // tbGr
            // 
            tbGr.Location = new Point(446, 340);
            tbGr.Name = "tbGr";
            tbGr.Size = new Size(93, 23);
            tbGr.TabIndex = 27;
            // 
            // tbStockwerk
            // 
            tbStockwerk.Location = new Point(188, 412);
            tbStockwerk.Name = "tbStockwerk";
            tbStockwerk.Size = new Size(91, 23);
            tbStockwerk.TabIndex = 26;
            // 
            // tbHausNr
            // 
            tbHausNr.Location = new Point(188, 376);
            tbHausNr.Name = "tbHausNr";
            tbHausNr.Size = new Size(91, 23);
            tbHausNr.TabIndex = 25;
            // 
            // tbLSId
            // 
            tbLSId.Location = new Point(188, 343);
            tbLSId.Name = "tbLSId";
            tbLSId.Size = new Size(91, 23);
            tbLSId.TabIndex = 24;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(330, 415);
            label21.Name = "label21";
            label21.Size = new Size(37, 15);
            label21.TabIndex = 22;
            label21.Text = "Miete";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(85, 379);
            label20.Name = "label20";
            label20.Size = new Size(50, 15);
            label20.TabIndex = 21;
            label20.Text = "Haus Nr";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(85, 343);
            label19.Name = "label19";
            label19.Size = new Size(88, 15);
            label19.TabIndex = 20;
            label19.Text = "Liegenschaft ID";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(85, 415);
            label17.Name = "label17";
            label17.Size = new Size(61, 15);
            label17.TabIndex = 19;
            label17.Text = "Stockwerk";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(330, 343);
            label18.Name = "label18";
            label18.Size = new Size(42, 15);
            label18.TabIndex = 10;
            label18.Text = "Grösse";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(330, 379);
            label16.Name = "label16";
            label16.Size = new Size(103, 15);
            label16.TabIndex = 9;
            label16.Text = "Anzahl der Räume";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Linen;
            label15.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(229, 306);
            label15.Name = "label15";
            label15.Size = new Size(95, 20);
            label15.TabIndex = 6;
            label15.Text = "Wohnung Nr:";
            //label15.Click += label15_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Linen;
            label14.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(85, 306);
            label14.Name = "label14";
            label14.Size = new Size(116, 20);
            label14.TabIndex = 5;
            label14.Text = "Wohnungsdaten";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(85, 247);
            label12.Name = "label12";
            label12.Size = new Size(82, 15);
            label12.TabIndex = 3;
            label12.Text = "Einzugsdatum";
            // 
            // tbMSuchen
            // 
            tbMSuchen.Location = new Point(85, 25);
            tbMSuchen.Name = "tbMSuchen";
            tbMSuchen.Size = new Size(139, 23);
            tbMSuchen.TabIndex = 1;
            // 
            // dgvMieter
            // 
            dataGridViewCellStyle3.BackColor = Color.RosyBrown;
            dgvMieter.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvMieter.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMieter.BackgroundColor = Color.Linen;
            dgvMieter.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMieter.Columns.AddRange(new DataGridViewColumn[] { MMieterIdCol, MNameCol, MVornameCol, MAdresseCol });
            dgvMieter.Location = new Point(85, 68);
            dgvMieter.Name = "dgvMieter";
            dgvMieter.Size = new Size(539, 152);
            dgvMieter.TabIndex = 0;
            dgvMieter.CellClick += dgvMieter_SelectionChanged;
            // 
            // MMieterIdCol
            // 
            MMieterIdCol.FillWeight = 20F;
            MMieterIdCol.HeaderText = "ID";
            MMieterIdCol.Name = "MMieterIdCol";
            // 
            // MNameCol
            // 
            MNameCol.FillWeight = 50F;
            MNameCol.HeaderText = "Name";
            MNameCol.Name = "MNameCol";
            // 
            // MVornameCol
            // 
            MVornameCol.FillWeight = 50F;
            MVornameCol.HeaderText = "Vorname";
            MVornameCol.Name = "MVornameCol";
            // 
            // MAdresseCol
            // 
            MAdresseCol.FillWeight = 90F;
            MAdresseCol.HeaderText = "Adresse";
            MAdresseCol.Name = "MAdresseCol";
            // 
            // tpLiegenschaft
            // 
            tpLiegenschaft.BackColor = Color.RosyBrown;
            tpLiegenschaft.Controls.Add(tbGesamtGr);
            tpLiegenschaft.Controls.Add(label10);
            tpLiegenschaft.Controls.Add(dgvLS);
            tpLiegenschaft.Location = new Point(4, 24);
            tpLiegenschaft.Name = "tpLiegenschaft";
            tpLiegenschaft.Size = new Size(707, 484);
            tpLiegenschaft.TabIndex = 4;
            tpLiegenschaft.Text = "Liegenschaft";
            // 
            // tbGesamtGr
            // 
            tbGesamtGr.BackColor = Color.Linen;
            tbGesamtGr.Location = new Point(182, 343);
            tbGesamtGr.Name = "tbGesamtGr";
            tbGesamtGr.Size = new Size(190, 23);
            tbGesamtGr.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.MistyRose;
            label10.Location = new Point(86, 346);
            label10.Name = "label10";
            label10.Size = new Size(78, 15);
            label10.TabIndex = 1;
            label10.Text = "Gesamtgröße";
            // 
            // dgvLS
            // 
            dataGridViewCellStyle4.BackColor = Color.RosyBrown;
            dgvLS.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvLS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLS.BackgroundColor = Color.Linen;
            dgvLS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLS.Columns.AddRange(new DataGridViewColumn[] { LSIdCol, LSStrasseCol, LSNrCol, LSPLZCol, LSOrtCol, LSGroesseCol });
            dgvLS.Location = new Point(81, 79);
            dgvLS.Name = "dgvLS";
            dgvLS.Size = new Size(553, 247);
            dgvLS.TabIndex = 0;
            // 
            // LSIdCol
            // 
            LSIdCol.HeaderText = "ID";
            LSIdCol.Name = "LSIdCol";
            // 
            // LSStrasseCol
            // 
            LSStrasseCol.HeaderText = "Strasse";
            LSStrasseCol.Name = "LSStrasseCol";
            // 
            // LSNrCol
            // 
            LSNrCol.HeaderText = "Nr";
            LSNrCol.Name = "LSNrCol";
            // 
            // LSPLZCol
            // 
            LSPLZCol.HeaderText = "PLZ";
            LSPLZCol.Name = "LSPLZCol";
            // 
            // LSOrtCol
            // 
            LSOrtCol.HeaderText = "Ort";
            LSOrtCol.Name = "LSOrtCol";
            // 
            // LSGroesseCol
            // 
            LSGroesseCol.HeaderText = "Grösse";
            LSGroesseCol.Name = "LSGroesseCol";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(801, 568);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tpMieter.ResumeLayout(false);
            tpMieter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMieter).EndInit();
            tpLiegenschaft.ResumeLayout(false);
            tpLiegenschaft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tpMieter;
        private TabPage tpLiegenschaft;
        private TextBox tbWGr;
        //private TextBox tbWNr;
        private TextBox tbWHaus;
        private DataGridView dgvMieter;
        private Label label10;
        private DataGridView dgvLS;
        private TextBox tbGesamtGr;
        private DataGridViewTextBoxColumn LSIdCol;
        private DataGridViewTextBoxColumn LSStrasseCol;
        private DataGridViewTextBoxColumn LSNrCol;
        private DataGridViewTextBoxColumn LSPLZCol;
        private DataGridViewTextBoxColumn LSOrtCol;
        private DataGridViewTextBoxColumn LSGroesseCol;
        private Label label11;
        private TextBox tbMSuchen;
        private Label label12;
        private Label label18;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label20;
        private Label label19;
        private Label label17;
       // private TextBox tbWNr;
        private Label label21;
        private TextBox tbLSId;
        private TextBox tbHausNr;
        private TextBox tbGr;
        private TextBox tbStockwerk;
        private TextBox tbAnzRaum;
        private TextBox tbMiete;
        private TextBox tbEinzug;
        private TextBox tbWNr;
        private Button btnSuchen;
        private DataGridViewTextBoxColumn MMieterIdCol;
        private DataGridViewTextBoxColumn MNameCol;
        private DataGridViewTextBoxColumn MVornameCol;
        private DataGridViewTextBoxColumn MAdresseCol;
    }
}
