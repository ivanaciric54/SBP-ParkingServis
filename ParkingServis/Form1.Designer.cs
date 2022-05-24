
namespace ParkingServis
{
    partial class Form1
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
            this.LOAD = new System.Windows.Forms.Button();
            this.SAVE = new System.Windows.Forms.Button();
            this.CHANGE = new System.Windows.Forms.Button();
            this.DELETE = new System.Windows.Forms.Button();
            this.izborEntitetaBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LOAD
            // 
            this.LOAD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LOAD.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOAD.ForeColor = System.Drawing.Color.RoyalBlue;
            this.LOAD.Location = new System.Drawing.Point(79, 54);
            this.LOAD.Name = "LOAD";
            this.LOAD.Size = new System.Drawing.Size(99, 46);
            this.LOAD.TabIndex = 15;
            this.LOAD.Text = "Load";
            this.LOAD.UseVisualStyleBackColor = false;
            this.LOAD.Click += new System.EventHandler(this.LOAD_Click);
            // 
            // SAVE
            // 
            this.SAVE.BackColor = System.Drawing.Color.PaleGreen;
            this.SAVE.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.SAVE.ForeColor = System.Drawing.Color.DarkGreen;
            this.SAVE.Location = new System.Drawing.Point(79, 124);
            this.SAVE.Name = "SAVE";
            this.SAVE.Size = new System.Drawing.Size(99, 46);
            this.SAVE.TabIndex = 16;
            this.SAVE.Text = "Save";
            this.SAVE.UseVisualStyleBackColor = false;
            this.SAVE.Click += new System.EventHandler(this.SAVE_Click);
            // 
            // CHANGE
            // 
            this.CHANGE.BackColor = System.Drawing.Color.Khaki;
            this.CHANGE.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.CHANGE.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.CHANGE.Location = new System.Drawing.Point(79, 194);
            this.CHANGE.Name = "CHANGE";
            this.CHANGE.Size = new System.Drawing.Size(99, 46);
            this.CHANGE.TabIndex = 17;
            this.CHANGE.Text = "Change";
            this.CHANGE.UseVisualStyleBackColor = false;
            this.CHANGE.Click += new System.EventHandler(this.CHANGE_Click);
            // 
            // DELETE
            // 
            this.DELETE.BackColor = System.Drawing.Color.LightCoral;
            this.DELETE.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.DELETE.ForeColor = System.Drawing.Color.Maroon;
            this.DELETE.Location = new System.Drawing.Point(79, 268);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(99, 46);
            this.DELETE.TabIndex = 18;
            this.DELETE.Text = "Delete";
            this.DELETE.UseVisualStyleBackColor = false;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // izborEntitetaBox
            // 
            this.izborEntitetaBox.FormattingEnabled = true;
            this.izborEntitetaBox.Items.AddRange(new object[] {
            "Pravno lice",
            "Fizičko lice",
            "Pretplatna",
            "Jednokratna",
            "Parking mesto",
            "Garažno mesto",
            "Ulično mesto",
            "Parking",
            "Javna garaža",
            "Vozilo",
            "Telefon",
            "Odnosi se na P",
            "Zakup",
            "Zona",
            "Zone pretplatne"});
            this.izborEntitetaBox.Location = new System.Drawing.Point(253, 54);
            this.izborEntitetaBox.Name = "izborEntitetaBox";
            this.izborEntitetaBox.Size = new System.Drawing.Size(228, 28);
            this.izborEntitetaBox.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 367);
            this.Controls.Add(this.izborEntitetaBox);
            this.Controls.Add(this.DELETE);
            this.Controls.Add(this.CHANGE);
            this.Controls.Add(this.SAVE);
            this.Controls.Add(this.LOAD);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Parking Servis";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button LOAD;
        private System.Windows.Forms.Button SAVE;
        private System.Windows.Forms.Button CHANGE;
        private System.Windows.Forms.Button DELETE;
        private System.Windows.Forms.ComboBox izborEntitetaBox;
    }
}

