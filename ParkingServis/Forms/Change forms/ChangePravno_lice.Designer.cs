
namespace ParkingServis.Forms.Change_forms
{
    partial class ChangePravno_lice
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
            this.btnChange = new System.Windows.Forms.Button();
            this.txtOL = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtPIB = new System.Windows.Forms.TextBox();
            this.Ovlasceno_lice = new System.Windows.Forms.Label();
            this.Adresa = new System.Windows.Forms.Label();
            this.Naziv = new System.Windows.Forms.Label();
            this.PIB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(513, 200);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(100, 52);
            this.btnChange.TabIndex = 1;
            this.btnChange.Text = "Izmeni";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // txtOL
            // 
            this.txtOL.Location = new System.Drawing.Point(207, 221);
            this.txtOL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOL.Name = "txtOL";
            this.txtOL.Size = new System.Drawing.Size(148, 26);
            this.txtOL.TabIndex = 23;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(207, 161);
            this.txtAdresa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(148, 26);
            this.txtAdresa.TabIndex = 22;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(207, 104);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(148, 26);
            this.txtNaziv.TabIndex = 21;
            // 
            // txtPIB
            // 
            this.txtPIB.Location = new System.Drawing.Point(207, 48);
            this.txtPIB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPIB.Name = "txtPIB";
            this.txtPIB.Size = new System.Drawing.Size(148, 26);
            this.txtPIB.TabIndex = 20;
            this.txtPIB.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Ovlasceno_lice
            // 
            this.Ovlasceno_lice.AutoSize = true;
            this.Ovlasceno_lice.Location = new System.Drawing.Point(56, 232);
            this.Ovlasceno_lice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ovlasceno_lice.Name = "Ovlasceno_lice";
            this.Ovlasceno_lice.Size = new System.Drawing.Size(119, 20);
            this.Ovlasceno_lice.TabIndex = 19;
            this.Ovlasceno_lice.Text = "Ovlasceno_lice:";
            // 
            // Adresa
            // 
            this.Adresa.AutoSize = true;
            this.Adresa.Location = new System.Drawing.Point(116, 172);
            this.Adresa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Adresa.Name = "Adresa";
            this.Adresa.Size = new System.Drawing.Size(64, 20);
            this.Adresa.TabIndex = 18;
            this.Adresa.Text = "Adresa:";
            // 
            // Naziv
            // 
            this.Naziv.AutoSize = true;
            this.Naziv.Location = new System.Drawing.Point(125, 115);
            this.Naziv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Naziv.Name = "Naziv";
            this.Naziv.Size = new System.Drawing.Size(51, 20);
            this.Naziv.TabIndex = 17;
            this.Naziv.Text = "Naziv:";
            // 
            // PIB
            // 
            this.PIB.AutoSize = true;
            this.PIB.Location = new System.Drawing.Point(140, 58);
            this.PIB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PIB.Name = "PIB";
            this.PIB.Size = new System.Drawing.Size(39, 20);
            this.PIB.TabIndex = 16;
            this.PIB.Text = "PIB:";
            // 
            // ChangePravno_lice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(741, 314);
            this.Controls.Add(this.txtOL);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.txtPIB);
            this.Controls.Add(this.Ovlasceno_lice);
            this.Controls.Add(this.Adresa);
            this.Controls.Add(this.Naziv);
            this.Controls.Add(this.PIB);
            this.Controls.Add(this.btnChange);
            this.Name = "ChangePravno_lice";
            this.Text = "Pravno lice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.TextBox txtOL;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtPIB;
        private System.Windows.Forms.Label Ovlasceno_lice;
        private System.Windows.Forms.Label Adresa;
        private System.Windows.Forms.Label Naziv;
        private System.Windows.Forms.Label PIB;
    }
}