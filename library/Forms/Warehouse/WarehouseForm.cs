﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library.Forms.Warehouse
{
    public partial class WarehouseForm : Form
    {
        public WarehouseForm()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
