
namespace ParkingServis.Forms.Save_forms
{
    partial class SavePretplatna
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
            this.txtDO = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtZona = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(321, 338);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 52);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Zapamti";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDO
            // 
            this.txtDO.Location = new System.Drawing.Point(220, 179);
            this.txtDO.Name = "txtDO";
            this.txtDO.Size = new System.Drawing.Size(201, 26);
            this.txtDO.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Do:";
            // 
            // txtOD
            // 
            this.txtOD.Location = new System.Drawing.Point(220, 134);
            this.txtOD.Name = "txtOD";
            this.txtOD.Size = new System.Drawing.Size(201, 26);
            this.txtOD.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Od:";
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(220, 86);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(201, 26);
            this.txtDatum.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Datum:";
            // 
            // txtK
            // 
            this.txtK.Location = new System.Drawing.Point(220, 42);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(201, 26);
            this.txtK.TabIndex = 13;
            this.txtK.TextChanged += new System.EventHandler(this.txtK_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Klijenta:";
            // 
            // txtZona
            // 
            this.txtZona.Location = new System.Drawing.Point(220, 231);
            this.txtZona.Name = "txtZona";
            this.txtZona.Size = new System.Drawing.Size(201, 26);
            this.txtZona.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Zona:";
            // 
            // txtV
            // 
            this.txtV.Location = new System.Drawing.Point(220, 286);
            this.txtV.Name = "txtV";
            this.txtV.Size = new System.Drawing.Size(201, 26);
            this.txtV.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Vozilo:";
            // 
            // SavePretplatna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(644, 436);
            this.Controls.Add(this.txtV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtZona);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Name = "SavePretplatna";
            this.Text = "Pretplatna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtDO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtZona;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtV;
        private System.Windows.Forms.Label label6;
    }
}