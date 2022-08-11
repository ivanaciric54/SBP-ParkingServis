
namespace ParkingServis
{
    partial class Form1
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
            this.izborEntitetaBox = new System.Windows.Forms.ComboBox();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // izborEntitetaBox
            // 
            this.izborEntitetaBox.FormattingEnabled = true;
            this.izborEntitetaBox.Items.AddRange(new object[] {
            "Pravno lice",
            "Fizičko lice",
            "Pretplatna",
            "Jednokratna",
            "Garažno mesto",
            "Ulično mesto",
            "Parking",
            "Javna garaža",
            "Vozilo",
            "Telefon",
            "Zakup",
            "Zona"});
            this.izborEntitetaBox.Location = new System.Drawing.Point(70, 70);
            this.izborEntitetaBox.Name = "izborEntitetaBox";
            this.izborEntitetaBox.Size = new System.Drawing.Size(419, 28);
            this.izborEntitetaBox.TabIndex = 19;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(347, 215);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(142, 46);
            this.btnPrikazi.TabIndex = 21;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 367);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.izborEntitetaBox);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Parking Servis";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox izborEntitetaBox;
        private System.Windows.Forms.Button btnPrikazi;
    }
}

