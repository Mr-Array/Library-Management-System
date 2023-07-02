using System.Windows.Forms;

namespace Library_Management_System
{
    partial class ShowLibrarians
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
            this.dataGridViewLibrarians = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLibrarians)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLibrarians
            // 
            this.dataGridViewLibrarians.AllowUserToAddRows = false;
            this.dataGridViewLibrarians.AllowUserToDeleteRows = false;
            this.dataGridViewLibrarians.AllowUserToResizeColumns = false;
            this.dataGridViewLibrarians.AllowUserToResizeRows = false;
            this.dataGridViewLibrarians.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLibrarians.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewLibrarians.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewLibrarians.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLibrarians.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLibrarians.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewLibrarians.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewLibrarians.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewLibrarians.Name = "dataGridViewLibrarians";
            this.dataGridViewLibrarians.ReadOnly = true;
            this.dataGridViewLibrarians.RowHeadersWidth = 51;
            this.dataGridViewLibrarians.RowTemplate.Height = 29;
            this.dataGridViewLibrarians.Size = new System.Drawing.Size(747, 336);
            this.dataGridViewLibrarians.TabIndex = 0;
           // this.dataGridViewLibrarians.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLibrarians_CellContentClick);
            // 
            // ShowLibrarians
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(747, 336);
            this.Controls.Add(this.dataGridViewLibrarians);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ShowLibrarians";
            this.Text = "showform";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLibrarians)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridViewLibrarians;
    }
}