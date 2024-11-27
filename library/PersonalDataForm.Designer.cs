namespace library
{
    partial class PersonalDataForm
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
            this.button_back = new FontAwesome.Sharp.IconButton();
            this.panel_information = new System.Windows.Forms.Panel();
            this.check_show_pass = new System.Windows.Forms.CheckBox();
            this.text_box_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.text_box_login = new Guna.UI2.WinForms.Guna2TextBox();
            this.text_box_role_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.text_box_phone = new Guna.UI2.WinForms.Guna2TextBox();
            this.text_box_surname = new Guna.UI2.WinForms.Guna2TextBox();
            this.text_box_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.label_login = new System.Windows.Forms.Label();
            this.label_role_name = new System.Windows.Forms.Label();
            this.label_phone = new System.Windows.Forms.Label();
            this.label_surname = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_reminder = new System.Windows.Forms.Label();
            this.panel_information.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_back
            // 
            this.button_back.FlatAppearance.BorderSize = 0;
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_back.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.button_back.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button_back.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button_back.Location = new System.Drawing.Point(13, 14);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(53, 48);
            this.button_back.TabIndex = 25;
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // panel_information
            // 
            this.panel_information.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(50)))));
            this.panel_information.Controls.Add(this.check_show_pass);
            this.panel_information.Controls.Add(this.text_box_password);
            this.panel_information.Controls.Add(this.text_box_login);
            this.panel_information.Controls.Add(this.text_box_role_name);
            this.panel_information.Controls.Add(this.text_box_phone);
            this.panel_information.Controls.Add(this.text_box_surname);
            this.panel_information.Controls.Add(this.text_box_name);
            this.panel_information.Controls.Add(this.label_password);
            this.panel_information.Controls.Add(this.label_login);
            this.panel_information.Controls.Add(this.label_role_name);
            this.panel_information.Controls.Add(this.label_phone);
            this.panel_information.Controls.Add(this.label_surname);
            this.panel_information.Controls.Add(this.label_name);
            this.panel_information.Controls.Add(this.label_reminder);
            this.panel_information.Location = new System.Drawing.Point(136, 28);
            this.panel_information.Name = "panel_information";
            this.panel_information.Size = new System.Drawing.Size(392, 630);
            this.panel_information.TabIndex = 24;
            // 
            // check_show_pass
            // 
            this.check_show_pass.AutoSize = true;
            this.check_show_pass.FlatAppearance.BorderSize = 0;
            this.check_show_pass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.check_show_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(100)))), ((int)(((byte)(126)))));
            this.check_show_pass.Location = new System.Drawing.Point(55, 547);
            this.check_show_pass.Name = "check_show_pass";
            this.check_show_pass.Size = new System.Drawing.Size(120, 20);
            this.check_show_pass.TabIndex = 15;
            this.check_show_pass.Text = "Show password";
            this.check_show_pass.UseVisualStyleBackColor = true;
            this.check_show_pass.CheckedChanged += new System.EventHandler(this.check_show_pass_CheckedChanged);
            // 
            // text_box_password
            // 
            this.text_box_password.BorderRadius = 10;
            this.text_box_password.BorderThickness = 0;
            this.text_box_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_box_password.DefaultText = "";
            this.text_box_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_box_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_box_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_password.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(100)))), ((int)(((byte)(126)))));
            this.text_box_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_box_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.text_box_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_password.Location = new System.Drawing.Point(55, 500);
            this.text_box_password.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.text_box_password.Name = "text_box_password";
            this.text_box_password.PasswordChar = '●';
            this.text_box_password.PlaceholderText = "";
            this.text_box_password.ReadOnly = true;
            this.text_box_password.SelectedText = "";
            this.text_box_password.Size = new System.Drawing.Size(285, 38);
            this.text_box_password.TabIndex = 14;
            this.text_box_password.UseSystemPasswordChar = true;
            // 
            // text_box_login
            // 
            this.text_box_login.BorderRadius = 10;
            this.text_box_login.BorderThickness = 0;
            this.text_box_login.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_box_login.DefaultText = "";
            this.text_box_login.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_box_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_box_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_login.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_login.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(100)))), ((int)(((byte)(126)))));
            this.text_box_login.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_box_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.text_box_login.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_login.Location = new System.Drawing.Point(55, 420);
            this.text_box_login.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.text_box_login.Name = "text_box_login";
            this.text_box_login.PasswordChar = '\0';
            this.text_box_login.PlaceholderText = "";
            this.text_box_login.ReadOnly = true;
            this.text_box_login.SelectedText = "";
            this.text_box_login.Size = new System.Drawing.Size(285, 38);
            this.text_box_login.TabIndex = 13;
            // 
            // text_box_role_name
            // 
            this.text_box_role_name.BorderRadius = 10;
            this.text_box_role_name.BorderThickness = 0;
            this.text_box_role_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_box_role_name.DefaultText = "";
            this.text_box_role_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_box_role_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_box_role_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_role_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_role_name.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(100)))), ((int)(((byte)(126)))));
            this.text_box_role_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_role_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_box_role_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.text_box_role_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_role_name.Location = new System.Drawing.Point(55, 340);
            this.text_box_role_name.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.text_box_role_name.Name = "text_box_role_name";
            this.text_box_role_name.PasswordChar = '\0';
            this.text_box_role_name.PlaceholderText = "";
            this.text_box_role_name.ReadOnly = true;
            this.text_box_role_name.SelectedText = "";
            this.text_box_role_name.Size = new System.Drawing.Size(285, 38);
            this.text_box_role_name.TabIndex = 12;
            // 
            // text_box_phone
            // 
            this.text_box_phone.BorderRadius = 10;
            this.text_box_phone.BorderThickness = 0;
            this.text_box_phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_box_phone.DefaultText = "";
            this.text_box_phone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_box_phone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_box_phone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_phone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_phone.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(100)))), ((int)(((byte)(126)))));
            this.text_box_phone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_box_phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.text_box_phone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_phone.Location = new System.Drawing.Point(55, 260);
            this.text_box_phone.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.text_box_phone.Name = "text_box_phone";
            this.text_box_phone.PasswordChar = '\0';
            this.text_box_phone.PlaceholderText = "";
            this.text_box_phone.ReadOnly = true;
            this.text_box_phone.SelectedText = "";
            this.text_box_phone.Size = new System.Drawing.Size(285, 38);
            this.text_box_phone.TabIndex = 11;
            // 
            // text_box_surname
            // 
            this.text_box_surname.BorderRadius = 10;
            this.text_box_surname.BorderThickness = 0;
            this.text_box_surname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_box_surname.DefaultText = "";
            this.text_box_surname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_box_surname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_box_surname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_surname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_surname.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(100)))), ((int)(((byte)(126)))));
            this.text_box_surname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_box_surname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.text_box_surname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_surname.Location = new System.Drawing.Point(55, 180);
            this.text_box_surname.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.text_box_surname.Name = "text_box_surname";
            this.text_box_surname.PasswordChar = '\0';
            this.text_box_surname.PlaceholderText = "";
            this.text_box_surname.ReadOnly = true;
            this.text_box_surname.SelectedText = "";
            this.text_box_surname.Size = new System.Drawing.Size(285, 38);
            this.text_box_surname.TabIndex = 10;
            // 
            // text_box_name
            // 
            this.text_box_name.BorderRadius = 10;
            this.text_box_name.BorderThickness = 0;
            this.text_box_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_box_name.DefaultText = "";
            this.text_box_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_box_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_box_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_name.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(100)))), ((int)(((byte)(126)))));
            this.text_box_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_box_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.text_box_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_name.Location = new System.Drawing.Point(55, 100);
            this.text_box_name.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.text_box_name.Name = "text_box_name";
            this.text_box_name.PasswordChar = '\0';
            this.text_box_name.PlaceholderText = "";
            this.text_box_name.ReadOnly = true;
            this.text_box_name.SelectedText = "";
            this.text_box_name.Size = new System.Drawing.Size(285, 38);
            this.text_box_name.TabIndex = 9;
            // 
            // label_password
            // 
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_password.ForeColor = System.Drawing.Color.DimGray;
            this.label_password.Location = new System.Drawing.Point(51, 464);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(87, 30);
            this.label_password.TabIndex = 7;
            this.label_password.Text = "Пароль";
            this.label_password.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_login
            // 
            this.label_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_login.ForeColor = System.Drawing.Color.DimGray;
            this.label_login.Location = new System.Drawing.Point(51, 384);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(87, 30);
            this.label_login.TabIndex = 6;
            this.label_login.Text = "Логін";
            this.label_login.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_role_name
            // 
            this.label_role_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_role_name.ForeColor = System.Drawing.Color.DimGray;
            this.label_role_name.Location = new System.Drawing.Point(51, 304);
            this.label_role_name.Name = "label_role_name";
            this.label_role_name.Size = new System.Drawing.Size(71, 30);
            this.label_role_name.TabIndex = 5;
            this.label_role_name.Text = "Роль";
            this.label_role_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_phone
            // 
            this.label_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_phone.ForeColor = System.Drawing.Color.DimGray;
            this.label_phone.Location = new System.Drawing.Point(51, 224);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(173, 30);
            this.label_phone.TabIndex = 4;
            this.label_phone.Text = "Номер телефону";
            this.label_phone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_surname
            // 
            this.label_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_surname.ForeColor = System.Drawing.Color.DimGray;
            this.label_surname.Location = new System.Drawing.Point(51, 144);
            this.label_surname.Name = "label_surname";
            this.label_surname.Size = new System.Drawing.Size(104, 30);
            this.label_surname.TabIndex = 3;
            this.label_surname.Text = "Прізвище";
            this.label_surname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_name
            // 
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_name.ForeColor = System.Drawing.Color.DimGray;
            this.label_name.Location = new System.Drawing.Point(51, 64);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(63, 30);
            this.label_name.TabIndex = 2;
            this.label_name.Text = "Ім\'я";
            this.label_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_reminder
            // 
            this.label_reminder.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_reminder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.label_reminder.Location = new System.Drawing.Point(106, 14);
            this.label_reminder.Name = "label_reminder";
            this.label_reminder.Size = new System.Drawing.Size(174, 39);
            this.label_reminder.TabIndex = 1;
            this.label_reminder.Text = "Інформація";
            this.label_reminder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PersonalDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1422, 686);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.panel_information);
            this.Name = "PersonalDataForm";
            this.Text = "PersonalDataForm";
            this.panel_information.ResumeLayout(false);
            this.panel_information.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton button_back;
        private System.Windows.Forms.Panel panel_information;
        private System.Windows.Forms.CheckBox check_show_pass;
        private Guna.UI2.WinForms.Guna2TextBox text_box_password;
        private Guna.UI2.WinForms.Guna2TextBox text_box_login;
        private Guna.UI2.WinForms.Guna2TextBox text_box_role_name;
        private Guna.UI2.WinForms.Guna2TextBox text_box_phone;
        private Guna.UI2.WinForms.Guna2TextBox text_box_surname;
        private Guna.UI2.WinForms.Guna2TextBox text_box_name;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_role_name;
        private System.Windows.Forms.Label label_phone;
        private System.Windows.Forms.Label label_surname;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_reminder;
    }
}