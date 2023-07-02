using System.Drawing;
using System.Windows.Forms;

namespace Library_Management_System
{
    partial class Delete_Books
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.delte_txt = new System.Windows.Forms.Button();
            this.IDbk_txt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(120, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(122, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.delte_txt);
            this.panel1.Controls.Add(this.IDbk_txt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(131, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 250);
            this.panel1.TabIndex = 1;
            // 
            // delte_txt
            // 
            this.delte_txt.BackColor = System.Drawing.Color.Red;
            this.delte_txt.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.delte_txt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.delte_txt.Location = new System.Drawing.Point(190, 157);
            this.delte_txt.Name = "delte_txt";
            this.delte_txt.Size = new System.Drawing.Size(104, 33);
            this.delte_txt.TabIndex = 15;
            this.delte_txt.Text = "Delete";
            this.delte_txt.UseVisualStyleBackColor = false;
            this.delte_txt.Click += new System.EventHandler(this.delte_txt_Click);
            // 
            // IDbk_txt
            // 
            this.IDbk_txt.Location = new System.Drawing.Point(164, 83);
            this.IDbk_txt.Name = "IDbk_txt";
            this.IDbk_txt.Size = new System.Drawing.Size(171, 20);
            this.IDbk_txt.TabIndex = 6;
            // 
            // Delete_Books
            // 
            this.AcceptButton = this.delte_txt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(795, 343);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Delete_Books";
            this.Text = "Delete_Books";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button delte_txt;
        private System.Windows.Forms.TextBox IDbk_txt;
        private Label label4;
        private Label label1;
    }
}