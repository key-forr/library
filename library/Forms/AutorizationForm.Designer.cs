﻿
namespace library.Forms
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
            this.label_signIn = new System.Windows.Forms.Label();
            this.panel_signIn = new System.Windows.Forms.Panel();
            this.checked_show_password = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.button_submit = new Guna.UI2.WinForms.Guna2Button();
            this.text_box_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.text_box_login = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel_window_navigation = new System.Windows.Forms.Panel();
            this.button_collapse = new FontAwesome.Sharp.IconButton();
            this.button_window_state = new FontAwesome.Sharp.IconButton();
            this.button_close = new FontAwesome.Sharp.IconButton();
            label_forget_pass = new System.Windows.Forms.Label();
            this.panel_signIn.SuspendLayout();
            this.panel_window_navigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_forget_pass
            // 
            label_forget_pass.AutoSize = true;
            label_forget_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(100)))), ((int)(((byte)(126)))));
            label_forget_pass.Location = new System.Drawing.Point(371, 325);
            label_forget_pass.Name = "label_forget_pass";
            label_forget_pass.Size = new System.Drawing.Size(116, 16);
            label_forget_pass.TabIndex = 6;
            label_forget_pass.Text = "Забули пароль ?";
            // 
            // lable_password
            // 
            this.lable_password.AutoSize = true;
            this.lable_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.lable_password.Location = new System.Drawing.Point(55, 200);
            this.lable_password.Name = "lable_password";
            this.lable_password.Size = new System.Drawing.Size(148, 42);
            this.lable_password.TabIndex = 5;
            this.lable_password.Text = "Пароль";
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_login.ForeColor = System.Drawing.Color.White;
            this.label_login.Location = new System.Drawing.Point(55, 42);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(108, 42);
            this.label_login.TabIndex = 4;
            this.label_login.Text = "Логін";
            // 
            // label_signIn
            // 
            this.label_signIn.AutoSize = true;
            this.label_signIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_signIn.ForeColor = System.Drawing.Color.White;
            this.label_signIn.Location = new System.Drawing.Point(633, 222);
            this.label_signIn.Name = "label_signIn";
            this.label_signIn.Size = new System.Drawing.Size(152, 69);
            this.label_signIn.TabIndex = 0;
            this.label_signIn.Text = "Вхід";
            // 
            // panel_signIn
            // 
            this.panel_signIn.AutoSize = true;
            this.panel_signIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(50)))));
            this.panel_signIn.Controls.Add(this.checked_show_password);
            this.panel_signIn.Controls.Add(this.button_submit);
            this.panel_signIn.Controls.Add(this.text_box_password);
            this.panel_signIn.Controls.Add(this.text_box_login);
            this.panel_signIn.Controls.Add(label_forget_pass);
            this.panel_signIn.Controls.Add(this.label_login);
            this.panel_signIn.Controls.Add(this.lable_password);
            this.panel_signIn.Location = new System.Drawing.Point(450, 338);
            this.panel_signIn.Name = "panel_signIn";
            this.panel_signIn.Size = new System.Drawing.Size(545, 498);
            this.panel_signIn.TabIndex = 6;
            // 
            // checked_show_password
            // 
            this.checked_show_password.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(50)))));
            this.checked_show_password.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(73)))), ((int)(((byte)(229)))));
            this.checked_show_password.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.checked_show_password.CheckedState.InnerColor = System.Drawing.Color.White;
            this.checked_show_password.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checked_show_password.Location = new System.Drawing.Point(49, 315);
            this.checked_show_password.Name = "checked_show_password";
            this.checked_show_password.Size = new System.Drawing.Size(35, 20);
            this.checked_show_password.TabIndex = 10;
            this.checked_show_password.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checked_show_password.UncheckedState.BorderThickness = 1;
            this.checked_show_password.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(50)))));
            this.checked_show_password.UncheckedState.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(73)))), ((int)(((byte)(229)))));
            this.checked_show_password.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(73)))), ((int)(((byte)(229)))));
            this.checked_show_password.CheckedChanged += new System.EventHandler(this.checked_show_password_CheckedChanged);
            // 
            // button_submit
            // 
            this.button_submit.BorderRadius = 10;
            this.button_submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_submit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_submit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_submit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_submit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_submit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(73)))), ((int)(((byte)(229)))));
            this.button_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_submit.ForeColor = System.Drawing.Color.White;
            this.button_submit.Location = new System.Drawing.Point(150, 388);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(237, 64);
            this.button_submit.TabIndex = 8;
            this.button_submit.Text = "Підтвердити";
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            this.button_submit.MouseEnter += new System.EventHandler(this.button_submit_MouseEnter);
            this.button_submit.MouseLeave += new System.EventHandler(this.button_submit_MouseLeave);
            // 
            // text_box_password
            // 
            this.text_box_password.AutoSize = true;
            this.text_box_password.BorderColor = System.Drawing.Color.White;
            this.text_box_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_box_password.DefaultText = "";
            this.text_box_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_box_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_box_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_password.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.text_box_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_box_password.ForeColor = System.Drawing.Color.White;
            this.text_box_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_password.Location = new System.Drawing.Point(49, 249);
            this.text_box_password.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.text_box_password.Name = "text_box_password";
            this.text_box_password.PasswordChar = '●';
            this.text_box_password.PlaceholderText = "";
            this.text_box_password.SelectedText = "";
            this.text_box_password.Size = new System.Drawing.Size(447, 56);
            this.text_box_password.TabIndex = 9;
            // 
            // text_box_login
            // 
            this.text_box_login.AutoSize = true;
            this.text_box_login.BorderColor = System.Drawing.Color.White;
            this.text_box_login.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_box_login.DefaultText = "";
            this.text_box_login.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_box_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_box_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_login.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_login.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.text_box_login.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_box_login.ForeColor = System.Drawing.Color.White;
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
            // panel_window_navigation
            // 
            this.panel_window_navigation.Controls.Add(this.button_collapse);
            this.panel_window_navigation.Controls.Add(this.button_window_state);
            this.panel_window_navigation.Controls.Add(this.button_close);
            this.panel_window_navigation.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_window_navigation.Location = new System.Drawing.Point(0, 0);
            this.panel_window_navigation.Name = "panel_window_navigation";
            this.panel_window_navigation.Size = new System.Drawing.Size(1440, 35);
            this.panel_window_navigation.TabIndex = 7;
            // 
            // button_collapse
            // 
            this.button_collapse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_collapse.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_collapse.FlatAppearance.BorderSize = 0;
            this.button_collapse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_collapse.ForeColor = System.Drawing.Color.Black;
            this.button_collapse.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.button_collapse.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(100)))), ((int)(((byte)(126)))));
            this.button_collapse.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button_collapse.IconSize = 30;
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
            this.button_window_state.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(100)))), ((int)(((byte)(126)))));
            this.button_window_state.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button_window_state.IconSize = 30;
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
            this.button_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(100)))), ((int)(((byte)(126)))));
            this.button_close.IconChar = FontAwesome.Sharp.IconChar.X;
            this.button_close.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(100)))), ((int)(((byte)(126)))));
            this.button_close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button_close.IconSize = 25;
            this.button_close.Location = new System.Drawing.Point(1387, 0);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(53, 35);
            this.button_close.TabIndex = 0;
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // AutorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1440, 900);
            this.Controls.Add(this.panel_window_navigation);
            this.Controls.Add(this.panel_signIn);
            this.Controls.Add(this.label_signIn);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AutorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel_signIn.ResumeLayout(false);
            this.panel_signIn.PerformLayout();
            this.panel_window_navigation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lable_password;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_signIn;
        private System.Windows.Forms.Panel panel_signIn;
        private Guna.UI2.WinForms.Guna2TextBox text_box_login;
        private Guna.UI2.WinForms.Guna2TextBox text_box_password;
        private System.Windows.Forms.Panel panel_window_navigation;
        private FontAwesome.Sharp.IconButton button_collapse;
        private FontAwesome.Sharp.IconButton button_window_state;
        private FontAwesome.Sharp.IconButton button_close;
        private Guna.UI2.WinForms.Guna2Button button_submit;
        private Guna.UI2.WinForms.Guna2ToggleSwitch checked_show_password;
    }
}
