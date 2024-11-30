using Guna.UI2.WinForms;
using System.Drawing;
using System;

namespace library
{
    partial class BooksForm
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
            this.panel = new System.Windows.Forms.Panel();
            this.button_list_book = new Guna.UI2.WinForms.Guna2Button();
            this.panel_main = new System.Windows.Forms.Panel();
            this.button_add_book = new Guna.UI2.WinForms.Guna2Button();
            this.text_box_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.button_back = new FontAwesome.Sharp.IconButton();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.button_list_book);
            this.panel.Controls.Add(this.panel_main);
            this.panel.Controls.Add(this.button_add_book);
            this.panel.Controls.Add(this.text_box_search);
            this.panel.Controls.Add(this.button_back);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1422, 686);
            this.panel.TabIndex = 0;
            // 
            // button_list_book
            // 
            this.button_list_book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.button_list_book.BorderRadius = 10;
            this.button_list_book.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_list_book.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_list_book.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_list_book.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_list_book.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_list_book.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(78)))));
            this.button_list_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_list_book.ForeColor = System.Drawing.Color.White;
            this.button_list_book.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(78)))));
            this.button_list_book.Location = new System.Drawing.Point(87, 151);
            this.button_list_book.Name = "button_list_book";
            this.button_list_book.Size = new System.Drawing.Size(243, 50);
            this.button_list_book.TabIndex = 29;
            this.button_list_book.Text = "Список Книг";
            this.button_list_book.Click += new System.EventHandler(this.button_list_book_Click);
            this.button_list_book.MouseEnter += new System.EventHandler(this.button_list_book_MouseEnter);
            this.button_list_book.MouseLeave += new System.EventHandler(this.button_list_book_MouseLeave);
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(50)))));
            this.panel_main.Location = new System.Drawing.Point(394, 12);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1016, 662);
            this.panel_main.TabIndex = 28;
            // 
            // button_add_book
            // 
            this.button_add_book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.button_add_book.BorderRadius = 10;
            this.button_add_book.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_add_book.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_add_book.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_add_book.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_add_book.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_add_book.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(78)))));
            this.button_add_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add_book.ForeColor = System.Drawing.Color.White;
            this.button_add_book.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(78)))));
            this.button_add_book.Location = new System.Drawing.Point(87, 224);
            this.button_add_book.Name = "button_add_book";
            this.button_add_book.Size = new System.Drawing.Size(243, 50);
            this.button_add_book.TabIndex = 27;
            this.button_add_book.Text = "Додати книгу";
            this.button_add_book.Click += new System.EventHandler(this.button_add_book_Click);
            this.button_add_book.MouseEnter += new System.EventHandler(this.button_add_book_MouseEnter);
            this.button_add_book.MouseLeave += new System.EventHandler(this.button_add_book_MouseLeave);
            // 
            // text_box_search
            // 
            this.text_box_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(50)))));
            this.text_box_search.BorderColor = System.Drawing.Color.White;
            this.text_box_search.BorderRadius = 10;
            this.text_box_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_box_search.DefaultText = "";
            this.text_box_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_box_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_box_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_search.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(50)))));
            this.text_box_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_search.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_box_search.ForeColor = System.Drawing.Color.White;
            this.text_box_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_search.IconLeft = global::library.Properties.Resources.Search;
            this.text_box_search.Location = new System.Drawing.Point(87, 82);
            this.text_box_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_box_search.Name = "text_box_search";
            this.text_box_search.PasswordChar = '\0';
            this.text_box_search.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.text_box_search.PlaceholderText = "Введіть назву книги";
            this.text_box_search.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.text_box_search.SelectedText = "";
            this.text_box_search.Size = new System.Drawing.Size(243, 45);
            this.text_box_search.TabIndex = 26;
            this.text_box_search.TextChanged += new System.EventHandler(this.text_box_search_TextChanged);
            this.text_box_search.Enter += new System.EventHandler(this.text_box_search_Enter);
            // 
            // button_back
            // 
            this.button_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_back.FlatAppearance.BorderSize = 0;
            this.button_back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.button_back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_back.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.button_back.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(169)))), ((int)(((byte)(118)))));
            this.button_back.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button_back.Location = new System.Drawing.Point(12, 12);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(55, 46);
            this.button_back.TabIndex = 25;
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // BooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1422, 686);
            this.Controls.Add(this.panel);
            this.Name = "BooksForm";
            this.Text = "BooksForm";
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel panel_main;
        private Guna.UI2.WinForms.Guna2Button button_add_book;
        private Guna.UI2.WinForms.Guna2TextBox text_box_search;
        private FontAwesome.Sharp.IconButton button_back;
        private Guna.UI2.WinForms.Guna2Button button_list_book;
    }
}