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
    public partial class EmployeeForm : Form
    {
        private HomeForm parentForm;
        private Panel targetPanel;

        public EmployeeForm(HomeForm parentForm, Panel targetPanel)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.targetPanel = targetPanel;
        }

        private void button_back_home(object sender, EventArgs e)
        {
            this.Hide();
            this.parentForm.BackPanel(this.targetPanel);
        }
    }
}
