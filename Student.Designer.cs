using System.Drawing;
using System.Windows.Forms;

namespace Library_Management_System
{
    partial class Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student));
            this.sidepanel = new System.Windows.Forms.Panel();
            this.log_out = new System.Windows.Forms.Button();
            this.show_id = new System.Windows.Forms.Button();
            this.issu_book = new System.Windows.Forms.Button();
            this.show_books = new System.Windows.Forms.Button();
            this.search_book = new System.Windows.Forms.Button();
            this.headerpanel = new System.Windows.Forms.Panel();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.sidepanel.SuspendLayout();
            this.headerpanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sidepanel.Controls.Add(this.log_out);
            this.sidepanel.Controls.Add(this.show_id);
            this.sidepanel.Controls.Add(this.issu_book);
            this.sidepanel.Controls.Add(this.show_books);
            this.sidepanel.Controls.Add(this.search_book);
            this.sidepanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidepanel.Location = new System.Drawing.Point(0, 0);
            this.sidepanel.Margin = new System.Windows.Forms.Padding(2);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(158, 398);
            this.sidepanel.TabIndex = 4;
            // 
            // log_out
            // 
            this.log_out.BackColor = System.Drawing.Color.Red;
            this.log_out.Dock = System.Windows.Forms.DockStyle.Top;
            this.log_out.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.log_out.Font = new System.Drawing.Font("Sitka Small", 10.8F);
            this.log_out.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.log_out.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.log_out.Location = new System.Drawing.Point(0, 164);
            this.log_out.Margin = new System.Windows.Forms.Padding(2);
            this.log_out.Name = "log_out";
            this.log_out.Size = new System.Drawing.Size(158, 41);
            this.log_out.TabIndex = 9;
            this.log_out.Text = " Log out";
            this.log_out.UseVisualStyleBackColor = false;
            this.log_out.Click += new System.EventHandler(this.log_out_Click);
            // 
            // show_id
            // 
            this.show_id.BackColor = System.Drawing.Color.Turquoise;
            this.show_id.Dock = System.Windows.Forms.DockStyle.Top;
            this.show_id.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.show_id.Font = new System.Drawing.Font("Sitka Small", 10.8F);
            this.show_id.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.show_id.Location = new System.Drawing.Point(0, 123);
            this.show_id.Margin = new System.Windows.Forms.Padding(2);
            this.show_id.Name = "show_id";
            this.show_id.Size = new System.Drawing.Size(158, 41);
            this.show_id.TabIndex = 8;
            this.show_id.Text = "Show ID";
            this.show_id.UseVisualStyleBackColor = false;
            this.show_id.Click += new System.EventHandler(this.show_id_Click);
            // 
            // issu_book
            // 
            this.issu_book.BackColor = System.Drawing.Color.PaleTurquoise;
            this.issu_book.Dock = System.Windows.Forms.DockStyle.Top;
            this.issu_book.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.issu_book.Font = new System.Drawing.Font("Sitka Small", 10.8F);
            this.issu_book.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.issu_book.Location = new System.Drawing.Point(0, 82);
            this.issu_book.Margin = new System.Windows.Forms.Padding(2);
            this.issu_book.Name = "issu_book";
            this.issu_book.Size = new System.Drawing.Size(158, 41);
            this.issu_book.TabIndex = 7;
            this.issu_book.Text = " Issue Book";
            this.issu_book.UseVisualStyleBackColor = false;
            this.issu_book.Click += new System.EventHandler(this.issu_book_Click);
            // 
            // show_books
            // 
            this.show_books.BackColor = System.Drawing.Color.PaleVioletRed;
            this.show_books.Dock = System.Windows.Forms.DockStyle.Top;
            this.show_books.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.show_books.Font = new System.Drawing.Font("Sitka Small", 10.8F);
            this.show_books.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.show_books.Location = new System.Drawing.Point(0, 41);
            this.show_books.Margin = new System.Windows.Forms.Padding(2);
            this.show_books.Name = "show_books";
            this.show_books.Size = new System.Drawing.Size(158, 41);
            this.show_books.TabIndex = 6;
            this.show_books.Text = " Show Books";
            this.show_books.UseVisualStyleBackColor = false;
            this.show_books.Click += new System.EventHandler(this.show_books_Click);
            // 
            // search_book
            // 
            this.search_book.BackColor = System.Drawing.Color.PaleGreen;
            this.search_book.Dock = System.Windows.Forms.DockStyle.Top;
            this.search_book.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.search_book.Font = new System.Drawing.Font("Sitka Small", 10.8F);
            this.search_book.ForeColor = System.Drawing.SystemColors.ControlText;
            this.search_book.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.search_book.Location = new System.Drawing.Point(0, 0);
            this.search_book.Margin = new System.Windows.Forms.Padding(2);
            this.search_book.Name = "search_book";
            this.search_book.Size = new System.Drawing.Size(158, 41);
            this.search_book.TabIndex = 5;
            this.search_book.Text = " Search Book";
            this.search_book.UseVisualStyleBackColor = false;
            this.search_book.Click += new System.EventHandler(this.search_book_Click);
            // 
            // headerpanel
            // 
            this.headerpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(75)))), ((int)(((byte)(0)))));
            this.headerpanel.Controls.Add(this.panel1);
            this.headerpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerpanel.Location = new System.Drawing.Point(158, 0);
            this.headerpanel.Margin = new System.Windows.Forms.Padding(2);
            this.headerpanel.Name = "headerpanel";
            this.headerpanel.Size = new System.Drawing.Size(845, 47);
            this.headerpanel.TabIndex = 5;
            // 
            // mainpanel
            // 
            this.mainpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(158, 47);
            this.mainpanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(845, 351);
            this.mainpanel.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 47);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FloralWhite;
            this.label1.Location = new System.Drawing.Point(283, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Library Management System";
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1003, 398);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.headerpanel);
            this.Controls.Add(this.sidepanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Student_Load);
            this.sidepanel.ResumeLayout(false);
            this.headerpanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel sidepanel;
        private Button search_book;
        private Panel headerpanel;
        private Button show_books;
        private Button issu_book;
        private Panel mainpanel;
        private Button show_id;
        private Button log_out;
        private Panel panel1;
        private Label label1;
    }
}