using System.Drawing;
using System.Windows.Forms;

namespace Library_Management_System
{
    partial class librarian_interface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(librarian_interface));
            this.panel3 = new System.Windows.Forms.Panel();
            this.headerpanel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.main_panel = new System.Windows.Forms.Panel();
            this.add_book = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.show_books = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btnst = new System.Windows.Forms.Button();
            this.Log_out = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.headerpanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(75)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.headerpanel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(158, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1020, 42);
            this.panel3.TabIndex = 1;
            // 
            // headerpanel
            // 
            this.headerpanel.BackColor = System.Drawing.Color.DodgerBlue;
            this.headerpanel.Controls.Add(this.label9);
            this.headerpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerpanel.Location = new System.Drawing.Point(0, 0);
            this.headerpanel.Margin = new System.Windows.Forms.Padding(2);
            this.headerpanel.Name = "headerpanel";
            this.headerpanel.Size = new System.Drawing.Size(1020, 49);
            this.headerpanel.TabIndex = 78;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.FloralWhite;
            this.label9.Location = new System.Drawing.Point(521, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(359, 31);
            this.label9.TabIndex = 1;
            this.label9.Text = "Library Management System";
            // 
            // main_panel
            // 
            this.main_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.Location = new System.Drawing.Point(158, 42);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(1020, 367);
            this.main_panel.TabIndex = 2;
            this.main_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.main_panel_Paint);
            // 
            // add_book
            // 
            this.add_book.BackColor = System.Drawing.Color.PaleGreen;
            this.add_book.Dock = System.Windows.Forms.DockStyle.Top;
            this.add_book.Font = new System.Drawing.Font("Sitka Small", 10.8F);
            this.add_book.ForeColor = System.Drawing.SystemColors.ControlText;
            this.add_book.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add_book.Location = new System.Drawing.Point(0, 0);
            this.add_book.Name = "add_book";
            this.add_book.Size = new System.Drawing.Size(158, 41);
            this.add_book.TabIndex = 1;
            this.add_book.Text = "Add Books";
            this.add_book.UseVisualStyleBackColor = false;
            this.add_book.Click += new System.EventHandler(this.add_book_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Font = new System.Drawing.Font("Sitka Small", 10.8F);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 41);
            this.button2.TabIndex = 2;
            this.button2.Text = "Delete Books";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Orchid;
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Font = new System.Drawing.Font("Sitka Small", 10.8F);
            this.button3.ForeColor = System.Drawing.Color.DarkBlue;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 82);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 41);
            this.button3.TabIndex = 3;
            this.button3.Text = "Search Books";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.PaleVioletRed;
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.Font = new System.Drawing.Font("Sitka Small", 10.8F);
            this.button4.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 123);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(158, 41);
            this.button4.TabIndex = 4;
            this.button4.Text = "Return Book";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // show_books
            // 
            this.show_books.BackColor = System.Drawing.Color.Navy;
            this.show_books.Dock = System.Windows.Forms.DockStyle.Top;
            this.show_books.Font = new System.Drawing.Font("Sitka Small", 10.8F);
            this.show_books.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.show_books.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.show_books.Location = new System.Drawing.Point(0, 164);
            this.show_books.Name = "show_books";
            this.show_books.Size = new System.Drawing.Size(158, 41);
            this.show_books.TabIndex = 5;
            this.show_books.Text = "Show books";
            this.show_books.UseVisualStyleBackColor = false;
            this.show_books.Click += new System.EventHandler(this.show_books_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Navy;
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.Font = new System.Drawing.Font("Sitka Small", 10.8F);
            this.button6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(0, 205);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(158, 41);
            this.button6.TabIndex = 6;
            this.button6.Text = "Show borrowed Books";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.Log_out);
            this.panel1.Controls.Add(this.Btnst);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.show_books);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.add_book);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 409);
            this.panel1.TabIndex = 0;
            // 
            // Btnst
            // 
            this.Btnst.BackColor = System.Drawing.Color.Navy;
            this.Btnst.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btnst.Font = new System.Drawing.Font("Sitka Small", 10.8F);
            this.Btnst.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Btnst.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btnst.Location = new System.Drawing.Point(0, 246);
            this.Btnst.Name = "Btnst";
            this.Btnst.Size = new System.Drawing.Size(158, 41);
            this.Btnst.TabIndex = 18;
            this.Btnst.Text = "Show Students";
            this.Btnst.UseVisualStyleBackColor = false;
            this.Btnst.Click += new System.EventHandler(this.Btnst_Click);
            // 
            // Log_out
            // 
            this.Log_out.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Log_out.Dock = System.Windows.Forms.DockStyle.Top;
            this.Log_out.Font = new System.Drawing.Font("Sitka Small", 10.8F);
            this.Log_out.ForeColor = System.Drawing.Color.Blue;
            this.Log_out.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Log_out.Location = new System.Drawing.Point(0, 287);
            this.Log_out.Name = "Log_out";
            this.Log_out.Size = new System.Drawing.Size(158, 41);
            this.Log_out.TabIndex = 19;
            this.Log_out.Text = "Log Out";
            this.Log_out.UseVisualStyleBackColor = false;
            this.Log_out.Click += new System.EventHandler(this.Log_out_Click_1);
            // 
            // librarian_interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 409);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "librarian_interface";
            this.Text = "Librarian";
            this.panel3.ResumeLayout(false);
            this.headerpanel.ResumeLayout(false);
            this.headerpanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel main_panel;
        private Panel headerpanel;
        private Label label9;
        private Button add_book;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button show_books;
        private Button button6;
        private Panel panel1;
        private Button Log_out;
        private Button Btnst;
    }
}