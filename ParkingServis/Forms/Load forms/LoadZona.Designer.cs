﻿
namespace ParkingServis.Forms.Load_forms
{
    partial class LoadZona
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
            this.btnLoadZona = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unesite ID zone:";
            // 
            // btnLoadZona
            // 
            this.btnLoadZona.Location = new System.Drawing.Point(249, 96);
            this.btnLoadZona.Name = "btnLoadZona";
            this.btnLoadZona.Size = new System.Drawing.Size(89, 38);
            this.btnLoadZona.TabIndex = 3;
            this.btnLoadZona.Text = "Prikaži";
            this.btnLoadZona.UseVisualStyleBackColor = true;
            this.btnLoadZona.Click += new System.EventHandler(this.btnLoadZona_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(249, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(105, 26);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LoadZona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(561, 215);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnLoadZona);
            this.Controls.Add(this.label1);
            this.Name = "LoadZona";
            this.Text = "Zona";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoadZona;
        private System.Windows.Forms.TextBox textBox1;
    }
}