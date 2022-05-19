
namespace ParkingServis.Forms.Save_forms
{
    partial class SaveVozilo
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
            this.btnSave = new System.Windows.Forms.Button();
            this.Registracija = new System.Windows.Forms.Label();
            this.Proizvodjac = new System.Windows.Forms.Label();
            this.ModelVozila = new System.Windows.Forms.Label();
            this.BrojSaobracajne = new System.Windows.Forms.Label();
            this.txtRegistracija = new System.Windows.Forms.TextBox();
            this.txtProizvodjac = new System.Windows.Forms.TextBox();
            this.txtModelVozila = new System.Windows.Forms.TextBox();
            this.txtSaobracajne = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(263, 297);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 52);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Zapamti";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Registracija
            // 
            this.Registracija.AutoSize = true;
            this.Registracija.Location = new System.Drawing.Point(57, 46);
            this.Registracija.Name = "Registracija";
            this.Registracija.Size = new System.Drawing.Size(96, 20);
            this.Registracija.TabIndex = 4;
            this.Registracija.Text = "Registracija:";
            // 
            // Proizvodjac
            // 
            this.Proizvodjac.AutoSize = true;
            this.Proizvodjac.Location = new System.Drawing.Point(57, 107);
            this.Proizvodjac.Name = "Proizvodjac";
            this.Proizvodjac.Size = new System.Drawing.Size(90, 20);
            this.Proizvodjac.TabIndex = 5;
            this.Proizvodjac.Text = "Proizvođač:";
            // 
            // ModelVozila
            // 
            this.ModelVozila.AutoSize = true;
            this.ModelVozila.Location = new System.Drawing.Point(57, 172);
            this.ModelVozila.Name = "ModelVozila";
            this.ModelVozila.Size = new System.Drawing.Size(99, 20);
            this.ModelVozila.TabIndex = 6;
            this.ModelVozila.Text = "Model vozila:";
            // 
            // BrojSaobracajne
            // 
            this.BrojSaobracajne.AutoSize = true;
            this.BrojSaobracajne.Location = new System.Drawing.Point(57, 235);
            this.BrojSaobracajne.Name = "BrojSaobracajne";
            this.BrojSaobracajne.Size = new System.Drawing.Size(132, 20);
            this.BrojSaobracajne.TabIndex = 7;
            this.BrojSaobracajne.Text = "Broj saobraćajne:";
            // 
            // txtRegistracija
            // 
            this.txtRegistracija.Location = new System.Drawing.Point(211, 40);
            this.txtRegistracija.Name = "txtRegistracija";
            this.txtRegistracija.Size = new System.Drawing.Size(152, 26);
            this.txtRegistracija.TabIndex = 8;
            // 
            // txtProizvodjac
            // 
            this.txtProizvodjac.Location = new System.Drawing.Point(211, 101);
            this.txtProizvodjac.Name = "txtProizvodjac";
            this.txtProizvodjac.Size = new System.Drawing.Size(152, 26);
            this.txtProizvodjac.TabIndex = 9;
            // 
            // txtModelVozila
            // 
            this.txtModelVozila.Location = new System.Drawing.Point(211, 166);
            this.txtModelVozila.Name = "txtModelVozila";
            this.txtModelVozila.Size = new System.Drawing.Size(152, 26);
            this.txtModelVozila.TabIndex = 10;
            // 
            // txtSaobracajne
            // 
            this.txtSaobracajne.Location = new System.Drawing.Point(211, 229);
            this.txtSaobracajne.Name = "txtSaobracajne";
            this.txtSaobracajne.Size = new System.Drawing.Size(152, 26);
            this.txtSaobracajne.TabIndex = 11;
            this.txtSaobracajne.TextChanged += new System.EventHandler(this.txtSaobracajne_TextChanged);
            // 
            // SaveVozilo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(443, 385);
            this.Controls.Add(this.txtSaobracajne);
            this.Controls.Add(this.txtModelVozila);
            this.Controls.Add(this.txtProizvodjac);
            this.Controls.Add(this.txtRegistracija);
            this.Controls.Add(this.BrojSaobracajne);
            this.Controls.Add(this.ModelVozila);
            this.Controls.Add(this.Proizvodjac);
            this.Controls.Add(this.Registracija);
            this.Controls.Add(this.btnSave);
            this.Name = "SaveVozilo";
            this.Text = "Vozilo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label Registracija;
        private System.Windows.Forms.Label Proizvodjac;
        private System.Windows.Forms.Label ModelVozila;
        private System.Windows.Forms.Label BrojSaobracajne;
        private System.Windows.Forms.TextBox txtRegistracija;
        private System.Windows.Forms.TextBox txtProizvodjac;
        private System.Windows.Forms.TextBox txtModelVozila;
        private System.Windows.Forms.TextBox txtSaobracajne;
    }
}