
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
            this.registracija = new System.Windows.Forms.Label();
            this.br_saobracajne = new System.Windows.Forms.Label();
            this.proizvodjac = new System.Windows.Forms.Label();
            this.model = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(404, 206);
            this.btnChange.Margin = new System.Windows.Forms.Padding(2);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(67, 34);
            this.btnChange.TabIndex = 1;
            this.btnChange.Text = "Izmeni";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(154, 22);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Unesi ID:";
            // 
            // registracija
            // 
            this.registracija.AutoSize = true;
            this.registracija.Location = new System.Drawing.Point(56, 83);
            this.registracija.Name = "registracija";
            this.registracija.Size = new System.Drawing.Size(57, 13);
            this.registracija.TabIndex = 6;
            this.registracija.Text = "registracija";
            this.registracija.Click += new System.EventHandler(this.label2_Click);
            // 
            // br_saobracajne
            // 
            this.br_saobracajne.AutoSize = true;
            this.br_saobracajne.Location = new System.Drawing.Point(33, 124);
            this.br_saobracajne.Name = "br_saobracajne";
            this.br_saobracajne.Size = new System.Drawing.Size(80, 13);
            this.br_saobracajne.TabIndex = 7;
            this.br_saobracajne.Text = "br_saobracajne";
            // 
            // proizvodjac
            // 
            this.proizvodjac.AutoSize = true;
            this.proizvodjac.Location = new System.Drawing.Point(52, 175);
            this.proizvodjac.Name = "proizvodjac";
            this.proizvodjac.Size = new System.Drawing.Size(61, 13);
            this.proizvodjac.TabIndex = 8;
            this.proizvodjac.Text = "proizvodjac";
            // 
            // model
            // 
            this.model.AutoSize = true;
            this.model.Location = new System.Drawing.Point(78, 227);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(35, 13);
            this.model.TabIndex = 9;
            this.model.Text = "model";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(154, 76);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(154, 117);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 11;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(154, 168);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 12;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(154, 220);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 13;
            // 
            // ChangeVozilo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.model);
            this.Controls.Add(this.proizvodjac);
            this.Controls.Add(this.br_saobracajne);
            this.Controls.Add(this.registracija);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChange);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ChangeVozilo";
            this.Text = "Vozilo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label registracija;
        private System.Windows.Forms.Label br_saobracajne;
        private System.Windows.Forms.Label proizvodjac;
        private System.Windows.Forms.Label model;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
    }
}