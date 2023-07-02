using System.Drawing;
using System.Windows.Forms;

namespace Library_Management_System
{
    partial class adminform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminform));
            this.sidepanel = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.add_book = new System.Windows.Forms.Button();
            this.delete_lib = new System.Windows.Forms.Button();
            this.Add_lib = new System.Windows.Forms.Button();
            this.bottompanel = new System.Windows.Forms.Panel();
            this.headerpanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Btnst = new System.Windows.Forms.Button();
            this.show_books = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.adminpanel = new System.Windows.Forms.Panel();
            this.log_out = new System.Windows.Forms.Button();
            this.sidepanel.SuspendLayout();
            this.headerpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.Color.SteelBlue;
            this.sidepanel.Controls.Add(this.log_out);
            this.sidepanel.Controls.Add(this.button1);
            this.sidepanel.Controls.Add(this.show_books);
            this.sidepanel.Controls.Add(this.Btnst);
            this.sidepanel.Controls.Add(this.button6);
            this.sidepanel.Controls.Add(this.button4);
            this.sidepanel.Controls.Add(this.button3);
            this.sidepanel.Controls.Add(this.button5);
            this.sidepanel.Controls.Add(this.add_book);
            this.sidepanel.Controls.Add(this.delete_lib);
            this.sidepanel.Controls.Add(this.Add_lib);
            this.sidepanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidepanel.Location = new System.Drawing.Point(0, 49);
            this.sidepanel.Margin = new System.Windows.Forms.Padding(2);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(154, 473);
            this.sidepanel.TabIndex = 8;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Navy;
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.Font = new System.Drawing.Font("Sitka Small", 10.8F);
            this.button6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(0, 265);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(154, 41);
            this.button6.TabIndex = 15;
            this.button6.Text = "Show borrowed Books";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.PaleVioletRed;
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.Font = new System.Drawing.Font("Sitka Small", 10.8F);
            this.button4.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 224);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(154, 41);
            this.button4.TabIndex = 13;
            this.button4.Text = "Return Book";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Orchid;
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Font = new System.Drawing.Font("Sitka Small", 10.8F);
            this.button3.ForeColor = System.Drawing.Color.DarkBlue;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 183);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 41);
            this.button3.TabIndex = 12;
            this.button3.Text = "Search Books";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Red;
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.Font = new System.Drawing.Font("Sitka Small", 10.8F);
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(0, 142);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(154, 41);
            this.button5.TabIndex = 11;
            this.button5.Text = "Delete Books";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // add_book
            // 
            this.add_book.BackColor = System.Drawing.Color.PaleGreen;
            this.add_book.Dock = System.Windows.Forms.DockStyle.Top;
            this.add_book.Font = new System.Drawing.Font("Sitka Small", 10.8F);
            this.add_book.ForeColor = System.Drawing.SystemColors.ControlText;
            this.add_book.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add_book.Location = new System.Drawing.Point(0, 101);
            this.add_book.Name = "add_book";
            this.add_book.Size = new System.Drawing.Size(154, 41);
            this.add_book.TabIndex = 10;
            this.add_book.Text = "Add Books";
            this.add_book.UseVisualStyleBackColor = false;
            this.add_book.Click += new System.EventHandler(this.add_book_Click_1);
            // 
            // delete_lib
            // 
            this.delete_lib.BackColor = System.Drawing.Color.LightCyan;
            this.delete_lib.Dock = System.Windows.Forms.DockStyle.Top;
            this.delete_lib.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.delete_lib.Font = new System.Drawing.Font("Sitka Small", 10.8F);
            this.delete_lib.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delete_lib.Location = new System.Drawing.Point(0, 60);
            this.delete_lib.Margin = new System.Windows.Forms.Padding(2);
            this.delete_lib.Name = "delete_lib";
            this.delete_lib.Size = new System.Drawing.Size(154, 41);
            this.delete_lib.TabIndex = 6;
            this.delete_lib.Text = "Delete Librarian";
            this.delete_lib.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.delete_lib.UseVisualStyleBackColor = false;
            this.delete_lib.Click += new System.EventHandler(this.delete_lib_Click);
            // 
            // Add_lib
            // 
            this.Add_lib.BackColor = System.Drawing.Color.Lime;
            this.Add_lib.Dock = System.Windows.Forms.DockStyle.Top;
            this.Add_lib.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Add_lib.Font = new System.Drawing.Font("Sitka Small", 10.8F);
            this.Add_lib.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Add_lib.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Add_lib.Location = new System.Drawing.Point(0, 0);
            this.Add_lib.Margin = new System.Windows.Forms.Padding(2);
            this.Add_lib.Name = "Add_lib";
            this.Add_lib.Size = new System.Drawing.Size(154, 60);
            this.Add_lib.TabIndex = 5;
            this.Add_lib.Text = "ADD Librarian And Student";
            this.Add_lib.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Add_lib.UseVisualStyleBackColor = false;
            this.Add_lib.Click += new System.EventHandler(this.Add_lib_Click);
            // 
            // bottompanel
            // 
            this.bottompanel.BackColor = System.Drawing.Color.SteelBlue;
            this.bottompanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottompanel.Location = new System.Drawing.Point(0, 522);
            this.bottompanel.Margin = new System.Windows.Forms.Padding(2);
            this.bottompanel.Name = "bottompanel";
            this.bottompanel.Size = new System.Drawing.Size(949, 12);
            this.bottompanel.TabIndex = 10;
            // 
            // headerpanel
            // 
            this.headerpanel.BackColor = System.Drawing.Color.DodgerBlue;
            this.headerpanel.Controls.Add(this.label1);
            this.headerpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerpanel.Location = new System.Drawing.Point(0, 0);
            this.headerpanel.Margin = new System.Windows.Forms.Padding(2);
            this.headerpanel.Name = "headerpanel";
            this.headerpanel.Size = new System.Drawing.Size(949, 49);
            this.headerpanel.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FloralWhite;
            this.label1.Location = new System.Drawing.Point(521, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Library Management System";
            // 
            // Btnst
            // 
            this.Btnst.BackColor = System.Drawing.Color.Navy;
            this.Btnst.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btnst.Font = new System.Drawing.Font("Sitka Small", 10.8F);
            this.Btnst.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Btnst.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btnst.Location = new System.Drawing.Point(0, 306);
            this.Btnst.Name = "Btnst";
            this.Btnst.Size = new System.Drawing.Size(154, 41);
            this.Btnst.TabIndex = 17;
            this.Btnst.Text = "Show Students";
            this.Btnst.UseVisualStyleBackColor = false;
            this.Btnst.Click += new System.EventHandler(this.Btnst_Click);
            // 
            // show_books
            // 
            this.show_books.BackColor = System.Drawing.Color.Navy;
            this.show_books.Dock = System.Windows.Forms.DockStyle.Top;
            this.show_books.Font = new System.Drawing.Font("Sitka Small", 10.8F);
            this.show_books.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.show_books.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.show_books.Location = new System.Drawing.Point(0, 347);
            this.show_books.Name = "show_books";
            this.show_books.Size = new System.Drawing.Size(154, 41);
            this.show_books.TabIndex = 19;
            this.show_books.Text = "Show books";
            this.show_books.UseVisualStyleBackColor = false;
            this.show_books.Click += new System.EventHandler(this.show_books_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Font = new System.Drawing.Font("Sitka Small", 10.8F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 41);
            this.button1.TabIndex = 21;
            this.button1.Text = "Show Librarians";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // adminpanel
            // 
            this.adminpanel.BackgroundImage = global::Library_Management_System.Properties.Resources.HOW_DO_YOU_DESIGN_A_LIBRARY_MANAGEMENT_SYSTEM_min;
            this.adminpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.adminpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminpanel.Location = new System.Drawing.Point(154, 49);
            this.adminpanel.Margin = new System.Windows.Forms.Padding(2);
            this.adminpanel.Name = "adminpanel";
            this.adminpanel.Size = new System.Drawing.Size(795, 473);
            this.adminpanel.TabIndex = 11;
            // 
            // log_out
            // 
            this.log_out.BackColor = System.Drawing.Color.Red;
            this.log_out.Dock = System.Windows.Forms.DockStyle.Top;
            this.log_out.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.log_out.Font = new System.Drawing.Font("Sitka Small", 10.8F);
            this.log_out.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.log_out.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.log_out.Location = new System.Drawing.Point(0, 429);
            this.log_out.Margin = new System.Windows.Forms.Padding(2);
            this.log_out.Name = "log_out";
            this.log_out.Size = new System.Drawing.Size(154, 41);
            this.log_out.TabIndex = 22;
            this.log_out.Text = " Log out";
            this.log_out.UseVisualStyleBackColor = false;
            this.log_out.Click += new System.EventHandler(this.log_out_Click_2);
            // 
            // adminform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 534);
            this.Controls.Add(this.adminpanel);
            this.Controls.Add(this.sidepanel);
            this.Controls.Add(this.bottompanel);
            this.Controls.Add(this.headerpanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "adminform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminform";
            this.sidepanel.ResumeLayout(false);
            this.headerpanel.ResumeLayout(false);
            this.headerpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel adminpanel;
        private Panel sidepanel;
        private Button delete_lib;
        private Panel bottompanel;
        private Panel headerpanel;
        private Label label1;
        private Button Add_lib;
        private Button button6;
        private Button button4;
        private Button button3;
        private Button button5;
        private Button add_book;
        private Button Btnst;
        private Button show_books;
        private Button button1;
        private Button log_out;
    }
}