using System.Drawing;
using System.Windows.Forms;

namespace Library_Management_System
{
    partial class BorrowedBooks
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
            this.dataGridViewBorrow = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBorrow)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBorrow
            // 
            this.dataGridViewBorrow.AllowUserToAddRows = false;
            this.dataGridViewBorrow.AllowUserToDeleteRows = false;
            this.dataGridViewBorrow.AllowUserToResizeColumns = false;
            this.dataGridViewBorrow.AllowUserToResizeRows = false;
            this.dataGridViewBorrow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBorrow.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewBorrow.BackgroundColor = System.Drawing.Color.DarkTurquoise;
            this.dataGridViewBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBorrow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBorrow.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewBorrow.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewBorrow.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewBorrow.Name = "dataGridViewBorrow";
            this.dataGridViewBorrow.ReadOnly = true;
            this.dataGridViewBorrow.RowHeadersWidth = 51;
            this.dataGridViewBorrow.RowTemplate.Height = 29;
            this.dataGridViewBorrow.Size = new System.Drawing.Size(600, 292);
            this.dataGridViewBorrow.TabIndex = 0;
            // 
            // BorrowedBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 292);
            this.Controls.Add(this.dataGridViewBorrow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BorrowedBooks";
            this.Text = "BorrowedBooks";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBorrow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridViewBorrow;
    }
}