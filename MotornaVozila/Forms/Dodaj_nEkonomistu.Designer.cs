namespace MotornaVozila
{
    partial class Dodaj_nEkonomistu
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
            this.ime = new System.Windows.Forms.TextBox();
            this.prezime = new System.Windows.Forms.TextBox();
            this.matBr = new System.Windows.Forms.TextBox();
            this.telefon = new System.Windows.Forms.TextBox();
            this.grad = new System.Windows.Forms.TextBox();
            this.adresa = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ime
            // 
            this.ime.Location = new System.Drawing.Point(13, 13);
            this.ime.Name = "ime";
            this.ime.Size = new System.Drawing.Size(259, 20);
            this.ime.TabIndex = 0;
            this.ime.Text = "ime";
            // 
            // prezime
            // 
            this.prezime.Location = new System.Drawing.Point(13, 39);
            this.prezime.Name = "prezime";
            this.prezime.Size = new System.Drawing.Size(259, 20);
            this.prezime.TabIndex = 0;
            this.prezime.Text = "prezime";
            // 
            // matBr
            // 
            this.matBr.Location = new System.Drawing.Point(12, 65);
            this.matBr.Name = "matBr";
            this.matBr.Size = new System.Drawing.Size(259, 20);
            this.matBr.TabIndex = 0;
            this.matBr.Text = "matBr";
            // 
            // telefon
            // 
            this.telefon.Location = new System.Drawing.Point(12, 91);
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(259, 20);
            this.telefon.TabIndex = 0;
            this.telefon.Text = "telefon";
            // 
            // grad
            // 
            this.grad.Location = new System.Drawing.Point(12, 117);
            this.grad.Name = "grad";
            this.grad.Size = new System.Drawing.Size(259, 20);
            this.grad.TabIndex = 0;
            this.grad.Text = "grad";
            // 
            // adresa
            // 
            this.adresa.Location = new System.Drawing.Point(12, 143);
            this.adresa.Name = "adresa";
            this.adresa.Size = new System.Drawing.Size(259, 20);
            this.adresa.TabIndex = 0;
            this.adresa.Text = "adresa";
            // 
            // btnSubmit
            // 
            this.btnSubmit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSubmit.Location = new System.Drawing.Point(104, 193);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Dodaj_nEkonomistu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.adresa);
            this.Controls.Add(this.grad);
            this.Controls.Add(this.telefon);
            this.Controls.Add(this.matBr);
            this.Controls.Add(this.prezime);
            this.Controls.Add(this.ime);
            this.Name = "Dodaj_nEkonomistu";
            this.Text = "Dodaj_nEkonomistu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ime;
        private System.Windows.Forms.TextBox prezime;
        private System.Windows.Forms.TextBox matBr;
        private System.Windows.Forms.TextBox telefon;
        private System.Windows.Forms.TextBox grad;
        private System.Windows.Forms.TextBox adresa;
        private System.Windows.Forms.Button btnSubmit;
    }
}