
namespace ParkingServis.Forms.Save_forms
{
    partial class SaveUlicno_mesto
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
            this.txtUlica = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtZ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtZauzetost = new System.Windows.Forms.TextBox();
            this.Zauzetost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(314, 201);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 52);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Zapamti";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtUlica
            // 
            this.txtUlica.Location = new System.Drawing.Point(213, 81);
            this.txtUlica.Name = "txtUlica";
            this.txtUlica.Size = new System.Drawing.Size(201, 26);
            this.txtUlica.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ulica:";
            // 
            // txtZ
            // 
            this.txtZ.Location = new System.Drawing.Point(213, 37);
            this.txtZ.Name = "txtZ";
            this.txtZ.Size = new System.Drawing.Size(201, 26);
            this.txtZ.TabIndex = 13;
            this.txtZ.TextChanged += new System.EventHandler(this.txtZ_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID zone:";
            // 
            // txtZauzetost
            // 
            this.txtZauzetost.Location = new System.Drawing.Point(213, 139);
            this.txtZauzetost.Name = "txtZauzetost";
            this.txtZauzetost.Size = new System.Drawing.Size(201, 26);
            this.txtZauzetost.TabIndex = 17;
            // 
            // Zauzetost
            // 
            this.Zauzetost.AutoSize = true;
            this.Zauzetost.Location = new System.Drawing.Point(41, 145);
            this.Zauzetost.Name = "Zauzetost";
            this.Zauzetost.Size = new System.Drawing.Size(85, 20);
            this.Zauzetost.TabIndex = 16;
            this.Zauzetost.Text = "Zauzetost:";
            // 
            // SaveUlicno_mesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(633, 329);
            this.Controls.Add(this.txtZauzetost);
            this.Controls.Add(this.Zauzetost);
            this.Controls.Add(this.txtUlica);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtZ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Name = "SaveUlicno_mesto";
            this.Text = "Ulično mesto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtUlica;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtZ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtZauzetost;
        private System.Windows.Forms.Label Zauzetost;
    }
}