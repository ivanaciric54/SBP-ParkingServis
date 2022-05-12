
namespace ParkingServis.Forms.Load_forms
{
    partial class LoadOdnosi_se_na_P
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
            this.btnLoadOndosi_se_na_P = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unesite ID odnosi se na P:";
            // 
            // btnLoadOndosi_se_na_P
            // 
            this.btnLoadOndosi_se_na_P.Location = new System.Drawing.Point(295, 118);
            this.btnLoadOndosi_se_na_P.Name = "btnLoadOndosi_se_na_P";
            this.btnLoadOndosi_se_na_P.Size = new System.Drawing.Size(89, 38);
            this.btnLoadOndosi_se_na_P.TabIndex = 3;
            this.btnLoadOndosi_se_na_P.Text = "Prikaži";
            this.btnLoadOndosi_se_na_P.UseVisualStyleBackColor = true;
            this.btnLoadOndosi_se_na_P.Click += new System.EventHandler(this.btnLoadOndosi_se_na_P_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(295, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LoadOdnosi_se_na_P
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnLoadOndosi_se_na_P);
            this.Controls.Add(this.label1);
            this.Name = "LoadOdnosi_se_na_P";
            this.Text = "Odnosi se na P";
            this.Load += new System.EventHandler(this.LoadOdnosi_se_na_P_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoadOndosi_se_na_P;
        private System.Windows.Forms.TextBox textBox1;
    }
}