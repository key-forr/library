using Guna.UI2.WinForms;
using System.Drawing;
using System;

namespace library.Forms.Book
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
            this.panel_main = new System.Windows.Forms.Panel();
            this.button_books_list_navigation = new Guna.UI2.WinForms.Guna2Button();
            this.panel_books_interaction = new System.Windows.Forms.Panel();
            this.button_add_book_navigation = new Guna.UI2.WinForms.Guna2Button();
            this.text_box_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.button_back = new FontAwesome.Sharp.IconButton();
            this.panel_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.button_books_list_navigation);
            this.panel_main.Controls.Add(this.panel_books_interaction);
            this.panel_main.Controls.Add(this.button_add_book_navigation);
            this.panel_main.Controls.Add(this.text_box_search);
            this.panel_main.Controls.Add(this.button_back);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1422, 686);
            this.panel_main.TabIndex = 0;
            // 
            // button_books_list_navigation
            // 
            this.button_books_list_navigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.button_books_list_navigation.BorderRadius = 10;
            this.button_books_list_navigation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_books_list_navigation.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_books_list_navigation.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_books_list_navigation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_books_list_navigation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_books_list_navigation.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(78)))));
            this.button_books_list_navigation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_books_list_navigation.ForeColor = System.Drawing.Color.White;
            this.button_books_list_navigation.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(78)))));
            this.button_books_list_navigation.Location = new System.Drawing.Point(93, 140);
            this.button_books_list_navigation.Name = "button_books_list_navigation";
            this.button_books_list_navigation.Size = new System.Drawing.Size(265, 50);
            this.button_books_list_navigation.TabIndex = 29;
            this.button_books_list_navigation.Text = "Список книг";
            this.button_books_list_navigation.Click += new System.EventHandler(this.button_list_book_Click);
            this.button_books_list_navigation.MouseEnter += new System.EventHandler(this.button_books_list_navigation_MouseEnter);
            this.button_books_list_navigation.MouseLeave += new System.EventHandler(this.button_books_list_navigation_MouseLeave);
            // 
            // panel_books_interaction
            // 
            this.panel_books_interaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(50)))));
            this.panel_books_interaction.Location = new System.Drawing.Point(394, 12);
            this.panel_books_interaction.Name = "panel_books_interaction";
            this.panel_books_interaction.Size = new System.Drawing.Size(1016, 662);
            this.panel_books_interaction.TabIndex = 28;
            // 
            // button_add_book_navigation
            // 
            this.button_add_book_navigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.button_add_book_navigation.BorderRadius = 10;
            this.button_add_book_navigation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_add_book_navigation.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_add_book_navigation.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_add_book_navigation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_add_book_navigation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_add_book_navigation.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(78)))));
            this.button_add_book_navigation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add_book_navigation.ForeColor = System.Drawing.Color.White;
            this.button_add_book_navigation.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(78)))));
            this.button_add_book_navigation.Location = new System.Drawing.Point(93, 221);
            this.button_add_book_navigation.Name = "button_add_book_navigation";
            this.button_add_book_navigation.Size = new System.Drawing.Size(265, 50);
            this.button_add_book_navigation.TabIndex = 27;
            this.button_add_book_navigation.Text = "Додати книгу";
            this.button_add_book_navigation.Click += new System.EventHandler(this.button_add_book_Click);
            this.button_add_book_navigation.MouseEnter += new System.EventHandler(this.button_add_book_navigation_MouseEnter);
            this.button_add_book_navigation.MouseLeave += new System.EventHandler(this.button_add_book_navigation_MouseLeave);
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
            this.text_box_search.Location = new System.Drawing.Point(93, 69);
            this.text_box_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_box_search.Name = "text_box_search";
            this.text_box_search.PasswordChar = '\0';
            this.text_box_search.PlaceholderForeColor = System.Drawing.Color.White;
            this.text_box_search.PlaceholderText = "Введіть назву книги";
            this.text_box_search.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.text_box_search.SelectedText = "";
            this.text_box_search.Size = new System.Drawing.Size(265, 45);
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
            this.Controls.Add(this.panel_main);
            this.Name = "BooksForm";
            this.Text = "BooksForm";
            this.panel_main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel_books_interaction;
        private Guna.UI2.WinForms.Guna2Button button_add_book_navigation;
        private Guna.UI2.WinForms.Guna2TextBox text_box_search;
        private FontAwesome.Sharp.IconButton button_back;
        private Guna.UI2.WinForms.Guna2Button button_books_list_navigation;
    }
}