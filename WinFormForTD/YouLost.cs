﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormForTD
{
    public partial class YouLost : Form
    {
        public YouLost()
        {
            InitializeComponent();
        }

        public event Action returnToMenu;

        private void btnReturn_Click(object sender, EventArgs e)
        {
            returnToMenu.Invoke();
        }
    }
}