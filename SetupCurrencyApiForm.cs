﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialManager
{
    public partial class SetupCurrencyApiForm : Form
    {
        public SetupCurrencyApiForm()
        {
            InitializeComponent();

            keyTextBox.Text = Properties.Settings.Default.CurrencyApiKey;
        }
    }
}
