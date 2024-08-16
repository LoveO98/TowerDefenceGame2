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
    public partial class TowerInfoForm : Form
    {
        public TowerInfoForm()
        {
            InitializeComponent();
        }

        public event Action DestroyTower;

        private void btnDestroyTurret_Click(object sender, EventArgs e)
        {
            DestroyTower.Invoke();
        }
    }
}
