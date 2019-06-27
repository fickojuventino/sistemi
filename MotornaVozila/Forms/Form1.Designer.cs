namespace MotornaVozila
{
    partial class Form1
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
            this.btnServis = new System.Windows.Forms.Button();
            this.btn_kupac = new System.Windows.Forms.Button();
            this.btn_specijalnost = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSalon = new System.Windows.Forms.Button();
            this.btn_vozilo = new System.Windows.Forms.Button();
            this.btn_zaposleni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnServis
            // 
            this.btnServis.Location = new System.Drawing.Point(12, 70);
            this.btnServis.Name = "btnServis";
            this.btnServis.Size = new System.Drawing.Size(295, 23);
            this.btnServis.TabIndex = 6;
            this.btnServis.Text = "Servis";
            this.btnServis.UseVisualStyleBackColor = true;
            this.btnServis.Click += new System.EventHandler(this.btnServis_Click);
            // 
            // btn_kupac
            // 
            this.btn_kupac.Location = new System.Drawing.Point(12, 116);
            this.btn_kupac.Name = "btn_kupac";
            this.btn_kupac.Size = new System.Drawing.Size(295, 23);
            this.btn_kupac.TabIndex = 7;
            this.btn_kupac.Text = "Kupac";
            this.btn_kupac.UseVisualStyleBackColor = true;
            this.btn_kupac.Click += new System.EventHandler(this.btn_kupac_Click);
            // 
            // btn_specijalnost
            // 
            this.btn_specijalnost.Location = new System.Drawing.Point(12, 159);
            this.btn_specijalnost.Name = "btn_specijalnost";
            this.btn_specijalnost.Size = new System.Drawing.Size(295, 23);
            this.btn_specijalnost.TabIndex = 8;
            this.btn_specijalnost.Text = "Specijalnost";
            this.btn_specijalnost.UseVisualStyleBackColor = true;
            this.btn_specijalnost.Click += new System.EventHandler(this.btn_specijalnost_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 288);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(295, 45);
            this.button2.TabIndex = 9;
            this.button2.Text = "Nezavisni Ekonomista";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSalon
            // 
            this.btnSalon.Location = new System.Drawing.Point(12, 26);
            this.btnSalon.Name = "btnSalon";
            this.btnSalon.Size = new System.Drawing.Size(295, 23);
            this.btnSalon.TabIndex = 10;
            this.btnSalon.Text = "Salon";
            this.btnSalon.UseVisualStyleBackColor = true;
            this.btnSalon.Click += new System.EventHandler(this.btnSalon_Click);
            // 
            // btn_vozilo
            // 
            this.btn_vozilo.Location = new System.Drawing.Point(12, 203);
            this.btn_vozilo.Name = "btn_vozilo";
            this.btn_vozilo.Size = new System.Drawing.Size(295, 23);
            this.btn_vozilo.TabIndex = 11;
            this.btn_vozilo.Text = "Vozilo";
            this.btn_vozilo.UseVisualStyleBackColor = true;
            this.btn_vozilo.Click += new System.EventHandler(this.btn_vozilo_Click);
            // 
            // btn_zaposleni
            // 
            this.btn_zaposleni.Location = new System.Drawing.Point(12, 245);
            this.btn_zaposleni.Name = "btn_zaposleni";
            this.btn_zaposleni.Size = new System.Drawing.Size(295, 23);
            this.btn_zaposleni.TabIndex = 12;
            this.btn_zaposleni.Text = "Zaposleni";
            this.btn_zaposleni.UseVisualStyleBackColor = true;
            this.btn_zaposleni.Click += new System.EventHandler(this.btn_zaposleni_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 350);
            this.Controls.Add(this.btn_zaposleni);
            this.Controls.Add(this.btn_vozilo);
            this.Controls.Add(this.btnSalon);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_specijalnost);
            this.Controls.Add(this.btn_kupac);
            this.Controls.Add(this.btnServis);
            this.Name = "Form1";
            this.Text = "Motorna Vozila";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnServis;
        private System.Windows.Forms.Button btn_kupac;
        private System.Windows.Forms.Button btn_specijalnost;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSalon;
        private System.Windows.Forms.Button btn_vozilo;
        private System.Windows.Forms.Button btn_zaposleni;
    }
}

