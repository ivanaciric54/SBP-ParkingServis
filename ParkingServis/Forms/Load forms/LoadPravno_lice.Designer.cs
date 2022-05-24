
namespace ParkingServis
{
    partial class LoadPravno_lice
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
            this.btnLoadPravnoLice = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unesite ID pravnog lica:";
            // 
            // btnLoadPravnoLice
            // 
            this.btnLoadPravnoLice.Location = new System.Drawing.Point(245, 96);
            this.btnLoadPravnoLice.Name = "btnLoadPravnoLice";
            this.btnLoadPravnoLice.Size = new System.Drawing.Size(89, 38);
            this.btnLoadPravnoLice.TabIndex = 3;
            this.btnLoadPravnoLice.Text = "Prikaži";
            this.btnLoadPravnoLice.UseVisualStyleBackColor = true;
            this.btnLoadPravnoLice.Click += new System.EventHandler(this.btnLoadPravnoLice_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(245, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LoadPravno_lice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(568, 168);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnLoadPravnoLice);
            this.Controls.Add(this.label1);
            this.Name = "LoadPravno_lice";
            this.Text = "Pravno lice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoadPravnoLice;
        private System.Windows.Forms.TextBox textBox1;
    }
}