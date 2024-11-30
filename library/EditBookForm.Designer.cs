namespace library
{
    partial class EditBookForm
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
            this.button_save_book = new Guna.UI2.WinForms.Guna2Button();
            this.label_name = new System.Windows.Forms.Label();
            this.label_author = new System.Windows.Forms.Label();
            this.label_quantity = new System.Windows.Forms.Label();
            this.label_publishing = new System.Windows.Forms.Label();
            this.label_genre = new System.Windows.Forms.Label();
            this.label_year = new System.Windows.Forms.Label();
            this.label_edit_book = new System.Windows.Forms.Label();
            this.label_photo = new System.Windows.Forms.Label();
            this.text_box_quantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.text_box_publishing = new Guna.UI2.WinForms.Guna2TextBox();
            this.text_box_year = new Guna.UI2.WinForms.Guna2TextBox();
            this.text_box_author = new Guna.UI2.WinForms.Guna2TextBox();
            this.text_box_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.combo_box_genre = new Guna.UI2.WinForms.Guna2ComboBox();
            this.text_box_photo = new Guna.UI2.WinForms.Guna2TextBox();
            this.button_browse_photo = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // button_save_book
            // 
            this.button_save_book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(50)))));
            this.button_save_book.BorderRadius = 10;
            this.button_save_book.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_save_book.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_save_book.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_save_book.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_save_book.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_save_book.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(78)))));
            this.button_save_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save_book.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.button_save_book.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(78)))));
            this.button_save_book.Location = new System.Drawing.Point(198, 518);
            this.button_save_book.Name = "button_save_book";
            this.button_save_book.Size = new System.Drawing.Size(223, 50);
            this.button_save_book.TabIndex = 40;
            this.button_save_book.Text = "Зберегти";
            this.button_save_book.Click += new System.EventHandler(this.button_save_book_Click);
            this.button_save_book.MouseEnter += new System.EventHandler(this.button_save_book_MouseEnter);
            this.button_save_book.MouseLeave += new System.EventHandler(this.button_save_book_MouseLeave);
            // 
            // label_name
            // 
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(100)))), ((int)(((byte)(126)))));
            this.label_name.Location = new System.Drawing.Point(12, 82);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(85, 30);
            this.label_name.TabIndex = 41;
            this.label_name.Text = "Назва:";
            this.label_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_author
            // 
            this.label_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_author.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(100)))), ((int)(((byte)(126)))));
            this.label_author.Location = new System.Drawing.Point(12, 129);
            this.label_author.Name = "label_author";
            this.label_author.Size = new System.Drawing.Size(85, 30);
            this.label_author.TabIndex = 42;
            this.label_author.Text = "Автор:";
            this.label_author.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_quantity
            // 
            this.label_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_quantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(100)))), ((int)(((byte)(126)))));
            this.label_quantity.Location = new System.Drawing.Point(12, 317);
            this.label_quantity.Name = "label_quantity";
            this.label_quantity.Size = new System.Drawing.Size(116, 30);
            this.label_quantity.TabIndex = 46;
            this.label_quantity.Text = "Кількість:";
            this.label_quantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_publishing
            // 
            this.label_publishing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_publishing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(100)))), ((int)(((byte)(126)))));
            this.label_publishing.Location = new System.Drawing.Point(12, 176);
            this.label_publishing.Name = "label_publishing";
            this.label_publishing.Size = new System.Drawing.Size(153, 30);
            this.label_publishing.TabIndex = 45;
            this.label_publishing.Text = "Видавництво:";
            this.label_publishing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_genre
            // 
            this.label_genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_genre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(100)))), ((int)(((byte)(126)))));
            this.label_genre.Location = new System.Drawing.Point(12, 270);
            this.label_genre.Name = "label_genre";
            this.label_genre.Size = new System.Drawing.Size(76, 30);
            this.label_genre.TabIndex = 44;
            this.label_genre.Text = "Жанр:";
            this.label_genre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_year
            // 
            this.label_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_year.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(100)))), ((int)(((byte)(126)))));
            this.label_year.Location = new System.Drawing.Point(12, 223);
            this.label_year.Name = "label_year";
            this.label_year.Size = new System.Drawing.Size(141, 30);
            this.label_year.TabIndex = 43;
            this.label_year.Text = "Рік видання:";
            this.label_year.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_edit_book
            // 
            this.label_edit_book.AutoSize = true;
            this.label_edit_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_edit_book.ForeColor = System.Drawing.Color.White;
            this.label_edit_book.Location = new System.Drawing.Point(196, 23);
            this.label_edit_book.Name = "label_edit_book";
            this.label_edit_book.Size = new System.Drawing.Size(225, 38);
            this.label_edit_book.TabIndex = 47;
            this.label_edit_book.Text = "Редагування";
            this.label_edit_book.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_photo
            // 
            this.label_photo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_photo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(100)))), ((int)(((byte)(126)))));
            this.label_photo.Location = new System.Drawing.Point(12, 364);
            this.label_photo.Name = "label_photo";
            this.label_photo.Size = new System.Drawing.Size(95, 30);
            this.label_photo.TabIndex = 48;
            this.label_photo.Text = "Фото:";
            this.label_photo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // text_box_quantity
            // 
            this.text_box_quantity.BorderThickness = 0;
            this.text_box_quantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_box_quantity.DefaultText = "";
            this.text_box_quantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_box_quantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_box_quantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_quantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_quantity.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(50)))));
            this.text_box_quantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_box_quantity.ForeColor = System.Drawing.Color.White;
            this.text_box_quantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_quantity.Location = new System.Drawing.Point(134, 317);
            this.text_box_quantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_box_quantity.Name = "text_box_quantity";
            this.text_box_quantity.PasswordChar = '\0';
            this.text_box_quantity.PlaceholderText = "";
            this.text_box_quantity.SelectedText = "";
            this.text_box_quantity.Size = new System.Drawing.Size(309, 30);
            this.text_box_quantity.TabIndex = 53;
            this.text_box_quantity.WordWrap = false;
            // 
            // text_box_publishing
            // 
            this.text_box_publishing.BorderThickness = 0;
            this.text_box_publishing.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_box_publishing.DefaultText = "wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww";
            this.text_box_publishing.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_box_publishing.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_box_publishing.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_publishing.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_publishing.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(50)))));
            this.text_box_publishing.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_publishing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_box_publishing.ForeColor = System.Drawing.Color.White;
            this.text_box_publishing.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_publishing.Location = new System.Drawing.Point(156, 176);
            this.text_box_publishing.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_box_publishing.Name = "text_box_publishing";
            this.text_box_publishing.PasswordChar = '\0';
            this.text_box_publishing.PlaceholderText = "";
            this.text_box_publishing.SelectedText = "";
            this.text_box_publishing.Size = new System.Drawing.Size(465, 30);
            this.text_box_publishing.TabIndex = 51;
            this.text_box_publishing.WordWrap = false;
            // 
            // text_box_year
            // 
            this.text_box_year.BorderThickness = 0;
            this.text_box_year.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_box_year.DefaultText = "";
            this.text_box_year.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_box_year.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_box_year.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_year.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_year.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(50)))));
            this.text_box_year.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_box_year.ForeColor = System.Drawing.Color.White;
            this.text_box_year.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_year.Location = new System.Drawing.Point(159, 223);
            this.text_box_year.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_box_year.Name = "text_box_year";
            this.text_box_year.PasswordChar = '\0';
            this.text_box_year.PlaceholderText = "";
            this.text_box_year.SelectedText = "";
            this.text_box_year.Size = new System.Drawing.Size(284, 30);
            this.text_box_year.TabIndex = 50;
            this.text_box_year.WordWrap = false;
            // 
            // text_box_author
            // 
            this.text_box_author.BorderColor = System.Drawing.Color.White;
            this.text_box_author.BorderThickness = 0;
            this.text_box_author.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_box_author.DefaultText = "wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww";
            this.text_box_author.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_box_author.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_box_author.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_author.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_author.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(50)))));
            this.text_box_author.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_box_author.ForeColor = System.Drawing.Color.White;
            this.text_box_author.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_author.Location = new System.Drawing.Point(103, 124);
            this.text_box_author.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_box_author.Name = "text_box_author";
            this.text_box_author.PasswordChar = '\0';
            this.text_box_author.PlaceholderText = "";
            this.text_box_author.SelectedText = "";
            this.text_box_author.Size = new System.Drawing.Size(518, 35);
            this.text_box_author.TabIndex = 49;
            this.text_box_author.WordWrap = false;
            // 
            // text_box_name
            // 
            this.text_box_name.BorderColor = System.Drawing.Color.White;
            this.text_box_name.BorderThickness = 0;
            this.text_box_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_box_name.DefaultText = "wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww";
            this.text_box_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_box_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_box_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_name.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(50)))));
            this.text_box_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_box_name.ForeColor = System.Drawing.Color.White;
            this.text_box_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_name.Location = new System.Drawing.Point(103, 82);
            this.text_box_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_box_name.Name = "text_box_name";
            this.text_box_name.PasswordChar = '\0';
            this.text_box_name.PlaceholderText = "";
            this.text_box_name.SelectedText = "";
            this.text_box_name.Size = new System.Drawing.Size(518, 35);
            this.text_box_name.TabIndex = 54;
            this.text_box_name.WordWrap = false;
            // 
            // combo_box_genre
            // 
            this.combo_box_genre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(50)))));
            this.combo_box_genre.BorderColor = System.Drawing.Color.White;
            this.combo_box_genre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.combo_box_genre.DisplayMember = "id";
            this.combo_box_genre.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo_box_genre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_box_genre.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(50)))));
            this.combo_box_genre.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combo_box_genre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combo_box_genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.combo_box_genre.ForeColor = System.Drawing.Color.White;
            this.combo_box_genre.ItemHeight = 30;
            this.combo_box_genre.Location = new System.Drawing.Point(94, 270);
            this.combo_box_genre.Name = "combo_box_genre";
            this.combo_box_genre.Size = new System.Drawing.Size(327, 36);
            this.combo_box_genre.TabIndex = 55;
            this.combo_box_genre.ValueMember = "id";
            // 
            // text_box_photo
            // 
            this.text_box_photo.BorderThickness = 0;
            this.text_box_photo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_box_photo.DefaultText = "";
            this.text_box_photo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_box_photo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_box_photo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_photo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_photo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(50)))));
            this.text_box_photo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_photo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_box_photo.ForeColor = System.Drawing.Color.White;
            this.text_box_photo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_photo.Location = new System.Drawing.Point(94, 364);
            this.text_box_photo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_box_photo.Name = "text_box_photo";
            this.text_box_photo.PasswordChar = '\0';
            this.text_box_photo.PlaceholderText = "";
            this.text_box_photo.SelectedText = "";
            this.text_box_photo.Size = new System.Drawing.Size(527, 30);
            this.text_box_photo.TabIndex = 56;
            this.text_box_photo.WordWrap = false;
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
            this.button_browse_photo.Location = new System.Drawing.Point(17, 401);
            this.button_browse_photo.Name = "button_browse_photo";
            this.button_browse_photo.Size = new System.Drawing.Size(152, 35);
            this.button_browse_photo.TabIndex = 57;
            this.button_browse_photo.Text = "Вибрати";
            this.button_browse_photo.Click += new System.EventHandler(this.button_browse_photo_Click);
            // 
            // EditBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(633, 603);
            this.Controls.Add(this.button_browse_photo);
            this.Controls.Add(this.text_box_photo);
            this.Controls.Add(this.combo_box_genre);
            this.Controls.Add(this.text_box_name);
            this.Controls.Add(this.text_box_quantity);
            this.Controls.Add(this.text_box_publishing);
            this.Controls.Add(this.text_box_year);
            this.Controls.Add(this.text_box_author);
            this.Controls.Add(this.label_photo);
            this.Controls.Add(this.label_edit_book);
            this.Controls.Add(this.label_quantity);
            this.Controls.Add(this.label_publishing);
            this.Controls.Add(this.label_genre);
            this.Controls.Add(this.label_year);
            this.Controls.Add(this.label_author);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.button_save_book);
            this.Name = "EditBookForm";
            this.Text = "EditBookForm";
            this.Load += new System.EventHandler(this.EditBookForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button button_save_book;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_author;
        private System.Windows.Forms.Label label_quantity;
        private System.Windows.Forms.Label label_publishing;
        private System.Windows.Forms.Label label_genre;
        private System.Windows.Forms.Label label_year;
        private System.Windows.Forms.Label label_edit_book;
        private System.Windows.Forms.Label label_photo;
        private Guna.UI2.WinForms.Guna2TextBox text_box_quantity;
        private Guna.UI2.WinForms.Guna2TextBox text_box_publishing;
        private Guna.UI2.WinForms.Guna2TextBox text_box_year;
        private Guna.UI2.WinForms.Guna2TextBox text_box_author;
        private Guna.UI2.WinForms.Guna2TextBox text_box_name;
        private Guna.UI2.WinForms.Guna2ComboBox combo_box_genre;
        private Guna.UI2.WinForms.Guna2TextBox text_box_photo;
        private Guna.UI2.WinForms.Guna2Button button_browse_photo;
    }
}