namespace library.Forms.Reminder
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
            this.label_title = new System.Windows.Forms.Label();
            this.label_description = new System.Windows.Forms.Label();
            this.text_box_title = new System.Windows.Forms.TextBox();
            this.text_box_description = new System.Windows.Forms.TextBox();
            this.button_back = new FontAwesome.Sharp.IconButton();
            this.date_picker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.button_add = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_title.ForeColor = System.Drawing.Color.White;
            this.label_title.Location = new System.Drawing.Point(130, 13);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(93, 39);
            this.label_title.TabIndex = 24;
            this.label_title.Text = "Назва";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_description
            // 
            this.label_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_description.ForeColor = System.Drawing.Color.White;
            this.label_description.Location = new System.Drawing.Point(130, 107);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(93, 33);
            this.label_description.TabIndex = 25;
            this.label_description.Text = "Опис";
            this.label_description.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text_box_title
            // 
            this.text_box_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.text_box_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_box_title.ForeColor = System.Drawing.Color.White;
            this.text_box_title.Location = new System.Drawing.Point(17, 66);
            this.text_box_title.MaxLength = 20;
            this.text_box_title.Name = "text_box_title";
            this.text_box_title.Size = new System.Drawing.Size(330, 38);
            this.text_box_title.TabIndex = 26;
            // 
            // text_box_description
            // 
            this.text_box_description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.text_box_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_box_description.ForeColor = System.Drawing.Color.White;
            this.text_box_description.Location = new System.Drawing.Point(17, 143);
            this.text_box_description.MaxLength = 100;
            this.text_box_description.Multiline = true;
            this.text_box_description.Name = "text_box_description";
            this.text_box_description.Size = new System.Drawing.Size(330, 150);
            this.text_box_description.TabIndex = 27;
            // 
            // button_back
            // 
            this.button_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_back.FlatAppearance.BorderSize = 0;
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_back.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.button_back.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(169)))), ((int)(((byte)(118)))));
            this.button_back.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button_back.Location = new System.Drawing.Point(17, 12);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(53, 48);
            this.button_back.TabIndex = 28;
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            this.button_back.MouseEnter += new System.EventHandler(this.button_back_MouseEnter);
            this.button_back.MouseLeave += new System.EventHandler(this.button_back_MouseLeave);
            // 
            // date_picker
            // 
            this.date_picker.Checked = true;
            this.date_picker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.date_picker.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(73)))), ((int)(((byte)(229)))));
            this.date_picker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.date_picker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.date_picker.Location = new System.Drawing.Point(17, 300);
            this.date_picker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date_picker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date_picker.Name = "date_picker";
            this.date_picker.Size = new System.Drawing.Size(216, 41);
            this.date_picker.TabIndex = 30;
            this.date_picker.Value = new System.DateTime(2024, 11, 30, 18, 28, 23, 256);
            // 
            // button_add
            // 
            this.button_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_add.FlatAppearance.BorderSize = 0;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.button_add.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(169)))), ((int)(((byte)(118)))));
            this.button_add.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button_add.IconSize = 50;
            this.button_add.Location = new System.Drawing.Point(299, 299);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(48, 42);
            this.button_add.TabIndex = 31;
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            this.button_add.MouseEnter += new System.EventHandler(this.button_add_MouseEnter);
            this.button_add.MouseLeave += new System.EventHandler(this.button_add_MouseLeave);
            // 
            // ReminderAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(359, 353);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.date_picker);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.text_box_description);
            this.Controls.Add(this.text_box_title);
            this.Controls.Add(this.label_description);
            this.Controls.Add(this.label_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ReminderAddForm";
            this.Text = "ReminderAddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.TextBox text_box_title;
        private System.Windows.Forms.TextBox text_box_description;
        private FontAwesome.Sharp.IconButton button_back;
        private Guna.UI2.WinForms.Guna2DateTimePicker date_picker;
        private FontAwesome.Sharp.IconButton button_add;
    }
}