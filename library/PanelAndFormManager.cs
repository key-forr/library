using System;
using System.Windows.Forms;

namespace library
{
    internal static class PanelAndFormManager
    {
        public static void EmbedFormInPanel(Form childForm, Panel targetPanel)
        {
<<<<<<< HEAD
=======
            // Перевірка, чи форма вже вбудована в панель
>>>>>>> 7f9592e53a4bcc03e4191fd5acca31c2eb419e5c
            foreach (Control control in targetPanel.Controls)
            {
                if (control.GetType() == childForm.GetType()) // Перевіряємо тип форми
                {
<<<<<<< HEAD
                    return;
                }
            }

=======
                    return ;
                }
            }

            // Якщо форма ще не вбудована
>>>>>>> 7f9592e53a4bcc03e4191fd5acca31c2eb419e5c
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
