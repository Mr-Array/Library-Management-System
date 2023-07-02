using System.Drawing;
using System.Windows.Forms;

namespace Library_Management_System
{
    partial class SearchForm
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
            this.searchpanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.search_btn = new System.Windows.Forms.Button();
            this.book_idtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.title_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.search_result = new System.Windows.Forms.Panel();
            this.dataGridView_result = new System.Windows.Forms.DataGridView();
            this.searchpanel.SuspendLayout();
            this.search_result.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_result)).BeginInit();
            this.SuspendLayout();
            // 
            // searchpanel
            // 
            this.searchpanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchpanel.BackColor = System.Drawing.Color.Turquoise;
            this.searchpanel.Controls.Add(this.label3);
            this.searchpanel.Controls.Add(this.search_btn);
            this.searchpanel.Controls.Add(this.book_idtxt);
            this.searchpanel.Controls.Add(this.label2);
            this.searchpanel.Controls.Add(this.title_txt);
            this.searchpanel.Controls.Add(this.label1);
            this.searchpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchpanel.ForeColor = System.Drawing.SystemColors.Control;
            this.searchpanel.Location = new System.Drawing.Point(0, 0);
            this.searchpanel.Margin = new System.Windows.Forms.Padding(2);
            this.searchpanel.Name = "searchpanel";
            this.searchpanel.Size = new System.Drawing.Size(795, 192);
            this.searchpanel.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(415, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "or";
            // 
            // search_btn
            // 
            this.search_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.search_btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.search_btn.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.search_btn.ForeColor = System.Drawing.Color.Cornsilk;
            this.search_btn.Location = new System.Drawing.Point(376, 138);
            this.search_btn.Margin = new System.Windows.Forms.Padding(2);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(104, 36);
            this.search_btn.TabIndex = 4;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // book_idtxt
            // 
            this.book_idtxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.book_idtxt.Location = new System.Drawing.Point(342, 99);
            this.book_idtxt.Margin = new System.Windows.Forms.Padding(2);
            this.book_idtxt.Name = "book_idtxt";
            this.book_idtxt.Size = new System.Drawing.Size(174, 20);
            this.book_idtxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(304, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID";
            // 
            // title_txt
            // 
            this.title_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.title_txt.Location = new System.Drawing.Point(342, 45);
            this.title_txt.Margin = new System.Windows.Forms.Padding(2);
            this.title_txt.Name = "title_txt";
            this.title_txt.Size = new System.Drawing.Size(174, 20);
            this.title_txt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(296, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // search_result
            // 
            this.search_result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.search_result.Controls.Add(this.dataGridView_result);
            this.search_result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search_result.Location = new System.Drawing.Point(0, 192);
            this.search_result.Margin = new System.Windows.Forms.Padding(2);
            this.search_result.Name = "search_result";
            this.search_result.Size = new System.Drawing.Size(795, 151);
            this.search_result.TabIndex = 1;
            // 
            // dataGridView_result
            // 
            this.dataGridView_result.AllowUserToAddRows = false;
            this.dataGridView_result.AllowUserToDeleteRows = false;
            this.dataGridView_result.AllowUserToResizeColumns = false;
            this.dataGridView_result.AllowUserToResizeRows = false;
            this.dataGridView_result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_result.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_result.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_result.BackgroundColor = System.Drawing.Color.Aqua;
            this.dataGridView_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_result.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_result.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_result.Name = "dataGridView_result";
            this.dataGridView_result.RowHeadersWidth = 51;
            this.dataGridView_result.RowTemplate.Height = 29;
            this.dataGridView_result.Size = new System.Drawing.Size(795, 151);
            this.dataGridView_result.TabIndex = 0;
            // 
            // SearchForm
            // 
            this.AcceptButton = this.search_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(795, 343);
            this.Controls.Add(this.search_result);
            this.Controls.Add(this.searchpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SearchForm";
            this.Text = "searchForm";
            this.searchpanel.ResumeLayout(false);
            this.searchpanel.PerformLayout();
            this.search_result.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_result)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel searchpanel;
        private TextBox book_idtxt;
        private Label label2;
        private TextBox title_txt;
        private Label label1;
        private Button search_btn;
        private Label label3;
        private Panel search_result;
        private DataGridView dataGridView_result;
    }
}