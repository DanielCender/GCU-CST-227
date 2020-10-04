using MinesweeperClassLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone1
{
    public partial class MinesweeperGrid : Form
    {
        public static Board board;
        public static Button[,] boardBtns = new Button[16,16];
        public static Stopwatch watch = new Stopwatch();
        public static string timeElapsed;
        public MinesweeperGrid(int difficulty)
        {
            InitializeComponent();
            board = new Board(difficulty);
            // Initialize the board button struct
            foreach (var button in this.Controls.OfType<Button>())
            {
                int[] coordinates = getButtonTagCoordinates(button);
                int row = coordinates[0];
                int col = coordinates[1];
                // Store direct reference to the button
                boardBtns[row, col] = button;
            }
            setButtonTexts();
            watch.Start();
        }

        public static void setButtonTexts()
        {
            for (int r = 0; r < boardBtns.GetLength(0); r++)
            {
                for (int c = 0; c < boardBtns.GetLength(1); c++)
                {
                    if (board.Grid[r, c].LiveNeighbors > 0 && board.Grid[r,c].Visited) boardBtns[r, c].Text = string.Format("{0}", board.Grid[r, c].LiveNeighbors);
                }
            }
        }

        // Grab X/Y coordinates of cell selected
        private int[] getButtonTagCoordinates(Button b)
        {
            string[] inter = b.Tag.ToString().Split(',');
            int row = int.Parse(inter[1]);
            int col = int.Parse(inter[0]);
            int[] location = { row, col };
            return location;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            int[] coordinates = getButtonTagCoordinates(button);
            int row = coordinates[0];
            int col = coordinates[1];

            MouseEventArgs me = (MouseEventArgs)e;
            // If the user is right-clicking, then just add/remove flag
            if (me.Button == MouseButtons.Right)
            {
                if (board.Grid[row, col].Flagged)
                {
                    board.Grid[row, col].Flagged = false;
                    // Remove flag img
                    boardBtns[row, col].Image = null;
                }
                else
                {
                    board.Grid[row, col].Flagged = true;
                    // Add flag img
                    boardBtns[row, col].Image = Properties.Resources.flag; // Image.FromFile("/Users/danielcender/Documents/GCU/2020/CST-227/Wk5/Milestone/Milestone1/Images/flag");
                    boardBtns[row, col].ImageAlign = ContentAlignment.MiddleCenter;
                }
                return;
            }

            // Check if the button is already flagged. If so, do nothing
            if (board.Grid[row, col].Flagged)
            {
                return;
            }

            // Check if user hit a bomb
            if (board.Grid[row, col].Live)
            {
                // Show all bombs
                for (int r = 0; r < board.Grid.GetLength(0); r++)
                {
                    for (int c = 0; c < board.Grid.GetLength(1); c++)
                    {
                        if (board.Grid[row, col].Live)
                        {
                            // Set button image to bomb
                            boardBtns[row, col].Image = Properties.Resources.bomb; //Image.FromFile("/Users/danielcender/Documents/GCU/2020/CST-227/Wk5/Milestone/Milestone1/Images/bomb");
                            boardBtns[row, col].ImageAlign = ContentAlignment.MiddleCenter;
                        }
                    }
                }
                // Disable all buttons
                for (int r = 0; r < boardBtns.GetLength(0); r++)
                {
                    for (int c = 0; c < boardBtns.GetLength(1); c++)
                    {
                        boardBtns[r, c].Enabled = false;
                    }
                }
                timeElapsed = getCurrentWatchTime();
                watch.Stop();
                // Show Game Over Message
                Results nextForm = new Results("GAME OVER", timeElapsed);
                nextForm.Show();
            } else
            {
                // Check if all unarmed tiles have been visited
                if(board.AllSafeTilesVisited())
                {
                    // End game and see results
                    timeElapsed = getCurrentWatchTime();
                    watch.Stop();
                    Results nextForm = new Results("GAME WON", timeElapsed);
                    
                    nextForm.FormClosed += new System.Windows.Forms.FormClosedEventHandler(specialFormCloseEventHandler);
                    nextForm.Show();
                } else
                {
                    board.floodFill(row, col);
                    // Re-display all button Text properties
                    setButtonTexts();
                }
            }

            button.Text = string.Format("{0}", coordinates[0]);
            Console.Out.WriteLine("Clicked: {0} {1}", coordinates[0], coordinates[1]);
            // Finish game logic here
        }

        // This handler makes sure when the Results page closes, this frame gets hidden too
        private void specialFormCloseEventHandler(object sender, FormClosedEventArgs e)
        {
            Console.Out.WriteLine("Firing the close event handler....");
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeElapsed = getCurrentWatchTime();
        }

        public static string getCurrentWatchTime()
        {
            TimeSpan ts = watch.Elapsed;
            return String.Format("{0:00}.{1:00} seconds",
                ts.Seconds,
                ts.Milliseconds / 10);
        }
    }
}
