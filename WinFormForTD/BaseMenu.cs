using System;
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
    public partial class BaseMenu : Form
    {
        public BaseMenu()
        {
            InitializeComponent();
        }

        public bool _exitLevel;
        public bool _buyTurret;
        public int _turretNR;
        public delegate void BuyStructureHandler(int nr);
        public event BuyStructureHandler buyStructure;

        private void btnBaseBuyShort_Click(object sender, EventArgs e)
        {
            buyStructure.Invoke(1);
            //_buyTurret = true;
            //_turretNR = 1;
        }

        private void btnBaseBuyMedium_Click(object sender, EventArgs e)
        {
            buyStructure.Invoke(2);
            //_buyTurret = true;
            //_turretNR = 2;
        }

        private void btnBaseBuyLong_Click(object sender, EventArgs e)
        {
            buyStructure.Invoke(3);
            //_buyTurret = true;
            //_turretNR = 3;
        }

        private void btnBaseBuyTower_Click(object sender, EventArgs e)
        {
            buyStructure.Invoke(4);
        }

        private void btnBaseExit_Click(object sender, EventArgs e)
        {
            _exitLevel = true;
        }

        private void BaseMenu_Load(object sender, EventArgs e)
        {
            
        }

        
    }
}
