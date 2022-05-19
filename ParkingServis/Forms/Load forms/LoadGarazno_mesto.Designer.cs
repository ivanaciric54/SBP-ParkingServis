
namespace ParkingServis.Forms.Load_forms
{
    partial class LoadGarazno_mesto
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
            this.btnLoadGaraznoMesto = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unesite ID fizičkog lica:";
            // 
            // btnLoadGaraznoMesto
            // 
            this.btnLoadGaraznoMesto.Location = new System.Drawing.Point(306, 105);
            this.btnLoadGaraznoMesto.Name = "btnLoadGaraznoMesto";
            this.btnLoadGaraznoMesto.Size = new System.Drawing.Size(89, 38);
            this.btnLoadGaraznoMesto.TabIndex = 2;
            this.btnLoadGaraznoMesto.Text = "Prikaži";
            this.btnLoadGaraznoMesto.UseVisualStyleBackColor = true;
            this.btnLoadGaraznoMesto.Click += new System.EventHandler(this.btnLoadGaraznoMesto_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(306, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 26);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // LoadGarazno_mesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(621, 179);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnLoadGaraznoMesto);
            this.Controls.Add(this.label1);
            this.Name = "LoadGarazno_mesto";
            this.Text = "Garažno mesto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoadGaraznoMesto;
        private System.Windows.Forms.TextBox textBox1;
    }
}