using FontAwesome.Sharp;
using Guna.UI2.WinForms;
using library;
using System;
using System.Data;
using System.Drawing;
using System.Web.Configuration;
using System.Windows.Forms;

namespace library
{
    public partial class HomeForm : Form
    {
        private RemindersListForm reminderListForm;
        private BooksForm booksForm;
        private UsersForm employeeForm;
        private ReminderAddForm reminderAddForm;
        private PersonalDataForm personalDataForm;
        private WarehouseForm storageForm;
        private BookingForm bookingForm;
        private ClientsForm customerForm;
        private StatisticsForm statisticsForm;
        private AccountOptionsForm accountOptionsForm;

        private Control currentActiveButton;

        public HomeForm()
        {
            InitializeComponent();
            reminderListForm = new RemindersListForm();
            PanelAndFormManager.EmbedFormInPanel(reminderListForm, panel_reminder_list);

            SetActiveNavigationButton(button_home_navigation);
        }

        public Panel MainPanel
        {
            get { return panel_main; }
        }

        public void UpdateReminderListForm()
        {
            panel_reminder_list.Controls.Clear();

            reminderListForm = new RemindersListForm();
            PanelAndFormManager.EmbedFormInPanel(reminderListForm, panel_reminder_list);
        }

        private void SetActiveNavigationButton(Control button)
        {
            if (currentActiveButton != null)
            {
                ResetNavigationButton(currentActiveButton);
            }

            currentActiveButton = button;

            if (button is IconButton iconBtn)
            {
                iconBtn.IconColor = Color.FromArgb(156, 74, 232);
                iconBtn.ForeColor = Color.FromArgb(156, 74, 232);
            }
            else if (button is Button regularBtn)
            {
                regularBtn.ForeColor = Color.FromArgb(156, 74, 232);
            }
        }

        private void ResetNavigationButton(Control button)
        {
            if (button is IconButton iconBtn)
            {
                iconBtn.IconColor = Color.White;
                iconBtn.ForeColor = Color.White;
            }
            else if (button is Button regularBtn)
            {
                regularBtn.ForeColor = Color.White;
            }
        }

        private bool IsButtonActive(Control button)
        {
            if (currentActiveButton == null)
                return false;

            if (button is IconButton iconBtn && currentActiveButton is IconButton currentIconBtn)
            {
                return iconBtn == currentIconBtn;
            }
            else if (button is Button regularBtn && currentActiveButton is Button currentRegularBtn)
            {
                return regularBtn == currentRegularBtn;
            }

            return false;
        }

        private void button_collapse_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button_window_state_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.StartPosition = FormStartPosition.CenterScreen;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_add_reminder_Click(object sender, EventArgs e)
        {
            reminderAddForm = new ReminderAddForm(this);
            PanelAndFormManager.EmbedFormInPanel(reminderAddForm, panel_reminder);
        }

        private void button_books_navigation_Click(object sender, EventArgs e)
        {
            SetActiveNavigationButton(button_books_navigation);

            booksForm = new BooksForm();
            PanelAndFormManager.EmbedFormInPanel(booksForm, panel_main);
        }

        private void button_employee_navigation_Click(object sender, EventArgs e)
        {
            SetActiveNavigationButton(button_employee_navigation);

            employeeForm = new UsersForm();
            PanelAndFormManager.EmbedFormInPanel(employeeForm, panel_main);
        }

        private void button_storage_navigation_Click(object sender, EventArgs e)
        {
            SetActiveNavigationButton(button_storage_navigation);

            storageForm = new WarehouseForm();
            PanelAndFormManager.EmbedFormInPanel(storageForm, panel_main);
        }

        private void button_booking_navigation_Click(object sender, EventArgs e)
        {
            SetActiveNavigationButton(button_booking_navigation);

            bookingForm = new BookingForm();
            PanelAndFormManager.EmbedFormInPanel(bookingForm, panel_main);
        }

        private void button_statistics_navigation_Click(object sender, EventArgs e)
        {
            SetActiveNavigationButton(button_statistics_navigation);

            statisticsForm = new StatisticsForm();
            PanelAndFormManager.EmbedFormInPanel(statisticsForm, panel_main);
        }

        private void button_customer_navigation_Click(object sender, EventArgs e)
        {
            SetActiveNavigationButton(button_customer_navigation);

            customerForm = new ClientsForm();
            PanelAndFormManager.EmbedFormInPanel(customerForm, panel_main);
        }

        private void button_personal_office_navigation_Click(object sender, EventArgs e)
        {
            SetActiveNavigationButton(button_personal_office_navigation);

            accountOptionsForm = new AccountOptionsForm(this);

            accountOptionsForm.Location = new Point
            (
                this.Location.X + this.Width - accountOptionsForm.Width - 100,
                this.Location.Y + 75
            );

            accountOptionsForm.ShowDialog();

            personalDataForm = accountOptionsForm.PersonalDataForm;
        }

        private void button_home_navigation_Click(object sender, EventArgs e)
        {
            SetActiveNavigationButton(button_home_navigation);

            if (booksForm != null && booksForm.Visible)
            {
                booksForm.Close();
            }

            if (accountOptionsForm != null && accountOptionsForm.Visible)
            {
                accountOptionsForm.Close();
            }

            if (personalDataForm != null && personalDataForm.Visible)
            {
                personalDataForm.Close();
            }

            if (storageForm != null && storageForm.Visible)
            {
                storageForm.Close();
            }

            if (bookingForm != null && bookingForm.Visible)
            {
                bookingForm.Close();
            }

            if (customerForm != null && customerForm.Visible)
            {
                customerForm.Close();
            }

            if (statisticsForm != null && statisticsForm.Visible)
            {
                statisticsForm.Close();
            }

            if (employeeForm != null && employeeForm.Visible)
            {
                employeeForm.Close();
            }

            if (reminderAddForm != null && reminderAddForm.Visible)
            {
                reminderAddForm.Close();
            }
        }

        private void button_add_reminder_MouseEnter(object sender, EventArgs e)
        {
            ButtonUtils.AnimateButtonOnHover(button_add_reminder, true, Color.FromArgb(72, 169, 118), 5);
        }

        private void button_add_reminder_MouseLeave(object sender, EventArgs e)
        {
            ButtonUtils.AnimateButtonOnHover(button_add_reminder, false, Color.FromArgb(72, 169, 118), 5);
        }

        private void button_books_navigation_MouseEnter(object sender, EventArgs e)
        {
            if (!IsButtonActive(button_books_navigation))
            {
                ButtonUtils.AnimateNavigationButton(button_books_navigation, true, Color.White, Color.FromArgb(22, 26, 50));
            }
        }

        private void button_books_navigation_MouseLeave(object sender, EventArgs e)
        {
            if (!IsButtonActive(button_books_navigation))
            {
                ButtonUtils.AnimateNavigationButton(button_books_navigation, false, Color.White, Color.FromArgb(22, 26, 50));
            }
        }

        private void button_storage_navigation_MouseEnter(object sender, EventArgs e)
        {
            if (!IsButtonActive(button_storage_navigation))
            {
                ButtonUtils.AnimateNavigationButton(button_storage_navigation, true, Color.White, Color.FromArgb(22, 26, 50));
            }
        }

        private void button_storage_navigation_MouseLeave(object sender, EventArgs e)
        {
            if (!IsButtonActive(button_storage_navigation))
            {
                ButtonUtils.AnimateNavigationButton(button_storage_navigation, false, Color.White, Color.FromArgb(22, 26, 50));
            }
        }

        private void button_booking_navigation_MouseEnter(object sender, EventArgs e)
        {
            if (!IsButtonActive(button_booking_navigation))
            {
                ButtonUtils.AnimateNavigationButton(button_booking_navigation, true, Color.White, Color.FromArgb(22, 26, 50));
            }
        }

        private void button_booking_navigation_MouseLeave(object sender, EventArgs e)
        {
            if (!IsButtonActive(button_booking_navigation))
            {
                ButtonUtils.AnimateNavigationButton(button_booking_navigation, false, Color.White, Color.FromArgb(22, 26, 50));
            }
        }

        private void button_customer_navigation_MouseEnter(object sender, EventArgs e)
        {
            if (!IsButtonActive(button_customer_navigation))
            {
                ButtonUtils.AnimateNavigationButton(button_customer_navigation, true, Color.White, Color.FromArgb(22, 26, 50));
            }
        }

        private void button_customer_navigation_MouseLeave(object sender, EventArgs e)
        {
            if (!IsButtonActive(button_customer_navigation))
            {
                ButtonUtils.AnimateNavigationButton(button_customer_navigation, false, Color.White, Color.FromArgb(22, 26, 50));
            }
        }

        private void button_employee_navigation_MouseEnter(object sender, EventArgs e)
        {
            if (!IsButtonActive(button_employee_navigation))
            {
                ButtonUtils.AnimateNavigationButton(button_employee_navigation, true, Color.White, Color.FromArgb(22, 26, 50));
            }
        }

        private void button_employee_navigation_MouseLeave(object sender, EventArgs e)
        {
            if (!IsButtonActive(button_employee_navigation))
            {
                ButtonUtils.AnimateNavigationButton(button_employee_navigation, false, Color.White, Color.FromArgb(22, 26, 50));
            }
        }

        private void button_statistics_navigation_MouseEnter(object sender, EventArgs e)
        {
            if (!IsButtonActive(button_statistics_navigation))
            {
                ButtonUtils.AnimateNavigationButton(button_statistics_navigation, true, Color.White, Color.FromArgb(22, 26, 50));
            }
        }

        private void button_statistics_navigation_MouseLeave(object sender, EventArgs e)
        {
            if (!IsButtonActive(button_statistics_navigation))
            {
                ButtonUtils.AnimateNavigationButton(button_statistics_navigation, false, Color.White, Color.FromArgb(22, 26, 50));
            }
        }

        private void button_home_navigation_MouseEnter(object sender, EventArgs e)
        {
            if (!IsButtonActive(button_home_navigation))
            {
                ButtonUtils.AnimateNavigationIconButton(button_home_navigation, true, Color.White, Color.FromArgb(22, 26, 50));
            }
        }

        private void button_home_navigation_MouseLeave(object sender, EventArgs e)
        {
            if (!IsButtonActive(button_home_navigation))
            {
                ButtonUtils.AnimateNavigationIconButton(button_home_navigation, false, Color.White, Color.FromArgb(22, 26, 50));
            }
        }

        private void button_personal_office_navigation_MouseEnter(object sender, EventArgs e)
        {
            if (!IsButtonActive(button_personal_office_navigation))
            {
                ButtonUtils.AnimateNavigationIconButton(button_personal_office_navigation, true, Color.White, Color.FromArgb(22, 26, 50));
            }
        }

        private void button_personal_office_navigation_MouseLeave(object sender, EventArgs e)
        {
            if (!IsButtonActive(button_personal_office_navigation))
            {
                ButtonUtils.AnimateNavigationIconButton(button_personal_office_navigation, false, Color.White, Color.FromArgb(22, 26, 50));
            }
        }
    }
}
