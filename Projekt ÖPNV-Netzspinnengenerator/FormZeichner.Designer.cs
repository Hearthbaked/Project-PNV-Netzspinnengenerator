namespace Projekt_ÖPNV_Netzspinnengenerator
{
    partial class FormZeichner
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
            this.btnZurueckHalte = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.pZeichner = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnZurueckHalte
            // 
            this.btnZurueckHalte.Location = new System.Drawing.Point(9, 554);
            this.btnZurueckHalte.Name = "btnZurueckHalte";
            this.btnZurueckHalte.Size = new System.Drawing.Size(197, 23);
            this.btnZurueckHalte.TabIndex = 1;
            this.btnZurueckHalte.Text = "Wechsel zur Haltestellen Erfassung";
            this.btnZurueckHalte.UseVisualStyleBackColor = true;
            this.btnZurueckHalte.Click += new System.EventHandler(this.btnZurueckHalte_Click);
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(443, 554);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(95, 34);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Exportieren";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // pZeichner
            // 
            this.pZeichner.Location = new System.Drawing.Point(9, 12);
            this.pZeichner.Name = "pZeichner";
            this.pZeichner.Size = new System.Drawing.Size(934, 536);
            this.pZeichner.TabIndex = 4;
            this.pZeichner.Paint += new System.Windows.Forms.PaintEventHandler(this.pZeichner_Paint);
            // 
            // FormZeichner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 589);
            this.Controls.Add(this.pZeichner);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnZurueckHalte);
            this.Name = "FormZeichner";
            this.Text = "Zeichen-Tool";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnZurueckHalte;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Panel pZeichner;
    }
}