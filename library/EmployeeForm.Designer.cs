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
            this.button_back = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // button_back
            // 
            this.button_back.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_back.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_back.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_back.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_back.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.button_back.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_back.ForeColor = System.Drawing.Color.White;
            this.button_back.Image = global::library.Properties.Resources.Back;
            this.button_back.ImageSize = new System.Drawing.Size(40, 40);
            this.button_back.Location = new System.Drawing.Point(27, 25);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(55, 53);
            this.button_back.TabIndex = 19;
            this.button_back.Click += new System.EventHandler(this.button_back_home);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1442, 679);
            this.Controls.Add(this.button_back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button button_back;
    }
}