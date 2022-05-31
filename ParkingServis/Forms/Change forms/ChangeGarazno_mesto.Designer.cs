
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nivo = new System.Windows.Forms.Label();
            this.redni_br = new System.Windows.Forms.Label();
            this.id_parkinga = new System.Windows.Forms.Label();
            this.txtNivo = new System.Windows.Forms.TextBox();
            this.txtRedniBroj = new System.Windows.Forms.TextBox();
            this.txtParking = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(328, 133);
            this.btnChange.Margin = new System.Windows.Forms.Padding(2);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(67, 34);
            this.btnChange.TabIndex = 1;
            this.btnChange.Text = "Izmeni";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 46);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Unesi ID:";
            // 
            // nivo
            // 
            this.nivo.AutoSize = true;
            this.nivo.Location = new System.Drawing.Point(70, 84);
            this.nivo.Name = "nivo";
            this.nivo.Size = new System.Drawing.Size(30, 13);
            this.nivo.TabIndex = 6;
            this.nivo.Text = "nivo:";
            // 
            // redni_br
            // 
            this.redni_br.AutoSize = true;
            this.redni_br.Location = new System.Drawing.Point(52, 116);
            this.redni_br.Name = "redni_br";
            this.redni_br.Size = new System.Drawing.Size(48, 13);
            this.redni_br.TabIndex = 7;
            this.redni_br.Text = "redni_br:";
            // 
            // id_parkinga
            // 
            this.id_parkinga.AutoSize = true;
            this.id_parkinga.Location = new System.Drawing.Point(35, 147);
            this.id_parkinga.Name = "id_parkinga";
            this.id_parkinga.Size = new System.Drawing.Size(65, 13);
            this.id_parkinga.TabIndex = 8;
            this.id_parkinga.Text = "id_parkinga:";
            // 
            // txtNivo
            // 
            this.txtNivo.Location = new System.Drawing.Point(117, 84);
            this.txtNivo.Name = "txtNivo";
            this.txtNivo.Size = new System.Drawing.Size(100, 20);
            this.txtNivo.TabIndex = 9;
            this.txtNivo.TextChanged += new System.EventHandler(this.txtNivo_TextChanged);
            // 
            // txtRedniBroj
            // 
            this.txtRedniBroj.Location = new System.Drawing.Point(117, 116);
            this.txtRedniBroj.Name = "txtRedniBroj";
            this.txtRedniBroj.Size = new System.Drawing.Size(100, 20);
            this.txtRedniBroj.TabIndex = 10;
            this.txtRedniBroj.TextChanged += new System.EventHandler(this.txtRedniBroj_TextChanged);
            // 
            // txtParking
            // 
            this.txtParking.Location = new System.Drawing.Point(117, 147);
            this.txtParking.Name = "txtParking";
            this.txtParking.Size = new System.Drawing.Size(100, 20);
            this.txtParking.TabIndex = 11;
            this.txtParking.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // ChangeGarazno_mesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(465, 214);
            this.Controls.Add(this.txtParking);
            this.Controls.Add(this.txtRedniBroj);
            this.Controls.Add(this.txtNivo);
            this.Controls.Add(this.id_parkinga);
            this.Controls.Add(this.redni_br);
            this.Controls.Add(this.nivo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChange);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ChangeGarazno_mesto";
            this.Text = "Garažno mesto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nivo;
        private System.Windows.Forms.Label redni_br;
        private System.Windows.Forms.Label id_parkinga;
        private System.Windows.Forms.TextBox txtNivo;
        private System.Windows.Forms.TextBox txtRedniBroj;
        private System.Windows.Forms.TextBox txtParking;
    }
}