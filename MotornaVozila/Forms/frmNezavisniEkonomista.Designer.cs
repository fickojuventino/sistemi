namespace MotornaVozila
{
    partial class frmNezavisniEkonomista
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
            this.dgvNezavisniEkonomista = new System.Windows.Forms.DataGridView();
            this.txt_ime = new System.Windows.Forms.TextBox();
            this.txt_prezime = new System.Windows.Forms.TextBox();
            this.txt_maticni_broj = new System.Windows.Forms.TextBox();
            this.txt_telefon = new System.Windows.Forms.TextBox();
            this.txt_grad = new System.Windows.Forms.TextBox();
            this.txt_adresa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_sacuvaj = new System.Windows.Forms.Button();
            this.btn_obustavi = new System.Windows.Forms.Button();
            this.btn_obrisi = new System.Windows.Forms.Button();
            this.btn_novi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNezavisniEkonomista)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNezavisniEkonomista
            // 
            this.dgvNezavisniEkonomista.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvNezavisniEkonomista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNezavisniEkonomista.GridColor = System.Drawing.SystemColors.Control;
            this.dgvNezavisniEkonomista.Location = new System.Drawing.Point(255, 12);
            this.dgvNezavisniEkonomista.Name = "dgvNezavisniEkonomista";
            this.dgvNezavisniEkonomista.Size = new System.Drawing.Size(550, 248);
            this.dgvNezavisniEkonomista.TabIndex = 0;
            this.dgvNezavisniEkonomista.SelectionChanged += new System.EventHandler(this.dgvNezavisniEkonomista_SelectionChanged);
            // 
            // txt_ime
            // 
            this.txt_ime.Location = new System.Drawing.Point(128, 12);
            this.txt_ime.Name = "txt_ime";
            this.txt_ime.Size = new System.Drawing.Size(111, 20);
            this.txt_ime.TabIndex = 1;
            // 
            // txt_prezime
            // 
            this.txt_prezime.Location = new System.Drawing.Point(128, 38);
            this.txt_prezime.Name = "txt_prezime";
            this.txt_prezime.Size = new System.Drawing.Size(111, 20);
            this.txt_prezime.TabIndex = 2;
            // 
            // txt_maticni_broj
            // 
            this.txt_maticni_broj.Location = new System.Drawing.Point(128, 64);
            this.txt_maticni_broj.Name = "txt_maticni_broj";
            this.txt_maticni_broj.Size = new System.Drawing.Size(111, 20);
            this.txt_maticni_broj.TabIndex = 3;
            // 
            // txt_telefon
            // 
            this.txt_telefon.Location = new System.Drawing.Point(128, 90);
            this.txt_telefon.Name = "txt_telefon";
            this.txt_telefon.Size = new System.Drawing.Size(111, 20);
            this.txt_telefon.TabIndex = 4;
            // 
            // txt_grad
            // 
            this.txt_grad.Location = new System.Drawing.Point(128, 116);
            this.txt_grad.Name = "txt_grad";
            this.txt_grad.Size = new System.Drawing.Size(111, 20);
            this.txt_grad.TabIndex = 5;
            // 
            // txt_adresa
            // 
            this.txt_adresa.Location = new System.Drawing.Point(128, 142);
            this.txt_adresa.Name = "txt_adresa";
            this.txt_adresa.Size = new System.Drawing.Size(111, 20);
            this.txt_adresa.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Maticni broj";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Telefon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Grad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Adresa";
            // 
            // btn_sacuvaj
            // 
            this.btn_sacuvaj.Location = new System.Drawing.Point(12, 237);
            this.btn_sacuvaj.Name = "btn_sacuvaj";
            this.btn_sacuvaj.Size = new System.Drawing.Size(75, 23);
            this.btn_sacuvaj.TabIndex = 13;
            this.btn_sacuvaj.Text = "Sacuvaj";
            this.btn_sacuvaj.UseVisualStyleBackColor = true;
            this.btn_sacuvaj.Click += new System.EventHandler(this.btn_sacuvaj_Click);
            // 
            // btn_obustavi
            // 
            this.btn_obustavi.Location = new System.Drawing.Point(93, 237);
            this.btn_obustavi.Name = "btn_obustavi";
            this.btn_obustavi.Size = new System.Drawing.Size(75, 23);
            this.btn_obustavi.TabIndex = 14;
            this.btn_obustavi.Text = "Obustavi";
            this.btn_obustavi.UseVisualStyleBackColor = true;
            this.btn_obustavi.Click += new System.EventHandler(this.btn_obustavi_Click);
            // 
            // btn_obrisi
            // 
            this.btn_obrisi.Location = new System.Drawing.Point(174, 237);
            this.btn_obrisi.Name = "btn_obrisi";
            this.btn_obrisi.Size = new System.Drawing.Size(75, 23);
            this.btn_obrisi.TabIndex = 15;
            this.btn_obrisi.Text = "Obrisi";
            this.btn_obrisi.UseVisualStyleBackColor = true;
            this.btn_obrisi.Click += new System.EventHandler(this.btn_obrisi_Click);
            // 
            // btn_novi
            // 
            this.btn_novi.Location = new System.Drawing.Point(174, 208);
            this.btn_novi.Name = "btn_novi";
            this.btn_novi.Size = new System.Drawing.Size(75, 23);
            this.btn_novi.TabIndex = 16;
            this.btn_novi.Text = "Novi";
            this.btn_novi.UseVisualStyleBackColor = true;
            this.btn_novi.Click += new System.EventHandler(this.btn_novi_Click);
            // 
            // frmNezavisniEkonomista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 283);
            this.Controls.Add(this.btn_novi);
            this.Controls.Add(this.btn_obrisi);
            this.Controls.Add(this.btn_obustavi);
            this.Controls.Add(this.btn_sacuvaj);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_adresa);
            this.Controls.Add(this.txt_grad);
            this.Controls.Add(this.txt_telefon);
            this.Controls.Add(this.txt_maticni_broj);
            this.Controls.Add(this.txt_prezime);
            this.Controls.Add(this.txt_ime);
            this.Controls.Add(this.dgvNezavisniEkonomista);
            this.Name = "frmNezavisniEkonomista";
            this.Text = "frmNezavisniEkonomista";
            this.Load += new System.EventHandler(this.frmNezavisniEkonomista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNezavisniEkonomista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNezavisniEkonomista;
        private System.Windows.Forms.TextBox txt_ime;
        private System.Windows.Forms.TextBox txt_prezime;
        private System.Windows.Forms.TextBox txt_maticni_broj;
        private System.Windows.Forms.TextBox txt_telefon;
        private System.Windows.Forms.TextBox txt_grad;
        private System.Windows.Forms.TextBox txt_adresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_sacuvaj;
        private System.Windows.Forms.Button btn_obustavi;
        private System.Windows.Forms.Button btn_obrisi;
        private System.Windows.Forms.Button btn_novi;
    }
}