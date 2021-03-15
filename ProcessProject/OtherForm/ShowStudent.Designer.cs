
namespace ProcessProject.OtherForm
{
    partial class ShowStudent
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
            this.dgvShoStudent = new System.Windows.Forms.DataGridView();
            this.panelFormControl = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShoStudent)).BeginInit();
            this.panelFormControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvShoStudent
            // 
            this.dgvShoStudent.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvShoStudent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvShoStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShoStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShoStudent.Location = new System.Drawing.Point(0, 0);
            this.dgvShoStudent.Name = "dgvShoStudent";
            this.dgvShoStudent.Size = new System.Drawing.Size(880, 575);
            this.dgvShoStudent.TabIndex = 0;
            this.dgvShoStudent.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowStudent_CellDoubleClick);
            // 
            // panelFormControl
            // 
            this.panelFormControl.Controls.Add(this.dgvShoStudent);
            this.panelFormControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormControl.Location = new System.Drawing.Point(0, 0);
            this.panelFormControl.Name = "panelFormControl";
            this.panelFormControl.Size = new System.Drawing.Size(880, 575);
            this.panelFormControl.TabIndex = 1;
            // 
            // ShowStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(880, 575);
            this.Controls.Add(this.panelFormControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowStudent";
            this.Text = "ShowStudent";
            this.Load += new System.EventHandler(this.ShowStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShoStudent)).EndInit();
            this.panelFormControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShoStudent;
        private System.Windows.Forms.Panel panelFormControl;
    }
}