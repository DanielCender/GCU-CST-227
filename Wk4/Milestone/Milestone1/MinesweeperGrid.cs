using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone1
{
    public partial class MinesweeperGrid : Form
    {
        public MinesweeperGrid()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var control = (Button)sender;
            int inter = string.IsNullOrEmpty(control.Text) ? 1 : int.Parse(control.Text) + 1;
            control.Text = string.Format("{0}", inter);
        }
    }
}
