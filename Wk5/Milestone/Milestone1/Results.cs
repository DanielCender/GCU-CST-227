using Milestone;
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
    public partial class Results : Form
    {
        public Results(string results, string time)
        {
            InitializeComponent();
            resultsTextLabel.Text = results;
            timeElapsedValue.Text = time;
        }

        private void playAgainBtn_Click(object sender, EventArgs e)
        {
            // Go back to game start and difficulty selection
            LevelSelect nextForm = new LevelSelect();
            this.Close();
            nextForm.Show();
        }
    }
}
