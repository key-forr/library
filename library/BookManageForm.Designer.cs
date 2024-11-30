namespace library
{
    partial class BookManageForm
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
            this.panel_book_info = new System.Windows.Forms.Panel();
            this.panel_book_interaction = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel_book_info
            // 
            this.panel_book_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.panel_book_info.Location = new System.Drawing.Point(24, 24);
            this.panel_book_info.Name = "panel_book_info";
            this.panel_book_info.Size = new System.Drawing.Size(729, 650);
            this.panel_book_info.TabIndex = 0;
            // 
            // panel_book_interaction
            // 
            this.panel_book_interaction.Location = new System.Drawing.Point(759, 24);
            this.panel_book_interaction.Name = "panel_book_interaction";
            this.panel_book_interaction.Size = new System.Drawing.Size(651, 650);
            this.panel_book_interaction.TabIndex = 1;
            // 
            // BookManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1422, 686);
            this.Controls.Add(this.panel_book_interaction);
            this.Controls.Add(this.panel_book_info);
            this.Name = "BookManageForm";
            this.Text = "BookDetailForm";
            this.Load += new System.EventHandler(this.BookDetailsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_book_info;
        private System.Windows.Forms.Panel panel_book_interaction;
    }
}