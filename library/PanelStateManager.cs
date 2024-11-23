using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace library
{
    public class PanelStateManager
    {
        // Хеш-таблиця для зберігання станів панелей
        private Dictionary<Panel, List<Control>> panelStates = new Dictionary<Panel, List<Control>>();

        // Метод для збереження стану панелі
        public void SavePanelState(Panel panel)
        {
            if (panel == null) return;

            // Копіюємо поточний стан (усі дочірні елементи)
            var controlsCopy = panel.Controls.Cast<Control>().ToList();

            // Додаємо до словника (або оновлюємо, якщо стан вже існує)
            if (panelStates.ContainsKey(panel))
                panelStates[panel] = controlsCopy;
            else
                panelStates.Add(panel, controlsCopy);
        }

        // Метод для відновлення стану панелі
        public void RestorePanelState(Panel panel)
        {
            if (panel == null || !panelStates.ContainsKey(panel)) return;

            // Очищаємо панель
            panel.Controls.Clear();

            // Відновлюємо збережені елементи
            foreach (var control in panelStates[panel])
            {
                panel.Controls.Add(control);
            }
        }

        // Метод для очищення стану панелі (якщо потрібно видалити дані з хеш-таблиці)
        public void ClearPanelState(Panel panel)
        {
            if (panelStates.ContainsKey(panel))
            {
                panelStates.Remove(panel);
            }
        }
    }
}
