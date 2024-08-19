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
    public partial class TurretInfoForm : Form
    {

        public event Action DestroyTurret;
        public delegate void UpgradeTurretHandler(int upgrade);
        public event UpgradeTurretHandler UpgradeTurret;
        public event Action LockOnCheck;
        public event Action LockTargetChange;
        public event Action TargetModeChange;

        public TurretInfoForm()
        {
            InitializeComponent();
        }

        private void btnDestroyTurret_Click(object sender, EventArgs e)
        {
            DestroyTurret.Invoke();
        }

        private void cbTurretIgnoreGlobalTargeting_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnUpgradeTurretBasic_Click(object sender, EventArgs e)
        {
            UpgradeTurret.Invoke(1);
        }

        private void btnUpgradeTurretAlien_Click(object sender, EventArgs e)
        {
            UpgradeTurret.Invoke(2);
        }

        private void cbTurretLockOn_CheckedChanged(object sender, EventArgs e)
        {
            LockOnCheck.Invoke();
        }

        private void cbTurretIgnoreGlobalTargeting_CheckedChanged(object sender, EventArgs e)
        {
            LockTargetChange.Invoke();
        }

        

        private void cbTurretTargetingModes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            TargetModeChange.Invoke();
        }
    }
}
