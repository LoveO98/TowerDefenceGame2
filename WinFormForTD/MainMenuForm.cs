using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WinFormForTD.TurretInfoForm;

namespace WinFormForTD
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        public delegate void StartLevelHandler(int levelNr);
        public event StartLevelHandler StartLevel;
        public event Action ExitGame;

        private void btnMenuTutorial_Click(object sender, EventArgs e)
        {
            StartLevel.Invoke(0);
        }

        private void btnMenuLvl1_Click(object sender, EventArgs e)
        {
            StartLevel.Invoke(1);
        }

        private void btnMenuLvl2_Click(object sender, EventArgs e)
        {
            StartLevel.Invoke(2);
        }

        private void btnMenuSandbox_Click(object sender, EventArgs e)
        {
            StartLevel.Invoke(3);
        }

        private void btnMenuExit_Click(object sender, EventArgs e)
        {
            ExitGame.Invoke();
        }
    }
}
