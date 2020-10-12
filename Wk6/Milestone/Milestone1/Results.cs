using Milestone;
using System;
using System.Collections.Generic;
using MinesweeperClassLib;
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
        public static PlayerStats stats;
        public Results(string results, string time, string playerName, decimal playerTime)
        {
            InitializeComponent();
            resultsTextLabel.Text = results;
            timeElapsedValue.Text = time;
            // Init player stats record
            stats = new PlayerStats(playerName, playerTime);
        }

        private void playAgainBtn_Click(object sender, EventArgs e)
        {
            // Create player stats 
            // Go back to game start and difficulty selection
            LeaderBoard nextForm = new LeaderBoard(stats);
            this.Close();
            nextForm.Show();
        }
    }
}
