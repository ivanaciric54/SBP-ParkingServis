
namespace ParkingServis.Forms.Load_forms
{
    partial class LoadJavna_garaza
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnLoadJavnaGraza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unesite ID javne garaže:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(289, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnLoadJavnaGraza
            // 
            this.btnLoadJavnaGraza.Location = new System.Drawing.Point(289, 109);
            this.btnLoadJavnaGraza.Name = "btnLoadJavnaGraza";
            this.btnLoadJavnaGraza.Size = new System.Drawing.Size(96, 40);
            this.btnLoadJavnaGraza.TabIndex = 6;
            this.btnLoadJavnaGraza.Text = "Prikaži";
            this.btnLoadJavnaGraza.UseVisualStyleBackColor = true;
            this.btnLoadJavnaGraza.Click += new System.EventHandler(this.btnLoadJavnaGraza_Click);
            // 
            // LoadJavna_garaza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoadJavnaGraza);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "LoadJavna_garaza";
            this.Text = "Javna garaža";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnLoadJavnaGraza;
    }
}