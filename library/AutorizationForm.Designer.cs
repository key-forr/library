
namespace library
{
    partial class AutorizationForm
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
            System.Windows.Forms.Label label_forgetPass;
            this.lable_password = new System.Windows.Forms.Label();
            this.label_login = new System.Windows.Forms.Label();
            this.button_submit = new System.Windows.Forms.Button();
            this.label_signIn = new System.Windows.Forms.Label();
            this.panel_signIn = new System.Windows.Forms.Panel();
            this.password_box = new Guna.UI2.WinForms.Guna2TextBox();
            this.login_box = new Guna.UI2.WinForms.Guna2TextBox();
            this.check_showPass = new System.Windows.Forms.CheckBox();
            label_forgetPass = new System.Windows.Forms.Label();
            this.panel_signIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_forgetPass
            // 
            label_forgetPass.AutoSize = true;
            label_forgetPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(100)))), ((int)(((byte)(126)))));
            label_forgetPass.Location = new System.Drawing.Point(371, 325);
            label_forgetPass.Name = "label_forgetPass";
            label_forgetPass.Size = new System.Drawing.Size(125, 17);
            label_forgetPass.TabIndex = 6;
            label_forgetPass.Text = "Forget password ?";
            // 
            // lable_password
            // 
            this.lable_password.AutoSize = true;
            this.lable_password.Font = new System.Drawing.Font("Lucida Fax", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.lable_password.Location = new System.Drawing.Point(55, 200);
            this.lable_password.Name = "lable_password";
            this.lable_password.Size = new System.Drawing.Size(199, 43);
            this.lable_password.TabIndex = 5;
            this.lable_password.Text = "Password";
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Font = new System.Drawing.Font("Lucida Fax", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.label_login.Location = new System.Drawing.Point(55, 42);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(126, 43);
            this.label_login.TabIndex = 4;
            this.label_login.Text = "Login";
            // 
            // button_submit
            // 
            this.button_submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(73)))), ((int)(((byte)(229)))));
            this.button_submit.FlatAppearance.BorderSize = 0;
            this.button_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_submit.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_submit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.button_submit.Location = new System.Drawing.Point(188, 380);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(153, 58);
            this.button_submit.TabIndex = 2;
            this.button_submit.Text = "Submit";
            this.button_submit.UseVisualStyleBackColor = false;
            this.button_submit.Click += new System.EventHandler(this.button_autorization);
            this.button_submit.MouseEnter += new System.EventHandler(this.button_submit_mouse_enter);
            this.button_submit.MouseLeave += new System.EventHandler(this.button_submit_mouse_leave);
            // 
            // label_signIn
            // 
            this.label_signIn.AutoSize = true;
            this.label_signIn.Font = new System.Drawing.Font("Lucida Fax", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_signIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.label_signIn.Location = new System.Drawing.Point(598, 228);
            this.label_signIn.Name = "label_signIn";
            this.label_signIn.Size = new System.Drawing.Size(245, 68);
            this.label_signIn.TabIndex = 0;
            this.label_signIn.Text = "Sign in";
            // 
            // panel_signIn
            // 
            this.panel_signIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(50)))));
            this.panel_signIn.Controls.Add(this.password_box);
            this.panel_signIn.Controls.Add(this.login_box);
            this.panel_signIn.Controls.Add(label_forgetPass);
            this.panel_signIn.Controls.Add(this.check_showPass);
            this.panel_signIn.Controls.Add(this.label_login);
            this.panel_signIn.Controls.Add(this.button_submit);
            this.panel_signIn.Controls.Add(this.lable_password);
            this.panel_signIn.Location = new System.Drawing.Point(450, 338);
            this.panel_signIn.Name = "panel_signIn";
            this.panel_signIn.Size = new System.Drawing.Size(545, 498);
            this.panel_signIn.TabIndex = 6;
            // 
            // password_box
            // 
            this.password_box.DefaultText = "";
            this.password_box.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.password_box.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.password_box.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password_box.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password_box.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.password_box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password_box.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.password_box.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password_box.Location = new System.Drawing.Point(49, 249);
            this.password_box.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.password_box.Name = "password_box";
            this.password_box.PasswordChar = '\0';
            this.password_box.PlaceholderText = "";
            this.password_box.SelectedText = "";
            this.password_box.Size = new System.Drawing.Size(447, 56);
            this.password_box.TabIndex = 9;
            // 
            // login_box
            // 
            this.login_box.DefaultText = "";
            this.login_box.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.login_box.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.login_box.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.login_box.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.login_box.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.login_box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.login_box.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.login_box.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.login_box.Location = new System.Drawing.Point(49, 109);
            this.login_box.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.login_box.Name = "login_box";
            this.login_box.PasswordChar = '\0';
            this.login_box.PlaceholderText = "";
            this.login_box.SelectedText = "";
            this.login_box.Size = new System.Drawing.Size(447, 56);
            this.login_box.TabIndex = 8;
            // 
            // check_showPass
            // 
            this.check_showPass.AutoSize = true;
            this.check_showPass.FlatAppearance.BorderSize = 0;
            this.check_showPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.check_showPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(100)))), ((int)(((byte)(126)))));
            this.check_showPass.Location = new System.Drawing.Point(54, 321);
            this.check_showPass.Name = "check_showPass";
            this.check_showPass.Size = new System.Drawing.Size(124, 21);
            this.check_showPass.TabIndex = 3;
            this.check_showPass.Text = "Show password";
            this.check_showPass.UseVisualStyleBackColor = true;
            this.check_showPass.CheckedChanged += new System.EventHandler(this.check_box_checked_changed);
            // 
            // AutorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1440, 800);
            this.Controls.Add(this.panel_signIn);
            this.Controls.Add(this.label_signIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AutorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel_signIn.ResumeLayout(false);
            this.panel_signIn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lable_password;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Button button_submit;
        private System.Windows.Forms.Label label_signIn;
        private System.Windows.Forms.Panel panel_signIn;
        private System.Windows.Forms.CheckBox check_showPass;
        private Guna.UI2.WinForms.Guna2TextBox login_box;
        private Guna.UI2.WinForms.Guna2TextBox password_box;
    }
}

