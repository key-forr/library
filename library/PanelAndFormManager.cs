using System;
using System.Windows.Forms;

namespace library
{
    internal static class PanelAndFormManager
    {
        public static void EmbedFormInPanel(Form childForm, Panel targetPanel)
        {
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
