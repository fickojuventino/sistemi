namespace MotornaVozila
{
    partial class frmServisi
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
            this.dgvServisi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id_sef = new System.Windows.Forms.TextBox();
            this.txt_id_salon = new System.Windows.Forms.TextBox();
            this.txt_tip_usluge = new System.Windows.Forms.TextBox();
            this.txt_id_tehnicar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_datum_prijema = new System.Windows.Forms.DateTimePicker();
            this.dtp_datum_zavrsetka = new System.Windows.Forms.DateTimePicker();
            this.btn_sacuvaj = new System.Windows.Forms.Button();
            this.btn_novi = new System.Windows.Forms.Button();
            this.btn_obrisi = new System.Windows.Forms.Button();
            this.btn_obustavi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServisi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvServisi
            // 
            this.dgvServisi.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvServisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServisi.GridColor = System.Drawing.SystemColors.Control;
            this.dgvServisi.Location = new System.Drawing.Point(281, 12);
            this.dgvServisi.Name = "dgvServisi";
            this.dgvServisi.Size = new System.Drawing.Size(570, 333);
            this.dgvServisi.TabIndex = 0;
            this.dgvServisi.SelectionChanged += new System.EventHandler(this.dgvServisi_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id Sefa";
            // 
            // txt_id_sef
            // 
            this.txt_id_sef.Location = new System.Drawing.Point(122, 12);
            this.txt_id_sef.Name = "txt_id_sef";
            this.txt_id_sef.Size = new System.Drawing.Size(121, 20);
            this.txt_id_sef.TabIndex = 2;
            // 
            // txt_id_salon
            // 
            this.txt_id_salon.Location = new System.Drawing.Point(122, 38);
            this.txt_id_salon.Name = "txt_id_salon";
            this.txt_id_salon.Size = new System.Drawing.Size(121, 20);
            this.txt_id_salon.TabIndex = 3;
            // 
            // txt_tip_usluge
            // 
            this.txt_tip_usluge.Location = new System.Drawing.Point(122, 64);
            this.txt_tip_usluge.Name = "txt_tip_usluge";
            this.txt_tip_usluge.Size = new System.Drawing.Size(121, 20);
            this.txt_tip_usluge.TabIndex = 4;
            // 
            // txt_id_tehnicar
            // 
            this.txt_id_tehnicar.Location = new System.Drawing.Point(122, 90);
            this.txt_id_tehnicar.Name = "txt_id_tehnicar";
            this.txt_id_tehnicar.Size = new System.Drawing.Size(121, 20);
            this.txt_id_tehnicar.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Id Salona";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tip Usluge";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Id Tehnicara";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Datum Prijema";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Datum Zavrsetka";
            // 
            // dtp_datum_prijema
            // 
            this.dtp_datum_prijema.CustomFormat = "";
            this.dtp_datum_prijema.Location = new System.Drawing.Point(122, 119);
            this.dtp_datum_prijema.Name = "dtp_datum_prijema";
            this.dtp_datum_prijema.Size = new System.Drawing.Size(121, 20);
            this.dtp_datum_prijema.TabIndex = 14;
            // 
            // dtp_datum_zavrsetka
            // 
            this.dtp_datum_zavrsetka.CustomFormat = "";
            this.dtp_datum_zavrsetka.Location = new System.Drawing.Point(122, 145);
            this.dtp_datum_zavrsetka.Name = "dtp_datum_zavrsetka";
            this.dtp_datum_zavrsetka.Size = new System.Drawing.Size(121, 20);
            this.dtp_datum_zavrsetka.TabIndex = 15;
            // 
            // btn_sacuvaj
            // 
            this.btn_sacuvaj.Location = new System.Drawing.Point(28, 312);
            this.btn_sacuvaj.Name = "btn_sacuvaj";
            this.btn_sacuvaj.Size = new System.Drawing.Size(75, 23);
            this.btn_sacuvaj.TabIndex = 16;
            this.btn_sacuvaj.Text = "Sacuvaj";
            this.btn_sacuvaj.UseVisualStyleBackColor = true;
            this.btn_sacuvaj.Click += new System.EventHandler(this.btn_sacuvaj_Click);
            // 
            // btn_novi
            // 
            this.btn_novi.Location = new System.Drawing.Point(190, 283);
            this.btn_novi.Name = "btn_novi";
            this.btn_novi.Size = new System.Drawing.Size(75, 23);
            this.btn_novi.TabIndex = 17;
            this.btn_novi.Text = "Novi";
            this.btn_novi.UseVisualStyleBackColor = true;
            this.btn_novi.Click += new System.EventHandler(this.btn_novi_Click);
            // 
            // btn_obrisi
            // 
            this.btn_obrisi.Location = new System.Drawing.Point(190, 312);
            this.btn_obrisi.Name = "btn_obrisi";
            this.btn_obrisi.Size = new System.Drawing.Size(75, 23);
            this.btn_obrisi.TabIndex = 18;
            this.btn_obrisi.Text = "Obrisi";
            this.btn_obrisi.UseVisualStyleBackColor = true;
            this.btn_obrisi.Click += new System.EventHandler(this.btn_obrisi_Click);
            // 
            // btn_obustavi
            // 
            this.btn_obustavi.Location = new System.Drawing.Point(109, 312);
            this.btn_obustavi.Name = "btn_obustavi";
            this.btn_obustavi.Size = new System.Drawing.Size(75, 23);
            this.btn_obustavi.TabIndex = 19;
            this.btn_obustavi.Text = "Obustavi";
            this.btn_obustavi.UseVisualStyleBackColor = true;
            this.btn_obustavi.Click += new System.EventHandler(this.btn_obustavi_Click);
            // 
            // frmServisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 358);
            this.Controls.Add(this.btn_obustavi);
            this.Controls.Add(this.btn_obrisi);
            this.Controls.Add(this.btn_novi);
            this.Controls.Add(this.btn_sacuvaj);
            this.Controls.Add(this.dtp_datum_zavrsetka);
            this.Controls.Add(this.dtp_datum_prijema);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_id_tehnicar);
            this.Controls.Add(this.txt_tip_usluge);
            this.Controls.Add(this.txt_id_salon);
            this.Controls.Add(this.txt_id_sef);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvServisi);
            this.Name = "frmServisi";
            this.Text = "frmServisi";
            this.Load += new System.EventHandler(this.frmServisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvServisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id_sef;
        private System.Windows.Forms.TextBox txt_id_salon;
        private System.Windows.Forms.TextBox txt_tip_usluge;
        private System.Windows.Forms.TextBox txt_id_tehnicar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_datum_prijema;
        private System.Windows.Forms.DateTimePicker dtp_datum_zavrsetka;
        private System.Windows.Forms.Button btn_sacuvaj;
        private System.Windows.Forms.Button btn_novi;
        private System.Windows.Forms.Button btn_obrisi;
        private System.Windows.Forms.Button btn_obustavi;
    }
}