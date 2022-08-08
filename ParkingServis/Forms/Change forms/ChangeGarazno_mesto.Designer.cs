
namespace ParkingServis.Forms.Change_forms
{
    partial class ChangeGarazno_mesto
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
            this.btnChange = new System.Windows.Forms.Button();
            this.txtZauzetost = new System.Windows.Forms.TextBox();
            this.txtParking = new System.Windows.Forms.TextBox();
            this.txtRedniBroj = new System.Windows.Forms.TextBox();
            this.txtNivo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(547, 296);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(100, 52);
            this.btnChange.TabIndex = 1;
            this.btnChange.Text = "Izmeni";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // txtZauzetost
            // 
            this.txtZauzetost.Location = new System.Drawing.Point(193, 260);
            this.txtZauzetost.Name = "txtZauzetost";
            this.txtZauzetost.Size = new System.Drawing.Size(201, 26);
            this.txtZauzetost.TabIndex = 19;
            // 
            // txtParking
            // 
            this.txtParking.Location = new System.Drawing.Point(193, 45);
            this.txtParking.Name = "txtParking";
            this.txtParking.Size = new System.Drawing.Size(201, 26);
            this.txtParking.TabIndex = 18;
            // 
            // txtRedniBroj
            // 
            this.txtRedniBroj.Location = new System.Drawing.Point(193, 189);
            this.txtRedniBroj.Name = "txtRedniBroj";
            this.txtRedniBroj.Size = new System.Drawing.Size(201, 26);
            this.txtRedniBroj.TabIndex = 17;
            // 
            // txtNivo
            // 
            this.txtNivo.Location = new System.Drawing.Point(193, 120);
            this.txtNivo.Name = "txtNivo";
            this.txtNivo.Size = new System.Drawing.Size(201, 26);
            this.txtNivo.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Zauzetost:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Parking:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Redni broj:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nivo:";
            // 
            // ChangeGarazno_mesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(707, 427);
            this.Controls.Add(this.txtZauzetost);
            this.Controls.Add(this.txtParking);
            this.Controls.Add(this.txtRedniBroj);
            this.Controls.Add(this.txtNivo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChange);
            this.Name = "ChangeGarazno_mesto";
            this.Text = "Garažno mesto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.TextBox txtZauzetost;
        private System.Windows.Forms.TextBox txtParking;
        private System.Windows.Forms.TextBox txtRedniBroj;
        private System.Windows.Forms.TextBox txtNivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}