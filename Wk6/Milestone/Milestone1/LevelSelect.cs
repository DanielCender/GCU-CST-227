using Milestone1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone
{
    public partial class LevelSelect : Form
    {
        public static int difficulty = 0;
        public static string name = "";
        public LevelSelect()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            difficulty = 2;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            difficulty = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MinesweeperGrid nextForm = new MinesweeperGrid(difficulty, name);
            this.Hide();
            nextForm.Show();
        }

        private void LevelSelect_Click(object sender, EventArgs e)
        {

        }

        private void LevelSelect_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            difficulty = 0;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void playerNameTextBox_TextChanged(object sender, EventArgs e)
        {
            name = playerNameTextBox.Text;
        }
    }
}
