namespace MotornaVozila
{
    partial class frmSalon
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
            this.dgvSalon = new System.Windows.Forms.DataGridView();
            this.txt_grad = new System.Windows.Forms.TextBox();
            this.txt_adresa = new System.Windows.Forms.TextBox();
            this.txt_id_zaposleni = new System.Windows.Forms.TextBox();
            this.txt_stepen_opremljenosti = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_sacuvaj = new System.Windows.Forms.Button();
            this.btn_otkazi = new System.Windows.Forms.Button();
            this.btn_obrisi = new System.Windows.Forms.Button();
            this.btn_novi = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_nez_ekonomista = new System.Windows.Forms.TextBox();
            this.txt_odgovorni_servis = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSalon
            // 
            this.dgvSalon.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSalon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalon.GridColor = System.Drawing.SystemColors.Control;
            this.dgvSalon.Location = new System.Drawing.Point(280, 12);
            this.dgvSalon.Name = "dgvSalon";
            this.dgvSalon.Size = new System.Drawing.Size(444, 225);
            this.dgvSalon.TabIndex = 0;
            this.dgvSalon.SelectionChanged += new System.EventHandler(this.dgvSalon_SelectionChanged);
            // 
            // txt_grad
            // 
            this.txt_grad.Location = new System.Drawing.Point(144, 12);
            this.txt_grad.Name = "txt_grad";
            this.txt_grad.Size = new System.Drawing.Size(111, 20);
            this.txt_grad.TabIndex = 1;
            // 
            // txt_adresa
            // 
            this.txt_adresa.Location = new System.Drawing.Point(144, 38);
            this.txt_adresa.Name = "txt_adresa";
            this.txt_adresa.Size = new System.Drawing.Size(111, 20);
            this.txt_adresa.TabIndex = 2;
            // 
            // txt_id_zaposleni
            // 
            this.txt_id_zaposleni.Location = new System.Drawing.Point(144, 64);
            this.txt_id_zaposleni.Name = "txt_id_zaposleni";
            this.txt_id_zaposleni.Size = new System.Drawing.Size(111, 20);
            this.txt_id_zaposleni.TabIndex = 3;
            // 
            // txt_stepen_opremljenosti
            // 
            this.txt_stepen_opremljenosti.Location = new System.Drawing.Point(144, 90);
            this.txt_stepen_opremljenosti.Name = "txt_stepen_opremljenosti";
            this.txt_stepen_opremljenosti.Size = new System.Drawing.Size(111, 20);
            this.txt_stepen_opremljenosti.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Grad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Adresa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Id Zaposlenog";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Stepen Opremljenosti";
            // 
            // btn_sacuvaj
            // 
            this.btn_sacuvaj.Location = new System.Drawing.Point(18, 214);
            this.btn_sacuvaj.Name = "btn_sacuvaj";
            this.btn_sacuvaj.Size = new System.Drawing.Size(75, 23);
            this.btn_sacuvaj.TabIndex = 9;
            this.btn_sacuvaj.Text = "Sacuvaj";
            this.btn_sacuvaj.UseVisualStyleBackColor = true;
            this.btn_sacuvaj.Click += new System.EventHandler(this.btn_sacuvaj_Click);
            // 
            // btn_otkazi
            // 
            this.btn_otkazi.Location = new System.Drawing.Point(99, 214);
            this.btn_otkazi.Name = "btn_otkazi";
            this.btn_otkazi.Size = new System.Drawing.Size(75, 23);
            this.btn_otkazi.TabIndex = 10;
            this.btn_otkazi.Text = "Obustavi";
            this.btn_otkazi.UseVisualStyleBackColor = true;
            this.btn_otkazi.Click += new System.EventHandler(this.btn_otkazi_Click);
            // 
            // btn_obrisi
            // 
            this.btn_obrisi.Location = new System.Drawing.Point(180, 214);
            this.btn_obrisi.Name = "btn_obrisi";
            this.btn_obrisi.Size = new System.Drawing.Size(75, 23);
            this.btn_obrisi.TabIndex = 11;
            this.btn_obrisi.Text = "Obrisi";
            this.btn_obrisi.UseVisualStyleBackColor = true;
            this.btn_obrisi.Click += new System.EventHandler(this.btn_obrisi_Click);
            // 
            // btn_novi
            // 
            this.btn_novi.Location = new System.Drawing.Point(180, 185);
            this.btn_novi.Name = "btn_novi";
            this.btn_novi.Size = new System.Drawing.Size(75, 23);
            this.btn_novi.TabIndex = 12;
            this.btn_novi.Text = "Novi";
            this.btn_novi.UseVisualStyleBackColor = true;
            this.btn_novi.Click += new System.EventHandler(this.btn_novi_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Nezavisni ekonomista";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Odgovorni servis";
            // 
            // txt_nez_ekonomista
            // 
            this.txt_nez_ekonomista.Location = new System.Drawing.Point(144, 142);
            this.txt_nez_ekonomista.Name = "txt_nez_ekonomista";
            this.txt_nez_ekonomista.Size = new System.Drawing.Size(111, 20);
            this.txt_nez_ekonomista.TabIndex = 14;
            // 
            // txt_odgovorni_servis
            // 
            this.txt_odgovorni_servis.Location = new System.Drawing.Point(144, 116);
            this.txt_odgovorni_servis.Name = "txt_odgovorni_servis";
            this.txt_odgovorni_servis.Size = new System.Drawing.Size(111, 20);
            this.txt_odgovorni_servis.TabIndex = 13;
            // 
            // frmSalon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 256);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_nez_ekonomista);
            this.Controls.Add(this.txt_odgovorni_servis);
            this.Controls.Add(this.btn_novi);
            this.Controls.Add(this.btn_obrisi);
            this.Controls.Add(this.btn_otkazi);
            this.Controls.Add(this.btn_sacuvaj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_stepen_opremljenosti);
            this.Controls.Add(this.txt_id_zaposleni);
            this.Controls.Add(this.txt_adresa);
            this.Controls.Add(this.txt_grad);
            this.Controls.Add(this.dgvSalon);
            this.Name = "frmSalon";
            this.Text = "frmSalon";
            this.Load += new System.EventHandler(this.frmSalon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSalon;
        private System.Windows.Forms.TextBox txt_grad;
        private System.Windows.Forms.TextBox txt_adresa;
        private System.Windows.Forms.TextBox txt_id_zaposleni;
        private System.Windows.Forms.TextBox txt_stepen_opremljenosti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_sacuvaj;
        private System.Windows.Forms.Button btn_otkazi;
        private System.Windows.Forms.Button btn_obrisi;
        private System.Windows.Forms.Button btn_novi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_nez_ekonomista;
        private System.Windows.Forms.TextBox txt_odgovorni_servis;
    }
}