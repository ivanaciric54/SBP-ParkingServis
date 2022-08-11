
namespace ParkingServis.Forms.Change_forms
{
    partial class ChangePretplatna
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
            this.txtDO = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(491, 184);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(100, 52);
            this.btnChange.TabIndex = 1;
            this.btnChange.Text = "Izmeni";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // txtDO
            // 
            this.txtDO.Location = new System.Drawing.Point(222, 101);
            this.txtDO.Name = "txtDO";
            this.txtDO.Size = new System.Drawing.Size(201, 26);
            this.txtDO.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Do:";
            // 
            // txtOD
            // 
            this.txtOD.Location = new System.Drawing.Point(222, 56);
            this.txtOD.Name = "txtOD";
            this.txtOD.Size = new System.Drawing.Size(201, 26);
            this.txtOD.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Od:";
            // 
            // ChangePretplatna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(685, 285);
            this.Controls.Add(this.txtDO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnChange);
            this.Name = "ChangePretplatna";
            this.Text = "Pretplatna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.TextBox txtDO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOD;
        private System.Windows.Forms.Label label3;
    }
}