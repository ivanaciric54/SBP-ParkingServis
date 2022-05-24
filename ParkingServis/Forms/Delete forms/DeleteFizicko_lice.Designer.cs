
namespace ParkingServis.Forms.Delete_forms
{
    partial class DeleteFizicko_lice
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbVozilaList = new System.Windows.Forms.ComboBox();
            this.ds = new System.Data.DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(528, 224);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 42);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Izbriši";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbVozilaList
            // 
            this.cbVozilaList.FormattingEnabled = true;
            this.cbVozilaList.Location = new System.Drawing.Point(12, 32);
            this.cbVozilaList.Name = "cbVozilaList";
            this.cbVozilaList.Size = new System.Drawing.Size(498, 24);
            this.cbVozilaList.TabIndex = 6;
            // 
            // ds
            // 
            this.ds.DataSetName = "NewDataSet";
            // 
            // DeleteFizicko_lice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.cbVozilaList);
            this.Controls.Add(this.btnDelete);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DeleteFizicko_lice";
            this.Text = "Fizicko lice";
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cbVozilaList;
        private System.Data.DataSet ds;
    }
}