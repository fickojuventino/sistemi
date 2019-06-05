namespace MotornaVozila
{
    partial class frmSpecijalnost
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
            this.dgvSpecijalnost = new System.Windows.Forms.DataGridView();
            this.txt_id_tehnicar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_specijalnost = new System.Windows.Forms.TextBox();
            this.btn_sacuvaj = new System.Windows.Forms.Button();
            this.btn_obrisi = new System.Windows.Forms.Button();
            this.btn_obustavi = new System.Windows.Forms.Button();
            this.btn_nova = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecijalnost)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSpecijalnost
            // 
            this.dgvSpecijalnost.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSpecijalnost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpecijalnost.GridColor = System.Drawing.SystemColors.Control;
            this.dgvSpecijalnost.Location = new System.Drawing.Point(262, 14);
            this.dgvSpecijalnost.Name = "dgvSpecijalnost";
            this.dgvSpecijalnost.Size = new System.Drawing.Size(198, 240);
            this.dgvSpecijalnost.TabIndex = 0;
            this.dgvSpecijalnost.SelectionChanged += new System.EventHandler(this.dgvSpecijalnost_SelectionChanged);
            // 
            // txt_id_tehnicar
            // 
            this.txt_id_tehnicar.Location = new System.Drawing.Point(111, 14);
            this.txt_id_tehnicar.Name = "txt_id_tehnicar";
            this.txt_id_tehnicar.Size = new System.Drawing.Size(128, 20);
            this.txt_id_tehnicar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id Tehnicara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Specijalnost";
            // 
            // txt_specijalnost
            // 
            this.txt_specijalnost.Location = new System.Drawing.Point(111, 40);
            this.txt_specijalnost.Name = "txt_specijalnost";
            this.txt_specijalnost.Size = new System.Drawing.Size(128, 20);
            this.txt_specijalnost.TabIndex = 4;
            // 
            // btn_sacuvaj
            // 
            this.btn_sacuvaj.Location = new System.Drawing.Point(19, 231);
            this.btn_sacuvaj.Name = "btn_sacuvaj";
            this.btn_sacuvaj.Size = new System.Drawing.Size(75, 23);
            this.btn_sacuvaj.TabIndex = 5;
            this.btn_sacuvaj.Text = "Sacuvaj";
            this.btn_sacuvaj.UseVisualStyleBackColor = true;
            this.btn_sacuvaj.Click += new System.EventHandler(this.btn_sacuvaj_Click);
            // 
            // btn_obrisi
            // 
            this.btn_obrisi.Location = new System.Drawing.Point(181, 231);
            this.btn_obrisi.Name = "btn_obrisi";
            this.btn_obrisi.Size = new System.Drawing.Size(75, 23);
            this.btn_obrisi.TabIndex = 6;
            this.btn_obrisi.Text = "Obrisi";
            this.btn_obrisi.UseVisualStyleBackColor = true;
            this.btn_obrisi.Click += new System.EventHandler(this.btn_obrisi_Click);
            // 
            // btn_obustavi
            // 
            this.btn_obustavi.Location = new System.Drawing.Point(100, 231);
            this.btn_obustavi.Name = "btn_obustavi";
            this.btn_obustavi.Size = new System.Drawing.Size(75, 23);
            this.btn_obustavi.TabIndex = 7;
            this.btn_obustavi.Text = "Obustavi";
            this.btn_obustavi.UseVisualStyleBackColor = true;
            this.btn_obustavi.Click += new System.EventHandler(this.btn_obustavi_Click);
            // 
            // btn_nova
            // 
            this.btn_nova.Location = new System.Drawing.Point(181, 202);
            this.btn_nova.Name = "btn_nova";
            this.btn_nova.Size = new System.Drawing.Size(75, 23);
            this.btn_nova.TabIndex = 8;
            this.btn_nova.Text = "Nova";
            this.btn_nova.UseVisualStyleBackColor = true;
            this.btn_nova.Click += new System.EventHandler(this.btn_nova_Click);
            // 
            // frmSpecijalnost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 266);
            this.Controls.Add(this.btn_nova);
            this.Controls.Add(this.btn_obustavi);
            this.Controls.Add(this.btn_obrisi);
            this.Controls.Add(this.btn_sacuvaj);
            this.Controls.Add(this.txt_specijalnost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_id_tehnicar);
            this.Controls.Add(this.dgvSpecijalnost);
            this.Name = "frmSpecijalnost";
            this.Text = "frmSpecijalnost";
            this.Load += new System.EventHandler(this.frmSpecijalnost_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecijalnost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSpecijalnost;
        private System.Windows.Forms.TextBox txt_id_tehnicar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_specijalnost;
        private System.Windows.Forms.Button btn_sacuvaj;
        private System.Windows.Forms.Button btn_obrisi;
        private System.Windows.Forms.Button btn_obustavi;
        private System.Windows.Forms.Button btn_nova;
    }
}