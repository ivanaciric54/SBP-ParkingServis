
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datum = new System.Windows.Forms.Label();
            this.period_vazenja_od = new System.Windows.Forms.Label();
            this.period_vazenja_do = new System.Windows.Forms.Label();
            this.id_klijenta = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(395, 183);
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
            this.textBox1.Location = new System.Drawing.Point(177, 33);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Unesi ID:";
            // 
            // datum
            // 
            this.datum.AutoSize = true;
            this.datum.Location = new System.Drawing.Point(91, 79);
            this.datum.Name = "datum";
            this.datum.Size = new System.Drawing.Size(39, 13);
            this.datum.TabIndex = 6;
            this.datum.Text = "datum:";
            this.datum.Click += new System.EventHandler(this.label2_Click);
            // 
            // period_vazenja_od
            // 
            this.period_vazenja_od.AutoSize = true;
            this.period_vazenja_od.Location = new System.Drawing.Point(30, 122);
            this.period_vazenja_od.Name = "period_vazenja_od";
            this.period_vazenja_od.Size = new System.Drawing.Size(100, 13);
            this.period_vazenja_od.TabIndex = 7;
            this.period_vazenja_od.Text = "period_vazenja_od:";
            // 
            // period_vazenja_do
            // 
            this.period_vazenja_do.AutoSize = true;
            this.period_vazenja_do.Location = new System.Drawing.Point(30, 165);
            this.period_vazenja_do.Name = "period_vazenja_do";
            this.period_vazenja_do.Size = new System.Drawing.Size(100, 13);
            this.period_vazenja_do.TabIndex = 8;
            this.period_vazenja_do.Text = "period_vazenja_do:";
            // 
            // id_klijenta
            // 
            this.id_klijenta.AutoSize = true;
            this.id_klijenta.Location = new System.Drawing.Point(73, 204);
            this.id_klijenta.Name = "id_klijenta";
            this.id_klijenta.Size = new System.Drawing.Size(57, 13);
            this.id_klijenta.TabIndex = 9;
            this.id_klijenta.Text = "id_klijenta:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(177, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(177, 115);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(177, 158);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 12;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(177, 197);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 13;
            // 
            // ChangePretplatna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(499, 254);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.id_klijenta);
            this.Controls.Add(this.period_vazenja_do);
            this.Controls.Add(this.period_vazenja_od);
            this.Controls.Add(this.datum);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChange);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ChangePretplatna";
            this.Text = "Pretplatna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label datum;
        private System.Windows.Forms.Label period_vazenja_od;
        private System.Windows.Forms.Label period_vazenja_do;
        private System.Windows.Forms.Label id_klijenta;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
    }
}