namespace Projekt_ÖPNV_Netzspinnengenerator
{
    partial class FormHaltestellen
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnWechselLinie = new System.Windows.Forms.Button();
            this.btnWechselZeichner = new System.Windows.Forms.Button();
            this.tbHaltestelle = new System.Windows.Forms.TextBox();
            this.lblHaltestelle = new System.Windows.Forms.Label();
            this.lblKuerzel = new System.Windows.Forms.Label();
            this.tbHaltestellenkuerzel = new System.Windows.Forms.TextBox();
            this.lblKoordinaten = new System.Windows.Forms.Label();
            this.tbStreckenkilometer = new System.Windows.Forms.TextBox();
            this.lblStreckenkilometer = new System.Windows.Forms.Label();
            this.tbKoordinateX = new System.Windows.Forms.TextBox();
            this.btnHinzufuegenHaltestellen = new System.Windows.Forms.Button();
            this.btnEntfernenHaltestellen = new System.Windows.Forms.Button();
            this.lbHaltestellen = new System.Windows.Forms.ListBox();
            this.lbLinien = new System.Windows.Forms.ListBox();
            this.lblHaltestellenliste = new System.Windows.Forms.Label();
            this.lblLinienliste = new System.Windows.Forms.Label();
            this.btnZuweisung = new System.Windows.Forms.Button();
            this.tbKoordinateY = new System.Windows.Forms.TextBox();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lbVerlauf = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnWechselLinie
            // 
            this.btnWechselLinie.Location = new System.Drawing.Point(13, 415);
            this.btnWechselLinie.Name = "btnWechselLinie";
            this.btnWechselLinie.Size = new System.Drawing.Size(157, 23);
            this.btnWechselLinie.TabIndex = 0;
            this.btnWechselLinie.Text = "Wechsel zur Linienerfassung";
            this.btnWechselLinie.UseVisualStyleBackColor = true;
            this.btnWechselLinie.Click += new System.EventHandler(this.btnWechselLinie_Click);
            // 
            // btnWechselZeichner
            // 
            this.btnWechselZeichner.Location = new System.Drawing.Point(475, 415);
            this.btnWechselZeichner.Name = "btnWechselZeichner";
            this.btnWechselZeichner.Size = new System.Drawing.Size(158, 23);
            this.btnWechselZeichner.TabIndex = 1;
            this.btnWechselZeichner.Text = "Wechsel zum Zeichen-Tool";
            this.btnWechselZeichner.UseVisualStyleBackColor = true;
            this.btnWechselZeichner.Click += new System.EventHandler(this.btnWechselZeichner_Click);
            // 
            // tbHaltestelle
            // 
            this.tbHaltestelle.Location = new System.Drawing.Point(24, 40);
            this.tbHaltestelle.Name = "tbHaltestelle";
            this.tbHaltestelle.Size = new System.Drawing.Size(100, 20);
            this.tbHaltestelle.TabIndex = 2;
            // 
            // lblHaltestelle
            // 
            this.lblHaltestelle.AutoSize = true;
            this.lblHaltestelle.Location = new System.Drawing.Point(24, 13);
            this.lblHaltestelle.Name = "lblHaltestelle";
            this.lblHaltestelle.Size = new System.Drawing.Size(88, 13);
            this.lblHaltestelle.TabIndex = 3;
            this.lblHaltestelle.Text = "Haltestellenname";
            // 
            // lblKuerzel
            // 
            this.lblKuerzel.AutoSize = true;
            this.lblKuerzel.Location = new System.Drawing.Point(24, 73);
            this.lblKuerzel.Name = "lblKuerzel";
            this.lblKuerzel.Size = new System.Drawing.Size(90, 13);
            this.lblKuerzel.TabIndex = 4;
            this.lblKuerzel.Text = "Haltestellenkürzel";
            // 
            // tbHaltestellenkuerzel
            // 
            this.tbHaltestellenkuerzel.Location = new System.Drawing.Point(24, 101);
            this.tbHaltestellenkuerzel.Name = "tbHaltestellenkuerzel";
            this.tbHaltestellenkuerzel.Size = new System.Drawing.Size(100, 20);
            this.tbHaltestellenkuerzel.TabIndex = 5;
            // 
            // lblKoordinaten
            // 
            this.lblKoordinaten.AutoSize = true;
            this.lblKoordinaten.Location = new System.Drawing.Point(24, 204);
            this.lblKoordinaten.Name = "lblKoordinaten";
            this.lblKoordinaten.Size = new System.Drawing.Size(64, 13);
            this.lblKoordinaten.TabIndex = 6;
            this.lblKoordinaten.Text = "Koordinaten";
            // 
            // tbStreckenkilometer
            // 
            this.tbStreckenkilometer.Location = new System.Drawing.Point(24, 165);
            this.tbStreckenkilometer.Name = "tbStreckenkilometer";
            this.tbStreckenkilometer.Size = new System.Drawing.Size(100, 20);
            this.tbStreckenkilometer.TabIndex = 7;
            // 
            // lblStreckenkilometer
            // 
            this.lblStreckenkilometer.AutoSize = true;
            this.lblStreckenkilometer.Location = new System.Drawing.Point(24, 139);
            this.lblStreckenkilometer.Name = "lblStreckenkilometer";
            this.lblStreckenkilometer.Size = new System.Drawing.Size(92, 13);
            this.lblStreckenkilometer.TabIndex = 8;
            this.lblStreckenkilometer.Text = "Streckenkilometer";
            // 
            // tbKoordinateX
            // 
            this.tbKoordinateX.Location = new System.Drawing.Point(24, 220);
            this.tbKoordinateX.Name = "tbKoordinateX";
            this.tbKoordinateX.Size = new System.Drawing.Size(100, 20);
            this.tbKoordinateX.TabIndex = 9;
            // 
            // btnHinzufuegenHaltestellen
            // 
            this.btnHinzufuegenHaltestellen.Location = new System.Drawing.Point(24, 272);
            this.btnHinzufuegenHaltestellen.Name = "btnHinzufuegenHaltestellen";
            this.btnHinzufuegenHaltestellen.Size = new System.Drawing.Size(100, 52);
            this.btnHinzufuegenHaltestellen.TabIndex = 10;
            this.btnHinzufuegenHaltestellen.Text = "Hinzufügen";
            this.btnHinzufuegenHaltestellen.UseVisualStyleBackColor = true;
            this.btnHinzufuegenHaltestellen.Click += new System.EventHandler(this.btnHinzufuegenHaltestellen_Click);
            // 
            // btnEntfernenHaltestellen
            // 
            this.btnEntfernenHaltestellen.Location = new System.Drawing.Point(24, 340);
            this.btnEntfernenHaltestellen.Name = "btnEntfernenHaltestellen";
            this.btnEntfernenHaltestellen.Size = new System.Drawing.Size(100, 55);
            this.btnEntfernenHaltestellen.TabIndex = 11;
            this.btnEntfernenHaltestellen.Text = "Entfernen";
            this.btnEntfernenHaltestellen.UseVisualStyleBackColor = true;
            this.btnEntfernenHaltestellen.Click += new System.EventHandler(this.btnEntfernenHaltestellen_Click);
            // 
            // lbHaltestellen
            // 
            this.lbHaltestellen.FormattingEnabled = true;
            this.lbHaltestellen.Location = new System.Drawing.Point(173, 40);
            this.lbHaltestellen.Name = "lbHaltestellen";
            this.lbHaltestellen.Size = new System.Drawing.Size(173, 355);
            this.lbHaltestellen.TabIndex = 12;
            // 
            // lbLinien
            // 
            this.lbLinien.FormattingEnabled = true;
            this.lbLinien.Location = new System.Drawing.Point(352, 40);
            this.lbLinien.Name = "lbLinien";
            this.lbLinien.Size = new System.Drawing.Size(172, 355);
            this.lbLinien.TabIndex = 13;
            // 
            // lblHaltestellenliste
            // 
            this.lblHaltestellenliste.AutoSize = true;
            this.lblHaltestellenliste.Location = new System.Drawing.Point(179, 13);
            this.lblHaltestellenliste.Name = "lblHaltestellenliste";
            this.lblHaltestellenliste.Size = new System.Drawing.Size(80, 13);
            this.lblHaltestellenliste.TabIndex = 14;
            this.lblHaltestellenliste.Text = "Haltestellenliste";
            // 
            // lblLinienliste
            // 
            this.lblLinienliste.AutoSize = true;
            this.lblLinienliste.Location = new System.Drawing.Point(472, 13);
            this.lblLinienliste.Name = "lblLinienliste";
            this.lblLinienliste.Size = new System.Drawing.Size(53, 13);
            this.lblLinienliste.TabIndex = 15;
            this.lblLinienliste.Text = "Linienliste";
            // 
            // btnZuweisung
            // 
            this.btnZuweisung.Location = new System.Drawing.Point(337, 415);
            this.btnZuweisung.Name = "btnZuweisung";
            this.btnZuweisung.Size = new System.Drawing.Size(75, 23);
            this.btnZuweisung.TabIndex = 16;
            this.btnZuweisung.Text = "Zuweisen";
            this.btnZuweisung.UseVisualStyleBackColor = true;
            this.btnZuweisung.Click += new System.EventHandler(this.btnZuweisung_Click);
            // 
            // tbKoordinateY
            // 
            this.tbKoordinateY.Location = new System.Drawing.Point(24, 246);
            this.tbKoordinateY.Name = "tbKoordinateY";
            this.tbKoordinateY.Size = new System.Drawing.Size(100, 20);
            this.tbKoordinateY.TabIndex = 17;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(4, 223);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(14, 13);
            this.lblX.TabIndex = 18;
            this.lblX.Text = "X";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(4, 249);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(14, 13);
            this.lblY.TabIndex = 19;
            this.lblY.Text = "Y";
            // 
            // lbVerlauf
            // 
            this.lbVerlauf.FormattingEnabled = true;
            this.lbVerlauf.Location = new System.Drawing.Point(496, 40);
            this.lbVerlauf.Name = "lbVerlauf";
            this.lbVerlauf.Size = new System.Drawing.Size(137, 355);
            this.lbVerlauf.TabIndex = 20;
            this.lbVerlauf.SelectedIndexChanged += new System.EventHandler(this.lbVerlauf_SelectedIndexChanged);
            // 
            // FormHaltestellen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 450);
            this.Controls.Add(this.lbVerlauf);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.tbKoordinateY);
            this.Controls.Add(this.btnZuweisung);
            this.Controls.Add(this.lblLinienliste);
            this.Controls.Add(this.lblHaltestellenliste);
            this.Controls.Add(this.lbLinien);
            this.Controls.Add(this.lbHaltestellen);
            this.Controls.Add(this.btnEntfernenHaltestellen);
            this.Controls.Add(this.btnHinzufuegenHaltestellen);
            this.Controls.Add(this.tbKoordinateX);
            this.Controls.Add(this.lblStreckenkilometer);
            this.Controls.Add(this.tbStreckenkilometer);
            this.Controls.Add(this.lblKoordinaten);
            this.Controls.Add(this.tbHaltestellenkuerzel);
            this.Controls.Add(this.lblKuerzel);
            this.Controls.Add(this.lblHaltestelle);
            this.Controls.Add(this.tbHaltestelle);
            this.Controls.Add(this.btnWechselZeichner);
            this.Controls.Add(this.btnWechselLinie);
            this.Name = "FormHaltestellen";
            this.Text = "Haltestellen Erfassung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWechselLinie;
        private System.Windows.Forms.Button btnWechselZeichner;
        private System.Windows.Forms.TextBox tbHaltestelle;
        private System.Windows.Forms.Label lblHaltestelle;
        private System.Windows.Forms.Label lblKuerzel;
        private System.Windows.Forms.TextBox tbHaltestellenkuerzel;
        private System.Windows.Forms.Label lblKoordinaten;
        private System.Windows.Forms.TextBox tbStreckenkilometer;
        private System.Windows.Forms.Label lblStreckenkilometer;
        private System.Windows.Forms.TextBox tbKoordinateX;
        private System.Windows.Forms.Button btnHinzufuegenHaltestellen;
        private System.Windows.Forms.Button btnEntfernenHaltestellen;
        private System.Windows.Forms.ListBox lbHaltestellen;
        private System.Windows.Forms.ListBox lbLinien;
        private System.Windows.Forms.Label lblHaltestellenliste;
        private System.Windows.Forms.Label lblLinienliste;
        private System.Windows.Forms.Button btnZuweisung;
        private System.Windows.Forms.TextBox tbKoordinateY;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.ListBox lbVerlauf;
    }
}