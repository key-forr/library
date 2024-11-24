using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace library
{
    public class PanelStateManager
    {
        private Dictionary<Panel, List<Control>> panelStates = new Dictionary<Panel, List<Control>>();

        public void SavePanelState(Panel panel)
        {
            if (panel == null) 
                return;

            var controlsCopy = panel.Controls.Cast<Control>().ToList();

            if (panelStates.ContainsKey(panel))
                panelStates[panel] = controlsCopy;
            else
                panelStates.Add(panel, controlsCopy);
        }

        public void RestorePanelState(Panel panel)
        {
            if (panel == null || !panelStates.ContainsKey(panel)) 
                return;

            panel.Controls.Clear();

            foreach (var control in panelStates[panel])
            {
                panel.Controls.Add(control);
            }
        }
    }
}
