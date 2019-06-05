namespace MotornaVozila
{
    partial class frmKupac
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
            this.dgvKupac = new System.Windows.Forms.DataGridView();
            this.txt_ime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_novi = new System.Windows.Forms.Button();
            this.txt_prezime = new System.Windows.Forms.TextBox();
            this.txt_telefon = new System.Windows.Forms.TextBox();
            this.txt_pib = new System.Windows.Forms.TextBox();
            this.txt_mat_br = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_sacuvaj = new System.Windows.Forms.Button();
            this.btn_obustavi = new System.Windows.Forms.Button();
            this.btn_obrisi = new System.Windows.Forms.Button();
            this.cb_tip_lica = new System.Windows.Forms.ComboBox();
            this.txt_id_kup_vozila = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKupac)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKupac
            // 
            this.dgvKupac.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvKupac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKupac.GridColor = System.Drawing.SystemColors.Control;
            this.dgvKupac.Location = new System.Drawing.Point(282, 16);
            this.dgvKupac.Name = "dgvKupac";
            this.dgvKupac.Size = new System.Drawing.Size(501, 293);
            this.dgvKupac.TabIndex = 0;
            this.dgvKupac.SelectionChanged += new System.EventHandler(this.dgvKupac_SelectionChanged);
            // 
            // txt_ime
            // 
            this.txt_ime.Location = new System.Drawing.Point(138, 16);
            this.txt_ime.Name = "txt_ime";
            this.txt_ime.Size = new System.Drawing.Size(124, 20);
            this.txt_ime.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ime";
            // 
            // btn_novi
            // 
            this.btn_novi.Location = new System.Drawing.Point(189, 257);
            this.btn_novi.Name = "btn_novi";
            this.btn_novi.Size = new System.Drawing.Size(75, 23);
            this.btn_novi.TabIndex = 3;
            this.btn_novi.Text = "Novi";
            this.btn_novi.UseVisualStyleBackColor = true;
            this.btn_novi.Click += new System.EventHandler(this.btn_novi_Click);
            // 
            // txt_prezime
            // 
            this.txt_prezime.Location = new System.Drawing.Point(138, 42);
            this.txt_prezime.Name = "txt_prezime";
            this.txt_prezime.Size = new System.Drawing.Size(124, 20);
            this.txt_prezime.TabIndex = 4;
            // 
            // txt_telefon
            // 
            this.txt_telefon.Location = new System.Drawing.Point(138, 68);
            this.txt_telefon.Name = "txt_telefon";
            this.txt_telefon.Size = new System.Drawing.Size(124, 20);
            this.txt_telefon.TabIndex = 5;
            // 
            // txt_pib
            // 
            this.txt_pib.Location = new System.Drawing.Point(138, 120);
            this.txt_pib.Name = "txt_pib";
            this.txt_pib.Size = new System.Drawing.Size(124, 20);
            this.txt_pib.TabIndex = 7;
            // 
            // txt_mat_br
            // 
            this.txt_mat_br.Location = new System.Drawing.Point(138, 146);
            this.txt_mat_br.Name = "txt_mat_br";
            this.txt_mat_br.Size = new System.Drawing.Size(124, 20);
            this.txt_mat_br.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tip Lica";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "PIB";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Maticni Broj";
            // 
            // btn_sacuvaj
            // 
            this.btn_sacuvaj.Location = new System.Drawing.Point(27, 286);
            this.btn_sacuvaj.Name = "btn_sacuvaj";
            this.btn_sacuvaj.Size = new System.Drawing.Size(75, 23);
            this.btn_sacuvaj.TabIndex = 14;
            this.btn_sacuvaj.Text = "Sacuvaj";
            this.btn_sacuvaj.UseVisualStyleBackColor = true;
            this.btn_sacuvaj.Click += new System.EventHandler(this.btn_sacuvaj_Click);
            // 
            // btn_obustavi
            // 
            this.btn_obustavi.Location = new System.Drawing.Point(108, 286);
            this.btn_obustavi.Name = "btn_obustavi";
            this.btn_obustavi.Size = new System.Drawing.Size(75, 23);
            this.btn_obustavi.TabIndex = 15;
            this.btn_obustavi.Text = "Obustavi";
            this.btn_obustavi.UseVisualStyleBackColor = true;
            this.btn_obustavi.Click += new System.EventHandler(this.btn_obustavi_Click);
            // 
            // btn_obrisi
            // 
            this.btn_obrisi.Location = new System.Drawing.Point(189, 286);
            this.btn_obrisi.Name = "btn_obrisi";
            this.btn_obrisi.Size = new System.Drawing.Size(75, 23);
            this.btn_obrisi.TabIndex = 16;
            this.btn_obrisi.Text = "Obrisi";
            this.btn_obrisi.UseVisualStyleBackColor = true;
            this.btn_obrisi.Click += new System.EventHandler(this.btn_obrisi_Click);
            // 
            // cb_tip_lica
            // 
            this.cb_tip_lica.FormattingEnabled = true;
            this.cb_tip_lica.Items.AddRange(new object[] {
            "pravno",
            "fizicko"});
            this.cb_tip_lica.Location = new System.Drawing.Point(138, 94);
            this.cb_tip_lica.Name = "cb_tip_lica";
            this.cb_tip_lica.Size = new System.Drawing.Size(126, 21);
            this.cb_tip_lica.TabIndex = 17;
            // 
            // txt_id_kup_vozila
            // 
            this.txt_id_kup_vozila.Location = new System.Drawing.Point(138, 172);
            this.txt_id_kup_vozila.Name = "txt_id_kup_vozila";
            this.txt_id_kup_vozila.Size = new System.Drawing.Size(124, 20);
            this.txt_id_kup_vozila.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Id Kupljenog Vozila";
            // 
            // frmKupac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 322);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_id_kup_vozila);
            this.Controls.Add(this.cb_tip_lica);
            this.Controls.Add(this.btn_obrisi);
            this.Controls.Add(this.btn_obustavi);
            this.Controls.Add(this.btn_sacuvaj);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_mat_br);
            this.Controls.Add(this.txt_pib);
            this.Controls.Add(this.txt_telefon);
            this.Controls.Add(this.txt_prezime);
            this.Controls.Add(this.btn_novi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ime);
            this.Controls.Add(this.dgvKupac);
            this.Name = "frmKupac";
            this.Text = "frmKupac";
            this.Load += new System.EventHandler(this.frmKupac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKupac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKupac;
        private System.Windows.Forms.TextBox txt_ime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_novi;
        private System.Windows.Forms.TextBox txt_prezime;
        private System.Windows.Forms.TextBox txt_telefon;
        private System.Windows.Forms.TextBox txt_pib;
        private System.Windows.Forms.TextBox txt_mat_br;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_sacuvaj;
        private System.Windows.Forms.Button btn_obustavi;
        private System.Windows.Forms.Button btn_obrisi;
        private System.Windows.Forms.ComboBox cb_tip_lica;
        private System.Windows.Forms.TextBox txt_id_kup_vozila;
        private System.Windows.Forms.Label label7;
    }
}