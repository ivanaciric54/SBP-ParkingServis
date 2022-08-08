
namespace ParkingServis.Forms.Change_forms
{
    partial class ChangeParking
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
            this.txtVremeDO = new System.Windows.Forms.TextBox();
            this.txtVremeOD = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtBrM = new System.Windows.Forms.TextBox();
            this.txtZona = new System.Windows.Forms.TextBox();
            this.radno_vreme_do = new System.Windows.Forms.Label();
            this.radno_vreme_od = new System.Windows.Forms.Label();
            this.naziv = new System.Windows.Forms.Label();
            this.adresa = new System.Windows.Forms.Label();
            this.br_mesta = new System.Windows.Forms.Label();
            this.zona = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtVremeDO
            // 
            this.txtVremeDO.Location = new System.Drawing.Point(315, 348);
            this.txtVremeDO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVremeDO.Name = "txtVremeDO";
            this.txtVremeDO.Size = new System.Drawing.Size(148, 26);
            this.txtVremeDO.TabIndex = 33;
            // 
            // txtVremeOD
            // 
            this.txtVremeOD.Location = new System.Drawing.Point(315, 288);
            this.txtVremeOD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVremeOD.Name = "txtVremeOD";
            this.txtVremeOD.Size = new System.Drawing.Size(148, 26);
            this.txtVremeOD.TabIndex = 32;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(315, 229);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(148, 26);
            this.txtNaziv.TabIndex = 31;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(315, 174);
            this.txtAdresa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(148, 26);
            this.txtAdresa.TabIndex = 30;
            // 
            // txtBrM
            // 
            this.txtBrM.Location = new System.Drawing.Point(315, 114);
            this.txtBrM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBrM.Name = "txtBrM";
            this.txtBrM.Size = new System.Drawing.Size(148, 26);
            this.txtBrM.TabIndex = 29;
            this.txtBrM.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtZona
            // 
            this.txtZona.Location = new System.Drawing.Point(315, 60);
            this.txtZona.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtZona.Name = "txtZona";
            this.txtZona.Size = new System.Drawing.Size(148, 26);
            this.txtZona.TabIndex = 28;
            this.txtZona.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // radno_vreme_do
            // 
            this.radno_vreme_do.AutoSize = true;
            this.radno_vreme_do.Location = new System.Drawing.Point(108, 359);
            this.radno_vreme_do.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.radno_vreme_do.Name = "radno_vreme_do";
            this.radno_vreme_do.Size = new System.Drawing.Size(133, 20);
            this.radno_vreme_do.TabIndex = 27;
            this.radno_vreme_do.Text = "radno_vreme_do:";
            // 
            // radno_vreme_od
            // 
            this.radno_vreme_od.AutoSize = true;
            this.radno_vreme_od.Location = new System.Drawing.Point(108, 299);
            this.radno_vreme_od.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.radno_vreme_od.Name = "radno_vreme_od";
            this.radno_vreme_od.Size = new System.Drawing.Size(133, 20);
            this.radno_vreme_od.TabIndex = 26;
            this.radno_vreme_od.Text = "radno_vreme_od:";
            // 
            // naziv
            // 
            this.naziv.AutoSize = true;
            this.naziv.Location = new System.Drawing.Point(191, 240);
            this.naziv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.naziv.Name = "naziv";
            this.naziv.Size = new System.Drawing.Size(49, 20);
            this.naziv.TabIndex = 25;
            this.naziv.Text = "naziv:";
            // 
            // adresa
            // 
            this.adresa.AutoSize = true;
            this.adresa.Location = new System.Drawing.Point(180, 185);
            this.adresa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.adresa.Name = "adresa";
            this.adresa.Size = new System.Drawing.Size(62, 20);
            this.adresa.TabIndex = 24;
            this.adresa.Text = "adresa:";
            // 
            // br_mesta
            // 
            this.br_mesta.AutoSize = true;
            this.br_mesta.Location = new System.Drawing.Point(163, 125);
            this.br_mesta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.br_mesta.Name = "br_mesta";
            this.br_mesta.Size = new System.Drawing.Size(80, 20);
            this.br_mesta.TabIndex = 23;
            this.br_mesta.Text = "br_mesta:";
            // 
            // zona
            // 
            this.zona.AutoSize = true;
            this.zona.Location = new System.Drawing.Point(193, 71);
            this.zona.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.zona.Name = "zona";
            this.zona.Size = new System.Drawing.Size(48, 20);
            this.zona.TabIndex = 22;
            this.zona.Text = "zona:";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(611, 359);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(100, 52);
            this.btnChange.TabIndex = 19;
            this.btnChange.Text = "Izmeni";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // ChangeParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtVremeDO);
            this.Controls.Add(this.txtVremeOD);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.txtBrM);
            this.Controls.Add(this.txtZona);
            this.Controls.Add(this.radno_vreme_do);
            this.Controls.Add(this.radno_vreme_od);
            this.Controls.Add(this.naziv);
            this.Controls.Add(this.adresa);
            this.Controls.Add(this.br_mesta);
            this.Controls.Add(this.zona);
            this.Controls.Add(this.btnChange);
            this.Name = "ChangeParking";
            this.Text = "Parking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVremeDO;
        private System.Windows.Forms.TextBox txtVremeOD;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtBrM;
        private System.Windows.Forms.TextBox txtZona;
        private System.Windows.Forms.Label radno_vreme_do;
        private System.Windows.Forms.Label radno_vreme_od;
        private System.Windows.Forms.Label naziv;
        private System.Windows.Forms.Label adresa;
        private System.Windows.Forms.Label br_mesta;
        private System.Windows.Forms.Label zona;
        private System.Windows.Forms.Button btnChange;
    }
}