
namespace ParkingServis.Forms.Load_forms
{
    partial class LoadZakup
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnLoadZakup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(242, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnLoadZakup
            // 
            this.btnLoadZakup.Location = new System.Drawing.Point(242, 74);
            this.btnLoadZakup.Name = "btnLoadZakup";
            this.btnLoadZakup.Size = new System.Drawing.Size(89, 38);
            this.btnLoadZakup.TabIndex = 7;
            this.btnLoadZakup.Text = "Prikaži";
            this.btnLoadZakup.UseVisualStyleBackColor = true;
            this.btnLoadZakup.Click += new System.EventHandler(this.btnLoadZakup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Unesite ID zakupa:";
            // 
            // LoadZakup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(608, 172);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnLoadZakup);
            this.Controls.Add(this.label1);
            this.Name = "LoadZakup";
            this.Text = "LoadZakup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnLoadZakup;
        private System.Windows.Forms.Label label1;
    }
}