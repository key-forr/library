namespace library.Forms.Client
{
    partial class ClientEditForm
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
            this.button_save = new Guna.UI2.WinForms.Guna2Button();
            this.text_box_surname = new Guna.UI2.WinForms.Guna2TextBox();
            this.text_box_phone = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_surname = new System.Windows.Forms.Label();
            this.label_phone = new System.Windows.Forms.Label();
            this.label_info = new System.Windows.Forms.Label();
            this.text_box_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.text_box_patronymic = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.label_patronymic = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(50)))));
            this.button_save.BorderRadius = 10;
            this.button_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_save.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(78)))));
            this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.button_save.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(78)))));
            this.button_save.Location = new System.Drawing.Point(108, 525);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(265, 50);
            this.button_save.TabIndex = 77;
            this.button_save.Text = "Зберегти";
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            this.button_save.MouseEnter += new System.EventHandler(this.button_save_MouseEnter);
            this.button_save.MouseLeave += new System.EventHandler(this.button_save_MouseLeave);
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
            this.text_box_surname.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.text_box_surname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_box_surname.ForeColor = System.Drawing.Color.White;
            this.text_box_surname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_surname.Location = new System.Drawing.Point(12, 228);
            this.text_box_surname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_box_surname.Name = "text_box_surname";
            this.text_box_surname.PasswordChar = '\0';
            this.text_box_surname.PlaceholderText = "";
            this.text_box_surname.SelectedText = "";
            this.text_box_surname.Size = new System.Drawing.Size(453, 45);
            this.text_box_surname.TabIndex = 73;
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
            this.text_box_phone.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.text_box_phone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_box_phone.ForeColor = System.Drawing.Color.White;
            this.text_box_phone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_phone.Location = new System.Drawing.Point(12, 418);
            this.text_box_phone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_box_phone.Name = "text_box_phone";
            this.text_box_phone.PasswordChar = '\0';
            this.text_box_phone.PlaceholderText = "";
            this.text_box_phone.SelectedText = "";
            this.text_box_phone.Size = new System.Drawing.Size(453, 45);
            this.text_box_phone.TabIndex = 72;
            // 
            // label_surname
            // 
            this.label_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_surname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(100)))), ((int)(((byte)(126)))));
            this.label_surname.Location = new System.Drawing.Point(12, 194);
            this.label_surname.Name = "label_surname";
            this.label_surname.Size = new System.Drawing.Size(153, 30);
            this.label_surname.TabIndex = 70;
            this.label_surname.Text = "Прізвище";
            this.label_surname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_phone
            // 
            this.label_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(100)))), ((int)(((byte)(126)))));
            this.label_phone.Location = new System.Drawing.Point(12, 384);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(141, 30);
            this.label_phone.TabIndex = 68;
            this.label_phone.Text = "Телефон";
            this.label_phone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_info.ForeColor = System.Drawing.Color.White;
            this.label_info.Location = new System.Drawing.Point(132, 20);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(202, 38);
            this.label_info.TabIndex = 79;
            this.label_info.Text = "Інформація";
            this.label_info.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.text_box_name.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.text_box_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_box_name.ForeColor = System.Drawing.Color.White;
            this.text_box_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_name.Location = new System.Drawing.Point(12, 133);
            this.text_box_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_box_name.Name = "text_box_name";
            this.text_box_name.PasswordChar = '\0';
            this.text_box_name.PlaceholderText = "";
            this.text_box_name.SelectedText = "";
            this.text_box_name.Size = new System.Drawing.Size(453, 45);
            this.text_box_name.TabIndex = 83;
            // 
            // text_box_patronymic
            // 
            this.text_box_patronymic.BorderRadius = 10;
            this.text_box_patronymic.BorderThickness = 0;
            this.text_box_patronymic.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_box_patronymic.DefaultText = "";
            this.text_box_patronymic.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_box_patronymic.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_box_patronymic.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_patronymic.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_patronymic.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.text_box_patronymic.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_patronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_box_patronymic.ForeColor = System.Drawing.Color.White;
            this.text_box_patronymic.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_patronymic.Location = new System.Drawing.Point(12, 323);
            this.text_box_patronymic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_box_patronymic.Name = "text_box_patronymic";
            this.text_box_patronymic.PasswordChar = '\0';
            this.text_box_patronymic.PlaceholderText = "";
            this.text_box_patronymic.SelectedText = "";
            this.text_box_patronymic.Size = new System.Drawing.Size(453, 45);
            this.text_box_patronymic.TabIndex = 82;
            // 
            // label_name
            // 
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(100)))), ((int)(((byte)(126)))));
            this.label_name.Location = new System.Drawing.Point(12, 99);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(153, 30);
            this.label_name.TabIndex = 81;
            this.label_name.Text = "Ім\'я";
            this.label_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_patronymic
            // 
            this.label_patronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_patronymic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(100)))), ((int)(((byte)(126)))));
            this.label_patronymic.Location = new System.Drawing.Point(12, 289);
            this.label_patronymic.Name = "label_patronymic";
            this.label_patronymic.Size = new System.Drawing.Size(179, 30);
            this.label_patronymic.TabIndex = 80;
            this.label_patronymic.Text = "По-батькові";
            this.label_patronymic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ClientEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(477, 615);
            this.Controls.Add(this.text_box_name);
            this.Controls.Add(this.text_box_patronymic);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_patronymic);
            this.Controls.Add(this.label_info);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.text_box_surname);
            this.Controls.Add(this.text_box_phone);
            this.Controls.Add(this.label_surname);
            this.Controls.Add(this.label_phone);
            this.Name = "ClientEditForm";
            this.Text = "CustomerEditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button button_save;
        private Guna.UI2.WinForms.Guna2TextBox text_box_surname;
        private Guna.UI2.WinForms.Guna2TextBox text_box_phone;
        private System.Windows.Forms.Label label_surname;
        private System.Windows.Forms.Label label_phone;
        private System.Windows.Forms.Label label_info;
        private Guna.UI2.WinForms.Guna2TextBox text_box_name;
        private Guna.UI2.WinForms.Guna2TextBox text_box_patronymic;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_patronymic;
    }
}