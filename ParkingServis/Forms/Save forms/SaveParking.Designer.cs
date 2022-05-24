
namespace ParkingServis.Forms.Save_forms
{
    partial class SaveParking
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtOD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNAZIV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBRMesta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtADRESA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtZONA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(314, 318);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 52);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Zapamti";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDO
            // 
            this.txtDO.Location = new System.Drawing.Point(213, 263);
            this.txtDO.Name = "txtDO";
            this.txtDO.Size = new System.Drawing.Size(201, 26);
            this.txtDO.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Radno vreme od:";
            // 
            // txtOD
            // 
            this.txtOD.Location = new System.Drawing.Point(213, 213);
            this.txtOD.Name = "txtOD";
            this.txtOD.Size = new System.Drawing.Size(201, 26);
            this.txtOD.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Radno vreme od:";
            // 
            // txtNAZIV
            // 
            this.txtNAZIV.Location = new System.Drawing.Point(213, 166);
            this.txtNAZIV.Name = "txtNAZIV";
            this.txtNAZIV.Size = new System.Drawing.Size(201, 26);
            this.txtNAZIV.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Naziv:";
            // 
            // txtBRMesta
            // 
            this.txtBRMesta.Location = new System.Drawing.Point(213, 121);
            this.txtBRMesta.Name = "txtBRMesta";
            this.txtBRMesta.Size = new System.Drawing.Size(201, 26);
            this.txtBRMesta.TabIndex = 21;
            this.txtBRMesta.TextChanged += new System.EventHandler(this.txtBRMesta_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Broj mesta:";
            // 
            // txtADRESA
            // 
            this.txtADRESA.Location = new System.Drawing.Point(213, 73);
            this.txtADRESA.Name = "txtADRESA";
            this.txtADRESA.Size = new System.Drawing.Size(201, 26);
            this.txtADRESA.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Adresa:";
            // 
            // txtZONA
            // 
            this.txtZONA.Location = new System.Drawing.Point(213, 29);
            this.txtZONA.Name = "txtZONA";
            this.txtZONA.Size = new System.Drawing.Size(201, 26);
            this.txtZONA.TabIndex = 17;
            this.txtZONA.TextChanged += new System.EventHandler(this.txtZONA_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Zona:";
            // 
            // SaveParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(666, 416);
            this.Controls.Add(this.txtDO);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtOD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNAZIV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBRMesta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtADRESA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtZONA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Name = "SaveParking";
            this.Text = "Parking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtDO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNAZIV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBRMesta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtADRESA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtZONA;
        private System.Windows.Forms.Label label1;
    }
}