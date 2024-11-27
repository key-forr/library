using System;
using System.Windows.Forms;

namespace library
{
    internal static class PanelAndFormManager
    {
        public static void EmbedFormInPanel(Form childForm, Panel targetPanel)
        {
            // Перевірка, чи форма вже вбудована в панель
            foreach (Control control in targetPanel.Controls)
            {
                if (control.GetType() == childForm.GetType()) // Перевіряємо тип форми
                {
                    return ;
                }
            }

            // Якщо форма ще не вбудована
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            targetPanel.Controls.Add(childForm);
            targetPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

    }
}
