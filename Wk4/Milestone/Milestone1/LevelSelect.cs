﻿using Milestone1;
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
        public LevelSelect()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MinesweeperGrid nextForm = new MinesweeperGrid();
            this.Hide();
            nextForm.Show();
        }

        private void LevelSelect_Click(object sender, EventArgs e)
        {

        }

        private void LevelSelect_Load(object sender, EventArgs e)
        {

        }
    }
}
