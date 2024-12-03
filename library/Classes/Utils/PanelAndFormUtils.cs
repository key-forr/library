using System;
using System.Linq;
using System.Windows.Forms;

namespace library.Classes.Utils
{
    internal static class PanelAndFormUtils
    {
        public static void EmbedFormInPanel(Form childForm, Panel targetPanel)
        {
            foreach (var control in targetPanel.Controls.OfType<Form>().ToList())
            {
                if (control.GetType() == childForm.GetType())
                {
                    targetPanel.Controls.Remove(control);
                    control.Close();
                }
            }

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
