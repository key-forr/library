namespace library
{
    partial class AccountOptionsForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_personal_data = new FontAwesome.Sharp.IconButton();
            this.button_logout = new FontAwesome.Sharp.IconButton();
            this.panel = new System.Windows.Forms.Panel();
            this.button_close = new FontAwesome.Sharp.IconButton();
            this.label_employee = new System.Windows.Forms.Label();
            this.label_phone = new System.Windows.Forms.Label();
            this.label_name_surname = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_personal_data);
            this.panel1.Controls.Add(this.button_logout);
            this.panel1.Controls.Add(this.panel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 338);
            this.panel1.TabIndex = 0;
            // 
            // button_personal_data
            // 
            this.button_personal_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(50)))));
            this.button_personal_data.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_personal_data.FlatAppearance.BorderSize = 0;
            this.button_personal_data.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_personal_data.ForeColor = System.Drawing.Color.White;
            this.button_personal_data.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.button_personal_data.IconColor = System.Drawing.Color.White;
            this.button_personal_data.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button_personal_data.IconSize = 24;
            this.button_personal_data.Location = new System.Drawing.Point(0, 151);
            this.button_personal_data.Name = "button_personal_data";
            this.button_personal_data.Size = new System.Drawing.Size(457, 96);
            this.button_personal_data.TabIndex = 8;
            this.button_personal_data.Text = "Додаткова інформація";
            this.button_personal_data.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_personal_data.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_personal_data.UseMnemonic = false;
            this.button_personal_data.UseVisualStyleBackColor = false;
            this.button_personal_data.Click += new System.EventHandler(this.button_personal_data_Click);
            // 
            // button_logout
            // 
            this.button_logout.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(50)))));
            this.button_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_logout.FlatAppearance.BorderSize = 0;
            this.button_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_logout.ForeColor = System.Drawing.Color.White;
            this.button_logout.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.button_logout.IconColor = System.Drawing.Color.White;
            this.button_logout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button_logout.IconSize = 24;
            this.button_logout.Location = new System.Drawing.Point(-1, 242);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(457, 96);
            this.button_logout.TabIndex = 10;
            this.button_logout.Text = "Вийти з системи";
            this.button_logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_logout.UseMnemonic = false;
            this.button_logout.UseVisualStyleBackColor = false;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(78)))));
            this.panel.Controls.Add(this.button_close);
            this.panel.Controls.Add(this.label_employee);
            this.panel.Controls.Add(this.label_phone);
            this.panel.Controls.Add(this.label_name_surname);
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(457, 182);
            this.panel.TabIndex = 9;
            // 
            // button_close
            // 
            this.button_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_close.FlatAppearance.BorderSize = 0;
            this.button_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(78)))));
            this.button_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(78)))));
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(169)))), ((int)(((byte)(118)))));
            this.button_close.IconChar = FontAwesome.Sharp.IconChar.X;
            this.button_close.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(169)))), ((int)(((byte)(118)))));
            this.button_close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button_close.IconSize = 24;
            this.button_close.Location = new System.Drawing.Point(390, 13);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(49, 41);
            this.button_close.TabIndex = 3;
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // label_employee
            // 
            this.label_employee.AutoSize = true;
            this.label_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_employee.ForeColor = System.Drawing.Color.White;
            this.label_employee.Location = new System.Drawing.Point(20, 22);
            this.label_employee.Name = "label_employee";
            this.label_employee.Size = new System.Drawing.Size(150, 32);
            this.label_employee.TabIndex = 2;
            this.label_employee.Text = "Працівник";
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_phone.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_phone.Location = new System.Drawing.Point(24, 109);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(0, 20);
            this.label_phone.TabIndex = 1;
            // 
            // label_name_surname
            // 
            this.label_name_surname.AutoSize = true;
            this.label_name_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name_surname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_name_surname.Location = new System.Drawing.Point(21, 75);
            this.label_name_surname.Name = "label_name_surname";
            this.label_name_surname.Size = new System.Drawing.Size(0, 25);
            this.label_name_surname.TabIndex = 0;
            // 
            // AccountOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 338);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountOptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AccountOptionsForm";
            this.panel1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton button_personal_data;
        private FontAwesome.Sharp.IconButton button_logout;
        private System.Windows.Forms.Panel panel;
        private FontAwesome.Sharp.IconButton button_close;
        private System.Windows.Forms.Label label_employee;
        private System.Windows.Forms.Label label_phone;
        private System.Windows.Forms.Label label_name_surname;
    }
}