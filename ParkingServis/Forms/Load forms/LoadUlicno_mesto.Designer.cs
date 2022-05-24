
namespace ParkingServis.Forms.Load_forms
{
    partial class LoadUlicno_mesto
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
            this.btnLoadUlicnoMesto = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unesite ID uličnog mesta:";
            // 
            // btnLoadUlicnoMesto
            // 
            this.btnLoadUlicnoMesto.Location = new System.Drawing.Point(281, 99);
            this.btnLoadUlicnoMesto.Name = "btnLoadUlicnoMesto";
            this.btnLoadUlicnoMesto.Size = new System.Drawing.Size(89, 38);
            this.btnLoadUlicnoMesto.TabIndex = 3;
            this.btnLoadUlicnoMesto.Text = "Prikaži";
            this.btnLoadUlicnoMesto.UseVisualStyleBackColor = true;
            this.btnLoadUlicnoMesto.Click += new System.EventHandler(this.btnLoadUlicnoMesto_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(281, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LoadUlicno_mesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(631, 182);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnLoadUlicnoMesto);
            this.Controls.Add(this.label1);
            this.Name = "LoadUlicno_mesto";
            this.Text = "Ulično mesto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoadUlicnoMesto;
        private System.Windows.Forms.TextBox textBox1;
    }
}