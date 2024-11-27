namespace library
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_navigation = new System.Windows.Forms.Panel();
            this.button_home_navigation = new FontAwesome.Sharp.IconButton();
            this.label_book = new System.Windows.Forms.Label();
            this.label_haven = new System.Windows.Forms.Label();
            this.button_personal_office_nav = new Guna.UI2.WinForms.Guna2Button();
            this.logo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.button_employee_navigation = new System.Windows.Forms.Button();
            this.button_statistics_navigation = new System.Windows.Forms.Button();
            this.button_booking_navigation = new System.Windows.Forms.Button();
            this.button_books_navigation = new System.Windows.Forms.Button();
            this.button_customer_navigation = new System.Windows.Forms.Button();
            this.button_storage_navigation = new System.Windows.Forms.Button();
            this.panel_main = new Guna.UI2.WinForms.Guna2Panel();
            this.panel_reminder = new Guna.UI2.WinForms.Guna2Panel();
            this.bellButton = new FontAwesome.Sharp.IconButton();
            this.reminder_view = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.button_add_reminder = new Guna.UI2.WinForms.Guna2Button();
            this.label_reminder = new System.Windows.Forms.Label();
            this.panel_window_navigation = new System.Windows.Forms.Panel();
            this.button_collapse = new FontAwesome.Sharp.IconButton();
            this.button_window_state = new FontAwesome.Sharp.IconButton();
            this.button_close = new FontAwesome.Sharp.IconButton();
            this.panel_navigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel_main.SuspendLayout();
            this.panel_reminder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reminder_view)).BeginInit();
            this.panel_window_navigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_navigation
            // 
            this.panel_navigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(50)))));
            this.panel_navigation.Controls.Add(this.button_home_navigation);
            this.panel_navigation.Controls.Add(this.label_book);
            this.panel_navigation.Controls.Add(this.label_haven);
            this.panel_navigation.Controls.Add(this.button_personal_office_nav);
            this.panel_navigation.Controls.Add(this.logo);
            this.panel_navigation.Controls.Add(this.button_employee_navigation);
            this.panel_navigation.Controls.Add(this.button_statistics_navigation);
            this.panel_navigation.Controls.Add(this.button_booking_navigation);
            this.panel_navigation.Controls.Add(this.button_books_navigation);
            this.panel_navigation.Controls.Add(this.button_customer_navigation);
            this.panel_navigation.Controls.Add(this.button_storage_navigation);
            this.panel_navigation.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_navigation.Location = new System.Drawing.Point(0, 35);
            this.panel_navigation.Name = "panel_navigation";
            this.panel_navigation.Size = new System.Drawing.Size(1440, 123);
            this.panel_navigation.TabIndex = 0;
            // 
            // button_home_navigation
            // 
            this.button_home_navigation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_home_navigation.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_home_navigation.FlatAppearance.BorderSize = 0;
            this.button_home_navigation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_home_navigation.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.button_home_navigation.IconColor = System.Drawing.Color.White;
            this.button_home_navigation.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button_home_navigation.Location = new System.Drawing.Point(1319, 0);
            this.button_home_navigation.Name = "button_home_navigation";
            this.button_home_navigation.Size = new System.Drawing.Size(50, 123);
            this.button_home_navigation.TabIndex = 20;
            this.button_home_navigation.UseVisualStyleBackColor = true;
            // 
            // label_book
            // 
            this.label_book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(50)))));
            this.label_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_book.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.label_book.Location = new System.Drawing.Point(145, 18);
            this.label_book.Name = "label_book";
            this.label_book.Size = new System.Drawing.Size(130, 43);
            this.label_book.TabIndex = 27;
            this.label_book.Text = "Book";
            this.label_book.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_haven
            // 
            this.label_haven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(50)))));
            this.label_haven.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_haven.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.label_haven.Location = new System.Drawing.Point(146, 61);
            this.label_haven.Name = "label_haven";
            this.label_haven.Size = new System.Drawing.Size(117, 43);
            this.label_haven.TabIndex = 26;
            this.label_haven.Text = "Haven";
            this.label_haven.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_personal_office_nav
            // 
            this.button_personal_office_nav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_personal_office_nav.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_personal_office_nav.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_personal_office_nav.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_personal_office_nav.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_personal_office_nav.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_personal_office_nav.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(50)))));
            this.button_personal_office_nav.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_personal_office_nav.ForeColor = System.Drawing.Color.White;
            this.button_personal_office_nav.Image = global::library.Properties.Resources.User;
            this.button_personal_office_nav.ImageSize = new System.Drawing.Size(45, 45);
            this.button_personal_office_nav.Location = new System.Drawing.Point(1369, 0);
            this.button_personal_office_nav.Name = "button_personal_office_nav";
            this.button_personal_office_nav.Size = new System.Drawing.Size(71, 123);
            this.button_personal_office_nav.TabIndex = 1;
            this.button_personal_office_nav.Click += new System.EventHandler(this.button_personal_office_nav_Click);
            // 
            // logo
            // 
            this.logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.ImageRotate = 0F;
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.logo.Name = "logo";
            this.logo.Padding = new System.Windows.Forms.Padding(25, 0, 10, 0);
            this.logo.Size = new System.Drawing.Size(200, 123);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logo.TabIndex = 13;
            this.logo.TabStop = false;
            // 
            // button_employee_navigation
            // 
            this.button_employee_navigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(50)))));
            this.button_employee_navigation.FlatAppearance.BorderSize = 0;
            this.button_employee_navigation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_employee_navigation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_employee_navigation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.button_employee_navigation.Location = new System.Drawing.Point(1089, 47);
            this.button_employee_navigation.Name = "button_employee_navigation";
            this.button_employee_navigation.Size = new System.Drawing.Size(200, 40);
            this.button_employee_navigation.TabIndex = 12;
            this.button_employee_navigation.Text = "Працівники";
            this.button_employee_navigation.UseVisualStyleBackColor = false;
            this.button_employee_navigation.Click += new System.EventHandler(this.button_employee_nav_Click);
            // 
            // button_statistics_navigation
            // 
            this.button_statistics_navigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(50)))));
            this.button_statistics_navigation.FlatAppearance.BorderSize = 0;
            this.button_statistics_navigation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_statistics_navigation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_statistics_navigation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.button_statistics_navigation.Location = new System.Drawing.Point(893, 47);
            this.button_statistics_navigation.Name = "button_statistics_navigation";
            this.button_statistics_navigation.Size = new System.Drawing.Size(200, 40);
            this.button_statistics_navigation.TabIndex = 11;
            this.button_statistics_navigation.Text = "Статистика";
            this.button_statistics_navigation.UseVisualStyleBackColor = false;
            // 
            // button_booking_navigation
            // 
            this.button_booking_navigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(50)))));
            this.button_booking_navigation.FlatAppearance.BorderSize = 0;
            this.button_booking_navigation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_booking_navigation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_booking_navigation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.button_booking_navigation.Location = new System.Drawing.Point(405, 47);
            this.button_booking_navigation.Name = "button_booking_navigation";
            this.button_booking_navigation.Size = new System.Drawing.Size(200, 40);
            this.button_booking_navigation.TabIndex = 8;
            this.button_booking_navigation.Text = "Бронювання";
            this.button_booking_navigation.UseVisualStyleBackColor = false;
            // 
            // button_books_navigation
            // 
            this.button_books_navigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(50)))));
            this.button_books_navigation.FlatAppearance.BorderSize = 0;
            this.button_books_navigation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_books_navigation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_books_navigation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.button_books_navigation.Location = new System.Drawing.Point(626, 47);
            this.button_books_navigation.Name = "button_books_navigation";
            this.button_books_navigation.Size = new System.Drawing.Size(100, 40);
            this.button_books_navigation.TabIndex = 9;
            this.button_books_navigation.Text = "Книги";
            this.button_books_navigation.UseVisualStyleBackColor = false;
            // 
            // button_customer_navigation
            // 
            this.button_customer_navigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(50)))));
            this.button_customer_navigation.FlatAppearance.BorderSize = 0;
            this.button_customer_navigation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_customer_navigation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_customer_navigation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.button_customer_navigation.Location = new System.Drawing.Point(753, 47);
            this.button_customer_navigation.Name = "button_customer_navigation";
            this.button_customer_navigation.Size = new System.Drawing.Size(130, 40);
            this.button_customer_navigation.TabIndex = 10;
            this.button_customer_navigation.Text = "Клієнти";
            this.button_customer_navigation.UseVisualStyleBackColor = false;
            // 
            // button_storage_navigation
            // 
            this.button_storage_navigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(50)))));
            this.button_storage_navigation.FlatAppearance.BorderSize = 0;
            this.button_storage_navigation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_storage_navigation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_storage_navigation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.button_storage_navigation.Location = new System.Drawing.Point(269, 47);
            this.button_storage_navigation.Name = "button_storage_navigation";
            this.button_storage_navigation.Size = new System.Drawing.Size(130, 40);
            this.button_storage_navigation.TabIndex = 0;
            this.button_storage_navigation.Text = "Склад";
            this.button_storage_navigation.UseVisualStyleBackColor = false;
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.panel_main.Controls.Add(this.panel_reminder);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_main.Location = new System.Drawing.Point(0, 157);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1440, 743);
            this.panel_main.TabIndex = 10;
            // 
            // panel_reminder
            // 
            this.panel_reminder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_reminder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(50)))));
            this.panel_reminder.Controls.Add(this.bellButton);
            this.panel_reminder.Controls.Add(this.reminder_view);
            this.panel_reminder.Controls.Add(this.button_add_reminder);
            this.panel_reminder.Controls.Add(this.label_reminder);
            this.panel_reminder.Location = new System.Drawing.Point(983, 109);
            this.panel_reminder.Name = "panel_reminder";
            this.panel_reminder.Size = new System.Drawing.Size(370, 336);
            this.panel_reminder.TabIndex = 17;
            // 
            // bellButton
            // 
            this.bellButton.FlatAppearance.BorderSize = 0;
            this.bellButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bellButton.IconChar = FontAwesome.Sharp.IconChar.Bell;
            this.bellButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(169)))), ((int)(((byte)(118)))));
            this.bellButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bellButton.IconSize = 24;
            this.bellButton.Location = new System.Drawing.Point(274, 26);
            this.bellButton.Name = "bellButton";
            this.bellButton.Size = new System.Drawing.Size(42, 23);
            this.bellButton.TabIndex = 18;
            this.bellButton.UseVisualStyleBackColor = true;
            // 
            // reminder_view
            // 
            this.reminder_view.AllowUserToAddRows = false;
            this.reminder_view.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.reminder_view.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.reminder_view.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reminder_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reminder_view.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(50)))));
            this.reminder_view.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reminder_view.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.reminder_view.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(100)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(100)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.reminder_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.reminder_view.ColumnHeadersHeight = 50;
            this.reminder_view.ColumnHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(100)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.reminder_view.DefaultCellStyle = dataGridViewCellStyle6;
            this.reminder_view.DoubleBuffered = true;
            this.reminder_view.EnableHeadersVisualStyles = false;
            this.reminder_view.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(50)))));
            this.reminder_view.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(100)))), ((int)(((byte)(126)))));
            this.reminder_view.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(100)))), ((int)(((byte)(126)))));
            this.reminder_view.Location = new System.Drawing.Point(36, 77);
            this.reminder_view.Name = "reminder_view";
            this.reminder_view.ReadOnly = true;
            this.reminder_view.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.reminder_view.RowHeadersVisible = false;
            this.reminder_view.RowHeadersWidth = 51;
            this.reminder_view.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(100)))), ((int)(((byte)(126)))));
            this.reminder_view.RowTemplate.Height = 40;
            this.reminder_view.RowTemplate.ReadOnly = true;
            this.reminder_view.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.reminder_view.Size = new System.Drawing.Size(299, 160);
            this.reminder_view.TabIndex = 0;
            // 
            // button_add_reminder
            // 
            this.button_add_reminder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(50)))));
            this.button_add_reminder.BorderRadius = 10;
            this.button_add_reminder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_add_reminder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_add_reminder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_add_reminder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_add_reminder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(169)))), ((int)(((byte)(118)))));
            this.button_add_reminder.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add_reminder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.button_add_reminder.Location = new System.Drawing.Point(113, 271);
            this.button_add_reminder.Name = "button_add_reminder";
            this.button_add_reminder.Size = new System.Drawing.Size(145, 45);
            this.button_add_reminder.TabIndex = 10;
            this.button_add_reminder.Text = "Додати";
            this.button_add_reminder.Click += new System.EventHandler(this.button_add_reminder_Click);
            // 
            // label_reminder
            // 
            this.label_reminder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_reminder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.label_reminder.Location = new System.Drawing.Point(79, 16);
            this.label_reminder.Name = "label_reminder";
            this.label_reminder.Size = new System.Drawing.Size(200, 39);
            this.label_reminder.TabIndex = 0;
            this.label_reminder.Text = "Нагадування";
            this.label_reminder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_window_navigation
            // 
            this.panel_window_navigation.Controls.Add(this.button_collapse);
            this.panel_window_navigation.Controls.Add(this.button_window_state);
            this.panel_window_navigation.Controls.Add(this.button_close);
            this.panel_window_navigation.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_window_navigation.Location = new System.Drawing.Point(0, 0);
            this.panel_window_navigation.Name = "panel_window_navigation";
            this.panel_window_navigation.Size = new System.Drawing.Size(1440, 35);
            this.panel_window_navigation.TabIndex = 20;
            // 
            // button_collapse
            // 
            this.button_collapse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_collapse.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_collapse.FlatAppearance.BorderSize = 0;
            this.button_collapse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_collapse.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.button_collapse.IconColor = System.Drawing.Color.DimGray;
            this.button_collapse.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button_collapse.IconSize = 24;
            this.button_collapse.Location = new System.Drawing.Point(1281, 0);
            this.button_collapse.Name = "button_collapse";
            this.button_collapse.Size = new System.Drawing.Size(53, 35);
            this.button_collapse.TabIndex = 2;
            this.button_collapse.UseVisualStyleBackColor = true;
            this.button_collapse.Click += new System.EventHandler(this.button_collapse_Click);
            // 
            // button_window_state
            // 
            this.button_window_state.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_window_state.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_window_state.FlatAppearance.BorderSize = 0;
            this.button_window_state.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_window_state.IconChar = FontAwesome.Sharp.IconChar.Clone;
            this.button_window_state.IconColor = System.Drawing.Color.DimGray;
            this.button_window_state.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button_window_state.IconSize = 24;
            this.button_window_state.Location = new System.Drawing.Point(1334, 0);
            this.button_window_state.Name = "button_window_state";
            this.button_window_state.Size = new System.Drawing.Size(53, 35);
            this.button_window_state.TabIndex = 1;
            this.button_window_state.UseVisualStyleBackColor = true;
            this.button_window_state.Click += new System.EventHandler(this.button_window_state_Click);
            // 
            // button_close
            // 
            this.button_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_close.FlatAppearance.BorderSize = 0;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.IconChar = FontAwesome.Sharp.IconChar.X;
            this.button_close.IconColor = System.Drawing.Color.DimGray;
            this.button_close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button_close.IconSize = 24;
            this.button_close.Location = new System.Drawing.Point(1387, 0);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(53, 35);
            this.button_close.TabIndex = 0;
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1440, 900);
            this.Controls.Add(this.panel_navigation);
            this.Controls.Add(this.panel_window_navigation);
            this.Controls.Add(this.panel_main);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.panel_navigation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel_main.ResumeLayout(false);
            this.panel_reminder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reminder_view)).EndInit();
            this.panel_window_navigation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_navigation;
        private System.Windows.Forms.Button button_storage_navigation;
        private System.Windows.Forms.Button button_employee_navigation;
        private System.Windows.Forms.Button button_statistics_navigation;
        private System.Windows.Forms.Button button_customer_navigation;
        private System.Windows.Forms.Button button_books_navigation;
        private System.Windows.Forms.Button button_booking_navigation;
        private Guna.UI2.WinForms.Guna2PictureBox logo;
        private Guna.UI2.WinForms.Guna2Button button_personal_office_nav;
        private Guna.UI2.WinForms.Guna2Panel panel_main;
        private Guna.UI2.WinForms.Guna2Panel panel_reminder;
        private Guna.UI2.WinForms.Guna2Button button_add_reminder;
        private System.Windows.Forms.Label label_reminder;
        private System.Windows.Forms.Label label_book;
        private System.Windows.Forms.Label label_haven;
        private Bunifu.Framework.UI.BunifuCustomDataGrid reminder_view;
        private System.Windows.Forms.Panel panel_window_navigation;
        private FontAwesome.Sharp.IconButton button_collapse;
        private FontAwesome.Sharp.IconButton button_window_state;
        private FontAwesome.Sharp.IconButton button_close;
        private FontAwesome.Sharp.IconButton button_home_navigation;
        private FontAwesome.Sharp.IconButton bellButton;
    }
}