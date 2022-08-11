
namespace ParkingServis.Forms.Change_forms
{
    partial class ChangeZakup
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
            this.txtDO = new System.Windows.Forms.TextBox();
            this.txtOD = new System.Windows.Forms.TextBox();
            this.prezime = new System.Windows.Forms.Label();
            this.ime_roditelja = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDO
            // 
            this.txtDO.Location = new System.Drawing.Point(258, 130);
            this.txtDO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDO.Name = "txtDO";
            this.txtDO.Size = new System.Drawing.Size(148, 26);
            this.txtDO.TabIndex = 57;
            // 
            // txtOD
            // 
            this.txtOD.Location = new System.Drawing.Point(258, 75);
            this.txtOD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOD.Name = "txtOD";
            this.txtOD.Size = new System.Drawing.Size(148, 26);
            this.txtOD.TabIndex = 56;
            // 
            // prezime
            // 
            this.prezime.AutoSize = true;
            this.prezime.Location = new System.Drawing.Point(69, 130);
            this.prezime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prezime.Name = "prezime";
            this.prezime.Size = new System.Drawing.Size(66, 20);
            this.prezime.TabIndex = 49;
            this.prezime.Text = "Važi do:";
            // 
            // ime_roditelja
            // 
            this.ime_roditelja.AutoSize = true;
            this.ime_roditelja.Location = new System.Drawing.Point(68, 75);
            this.ime_roditelja.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ime_roditelja.Name = "ime_roditelja";
            this.ime_roditelja.Size = new System.Drawing.Size(66, 20);
            this.ime_roditelja.TabIndex = 48;
            this.ime_roditelja.Text = "Važi od:";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(440, 206);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(100, 52);
            this.btnChange.TabIndex = 43;
            this.btnChange.Text = "Izmeni";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // ChangeZakup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(705, 335);
            this.Controls.Add(this.txtDO);
            this.Controls.Add(this.txtOD);
            this.Controls.Add(this.prezime);
            this.Controls.Add(this.ime_roditelja);
            this.Controls.Add(this.btnChange);
            this.Name = "ChangeZakup";
            this.Text = "Zakup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDO;
        private System.Windows.Forms.TextBox txtOD;
        private System.Windows.Forms.Label prezime;
        private System.Windows.Forms.Label ime_roditelja;
        private System.Windows.Forms.Button btnChange;
    }
}