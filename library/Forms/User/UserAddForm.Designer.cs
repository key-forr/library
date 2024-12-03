namespace library.Forms.User
{
    partial class UserAddForm
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
            this.label_add_user = new System.Windows.Forms.Label();
            this.text_box_phone = new Guna.UI2.WinForms.Guna2TextBox();
            this.combo_box_roles = new Guna.UI2.WinForms.Guna2ComboBox();
            this.text_box_login = new Guna.UI2.WinForms.Guna2TextBox();
            this.text_box_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.text_box_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.text_box_surname = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_phone = new System.Windows.Forms.Label();
            this.label_role = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.label_login = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_surname = new System.Windows.Forms.Label();
            this.button_add = new Guna.UI2.WinForms.Guna2Button();
            this.checked_show_password = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.SuspendLayout();
            // 
            // label_add_user
            // 
            this.label_add_user.AutoSize = true;
            this.label_add_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_add_user.ForeColor = System.Drawing.Color.White;
            this.label_add_user.Location = new System.Drawing.Point(49, 19);
            this.label_add_user.Name = "label_add_user";
            this.label_add_user.Size = new System.Drawing.Size(335, 36);
            this.label_add_user.TabIndex = 1;
            this.label_add_user.Text = "Додати користувача";
            this.label_add_user.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // text_box_phone
            // 
            this.text_box_phone.BorderColor = System.Drawing.Color.White;
            this.text_box_phone.BorderRadius = 10;
            this.text_box_phone.BorderThickness = 0;
            this.text_box_phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_box_phone.DefaultText = "";
            this.text_box_phone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_box_phone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_box_phone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_phone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_phone.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.text_box_phone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_box_phone.ForeColor = System.Drawing.Color.White;
            this.text_box_phone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_phone.Location = new System.Drawing.Point(17, 257);
            this.text_box_phone.Margin = new System.Windows.Forms.Padding(5);
            this.text_box_phone.Name = "text_box_phone";
            this.text_box_phone.PasswordChar = '\0';
            this.text_box_phone.PlaceholderText = "";
            this.text_box_phone.SelectedText = "";
            this.text_box_phone.Size = new System.Drawing.Size(410, 44);
            this.text_box_phone.TabIndex = 26;
            // 
            // combo_box_roles
            // 
            this.combo_box_roles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(50)))));
            this.combo_box_roles.BorderColor = System.Drawing.Color.White;
            this.combo_box_roles.BorderRadius = 10;
            this.combo_box_roles.BorderThickness = 0;
            this.combo_box_roles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.combo_box_roles.DisplayMember = "id";
            this.combo_box_roles.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo_box_roles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_box_roles.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.combo_box_roles.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combo_box_roles.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combo_box_roles.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.combo_box_roles.ForeColor = System.Drawing.Color.White;
            this.combo_box_roles.ItemHeight = 30;
            this.combo_box_roles.Location = new System.Drawing.Point(17, 334);
            this.combo_box_roles.Name = "combo_box_roles";
            this.combo_box_roles.Size = new System.Drawing.Size(410, 36);
            this.combo_box_roles.TabIndex = 25;
            this.combo_box_roles.ValueMember = "id";
            // 
            // text_box_login
            // 
            this.text_box_login.BorderColor = System.Drawing.Color.White;
            this.text_box_login.BorderRadius = 10;
            this.text_box_login.BorderThickness = 0;
            this.text_box_login.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_box_login.DefaultText = "";
            this.text_box_login.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_box_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_box_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_login.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_login.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.text_box_login.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_box_login.ForeColor = System.Drawing.Color.White;
            this.text_box_login.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_login.Location = new System.Drawing.Point(17, 403);
            this.text_box_login.Margin = new System.Windows.Forms.Padding(5);
            this.text_box_login.Name = "text_box_login";
            this.text_box_login.PasswordChar = '\0';
            this.text_box_login.PlaceholderText = "";
            this.text_box_login.SelectedText = "";
            this.text_box_login.Size = new System.Drawing.Size(410, 44);
            this.text_box_login.TabIndex = 24;
            // 
            // text_box_password
            // 
            this.text_box_password.BorderColor = System.Drawing.Color.White;
            this.text_box_password.BorderRadius = 10;
            this.text_box_password.BorderThickness = 0;
            this.text_box_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_box_password.DefaultText = "";
            this.text_box_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_box_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_box_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_password.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.text_box_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_box_password.ForeColor = System.Drawing.Color.White;
            this.text_box_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_password.Location = new System.Drawing.Point(17, 482);
            this.text_box_password.Margin = new System.Windows.Forms.Padding(5);
            this.text_box_password.Name = "text_box_password";
            this.text_box_password.PasswordChar = '\0';
            this.text_box_password.PlaceholderText = "";
            this.text_box_password.SelectedText = "";
            this.text_box_password.Size = new System.Drawing.Size(410, 44);
            this.text_box_password.TabIndex = 23;
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
            this.text_box_name.Location = new System.Drawing.Point(17, 104);
            this.text_box_name.Margin = new System.Windows.Forms.Padding(5);
            this.text_box_name.Name = "text_box_name";
            this.text_box_name.PasswordChar = '\0';
            this.text_box_name.PlaceholderText = "";
            this.text_box_name.SelectedText = "";
            this.text_box_name.Size = new System.Drawing.Size(410, 44);
            this.text_box_name.TabIndex = 22;
            // 
            // text_box_surname
            // 
            this.text_box_surname.BorderColor = System.Drawing.Color.White;
            this.text_box_surname.BorderRadius = 10;
            this.text_box_surname.BorderThickness = 0;
            this.text_box_surname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_box_surname.DefaultText = "";
            this.text_box_surname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_box_surname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_box_surname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_surname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_surname.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.text_box_surname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_box_surname.ForeColor = System.Drawing.Color.White;
            this.text_box_surname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_surname.Location = new System.Drawing.Point(17, 178);
            this.text_box_surname.Margin = new System.Windows.Forms.Padding(5);
            this.text_box_surname.Name = "text_box_surname";
            this.text_box_surname.PasswordChar = '\0';
            this.text_box_surname.PlaceholderText = "";
            this.text_box_surname.SelectedText = "";
            this.text_box_surname.Size = new System.Drawing.Size(410, 44);
            this.text_box_surname.TabIndex = 21;
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(100)))), ((int)(((byte)(126)))));
            this.label_phone.Location = new System.Drawing.Point(17, 227);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(106, 25);
            this.label_phone.TabIndex = 20;
            this.label_phone.Text = "Телефон";
            // 
            // label_role
            // 
            this.label_role.AutoSize = true;
            this.label_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_role.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(100)))), ((int)(((byte)(126)))));
            this.label_role.Location = new System.Drawing.Point(17, 306);
            this.label_role.Name = "label_role";
            this.label_role.Size = new System.Drawing.Size(61, 25);
            this.label_role.TabIndex = 19;
            this.label_role.Text = "Роль";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(100)))), ((int)(((byte)(126)))));
            this.label_password.Location = new System.Drawing.Point(17, 452);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(86, 25);
            this.label_password.TabIndex = 18;
            this.label_password.Text = "Пароль";
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(100)))), ((int)(((byte)(126)))));
            this.label_login.Location = new System.Drawing.Point(17, 373);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(66, 25);
            this.label_login.TabIndex = 17;
            this.label_login.Text = "Логін";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(100)))), ((int)(((byte)(126)))));
            this.label_name.Location = new System.Drawing.Point(17, 74);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(53, 25);
            this.label_name.TabIndex = 16;
            this.label_name.Text = "Ім\'я";
            // 
            // label_surname
            // 
            this.label_surname.AutoSize = true;
            this.label_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_surname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(100)))), ((int)(((byte)(126)))));
            this.label_surname.Location = new System.Drawing.Point(17, 148);
            this.label_surname.Name = "label_surname";
            this.label_surname.Size = new System.Drawing.Size(109, 25);
            this.label_surname.TabIndex = 15;
            this.label_surname.Text = "Прізвище";
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(50)))));
            this.button_add.BorderRadius = 10;
            this.button_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_add.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(78)))));
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add.ForeColor = System.Drawing.Color.White;
            this.button_add.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(78)))));
            this.button_add.Location = new System.Drawing.Point(157, 553);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(265, 50);
            this.button_add.TabIndex = 56;
            this.button_add.Text = "Додати";
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            this.button_add.MouseEnter += new System.EventHandler(this.button_add_MouseEnter);
            this.button_add.MouseLeave += new System.EventHandler(this.button_add_MouseLeave);
            // 
            // checked_show_password
            // 
            this.checked_show_password.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(50)))));
            this.checked_show_password.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(73)))), ((int)(((byte)(229)))));
            this.checked_show_password.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.checked_show_password.CheckedState.InnerColor = System.Drawing.Color.White;
            this.checked_show_password.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checked_show_password.Location = new System.Drawing.Point(17, 534);
            this.checked_show_password.Name = "checked_show_password";
            this.checked_show_password.Size = new System.Drawing.Size(35, 20);
            this.checked_show_password.TabIndex = 57;
            this.checked_show_password.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checked_show_password.UncheckedState.BorderThickness = 1;
            this.checked_show_password.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(50)))));
            this.checked_show_password.UncheckedState.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(73)))), ((int)(((byte)(229)))));
            this.checked_show_password.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(73)))), ((int)(((byte)(229)))));
            this.checked_show_password.CheckedChanged += new System.EventHandler(this.checked_show_password_CheckedChanged);
            // 
            // UserAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(440, 615);
            this.Controls.Add(this.checked_show_password);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.text_box_phone);
            this.Controls.Add(this.combo_box_roles);
            this.Controls.Add(this.text_box_login);
            this.Controls.Add(this.text_box_password);
            this.Controls.Add(this.text_box_name);
            this.Controls.Add(this.text_box_surname);
            this.Controls.Add(this.label_phone);
            this.Controls.Add(this.label_role);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_surname);
            this.Controls.Add(this.label_add_user);
            this.Name = "UserAddForm";
            this.Text = "UserAddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_add_user;
        private Guna.UI2.WinForms.Guna2TextBox text_box_phone;
        private Guna.UI2.WinForms.Guna2ComboBox combo_box_roles;
        private Guna.UI2.WinForms.Guna2TextBox text_box_login;
        private Guna.UI2.WinForms.Guna2TextBox text_box_password;
        private Guna.UI2.WinForms.Guna2TextBox text_box_name;
        private Guna.UI2.WinForms.Guna2TextBox text_box_surname;
        private System.Windows.Forms.Label label_phone;
        private System.Windows.Forms.Label label_role;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_surname;
        private Guna.UI2.WinForms.Guna2Button button_add;
        private Guna.UI2.WinForms.Guna2ToggleSwitch checked_show_password;
    }
}