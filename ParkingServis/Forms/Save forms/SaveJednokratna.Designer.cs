
namespace ParkingServis.Forms.Save_forms
{
    partial class SaveJednokratna
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
            this.txtVK = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDO = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(308, 282);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 52);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Zapamti";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtVK
            // 
            this.txtVK.Location = new System.Drawing.Point(207, 214);
            this.txtVK.Name = "txtVK";
            this.txtVK.Size = new System.Drawing.Size(201, 26);
            this.txtVK.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Vreme kontrole:";
            // 
            // txtDO
            // 
            this.txtDO.Location = new System.Drawing.Point(207, 167);
            this.txtDO.Name = "txtDO";
            this.txtDO.Size = new System.Drawing.Size(201, 26);
            this.txtDO.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Period parkiranja do:";
            // 
            // txtOD
            // 
            this.txtOD.Location = new System.Drawing.Point(207, 122);
            this.txtOD.Name = "txtOD";
            this.txtOD.Size = new System.Drawing.Size(201, 26);
            this.txtOD.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Period parkiranja od:";
            // 
            // txtV
            // 
            this.txtV.Location = new System.Drawing.Point(207, 74);
            this.txtV.Name = "txtV";
            this.txtV.Size = new System.Drawing.Size(201, 26);
            this.txtV.TabIndex = 19;
            this.txtV.TextChanged += new System.EventHandler(this.txtV_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "ID vozila:";
            // 
            // txtK
            // 
            this.txtK.Location = new System.Drawing.Point(207, 30);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(201, 26);
            this.txtK.TabIndex = 17;
            this.txtK.TextChanged += new System.EventHandler(this.txtK_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "ID klijenta:";
            // 
            // SaveJednokratna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(559, 393);
            this.Controls.Add(this.txtVK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Name = "SaveJednokratna";
            this.Text = "Jednokratna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtVK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.Label label1;
    }
}