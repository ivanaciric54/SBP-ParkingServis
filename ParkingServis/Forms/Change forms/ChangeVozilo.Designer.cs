
namespace ParkingServis.Forms.Change_forms
{
    partial class ChangeVozilo
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRegistracija = new System.Windows.Forms.TextBox();
            this.txtBrojSaobracajne = new System.Windows.Forms.TextBox();
            this.txtProizvodjac = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.chkRegistracija = new System.Windows.Forms.CheckBox();
            this.chkBrojSaobracajne = new System.Windows.Forms.CheckBox();
            this.chkProizvodjac = new System.Windows.Forms.CheckBox();
            this.chkModel = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(266, 311);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(100, 52);
            this.btnChange.TabIndex = 1;
            this.btnChange.Text = "Izmeni";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(207, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 26);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Unesi ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Registracija:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Broj saobraćajne:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Proizvođač:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Model:";
            // 
            // txtRegistracija
            // 
            this.txtRegistracija.Location = new System.Drawing.Point(207, 91);
            this.txtRegistracija.Name = "txtRegistracija";
            this.txtRegistracija.Size = new System.Drawing.Size(159, 26);
            this.txtRegistracija.TabIndex = 10;
            // 
            // txtBrojSaobracajne
            // 
            this.txtBrojSaobracajne.Location = new System.Drawing.Point(207, 150);
            this.txtBrojSaobracajne.Name = "txtBrojSaobracajne";
            this.txtBrojSaobracajne.Size = new System.Drawing.Size(159, 26);
            this.txtBrojSaobracajne.TabIndex = 11;
            this.txtBrojSaobracajne.TextChanged += new System.EventHandler(this.txtBrojSaobracajne_TextChanged);
            // 
            // txtProizvodjac
            // 
            this.txtProizvodjac.Location = new System.Drawing.Point(207, 197);
            this.txtProizvodjac.Name = "txtProizvodjac";
            this.txtProizvodjac.Size = new System.Drawing.Size(159, 26);
            this.txtProizvodjac.TabIndex = 12;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(207, 249);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(159, 26);
            this.txtModel.TabIndex = 13;
            // 
            // chkRegistracija
            // 
            this.chkRegistracija.AutoSize = true;
            this.chkRegistracija.Location = new System.Drawing.Point(388, 98);
            this.chkRegistracija.Name = "chkRegistracija";
            this.chkRegistracija.Size = new System.Drawing.Size(22, 21);
            this.chkRegistracija.TabIndex = 14;
            this.chkRegistracija.UseVisualStyleBackColor = true;
            this.chkRegistracija.CheckedChanged += new System.EventHandler(this.chkRegistacija_CheckedChanged);
            // 
            // chkBrojSaobracajne
            // 
            this.chkBrojSaobracajne.AutoSize = true;
            this.chkBrojSaobracajne.Location = new System.Drawing.Point(388, 155);
            this.chkBrojSaobracajne.Name = "chkBrojSaobracajne";
            this.chkBrojSaobracajne.Size = new System.Drawing.Size(22, 21);
            this.chkBrojSaobracajne.TabIndex = 15;
            this.chkBrojSaobracajne.UseVisualStyleBackColor = true;
            this.chkBrojSaobracajne.CheckedChanged += new System.EventHandler(this.chkBrojSaobracajne_CheckedChanged);
            // 
            // chkProizvodjac
            // 
            this.chkProizvodjac.AutoSize = true;
            this.chkProizvodjac.Location = new System.Drawing.Point(388, 204);
            this.chkProizvodjac.Name = "chkProizvodjac";
            this.chkProizvodjac.Size = new System.Drawing.Size(22, 21);
            this.chkProizvodjac.TabIndex = 16;
            this.chkProizvodjac.UseVisualStyleBackColor = true;
            this.chkProizvodjac.CheckedChanged += new System.EventHandler(this.chkProizvodjac_CheckedChanged);
            // 
            // chkModel
            // 
            this.chkModel.AutoSize = true;
            this.chkModel.Location = new System.Drawing.Point(388, 254);
            this.chkModel.Name = "chkModel";
            this.chkModel.Size = new System.Drawing.Size(22, 21);
            this.chkModel.TabIndex = 17;
            this.chkModel.UseVisualStyleBackColor = true;
            this.chkModel.CheckedChanged += new System.EventHandler(this.chkModel_CheckedChanged);
            // 
            // ChangeVozilo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(535, 450);
            this.Controls.Add(this.chkModel);
            this.Controls.Add(this.chkProizvodjac);
            this.Controls.Add(this.chkBrojSaobracajne);
            this.Controls.Add(this.chkRegistracija);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtProizvodjac);
            this.Controls.Add(this.txtBrojSaobracajne);
            this.Controls.Add(this.txtRegistracija);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChange);
            this.Name = "ChangeVozilo";
            this.Text = "Vozilo";
            this.Load += new System.EventHandler(this.ChangeVozilo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRegistracija;
        private System.Windows.Forms.TextBox txtBrojSaobracajne;
        private System.Windows.Forms.TextBox txtProizvodjac;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.CheckBox chkRegistracija;
        private System.Windows.Forms.CheckBox chkBrojSaobracajne;
        private System.Windows.Forms.CheckBox chkProizvodjac;
        private System.Windows.Forms.CheckBox chkModel;
    }
}