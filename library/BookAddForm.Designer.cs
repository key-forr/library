namespace library
{
    partial class BookAddForm
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
            this.label_add_book = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_author = new System.Windows.Forms.Label();
            this.label_publishing = new System.Windows.Forms.Label();
            this.label_quantity = new System.Windows.Forms.Label();
            this.label_genre = new System.Windows.Forms.Label();
            this.label_photo = new System.Windows.Forms.Label();
            this.label_year = new System.Windows.Forms.Label();
            this.text_box_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.text_box_author = new Guna.UI2.WinForms.Guna2TextBox();
            this.text_box_year = new Guna.UI2.WinForms.Guna2TextBox();
            this.text_box_publishing = new Guna.UI2.WinForms.Guna2TextBox();
            this.combo_box_genre = new Guna.UI2.WinForms.Guna2ComboBox();
            this.text_box_quantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.button_add_book = new Guna.UI2.WinForms.Guna2Button();
            this.button_browse_photo = new Guna.UI2.WinForms.Guna2Button();
            this.picture_box_photo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box_photo)).BeginInit();
            this.SuspendLayout();
            // 
            // label_add_book
            // 
            this.label_add_book.AutoSize = true;
            this.label_add_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_add_book.ForeColor = System.Drawing.Color.White;
            this.label_add_book.Location = new System.Drawing.Point(371, 32);
            this.label_add_book.Name = "label_add_book";
            this.label_add_book.Size = new System.Drawing.Size(235, 38);
            this.label_add_book.TabIndex = 0;
            this.label_add_book.Text = "Додати книгу";
            this.label_add_book.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(100)))), ((int)(((byte)(126)))));
            this.label_name.Location = new System.Drawing.Point(36, 104);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(133, 25);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "Назва книги";
            // 
            // label_author
            // 
            this.label_author.AutoSize = true;
            this.label_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_author.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(100)))), ((int)(((byte)(126)))));
            this.label_author.Location = new System.Drawing.Point(36, 190);
            this.label_author.Name = "label_author";
            this.label_author.Size = new System.Drawing.Size(74, 25);
            this.label_author.TabIndex = 2;
            this.label_author.Text = "Автор";
            // 
            // label_publishing
            // 
            this.label_publishing.AutoSize = true;
            this.label_publishing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_publishing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(100)))), ((int)(((byte)(126)))));
            this.label_publishing.Location = new System.Drawing.Point(220, 273);
            this.label_publishing.Name = "label_publishing";
            this.label_publishing.Size = new System.Drawing.Size(145, 25);
            this.label_publishing.TabIndex = 3;
            this.label_publishing.Text = "Видавництво";
            // 
            // label_quantity
            // 
            this.label_quantity.AutoSize = true;
            this.label_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_quantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(100)))), ((int)(((byte)(126)))));
            this.label_quantity.Location = new System.Drawing.Point(36, 432);
            this.label_quantity.Name = "label_quantity";
            this.label_quantity.Size = new System.Drawing.Size(105, 25);
            this.label_quantity.TabIndex = 4;
            this.label_quantity.Text = "Кількість";
            // 
            // label_genre
            // 
            this.label_genre.AutoSize = true;
            this.label_genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_genre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(100)))), ((int)(((byte)(126)))));
            this.label_genre.Location = new System.Drawing.Point(36, 359);
            this.label_genre.Name = "label_genre";
            this.label_genre.Size = new System.Drawing.Size(67, 25);
            this.label_genre.TabIndex = 5;
            this.label_genre.Text = "Жанр";
            // 
            // label_photo
            // 
            this.label_photo.AutoSize = true;
            this.label_photo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_photo.ForeColor = System.Drawing.Color.White;
            this.label_photo.Location = new System.Drawing.Point(770, 88);
            this.label_photo.Name = "label_photo";
            this.label_photo.Size = new System.Drawing.Size(81, 29);
            this.label_photo.TabIndex = 6;
            this.label_photo.Text = "Фото";
            // 
            // label_year
            // 
            this.label_year.AutoSize = true;
            this.label_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_year.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(100)))), ((int)(((byte)(126)))));
            this.label_year.Location = new System.Drawing.Point(36, 273);
            this.label_year.Name = "label_year";
            this.label_year.Size = new System.Drawing.Size(130, 25);
            this.label_year.TabIndex = 7;
            this.label_year.Text = "Рік видання";
            // 
            // text_box_name
            // 
            this.text_box_name.BorderColor = System.Drawing.Color.White;
            this.text_box_name.BorderRadius = 10;
            this.text_box_name.BorderThickness = 0;
            this.text_box_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_box_name.DefaultText = "";
            this.text_box_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_box_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_box_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_name.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.text_box_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_box_name.ForeColor = System.Drawing.Color.White;
            this.text_box_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_name.Location = new System.Drawing.Point(34, 134);
            this.text_box_name.Margin = new System.Windows.Forms.Padding(5);
            this.text_box_name.Name = "text_box_name";
            this.text_box_name.PasswordChar = '\0';
            this.text_box_name.PlaceholderText = "";
            this.text_box_name.SelectedText = "";
            this.text_box_name.Size = new System.Drawing.Size(604, 47);
            this.text_box_name.TabIndex = 9;
            // 
            // text_box_author
            // 
            this.text_box_author.BorderColor = System.Drawing.Color.White;
            this.text_box_author.BorderRadius = 10;
            this.text_box_author.BorderThickness = 0;
            this.text_box_author.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_box_author.DefaultText = "";
            this.text_box_author.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_box_author.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_box_author.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_author.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_author.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.text_box_author.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_box_author.ForeColor = System.Drawing.Color.White;
            this.text_box_author.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_author.Location = new System.Drawing.Point(34, 220);
            this.text_box_author.Margin = new System.Windows.Forms.Padding(5);
            this.text_box_author.Name = "text_box_author";
            this.text_box_author.PasswordChar = '\0';
            this.text_box_author.PlaceholderText = "";
            this.text_box_author.SelectedText = "";
            this.text_box_author.Size = new System.Drawing.Size(602, 44);
            this.text_box_author.TabIndex = 10;
            // 
            // text_box_year
            // 
            this.text_box_year.BorderColor = System.Drawing.Color.White;
            this.text_box_year.BorderRadius = 10;
            this.text_box_year.BorderThickness = 0;
            this.text_box_year.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_box_year.DefaultText = "";
            this.text_box_year.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_box_year.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_box_year.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_year.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_year.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.text_box_year.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_box_year.ForeColor = System.Drawing.Color.White;
            this.text_box_year.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_year.Location = new System.Drawing.Point(34, 462);
            this.text_box_year.Margin = new System.Windows.Forms.Padding(5);
            this.text_box_year.Name = "text_box_year";
            this.text_box_year.PasswordChar = '\0';
            this.text_box_year.PlaceholderText = "";
            this.text_box_year.SelectedText = "";
            this.text_box_year.Size = new System.Drawing.Size(161, 43);
            this.text_box_year.TabIndex = 11;
            this.text_box_year.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_box_year_KeyPress);
            // 
            // text_box_publishing
            // 
            this.text_box_publishing.BorderColor = System.Drawing.Color.White;
            this.text_box_publishing.BorderRadius = 10;
            this.text_box_publishing.BorderThickness = 0;
            this.text_box_publishing.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_box_publishing.DefaultText = "";
            this.text_box_publishing.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_box_publishing.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_box_publishing.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_publishing.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_publishing.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.text_box_publishing.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_publishing.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_box_publishing.ForeColor = System.Drawing.Color.White;
            this.text_box_publishing.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_publishing.Location = new System.Drawing.Point(225, 303);
            this.text_box_publishing.Margin = new System.Windows.Forms.Padding(5);
            this.text_box_publishing.Name = "text_box_publishing";
            this.text_box_publishing.PasswordChar = '\0';
            this.text_box_publishing.PlaceholderText = "";
            this.text_box_publishing.SelectedText = "";
            this.text_box_publishing.Size = new System.Drawing.Size(413, 45);
            this.text_box_publishing.TabIndex = 12;
            // 
            // combo_box_genre
            // 
            this.combo_box_genre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(50)))));
            this.combo_box_genre.BorderColor = System.Drawing.Color.White;
            this.combo_box_genre.BorderRadius = 10;
            this.combo_box_genre.BorderThickness = 0;
            this.combo_box_genre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.combo_box_genre.DisplayMember = "id";
            this.combo_box_genre.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo_box_genre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_box_genre.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.combo_box_genre.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combo_box_genre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combo_box_genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.combo_box_genre.ForeColor = System.Drawing.Color.White;
            this.combo_box_genre.ItemHeight = 30;
            this.combo_box_genre.Location = new System.Drawing.Point(34, 387);
            this.combo_box_genre.Name = "combo_box_genre";
            this.combo_box_genre.Size = new System.Drawing.Size(602, 36);
            this.combo_box_genre.TabIndex = 13;
            this.combo_box_genre.ValueMember = "id";
            // 
            // text_box_quantity
            // 
            this.text_box_quantity.BorderColor = System.Drawing.Color.White;
            this.text_box_quantity.BorderRadius = 10;
            this.text_box_quantity.BorderThickness = 0;
            this.text_box_quantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_box_quantity.DefaultText = "";
            this.text_box_quantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_box_quantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_box_quantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_quantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_quantity.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.text_box_quantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_box_quantity.ForeColor = System.Drawing.Color.White;
            this.text_box_quantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_quantity.Location = new System.Drawing.Point(34, 303);
            this.text_box_quantity.Margin = new System.Windows.Forms.Padding(5);
            this.text_box_quantity.Name = "text_box_quantity";
            this.text_box_quantity.PasswordChar = '\0';
            this.text_box_quantity.PlaceholderText = "";
            this.text_box_quantity.SelectedText = "";
            this.text_box_quantity.Size = new System.Drawing.Size(161, 45);
            this.text_box_quantity.TabIndex = 14;
            this.text_box_quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_box_quantity_KeyPress);
            // 
            // button_add_book
            // 
            this.button_add_book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(50)))));
            this.button_add_book.BorderRadius = 10;
            this.button_add_book.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_add_book.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_add_book.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_add_book.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_add_book.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_add_book.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(169)))), ((int)(((byte)(118)))));
            this.button_add_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add_book.ForeColor = System.Drawing.Color.White;
            this.button_add_book.Location = new System.Drawing.Point(378, 515);
            this.button_add_book.Name = "button_add_book";
            this.button_add_book.Size = new System.Drawing.Size(228, 49);
            this.button_add_book.TabIndex = 16;
            this.button_add_book.Text = "Додати";
            this.button_add_book.Click += new System.EventHandler(this.button_add_book_Click);
            this.button_add_book.MouseEnter += new System.EventHandler(this.button_add_book_MouseEnter);
            this.button_add_book.MouseLeave += new System.EventHandler(this.button_add_book_MouseLeave);
            // 
            // button_browse_photo
            // 
            this.button_browse_photo.BorderColor = System.Drawing.Color.White;
            this.button_browse_photo.BorderThickness = 1;
            this.button_browse_photo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_browse_photo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_browse_photo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_browse_photo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_browse_photo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_browse_photo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.button_browse_photo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_browse_photo.ForeColor = System.Drawing.Color.White;
            this.button_browse_photo.Location = new System.Drawing.Point(802, 470);
            this.button_browse_photo.Name = "button_browse_photo";
            this.button_browse_photo.Size = new System.Drawing.Size(152, 35);
            this.button_browse_photo.TabIndex = 17;
            this.button_browse_photo.Text = "Вибрати";
            this.button_browse_photo.Click += new System.EventHandler(this.button_browse_photo_Click);
            // 
            // picture_box_photo
            // 
            this.picture_box_photo.Location = new System.Drawing.Point(669, 120);
            this.picture_box_photo.Name = "picture_box_photo";
            this.picture_box_photo.Size = new System.Drawing.Size(285, 335);
            this.picture_box_photo.TabIndex = 18;
            this.picture_box_photo.TabStop = false;
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(998, 615);
            this.Controls.Add(this.picture_box_photo);
            this.Controls.Add(this.button_browse_photo);
            this.Controls.Add(this.button_add_book);
            this.Controls.Add(this.text_box_quantity);
            this.Controls.Add(this.combo_box_genre);
            this.Controls.Add(this.text_box_publishing);
            this.Controls.Add(this.text_box_year);
            this.Controls.Add(this.text_box_author);
            this.Controls.Add(this.text_box_name);
            this.Controls.Add(this.label_year);
            this.Controls.Add(this.label_photo);
            this.Controls.Add(this.label_genre);
            this.Controls.Add(this.label_quantity);
            this.Controls.Add(this.label_publishing);
            this.Controls.Add(this.label_author);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_add_book);
            this.Name = "AddBookForm";
            this.Text = "AddBookForm";
            this.Load += new System.EventHandler(this.AddBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_box_photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_add_book;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_author;
        private System.Windows.Forms.Label label_publishing;
        private System.Windows.Forms.Label label_quantity;
        private System.Windows.Forms.Label label_genre;
        private System.Windows.Forms.Label label_photo;
        private System.Windows.Forms.Label label_year;
        private Guna.UI2.WinForms.Guna2TextBox text_box_name;
        private Guna.UI2.WinForms.Guna2TextBox text_box_author;
        private Guna.UI2.WinForms.Guna2TextBox text_box_year;
        private Guna.UI2.WinForms.Guna2TextBox text_box_publishing;
        private Guna.UI2.WinForms.Guna2ComboBox combo_box_genre;
        private Guna.UI2.WinForms.Guna2TextBox text_box_quantity;
        private Guna.UI2.WinForms.Guna2Button button_add_book;
        private Guna.UI2.WinForms.Guna2Button button_browse_photo;
        private System.Windows.Forms.PictureBox picture_box_photo;
    }
}