
namespace ParkingServis.Forms.Load_forms
{
    partial class LoadKlijent
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
            this.btnLoadKlijent = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unesite ID klijenta:";
            // 
            // btnLoadKlijent
            // 
            this.btnLoadKlijent.Location = new System.Drawing.Point(237, 98);
            this.btnLoadKlijent.Name = "btnLoadKlijent";
            this.btnLoadKlijent.Size = new System.Drawing.Size(89, 38);
            this.btnLoadKlijent.TabIndex = 3;
            this.btnLoadKlijent.Text = "Prikaži";
            this.btnLoadKlijent.UseVisualStyleBackColor = true;
            this.btnLoadKlijent.Click += new System.EventHandler(this.btnLoadKlijent_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(237, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LoadKlijent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(606, 197);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnLoadKlijent);
            this.Controls.Add(this.label1);
            this.Name = "LoadKlijent";
            this.Text = "Klijent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoadKlijent;
        private System.Windows.Forms.TextBox textBox1;
    }
}