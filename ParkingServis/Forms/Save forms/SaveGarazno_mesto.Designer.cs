
namespace ParkingServis.Forms.Save_forms
{
    partial class SaveGarazno_mesto
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
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNivo = new System.Windows.Forms.TextBox();
            this.txtRedniBroj = new System.Windows.Forms.TextBox();
            this.txtParking = new System.Windows.Forms.TextBox();
            this.txtZauzetost = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(291, 322);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 52);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Zapamti";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nivo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Redni broj:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Parking:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Zauzetost:";
            // 
            // txtNivo
            // 
            this.txtNivo.Location = new System.Drawing.Point(190, 44);
            this.txtNivo.Name = "txtNivo";
            this.txtNivo.Size = new System.Drawing.Size(201, 26);
            this.txtNivo.TabIndex = 8;
            this.txtNivo.TextChanged += new System.EventHandler(this.txtNivo_TextChanged);
            // 
            // txtRedniBroj
            // 
            this.txtRedniBroj.Location = new System.Drawing.Point(190, 113);
            this.txtRedniBroj.Name = "txtRedniBroj";
            this.txtRedniBroj.Size = new System.Drawing.Size(201, 26);
            this.txtRedniBroj.TabIndex = 9;
            this.txtRedniBroj.TextChanged += new System.EventHandler(this.txtRedniBroj_TextChanged);
            // 
            // txtParking
            // 
            this.txtParking.Location = new System.Drawing.Point(190, 184);
            this.txtParking.Name = "txtParking";
            this.txtParking.Size = new System.Drawing.Size(201, 26);
            this.txtParking.TabIndex = 10;
            this.txtParking.TextChanged += new System.EventHandler(this.txtParking_TextChanged);
            // 
            // txtZauzetost
            // 
            this.txtZauzetost.Location = new System.Drawing.Point(190, 258);
            this.txtZauzetost.Name = "txtZauzetost";
            this.txtZauzetost.Size = new System.Drawing.Size(201, 26);
            this.txtZauzetost.TabIndex = 11;
            this.txtZauzetost.TextChanged += new System.EventHandler(this.txtZauzetost_TextChanged);
            // 
            // SaveGarazno_mesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(525, 432);
            this.Controls.Add(this.txtZauzetost);
            this.Controls.Add(this.txtParking);
            this.Controls.Add(this.txtRedniBroj);
            this.Controls.Add(this.txtNivo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Name = "SaveGarazno_mesto";
            this.Text = "Garažno mesto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNivo;
        private System.Windows.Forms.TextBox txtRedniBroj;
        private System.Windows.Forms.TextBox txtParking;
        private System.Windows.Forms.TextBox txtZauzetost;
    }
}