using Milestone;
using MinesweeperClassLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone1
{
    public partial class LeaderBoard : Form
    {
        // Setup location of player stats db
        string filePath = Path.Combine(Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).FullName).FullName, @"", "stats.txt");
        string[] fileLines = { };
        ArrayList statList = new ArrayList();
        BindingSource statsListBinding = new BindingSource();
        public LeaderBoard(PlayerStats playerStats)
        {
            InitializeComponent();

            // Read all player stats
            try
            {
                fileLines = File.ReadAllLines(filePath);
               // fileLines = File.ReadAllLines(Properties.Resources.stats);
            }
            catch (Exception e)
            {
                Console.WriteLine("File could not be read successfully. Illegal file path: {0}", filePath);
                Console.WriteLine(e.Message);
            }

            for (int i = 0; i < fileLines.Length; i++)
            {
                string line = fileLines[i];
                string[] entries = line.Split(',');
                if (entries.Length != 2)
                {
                    // Print message and continue to next line
                    Console.WriteLine("Player stats file row {0} does not contain 2 valid columns: {1}", i, line);
                    continue;
                }
                statList.Add(new PlayerStats(entries[0], decimal.Parse(entries[1])));
            }


            // Add new stat to list
            statList.Add(playerStats);

            // Sort and grab top 10
            var orderedPlayers =
                from PlayerStats stats in statList
                orderby stats
                select stats;
            var top10Players = orderedPlayers.Take(10);
            // Save new list
            List<String> outputLines = new List<string>();
            foreach(PlayerStats s in top10Players)
            {
                outputLines.Add(s.ToString());
            }
            File.WriteAllLines(filePath, outputLines);
           // File.WriteAllLines(Properties.Resources.stats, outputLines);
            // Display records
            statsListBinding.DataSource = top10Players;
            playerStatsBox.DataSource = statsListBinding;
            playerStatsBox.DisplayMember = "name";
            playerStatsBox.ValueMember = "name";

        }

        private void playerStatsBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void playAgainBtn_Click(object sender, EventArgs e)
        {
            LevelSelect nextForm = new LevelSelect();
            this.Close();
            nextForm.Show();
        }
    }
}
