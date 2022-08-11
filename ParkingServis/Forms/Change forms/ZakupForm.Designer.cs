
namespace ParkingServis.Forms.Change_forms
{
    partial class ZakupForm
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
            this.Registracija = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DELETE = new System.Windows.Forms.Button();
            this.CHANGE = new System.Windows.Forms.Button();
            this.SAVE = new System.Windows.Forms.Button();
            this.LOAD = new System.Windows.Forms.Button();
            this.BrMesta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Registracija,
            this.OL,
            this.BrMesta});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(33, 42);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(700, 374);
            this.listView1.TabIndex = 38;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 100;
            // 
            // Registracija
            // 
            this.Registracija.Text = "Registracija";
            this.Registracija.Width = 200;
            // 
            // OL
            // 
            this.OL.Text = "Odgovorni za vozilo";
            this.OL.Width = 200;
            // 
            // DELETE
            // 
            this.DELETE.BackColor = System.Drawing.Color.LightCoral;
            this.DELETE.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.DELETE.ForeColor = System.Drawing.Color.Maroon;
            this.DELETE.Location = new System.Drawing.Point(434, 455);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(99, 46);
            this.DELETE.TabIndex = 37;
            this.DELETE.Text = "Delete";
            this.DELETE.UseVisualStyleBackColor = false;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // CHANGE
            // 
            this.CHANGE.BackColor = System.Drawing.Color.Khaki;
            this.CHANGE.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.CHANGE.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.CHANGE.Location = new System.Drawing.Point(296, 455);
            this.CHANGE.Name = "CHANGE";
            this.CHANGE.Size = new System.Drawing.Size(99, 46);
            this.CHANGE.TabIndex = 36;
            this.CHANGE.Text = "Change";
            this.CHANGE.UseVisualStyleBackColor = false;
            this.CHANGE.Click += new System.EventHandler(this.CHANGE_Click);
            // 
            // SAVE
            // 
            this.SAVE.BackColor = System.Drawing.Color.PaleGreen;
            this.SAVE.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.SAVE.ForeColor = System.Drawing.Color.DarkGreen;
            this.SAVE.Location = new System.Drawing.Point(163, 455);
            this.SAVE.Name = "SAVE";
            this.SAVE.Size = new System.Drawing.Size(99, 46);
            this.SAVE.TabIndex = 35;
            this.SAVE.Text = "Save";
            this.SAVE.UseVisualStyleBackColor = false;
            this.SAVE.Click += new System.EventHandler(this.SAVE_Click);
            // 
            // LOAD
            // 
            this.LOAD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LOAD.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOAD.ForeColor = System.Drawing.Color.RoyalBlue;
            this.LOAD.Location = new System.Drawing.Point(33, 455);
            this.LOAD.Name = "LOAD";
            this.LOAD.Size = new System.Drawing.Size(99, 46);
            this.LOAD.TabIndex = 34;
            this.LOAD.Text = "Load";
            this.LOAD.UseVisualStyleBackColor = false;
            this.LOAD.Click += new System.EventHandler(this.LOAD_Click);
            // 
            // BrMesta
            // 
            this.BrMesta.Text = "Broj mesta";
            this.BrMesta.Width = 200;
            // 
            // ZakupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 526);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.DELETE);
            this.Controls.Add(this.CHANGE);
            this.Controls.Add(this.SAVE);
            this.Controls.Add(this.LOAD);
            this.Name = "ZakupForm";
            this.Text = "ZakupForm";
            this.Load += new System.EventHandler(this.ZakupForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Registracija;
        private System.Windows.Forms.ColumnHeader OL;
        private System.Windows.Forms.Button DELETE;
        private System.Windows.Forms.Button CHANGE;
        private System.Windows.Forms.Button SAVE;
        private System.Windows.Forms.Button LOAD;
        private System.Windows.Forms.ColumnHeader BrMesta;
    }
}