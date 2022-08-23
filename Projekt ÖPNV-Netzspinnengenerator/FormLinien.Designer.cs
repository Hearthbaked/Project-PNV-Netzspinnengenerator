namespace Projekt_ÖPNV_Netzspinnengenerator
{
    partial class FormLinien
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnWechselHalte = new System.Windows.Forms.Button();
            this.tbLinienbezeichnung = new System.Windows.Forms.TextBox();
            this.lblLinienart = new System.Windows.Forms.Label();
            this.lblLinienbezeichnung = new System.Windows.Forms.Label();
            this.tbVerfuegbarkeit = new System.Windows.Forms.TextBox();
            this.lblVerfuegbarkeit = new System.Windows.Forms.Label();
            this.tbLaenge = new System.Windows.Forms.TextBox();
            this.lblLaenge = new System.Windows.Forms.Label();
            this.btnHinzufuegen = new System.Windows.Forms.Button();
            this.btnEntfernen = new System.Windows.Forms.Button();
            this.lbLinien = new System.Windows.Forms.ListBox();
            this.lblLinien = new System.Windows.Forms.Label();
            this.cbLinienart = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnWechselHalte
            // 
            this.btnWechselHalte.Location = new System.Drawing.Point(234, 379);
            this.btnWechselHalte.Name = "btnWechselHalte";
            this.btnWechselHalte.Size = new System.Drawing.Size(190, 23);
            this.btnWechselHalte.TabIndex = 0;
            this.btnWechselHalte.Text = "Wechsel zur Haltestellen Erfassung";
            this.btnWechselHalte.UseVisualStyleBackColor = true;
            this.btnWechselHalte.Click += new System.EventHandler(this.btnWechselHalte_Click);
            // 
            // tbLinienbezeichnung
            // 
            this.tbLinienbezeichnung.Location = new System.Drawing.Point(28, 48);
            this.tbLinienbezeichnung.Name = "tbLinienbezeichnung";
            this.tbLinienbezeichnung.Size = new System.Drawing.Size(130, 20);
            this.tbLinienbezeichnung.TabIndex = 1;
            // 
            // lblLinienart
            // 
            this.lblLinienart.AutoSize = true;
            this.lblLinienart.Location = new System.Drawing.Point(25, 90);
            this.lblLinienart.Name = "lblLinienart";
            this.lblLinienart.Size = new System.Drawing.Size(47, 13);
            this.lblLinienart.TabIndex = 2;
            this.lblLinienart.Text = "Linienart";
            // 
            // lblLinienbezeichnung
            // 
            this.lblLinienbezeichnung.AutoSize = true;
            this.lblLinienbezeichnung.Location = new System.Drawing.Point(25, 21);
            this.lblLinienbezeichnung.Name = "lblLinienbezeichnung";
            this.lblLinienbezeichnung.Size = new System.Drawing.Size(96, 13);
            this.lblLinienbezeichnung.TabIndex = 3;
            this.lblLinienbezeichnung.Text = "Linienbezeichnung";
            // 
            // tbVerfuegbarkeit
            // 
            this.tbVerfuegbarkeit.Location = new System.Drawing.Point(28, 174);
            this.tbVerfuegbarkeit.Name = "tbVerfuegbarkeit";
            this.tbVerfuegbarkeit.Size = new System.Drawing.Size(100, 20);
            this.tbVerfuegbarkeit.TabIndex = 5;
            // 
            // lblVerfuegbarkeit
            // 
            this.lblVerfuegbarkeit.AutoSize = true;
            this.lblVerfuegbarkeit.Location = new System.Drawing.Point(28, 155);
            this.lblVerfuegbarkeit.Name = "lblVerfuegbarkeit";
            this.lblVerfuegbarkeit.Size = new System.Drawing.Size(70, 13);
            this.lblVerfuegbarkeit.TabIndex = 6;
            this.lblVerfuegbarkeit.Text = "Verfügbarkeit";
            // 
            // tbLaenge
            // 
            this.tbLaenge.Location = new System.Drawing.Point(28, 237);
            this.tbLaenge.Name = "tbLaenge";
            this.tbLaenge.Size = new System.Drawing.Size(100, 20);
            this.tbLaenge.TabIndex = 7;
            // 
            // lblLaenge
            // 
            this.lblLaenge.AutoSize = true;
            this.lblLaenge.Location = new System.Drawing.Point(31, 218);
            this.lblLaenge.Name = "lblLaenge";
            this.lblLaenge.Size = new System.Drawing.Size(37, 13);
            this.lblLaenge.TabIndex = 8;
            this.lblLaenge.Text = "Länge";
            // 
            // btnHinzufuegen
            // 
            this.btnHinzufuegen.Location = new System.Drawing.Point(28, 303);
            this.btnHinzufuegen.Name = "btnHinzufuegen";
            this.btnHinzufuegen.Size = new System.Drawing.Size(100, 31);
            this.btnHinzufuegen.TabIndex = 9;
            this.btnHinzufuegen.Text = "Hinzufügen";
            this.btnHinzufuegen.UseVisualStyleBackColor = true;
            this.btnHinzufuegen.Click += new System.EventHandler(this.btnHinzufuegen_Click);
            // 
            // btnEntfernen
            // 
            this.btnEntfernen.Location = new System.Drawing.Point(28, 341);
            this.btnEntfernen.Name = "btnEntfernen";
            this.btnEntfernen.Size = new System.Drawing.Size(100, 32);
            this.btnEntfernen.TabIndex = 10;
            this.btnEntfernen.Text = "Entfernen";
            this.btnEntfernen.UseVisualStyleBackColor = true;
            this.btnEntfernen.Click += new System.EventHandler(this.btnEntfernen_Click);
            // 
            // lbLinien
            // 
            this.lbLinien.FormattingEnabled = true;
            this.lbLinien.Location = new System.Drawing.Point(251, 31);
            this.lbLinien.Name = "lbLinien";
            this.lbLinien.Size = new System.Drawing.Size(155, 342);
            this.lbLinien.TabIndex = 11;
            // 
            // lblLinien
            // 
            this.lblLinien.AutoSize = true;
            this.lblLinien.Location = new System.Drawing.Point(254, 11);
            this.lblLinien.Name = "lblLinien";
            this.lblLinien.Size = new System.Drawing.Size(60, 13);
            this.lblLinien.TabIndex = 12;
            this.lblLinien.Text = "Linien-Liste";
            // 
            // cbLinienart
            // 
            this.cbLinienart.FormattingEnabled = true;
            this.cbLinienart.Items.AddRange(new object[] {
            "Bus",
            "Tram",
            "U-Bahn",
            "Regionalbahn",
            "Fähre",
            "S-Bahn"});
            this.cbLinienart.Location = new System.Drawing.Point(28, 106);
            this.cbLinienart.Name = "cbLinienart";
            this.cbLinienart.Size = new System.Drawing.Size(121, 21);
            this.cbLinienart.TabIndex = 25;
            // 
            // FormLinien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 420);
            this.Controls.Add(this.cbLinienart);
            this.Controls.Add(this.lblLinien);
            this.Controls.Add(this.lbLinien);
            this.Controls.Add(this.btnEntfernen);
            this.Controls.Add(this.btnHinzufuegen);
            this.Controls.Add(this.lblLaenge);
            this.Controls.Add(this.tbLaenge);
            this.Controls.Add(this.lblVerfuegbarkeit);
            this.Controls.Add(this.tbVerfuegbarkeit);
            this.Controls.Add(this.lblLinienbezeichnung);
            this.Controls.Add(this.lblLinienart);
            this.Controls.Add(this.tbLinienbezeichnung);
            this.Controls.Add(this.btnWechselHalte);
            this.Name = "FormLinien";
            this.Text = "Linien Erfassung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWechselHalte;
        private System.Windows.Forms.TextBox tbLinienbezeichnung;
        private System.Windows.Forms.Label lblLinienart;
        private System.Windows.Forms.Label lblLinienbezeichnung;
        private System.Windows.Forms.TextBox tbVerfuegbarkeit;
        private System.Windows.Forms.Label lblVerfuegbarkeit;
        private System.Windows.Forms.TextBox tbLaenge;
        private System.Windows.Forms.Label lblLaenge;
        private System.Windows.Forms.Button btnHinzufuegen;
        private System.Windows.Forms.Button btnEntfernen;
        private System.Windows.Forms.ListBox lbLinien;
        private System.Windows.Forms.Label lblLinien;
        private System.Windows.Forms.ComboBox cbLinienart;
    }
}

