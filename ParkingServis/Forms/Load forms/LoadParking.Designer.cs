
namespace ParkingServis.Forms.Load_forms
{
    partial class LoadParking
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
            this.btnLoadParking = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unesite ID parking:";
            // 
            // btnLoadParking
            // 
            this.btnLoadParking.Location = new System.Drawing.Point(255, 108);
            this.btnLoadParking.Name = "btnLoadParking";
            this.btnLoadParking.Size = new System.Drawing.Size(89, 38);
            this.btnLoadParking.TabIndex = 3;
            this.btnLoadParking.Text = "Prikaži";
            this.btnLoadParking.UseVisualStyleBackColor = true;
            this.btnLoadParking.Click += new System.EventHandler(this.btnLoadParking_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(255, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LoadParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnLoadParking);
            this.Controls.Add(this.label1);
            this.Name = "LoadParking";
            this.Text = "Parking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoadParking;
        private System.Windows.Forms.TextBox textBox1;
    }
}