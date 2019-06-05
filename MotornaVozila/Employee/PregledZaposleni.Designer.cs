namespace MotornaVozila.Employee
{
    partial class PregledZaposleni
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
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.tbID = new System.Windows.Forms.TextBox();
            this.lbIme = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbPrezime = new System.Windows.Forms.Label();
            this.lbGodRadnogStaza = new System.Windows.Forms.Label();
            this.lbDatumZaposlenja = new System.Windows.Forms.Label();
            this.lbDatumRodjenja = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbDatumIstekaUgovora = new System.Windows.Forms.Label();
            this.lbStepenStSpreme = new System.Windows.Forms.Label();
            this.lbPlata = new System.Windows.Forms.Label();
            this.lbTipZaposlenog = new System.Windows.Forms.Label();
            this.lbTipUgovora = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Location = new System.Drawing.Point(197, 13);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(75, 23);
            this.btnPotvrdi.TabIndex = 0;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(13, 13);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(178, 20);
            this.tbID.TabIndex = 1;
            this.tbID.Text = "Unesite ID Zaposlenog";
            // 
            // lbIme
            // 
            this.lbIme.AutoSize = true;
            this.lbIme.Location = new System.Drawing.Point(6, 16);
            this.lbIme.Name = "lbIme";
            this.lbIme.Size = new System.Drawing.Size(27, 13);
            this.lbIme.TabIndex = 2;
            this.lbIme.Text = "Ime:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbTipUgovora);
            this.groupBox1.Controls.Add(this.lbTipZaposlenog);
            this.groupBox1.Controls.Add(this.lbPlata);
            this.groupBox1.Controls.Add(this.lbStepenStSpreme);
            this.groupBox1.Controls.Add(this.lbDatumIstekaUgovora);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbDatumRodjenja);
            this.groupBox1.Controls.Add(this.lbDatumZaposlenja);
            this.groupBox1.Controls.Add(this.lbGodRadnogStaza);
            this.groupBox1.Controls.Add(this.lbPrezime);
            this.groupBox1.Controls.Add(this.lbIme);
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 273);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci o Zaposlenom";
            // 
            // lbPrezime
            // 
            this.lbPrezime.AutoSize = true;
            this.lbPrezime.Location = new System.Drawing.Point(6, 39);
            this.lbPrezime.Name = "lbPrezime";
            this.lbPrezime.Size = new System.Drawing.Size(47, 13);
            this.lbPrezime.TabIndex = 3;
            this.lbPrezime.Text = "Prezime:";
            // 
            // lbGodRadnogStaza
            // 
            this.lbGodRadnogStaza.AutoSize = true;
            this.lbGodRadnogStaza.Location = new System.Drawing.Point(8, 62);
            this.lbGodRadnogStaza.Name = "lbGodRadnogStaza";
            this.lbGodRadnogStaza.Size = new System.Drawing.Size(115, 13);
            this.lbGodRadnogStaza.TabIndex = 3;
            this.lbGodRadnogStaza.Text = "Godine Radnog Staza:";
            // 
            // lbDatumZaposlenja
            // 
            this.lbDatumZaposlenja.AutoSize = true;
            this.lbDatumZaposlenja.Location = new System.Drawing.Point(6, 112);
            this.lbDatumZaposlenja.Name = "lbDatumZaposlenja";
            this.lbDatumZaposlenja.Size = new System.Drawing.Size(99, 13);
            this.lbDatumZaposlenja.TabIndex = 3;
            this.lbDatumZaposlenja.Text = "Datum Zaposlenja: ";
            // 
            // lbDatumRodjenja
            // 
            this.lbDatumRodjenja.AutoSize = true;
            this.lbDatumRodjenja.Location = new System.Drawing.Point(6, 85);
            this.lbDatumRodjenja.Name = "lbDatumRodjenja";
            this.lbDatumRodjenja.Size = new System.Drawing.Size(83, 13);
            this.lbDatumRodjenja.TabIndex = 3;
            this.lbDatumRodjenja.Text = "DatumRodjenja:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 3;
            // 
            // lbDatumIstekaUgovora
            // 
            this.lbDatumIstekaUgovora.AutoSize = true;
            this.lbDatumIstekaUgovora.Location = new System.Drawing.Point(6, 138);
            this.lbDatumIstekaUgovora.Name = "lbDatumIstekaUgovora";
            this.lbDatumIstekaUgovora.Size = new System.Drawing.Size(117, 13);
            this.lbDatumIstekaUgovora.TabIndex = 3;
            this.lbDatumIstekaUgovora.Text = "Datum Isteka Ugovora:";
            // 
            // lbStepenStSpreme
            // 
            this.lbStepenStSpreme.AutoSize = true;
            this.lbStepenStSpreme.Location = new System.Drawing.Point(6, 164);
            this.lbStepenStSpreme.Name = "lbStepenStSpreme";
            this.lbStepenStSpreme.Size = new System.Drawing.Size(123, 13);
            this.lbStepenStSpreme.TabIndex = 4;
            this.lbStepenStSpreme.Text = "Stepen Strucne Spreme:";
            // 
            // lbPlata
            // 
            this.lbPlata.AutoSize = true;
            this.lbPlata.Location = new System.Drawing.Point(8, 193);
            this.lbPlata.Name = "lbPlata";
            this.lbPlata.Size = new System.Drawing.Size(34, 13);
            this.lbPlata.TabIndex = 4;
            this.lbPlata.Text = "Plata:";
            // 
            // lbTipZaposlenog
            // 
            this.lbTipZaposlenog.AutoSize = true;
            this.lbTipZaposlenog.Location = new System.Drawing.Point(8, 222);
            this.lbTipZaposlenog.Name = "lbTipZaposlenog";
            this.lbTipZaposlenog.Size = new System.Drawing.Size(84, 13);
            this.lbTipZaposlenog.TabIndex = 5;
            this.lbTipZaposlenog.Text = "Tip Zaposlenog:";
            // 
            // lbTipUgovora
            // 
            this.lbTipUgovora.AutoSize = true;
            this.lbTipUgovora.Location = new System.Drawing.Point(8, 248);
            this.lbTipUgovora.Name = "lbTipUgovora";
            this.lbTipUgovora.Size = new System.Drawing.Size(66, 13);
            this.lbTipUgovora.TabIndex = 5;
            this.lbTipUgovora.Text = "TipUgovora:";
            // 
            // PregledZaposleni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 327);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.btnPotvrdi);
            this.Name = "PregledZaposleni";
            this.Text = "PregledZaposleni";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label lbIme;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbDatumIstekaUgovora;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbDatumRodjenja;
        private System.Windows.Forms.Label lbDatumZaposlenja;
        private System.Windows.Forms.Label lbGodRadnogStaza;
        private System.Windows.Forms.Label lbPrezime;
        private System.Windows.Forms.Label lbTipUgovora;
        private System.Windows.Forms.Label lbTipZaposlenog;
        private System.Windows.Forms.Label lbPlata;
        private System.Windows.Forms.Label lbStepenStSpreme;
    }
}