using System.Drawing;
using System.Windows.Forms;

namespace Library_Management_System
{
    partial class showform
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
            this.dataGridViewbooks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewbooks)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewbooks
            // 
            this.dataGridViewbooks.AllowUserToAddRows = false;
            this.dataGridViewbooks.AllowUserToDeleteRows = false;
            this.dataGridViewbooks.AllowUserToResizeColumns = false;
            this.dataGridViewbooks.AllowUserToResizeRows = false;
            this.dataGridViewbooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewbooks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewbooks.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dataGridViewbooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewbooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewbooks.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewbooks.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewbooks.Name = "dataGridViewbooks";
            this.dataGridViewbooks.ReadOnly = true;
            this.dataGridViewbooks.RowHeadersWidth = 51;
            this.dataGridViewbooks.RowTemplate.Height = 29;
            this.dataGridViewbooks.Size = new System.Drawing.Size(747, 336);
            this.dataGridViewbooks.TabIndex = 0;
            this.dataGridViewbooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewbooks_CellContentClick);
            // 
            // showform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(747, 336);
            this.Controls.Add(this.dataGridViewbooks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "showform";
            this.Text = "showform";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewbooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridViewbooks;
    }
}