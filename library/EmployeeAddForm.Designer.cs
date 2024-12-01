namespace library
{
    partial class EmployeeAddForm
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
            this.label_add_employee = new System.Windows.Forms.Label();
            this.text_box_employee_phone = new Guna.UI2.WinForms.Guna2TextBox();
            this.combo_box_employee_role = new Guna.UI2.WinForms.Guna2ComboBox();
            this.text_box_employee_login = new Guna.UI2.WinForms.Guna2TextBox();
            this.text_box_employee_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.text_box_employee_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.text_box_employee_surname = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_employee_phone = new System.Windows.Forms.Label();
            this.label_employee_role = new System.Windows.Forms.Label();
            this.label_employee_password = new System.Windows.Forms.Label();
            this.label_employee_login = new System.Windows.Forms.Label();
            this.label_employee_name = new System.Windows.Forms.Label();
            this.label_employee_surname = new System.Windows.Forms.Label();
            this.button_add = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label_add_employee
            // 
            this.label_add_employee.AutoSize = true;
            this.label_add_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_add_employee.ForeColor = System.Drawing.Color.White;
            this.label_add_employee.Location = new System.Drawing.Point(67, 19);
            this.label_add_employee.Name = "label_add_employee";
            this.label_add_employee.Size = new System.Drawing.Size(313, 36);
            this.label_add_employee.TabIndex = 1;
            this.label_add_employee.Text = "Додати працівника";
            this.label_add_employee.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // text_box_employee_phone
            // 
            this.text_box_employee_phone.BorderColor = System.Drawing.Color.White;
            this.text_box_employee_phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_box_employee_phone.DefaultText = "";
            this.text_box_employee_phone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_box_employee_phone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_box_employee_phone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_employee_phone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_employee_phone.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.text_box_employee_phone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_employee_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_box_employee_phone.ForeColor = System.Drawing.Color.White;
            this.text_box_employee_phone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_employee_phone.Location = new System.Drawing.Point(14, 274);
            this.text_box_employee_phone.Margin = new System.Windows.Forms.Padding(5);
            this.text_box_employee_phone.Name = "text_box_employee_phone";
            this.text_box_employee_phone.PasswordChar = '\0';
            this.text_box_employee_phone.PlaceholderText = "";
            this.text_box_employee_phone.SelectedText = "";
            this.text_box_employee_phone.Size = new System.Drawing.Size(410, 45);
            this.text_box_employee_phone.TabIndex = 26;
            // 
            // combo_box_employee_role
            // 
            this.combo_box_employee_role.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(50)))));
            this.combo_box_employee_role.BorderColor = System.Drawing.Color.White;
            this.combo_box_employee_role.Cursor = System.Windows.Forms.Cursors.Hand;
            this.combo_box_employee_role.DisplayMember = "id";
            this.combo_box_employee_role.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo_box_employee_role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_box_employee_role.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.combo_box_employee_role.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combo_box_employee_role.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combo_box_employee_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.combo_box_employee_role.ForeColor = System.Drawing.Color.White;
            this.combo_box_employee_role.ItemHeight = 30;
            this.combo_box_employee_role.Location = new System.Drawing.Point(14, 347);
            this.combo_box_employee_role.Name = "combo_box_employee_role";
            this.combo_box_employee_role.Size = new System.Drawing.Size(410, 36);
            this.combo_box_employee_role.TabIndex = 25;
            this.combo_box_employee_role.ValueMember = "id";
            // 
            // text_box_employee_login
            // 
            this.text_box_employee_login.BorderColor = System.Drawing.Color.White;
            this.text_box_employee_login.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_box_employee_login.DefaultText = "";
            this.text_box_employee_login.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_box_employee_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_box_employee_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_employee_login.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_employee_login.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.text_box_employee_login.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_employee_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_box_employee_login.ForeColor = System.Drawing.Color.White;
            this.text_box_employee_login.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_employee_login.Location = new System.Drawing.Point(14, 411);
            this.text_box_employee_login.Margin = new System.Windows.Forms.Padding(5);
            this.text_box_employee_login.Name = "text_box_employee_login";
            this.text_box_employee_login.PasswordChar = '\0';
            this.text_box_employee_login.PlaceholderText = "";
            this.text_box_employee_login.SelectedText = "";
            this.text_box_employee_login.Size = new System.Drawing.Size(410, 45);
            this.text_box_employee_login.TabIndex = 24;
            // 
            // text_box_employee_password
            // 
            this.text_box_employee_password.BorderColor = System.Drawing.Color.White;
            this.text_box_employee_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_box_employee_password.DefaultText = "";
            this.text_box_employee_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_box_employee_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_box_employee_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_employee_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_employee_password.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.text_box_employee_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_employee_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_box_employee_password.ForeColor = System.Drawing.Color.White;
            this.text_box_employee_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_employee_password.Location = new System.Drawing.Point(14, 486);
            this.text_box_employee_password.Margin = new System.Windows.Forms.Padding(5);
            this.text_box_employee_password.Name = "text_box_employee_password";
            this.text_box_employee_password.PasswordChar = '\0';
            this.text_box_employee_password.PlaceholderText = "";
            this.text_box_employee_password.SelectedText = "";
            this.text_box_employee_password.Size = new System.Drawing.Size(410, 43);
            this.text_box_employee_password.TabIndex = 23;
            // 
            // text_box_employee_name
            // 
            this.text_box_employee_name.BorderColor = System.Drawing.Color.White;
            this.text_box_employee_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_box_employee_name.DefaultText = "";
            this.text_box_employee_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_box_employee_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_box_employee_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_employee_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_employee_name.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.text_box_employee_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_employee_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_box_employee_name.ForeColor = System.Drawing.Color.White;
            this.text_box_employee_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_employee_name.Location = new System.Drawing.Point(14, 191);
            this.text_box_employee_name.Margin = new System.Windows.Forms.Padding(5);
            this.text_box_employee_name.Name = "text_box_employee_name";
            this.text_box_employee_name.PasswordChar = '\0';
            this.text_box_employee_name.PlaceholderText = "";
            this.text_box_employee_name.SelectedText = "";
            this.text_box_employee_name.Size = new System.Drawing.Size(410, 44);
            this.text_box_employee_name.TabIndex = 22;
            // 
            // text_box_employee_surname
            // 
            this.text_box_employee_surname.BorderColor = System.Drawing.Color.White;
            this.text_box_employee_surname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_box_employee_surname.DefaultText = "";
            this.text_box_employee_surname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_box_employee_surname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_box_employee_surname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_employee_surname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_employee_surname.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.text_box_employee_surname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_employee_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_box_employee_surname.ForeColor = System.Drawing.Color.White;
            this.text_box_employee_surname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_employee_surname.Location = new System.Drawing.Point(14, 105);
            this.text_box_employee_surname.Margin = new System.Windows.Forms.Padding(5);
            this.text_box_employee_surname.Name = "text_box_employee_surname";
            this.text_box_employee_surname.PasswordChar = '\0';
            this.text_box_employee_surname.PlaceholderText = "";
            this.text_box_employee_surname.SelectedText = "";
            this.text_box_employee_surname.Size = new System.Drawing.Size(412, 47);
            this.text_box_employee_surname.TabIndex = 21;
            // 
            // label_employee_phone
            // 
            this.label_employee_phone.AutoSize = true;
            this.label_employee_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_employee_phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(100)))), ((int)(((byte)(126)))));
            this.label_employee_phone.Location = new System.Drawing.Point(16, 249);
            this.label_employee_phone.Name = "label_employee_phone";
            this.label_employee_phone.Size = new System.Drawing.Size(85, 20);
            this.label_employee_phone.TabIndex = 20;
            this.label_employee_phone.Text = "Телефон";
            // 
            // label_employee_role
            // 
            this.label_employee_role.AutoSize = true;
            this.label_employee_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_employee_role.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(100)))), ((int)(((byte)(126)))));
            this.label_employee_role.Location = new System.Drawing.Point(16, 324);
            this.label_employee_role.Name = "label_employee_role";
            this.label_employee_role.Size = new System.Drawing.Size(50, 20);
            this.label_employee_role.TabIndex = 19;
            this.label_employee_role.Text = "Роль";
            // 
            // label_employee_password
            // 
            this.label_employee_password.AutoSize = true;
            this.label_employee_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_employee_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(100)))), ((int)(((byte)(126)))));
            this.label_employee_password.Location = new System.Drawing.Point(16, 461);
            this.label_employee_password.Name = "label_employee_password";
            this.label_employee_password.Size = new System.Drawing.Size(72, 20);
            this.label_employee_password.TabIndex = 18;
            this.label_employee_password.Text = "Пароль";
            // 
            // label_employee_login
            // 
            this.label_employee_login.AutoSize = true;
            this.label_employee_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_employee_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(100)))), ((int)(((byte)(126)))));
            this.label_employee_login.Location = new System.Drawing.Point(16, 386);
            this.label_employee_login.Name = "label_employee_login";
            this.label_employee_login.Size = new System.Drawing.Size(50, 20);
            this.label_employee_login.TabIndex = 17;
            this.label_employee_login.Text = "Login";
            // 
            // label_employee_name
            // 
            this.label_employee_name.AutoSize = true;
            this.label_employee_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_employee_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(100)))), ((int)(((byte)(126)))));
            this.label_employee_name.Location = new System.Drawing.Point(16, 167);
            this.label_employee_name.Name = "label_employee_name";
            this.label_employee_name.Size = new System.Drawing.Size(39, 20);
            this.label_employee_name.TabIndex = 16;
            this.label_employee_name.Text = "Ім\'я";
            // 
            // label_employee_surname
            // 
            this.label_employee_surname.AutoSize = true;
            this.label_employee_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_employee_surname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(100)))), ((int)(((byte)(126)))));
            this.label_employee_surname.Location = new System.Drawing.Point(16, 80);
            this.label_employee_surname.Name = "label_employee_surname";
            this.label_employee_surname.Size = new System.Drawing.Size(89, 20);
            this.label_employee_surname.TabIndex = 15;
            this.label_employee_surname.Text = "Прізвище";
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
            this.button_add.Location = new System.Drawing.Point(112, 537);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(201, 52);
            this.button_add.TabIndex = 56;
            this.button_add.Text = "Додати";
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // EmployeeAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(440, 615);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.text_box_employee_phone);
            this.Controls.Add(this.combo_box_employee_role);
            this.Controls.Add(this.text_box_employee_login);
            this.Controls.Add(this.text_box_employee_password);
            this.Controls.Add(this.text_box_employee_name);
            this.Controls.Add(this.text_box_employee_surname);
            this.Controls.Add(this.label_employee_phone);
            this.Controls.Add(this.label_employee_role);
            this.Controls.Add(this.label_employee_password);
            this.Controls.Add(this.label_employee_login);
            this.Controls.Add(this.label_employee_name);
            this.Controls.Add(this.label_employee_surname);
            this.Controls.Add(this.label_add_employee);
            this.Name = "EmployeeAddForm";
            this.Text = "EmployeeAddForm";
            this.Load += new System.EventHandler(this.EmployeeAddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_add_employee;
        private Guna.UI2.WinForms.Guna2TextBox text_box_employee_phone;
        private Guna.UI2.WinForms.Guna2ComboBox combo_box_employee_role;
        private Guna.UI2.WinForms.Guna2TextBox text_box_employee_login;
        private Guna.UI2.WinForms.Guna2TextBox text_box_employee_password;
        private Guna.UI2.WinForms.Guna2TextBox text_box_employee_name;
        private Guna.UI2.WinForms.Guna2TextBox text_box_employee_surname;
        private System.Windows.Forms.Label label_employee_phone;
        private System.Windows.Forms.Label label_employee_role;
        private System.Windows.Forms.Label label_employee_password;
        private System.Windows.Forms.Label label_employee_login;
        private System.Windows.Forms.Label label_employee_name;
        private System.Windows.Forms.Label label_employee_surname;
        private Guna.UI2.WinForms.Guna2Button button_add;
    }
}