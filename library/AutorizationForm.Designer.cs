﻿
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
            System.Windows.Forms.Label label_forget_pass;
            this.lable_password = new System.Windows.Forms.Label();
            this.label_login = new System.Windows.Forms.Label();
            this.button_submit = new System.Windows.Forms.Button();
            this.label_signIn = new System.Windows.Forms.Label();
            this.panel_signIn = new System.Windows.Forms.Panel();
            this.text_box_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.text_box_login = new Guna.UI2.WinForms.Guna2TextBox();
            this.check_show_pass = new System.Windows.Forms.CheckBox();
            label_forget_pass = new System.Windows.Forms.Label();
            this.panel_signIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_forget_pass
            // 
            label_forget_pass.AutoSize = true;
            label_forget_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(100)))), ((int)(((byte)(126)))));
            label_forget_pass.Location = new System.Drawing.Point(371, 325);
            label_forget_pass.Name = "label_forget_pass";
            label_forget_pass.Size = new System.Drawing.Size(118, 16);
            label_forget_pass.TabIndex = 6;
            label_forget_pass.Text = "Forget password ?";
            // 
            // lable_password
            // 
            this.lable_password.AutoSize = true;
            this.lable_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.lable_password.Location = new System.Drawing.Point(55, 200);
            this.lable_password.Name = "lable_password";
            this.lable_password.Size = new System.Drawing.Size(183, 42);
            this.lable_password.TabIndex = 5;
            this.lable_password.Text = "Password";
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.label_login.Location = new System.Drawing.Point(55, 42);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(110, 42);
            this.label_login.TabIndex = 4;
            this.label_login.Text = "Login";
            // 
            // button_submit
            // 
            this.button_submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(73)))), ((int)(((byte)(229)))));
            this.button_submit.FlatAppearance.BorderSize = 0;
            this.button_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.label_signIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_signIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.label_signIn.Location = new System.Drawing.Point(598, 228);
            this.label_signIn.Name = "label_signIn";
            this.label_signIn.Size = new System.Drawing.Size(218, 69);
            this.label_signIn.TabIndex = 0;
            this.label_signIn.Text = "Sign in";
            // 
            // panel_signIn
            // 
            this.panel_signIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(50)))));
            this.panel_signIn.Controls.Add(this.text_box_password);
            this.panel_signIn.Controls.Add(this.text_box_login);
            this.panel_signIn.Controls.Add(label_forget_pass);
            this.panel_signIn.Controls.Add(this.check_show_pass);
            this.panel_signIn.Controls.Add(this.label_login);
            this.panel_signIn.Controls.Add(this.button_submit);
            this.panel_signIn.Controls.Add(this.lable_password);
            this.panel_signIn.Location = new System.Drawing.Point(450, 338);
            this.panel_signIn.Name = "panel_signIn";
            this.panel_signIn.Size = new System.Drawing.Size(545, 498);
            this.panel_signIn.TabIndex = 6;
            // 
            // text_box_password
            // 
            this.text_box_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_box_password.DefaultText = "";
            this.text_box_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_box_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_box_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_password.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.text_box_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_box_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.text_box_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_password.Location = new System.Drawing.Point(49, 249);
            this.text_box_password.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.text_box_password.Name = "text_box_password";
            this.text_box_password.PasswordChar = '\0';
            this.text_box_password.PlaceholderText = "";
            this.text_box_password.SelectedText = "";
            this.text_box_password.Size = new System.Drawing.Size(447, 56);
            this.text_box_password.TabIndex = 9;
            // 
            // text_box_login
            // 
            this.text_box_login.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_box_login.DefaultText = "";
            this.text_box_login.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_box_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_box_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_login.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_login.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.text_box_login.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_box_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.text_box_login.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_login.Location = new System.Drawing.Point(49, 109);
            this.text_box_login.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.text_box_login.Name = "text_box_login";
            this.text_box_login.PasswordChar = '\0';
            this.text_box_login.PlaceholderText = "";
            this.text_box_login.SelectedText = "";
            this.text_box_login.Size = new System.Drawing.Size(447, 56);
            this.text_box_login.TabIndex = 8;
            // 
            // check_show_pass
            // 
            this.check_show_pass.AutoSize = true;
            this.check_show_pass.FlatAppearance.BorderSize = 0;
            this.check_show_pass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.check_show_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(100)))), ((int)(((byte)(126)))));
            this.check_show_pass.Location = new System.Drawing.Point(54, 321);
            this.check_show_pass.Name = "check_show_pass";
            this.check_show_pass.Size = new System.Drawing.Size(120, 20);
            this.check_show_pass.TabIndex = 3;
            this.check_show_pass.Text = "Show password";
            this.check_show_pass.UseVisualStyleBackColor = true;
            this.check_show_pass.CheckedChanged += new System.EventHandler(this.check_box_checked_changed);
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
        private System.Windows.Forms.CheckBox check_show_pass;
        private Guna.UI2.WinForms.Guna2TextBox text_box_login;
        private Guna.UI2.WinForms.Guna2TextBox text_box_password;
    }
}

