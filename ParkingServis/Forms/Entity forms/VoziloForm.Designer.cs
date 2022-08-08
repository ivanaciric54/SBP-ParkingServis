
namespace ParkingServis.Forms.Entity_forms
{
    partial class VoziloForm
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adresa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prebivalište = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DELETE = new System.Windows.Forms.Button();
            this.CHANGE = new System.Windows.Forms.Button();
            this.SAVE = new System.Windows.Forms.Button();
            this.LOAD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Ime,
            this.Prezime,
            this.Adresa,
            this.Prebivalište,
            this.Telefon});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(48, 28);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(700, 374);
            this.listView1.TabIndex = 33;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 100;
            // 
            // Ime
            // 
            this.Ime.Text = "Ime";
            this.Ime.Width = 150;
            // 
            // Prezime
            // 
            this.Prezime.Text = "Prezime";
            this.Prezime.Width = 150;
            // 
            // Adresa
            // 
            this.Adresa.Text = "Adresa";
            this.Adresa.Width = 150;
            // 
            // Prebivalište
            // 
            this.Prebivalište.Text = "Prebivalište";
            this.Prebivalište.Width = 150;
            // 
            // Telefon
            // 
            this.Telefon.Text = "Telefon";
            this.Telefon.Width = 150;
            // 
            // DELETE
            // 
            this.DELETE.BackColor = System.Drawing.Color.LightCoral;
            this.DELETE.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.DELETE.ForeColor = System.Drawing.Color.Maroon;
            this.DELETE.Location = new System.Drawing.Point(449, 441);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(99, 46);
            this.DELETE.TabIndex = 32;
            this.DELETE.Text = "Delete";
            this.DELETE.UseVisualStyleBackColor = false;
            // 
            // CHANGE
            // 
            this.CHANGE.BackColor = System.Drawing.Color.Khaki;
            this.CHANGE.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.CHANGE.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.CHANGE.Location = new System.Drawing.Point(311, 441);
            this.CHANGE.Name = "CHANGE";
            this.CHANGE.Size = new System.Drawing.Size(99, 46);
            this.CHANGE.TabIndex = 31;
            this.CHANGE.Text = "Change";
            this.CHANGE.UseVisualStyleBackColor = false;
            // 
            // SAVE
            // 
            this.SAVE.BackColor = System.Drawing.Color.PaleGreen;
            this.SAVE.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.SAVE.ForeColor = System.Drawing.Color.DarkGreen;
            this.SAVE.Location = new System.Drawing.Point(178, 441);
            this.SAVE.Name = "SAVE";
            this.SAVE.Size = new System.Drawing.Size(99, 46);
            this.SAVE.TabIndex = 30;
            this.SAVE.Text = "Save";
            this.SAVE.UseVisualStyleBackColor = false;
            // 
            // LOAD
            // 
            this.LOAD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LOAD.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOAD.ForeColor = System.Drawing.Color.RoyalBlue;
            this.LOAD.Location = new System.Drawing.Point(48, 441);
            this.LOAD.Name = "LOAD";
            this.LOAD.Size = new System.Drawing.Size(99, 46);
            this.LOAD.TabIndex = 29;
            this.LOAD.Text = "Load";
            this.LOAD.UseVisualStyleBackColor = false;
            // 
            // VoziloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 515);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.DELETE);
            this.Controls.Add(this.CHANGE);
            this.Controls.Add(this.SAVE);
            this.Controls.Add(this.LOAD);
            this.Name = "VoziloForm";
            this.Text = "VoziloForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Ime;
        private System.Windows.Forms.ColumnHeader Prezime;
        private System.Windows.Forms.ColumnHeader Adresa;
        private System.Windows.Forms.ColumnHeader Prebivalište;
        private System.Windows.Forms.ColumnHeader Telefon;
        private System.Windows.Forms.Button DELETE;
        private System.Windows.Forms.Button CHANGE;
        private System.Windows.Forms.Button SAVE;
        private System.Windows.Forms.Button LOAD;
    }
}