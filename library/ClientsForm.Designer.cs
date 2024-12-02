namespace library
{
    partial class ClientsForm
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
            this.panel_clients_list = new System.Windows.Forms.Panel();
            this.panel_client_interaction = new System.Windows.Forms.Panel();
            this.button_add = new Guna.UI2.WinForms.Guna2Button();
            this.button_back = new FontAwesome.Sharp.IconButton();
            this.text_box_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // panel_clients_list
            // 
            this.panel_clients_list.Location = new System.Drawing.Point(915, 12);
            this.panel_clients_list.Name = "panel_clients_list";
            this.panel_clients_list.Size = new System.Drawing.Size(495, 662);
            this.panel_clients_list.TabIndex = 30;
            // 
            // panel_client_interaction
            // 
            this.panel_client_interaction.Location = new System.Drawing.Point(414, 12);
            this.panel_client_interaction.Name = "panel_client_interaction";
            this.panel_client_interaction.Size = new System.Drawing.Size(495, 662);
            this.panel_client_interaction.TabIndex = 31;
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
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
            this.button_add.Location = new System.Drawing.Point(93, 140);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(265, 50);
            this.button_add.TabIndex = 56;
            this.button_add.Text = "Додати клієнта";
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            this.button_add.MouseEnter += new System.EventHandler(this.button_add_MouseEnter);
            this.button_add.MouseLeave += new System.EventHandler(this.button_add_MouseLeave);
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.button_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_back.FlatAppearance.BorderSize = 0;
            this.button_back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.button_back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_back.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.button_back.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(169)))), ((int)(((byte)(118)))));
            this.button_back.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button_back.Location = new System.Drawing.Point(12, 12);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(55, 46);
            this.button_back.TabIndex = 22;
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // text_box_search
            // 
            this.text_box_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(50)))));
            this.text_box_search.BorderColor = System.Drawing.Color.White;
            this.text_box_search.BorderRadius = 10;
            this.text_box_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_box_search.DefaultText = "+380";
            this.text_box_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_box_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_box_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_box_search.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(50)))));
            this.text_box_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_box_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(100)))), ((int)(((byte)(126)))));
            this.text_box_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_box_search.IconLeft = global::library.Properties.Resources.Search;
            this.text_box_search.Location = new System.Drawing.Point(93, 69);
            this.text_box_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_box_search.Name = "text_box_search";
            this.text_box_search.PasswordChar = '\0';
            this.text_box_search.PlaceholderForeColor = System.Drawing.Color.White;
            this.text_box_search.PlaceholderText = "";
            this.text_box_search.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.text_box_search.SelectedText = "";
            this.text_box_search.Size = new System.Drawing.Size(265, 45);
            this.text_box_search.TabIndex = 57;
            // 
            // ClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1422, 686);
            this.Controls.Add(this.text_box_search);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.panel_client_interaction);
            this.Controls.Add(this.panel_clients_list);
            this.Controls.Add(this.button_back);
            this.Name = "ClientsForm";
            this.Text = "ClientForm";
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton button_back;
        private System.Windows.Forms.Panel panel_clients_list;
        private System.Windows.Forms.Panel panel_client_interaction;
        private Guna.UI2.WinForms.Guna2Button button_add;
        private Guna.UI2.WinForms.Guna2TextBox text_box_search;
    }
}