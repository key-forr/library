namespace library
{
    partial class ReminderAddForm
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
            this.butoon_back = new Guna.UI2.WinForms.Guna2Button();
            this.button_add = new Guna.UI2.WinForms.Guna2Button();
            this.label_title = new System.Windows.Forms.Label();
            this.label_description = new System.Windows.Forms.Label();
            this.text_box_title = new System.Windows.Forms.TextBox();
            this.text_box_description = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // butoon_back
            // 
            this.butoon_back.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butoon_back.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butoon_back.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butoon_back.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butoon_back.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(50)))));
            this.butoon_back.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.butoon_back.ForeColor = System.Drawing.Color.White;
            this.butoon_back.Image = global::library.Properties.Resources.Back;
            this.butoon_back.ImageSize = new System.Drawing.Size(40, 40);
            this.butoon_back.Location = new System.Drawing.Point(12, 12);
            this.butoon_back.Name = "butoon_back";
            this.butoon_back.Size = new System.Drawing.Size(54, 48);
            this.butoon_back.TabIndex = 18;
            this.butoon_back.Click += new System.EventHandler(this.butoon_back_Click);
            // 
            // button_add
            // 
            this.button_add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_add.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(50)))));
            this.button_add.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_add.ForeColor = System.Drawing.Color.White;
            this.button_add.Image = global::library.Properties.Resources.Add;
            this.button_add.ImageSize = new System.Drawing.Size(40, 40);
            this.button_add.Location = new System.Drawing.Point(310, 248);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(55, 51);
            this.button_add.TabIndex = 23;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label_title
            // 
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.label_title.Location = new System.Drawing.Point(12, 73);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(93, 39);
            this.label_title.TabIndex = 24;
            this.label_title.Text = "Назва";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_description
            // 
            this.label_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.label_description.Location = new System.Drawing.Point(7, 122);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(93, 33);
            this.label_description.TabIndex = 25;
            this.label_description.Text = "Опис";
            this.label_description.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text_box_title
            // 
            this.text_box_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.text_box_title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_box_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_box_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.text_box_title.Location = new System.Drawing.Point(111, 78);
            this.text_box_title.Name = "text_box_title";
            this.text_box_title.Size = new System.Drawing.Size(254, 23);
            this.text_box_title.TabIndex = 26;
            // 
            // text_box_description
            // 
            this.text_box_description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.text_box_description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_box_description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.text_box_description.Location = new System.Drawing.Point(17, 168);
            this.text_box_description.Multiline = true;
            this.text_box_description.Name = "text_box_description";
            this.text_box_description.Size = new System.Drawing.Size(259, 131);
            this.text_box_description.TabIndex = 27;
            // 
            // ReminderAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(377, 326);
            this.Controls.Add(this.text_box_description);
            this.Controls.Add(this.text_box_title);
            this.Controls.Add(this.label_description);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.butoon_back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReminderAddForm";
            this.Text = "ReminderAddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button butoon_back;
        private Guna.UI2.WinForms.Guna2Button button_add;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.TextBox text_box_title;
        private System.Windows.Forms.TextBox text_box_description;
    }
}