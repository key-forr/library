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
        private HomeForm _parentForm;
        private Panel _targetPanel;

        public EmployeeForm(HomeForm parentForm, Panel targetPanel)
        {
            InitializeComponent();
            _parentForm = parentForm;
            _targetPanel = targetPanel;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            _parentForm.BackPanel(_targetPanel);
        }
    }
}
