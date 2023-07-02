using System.Drawing;
using System.Windows.Forms;

namespace Library_Management_System
{
    partial class deleteformcs
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
            this.delete_btn = new System.Windows.Forms.Button();
            this.searchpanel = new System.Windows.Forms.Panel();
            this.deletelib_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.Red;
            this.delete_btn.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.delete_btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.delete_btn.Location = new System.Drawing.Point(184, 159);
            this.delete_btn.Margin = new System.Windows.Forms.Padding(2);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(104, 34);
            this.delete_btn.TabIndex = 4;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // searchpanel
            // 
            this.searchpanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchpanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.searchpanel.BackgroundImage = global::Library_Management_System.Properties.Resources.HOW_DO_YOU_DESIGN_A_LIBRARY_MANAGEMENT_SYSTEM_min1;
            this.searchpanel.Controls.Add(this.delete_btn);
            this.searchpanel.Controls.Add(this.deletelib_txt);
            this.searchpanel.Controls.Add(this.label2);
            this.searchpanel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.searchpanel.Location = new System.Drawing.Point(145, 68);
            this.searchpanel.Margin = new System.Windows.Forms.Padding(2);
            this.searchpanel.Name = "searchpanel";
            this.searchpanel.Size = new System.Drawing.Size(476, 247);
            this.searchpanel.TabIndex = 1;
            // 
            // deletelib_txt
            // 
            this.deletelib_txt.Location = new System.Drawing.Point(174, 90);
            this.deletelib_txt.Margin = new System.Windows.Forms.Padding(2);
            this.deletelib_txt.Name = "deletelib_txt";
            this.deletelib_txt.Size = new System.Drawing.Size(174, 20);
            this.deletelib_txt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(51, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Librarian ID";
            // 
            // deleteformcs
            // 
            this.AcceptButton = this.delete_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(765, 383);
            this.Controls.Add(this.searchpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "deleteformcs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "deleteformcs";
            this.searchpanel.ResumeLayout(false);
            this.searchpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel searchpanel;
        private Button delete_btn;
        private TextBox deletelib_txt;
        private Label label2;
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
       
        #endregion
    }
}