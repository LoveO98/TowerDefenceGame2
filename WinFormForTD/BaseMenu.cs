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

        
        public delegate void BuyStructureHandler(int nr);
        public event BuyStructureHandler buyStructure;
        public event Action exitLevel;

        public event Action changeTargeting;
        public event Action unlockTargeting;

        private void btnBaseBuyShort_Click(object sender, EventArgs e)
        {
            buyStructure.Invoke(1);
        }

        private void btnBaseBuyMedium_Click(object sender, EventArgs e)
        {
            buyStructure.Invoke(2);
        }

        private void btnBaseBuyLong_Click(object sender, EventArgs e)
        {
            buyStructure.Invoke(3);
        }

        private void btnBaseBuyTower_Click(object sender, EventArgs e)
        {
            buyStructure.Invoke(4);
        }

        private void btnBaseExit_Click(object sender, EventArgs e)
        {
            exitLevel.Invoke();
        }

        private void BaseMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBaseApplyRules_Click(object sender, EventArgs e)
        {
            changeTargeting.Invoke();
        }

        private void btnBaseUnlockAll_Click(object sender, EventArgs e)
        {
            unlockTargeting.Invoke();
        }
    }
}
