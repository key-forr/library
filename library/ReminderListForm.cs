using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    public partial class ReminderListForm : Form
    {
        private List<Guna.UI2.WinForms.Guna2GroupBox> reminderCards = new List<Guna.UI2.WinForms.Guna2GroupBox>();
        
        public ReminderListForm()
        {
            InitializeComponent();
        }

        public void PinReminderCard(Guna.UI2.WinForms.Guna2GroupBox cardToPin)
        {
            cardToPin.Tag = true;

            reminderCards.Remove(cardToPin);
            this.Controls.Remove(cardToPin);

            int pinnedCount = reminderCards.Count(card => IsCardPinned(card));
            reminderCards.Insert(pinnedCount, cardToPin);

            RearrangeCards();
        }

        public void UnpinReminderCard(Guna.UI2.WinForms.Guna2GroupBox cardToUnpin)
        {
            cardToUnpin.Tag = false;

            reminderCards.Remove(cardToUnpin);
            this.Controls.Remove(cardToUnpin);

            reminderCards.Add(cardToUnpin);

            RearrangeCards();
        }

        private bool IsCardPinned(Guna.UI2.WinForms.Guna2GroupBox card)
        {
            return card.Tag != null && (bool)card.Tag == true;
        }

        private void RearrangeCards()
        {
            int x = 15;
            int y = 5;

            foreach (var card in reminderCards)
            {
                card.Location = new Point(x, y);
                this.Controls.Add(card);
                y += 110; 
            }
        }

        private void ReminderLoad()
        {
            using (DataBaseHelper dataBaseHelper = new DataBaseHelper())
            {
                reminderCards = dataBaseHelper.LoadReminderDataForCard(this);
                foreach (var bookCard in reminderCards)
                {
                    this.Controls.Add(bookCard);
                }
            }
        }

        private void ReminderListForm_Load(object sender, EventArgs e)
        {
            ReminderLoad();
        }
    }
}
