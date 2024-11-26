namespace library
{
    partial class EmployeeForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panel_reminder = new Guna.UI2.WinForms.Guna2Panel();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.button_more_reminder = new Guna.UI2.WinForms.Guna2Button();
            this.label_reminder = new System.Windows.Forms.Label();
            this.reminder_view = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.panel_reminder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reminder_view)).BeginInit();
            this.SuspendLayout();
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(169)))), ((int)(((byte)(118)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 32;
            this.iconButton1.Location = new System.Drawing.Point(-2, 1);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(87, 84);
            this.iconButton1.TabIndex = 20;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(50)))));
            this.guna2Panel1.BorderRadius = 16;
            this.guna2Panel1.Location = new System.Drawing.Point(91, 33);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(514, 607);
            this.guna2Panel1.TabIndex = 21;
            // 
            // panel_reminder
            // 
            this.panel_reminder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(50)))));
            this.panel_reminder.BorderRadius = 16;
            this.panel_reminder.Controls.Add(this.iconButton5);
            this.panel_reminder.Controls.Add(this.button_more_reminder);
            this.panel_reminder.Controls.Add(this.label_reminder);
            this.panel_reminder.Controls.Add(this.reminder_view);
            this.panel_reminder.Location = new System.Drawing.Point(637, 34);
            this.panel_reminder.Name = "panel_reminder";
            this.panel_reminder.Size = new System.Drawing.Size(414, 607);
            this.panel_reminder.TabIndex = 22;
            // 
            // iconButton5
            // 
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.Bell;
            this.iconButton5.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(169)))), ((int)(((byte)(118)))));
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 24;
            this.iconButton5.Location = new System.Drawing.Point(306, 23);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(48, 33);
            this.iconButton5.TabIndex = 11;
            this.iconButton5.UseVisualStyleBackColor = true;
            // 
            // button_more_reminder
            // 
            this.button_more_reminder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(50)))));
            this.button_more_reminder.BorderRadius = 10;
            this.button_more_reminder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_more_reminder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_more_reminder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_more_reminder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_more_reminder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(169)))), ((int)(((byte)(118)))));
            this.button_more_reminder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_more_reminder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.button_more_reminder.Location = new System.Drawing.Point(129, 541);
            this.button_more_reminder.Name = "button_more_reminder";
            this.button_more_reminder.Size = new System.Drawing.Size(155, 45);
            this.button_more_reminder.TabIndex = 10;
            this.button_more_reminder.Text = "Додати";
            // 
            // label_reminder
            // 
            this.label_reminder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_reminder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.label_reminder.Location = new System.Drawing.Point(104, 19);
            this.label_reminder.Name = "label_reminder";
            this.label_reminder.Size = new System.Drawing.Size(199, 39);
            this.label_reminder.TabIndex = 0;
            this.label_reminder.Text = "Нагадування";
            this.label_reminder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reminder_view
            // 
            this.reminder_view.AllowUserToAddRows = false;
            this.reminder_view.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.reminder_view.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.reminder_view.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reminder_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reminder_view.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(50)))));
            this.reminder_view.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reminder_view.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.reminder_view.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(100)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(100)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.reminder_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.reminder_view.ColumnHeadersHeight = 50;
            this.reminder_view.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(100)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.reminder_view.DefaultCellStyle = dataGridViewCellStyle3;
            this.reminder_view.DoubleBuffered = true;
            this.reminder_view.EnableHeadersVisualStyles = false;
            this.reminder_view.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(50)))));
            this.reminder_view.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(100)))), ((int)(((byte)(126)))));
            this.reminder_view.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(100)))), ((int)(((byte)(126)))));
            this.reminder_view.Location = new System.Drawing.Point(35, 72);
            this.reminder_view.Name = "reminder_view";
            this.reminder_view.ReadOnly = true;
            this.reminder_view.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.reminder_view.RowHeadersVisible = false;
            this.reminder_view.RowHeadersWidth = 51;
            this.reminder_view.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(100)))), ((int)(((byte)(126)))));
            this.reminder_view.RowTemplate.Height = 40;
            this.reminder_view.RowTemplate.ReadOnly = true;
            this.reminder_view.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.reminder_view.Size = new System.Drawing.Size(343, 447);
            this.reminder_view.TabIndex = 0;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(50)))));
            this.guna2Panel2.BorderRadius = 16;
            this.guna2Panel2.Location = new System.Drawing.Point(1083, 34);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(291, 606);
            this.guna2Panel2.TabIndex = 22;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1442, 679);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.panel_reminder);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.iconButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.panel_reminder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reminder_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton iconButton1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel panel_reminder;
        private FontAwesome.Sharp.IconButton iconButton5;
        private Bunifu.Framework.UI.BunifuCustomDataGrid reminder_view;
        private Guna.UI2.WinForms.Guna2Button button_more_reminder;
        private System.Windows.Forms.Label label_reminder;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
    }
}