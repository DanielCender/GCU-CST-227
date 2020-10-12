using System;
using MinesweeperClassLib;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Milestone1
{
    public partial class MinesweeperGrid : Form
    {
        public static Board board;
        public static string playerName;
        public static Button[,] boardBtns = new Button[16,16];
        public static Stopwatch watch = new Stopwatch();
        public static string timeElapsed;
        public MinesweeperGrid(int difficulty, string name)
        {
            InitializeComponent();
            board = new Board(difficulty);
            playerName = name;
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
                {// Set all non-live, visited, non-flagged cells to
                    // background color if they have > 0 live
                    //  neighbors
                    // Otherwise just set the text value
                    if (board.Grid[r, c].Visited && board.Grid[r, c].LiveNeighbors > 0) boardBtns[r, c].Text = string.Format("{0}", board.Grid[r, c].LiveNeighbors);
                    else if (board.Grid[r, c].Visited) boardBtns[r, c].BackColor = Color.FromArgb(167, 188, 216);
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
        private void button1_Click(object sender, EventArgs e) {
            // Just keeping this here cause I need to figure out how to remove
            // 99+ event handler references non-manually :|
        }

        private void mouseDown_handler(object sender, MouseEventArgs e)
        {
            var button = (Button)sender;
            int[] coordinates = getButtonTagCoordinates(button);
            int row = coordinates[0];
            int col = coordinates[1];

            // If the user is right-clicking, then just add/remove flag
            Console.WriteLine("User clicked with {0}", e.Button);
            if (e.Button == MouseButtons.Right)
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
                // Set clicked bomb's background to red
                boardBtns[row, col].BackColor = Color.FromArgb(235, 51, 35);
                boardBtns[row, col].Text = null;
                // Show all bombs
                for (int r = 0; r < board.Grid.GetLength(0); r++)
                {
                    for (int c = 0; c < board.Grid.GetLength(1); c++)
                    {
                        if (board.Grid[r, c].Live)
                        {
                            Console.Out.WriteLine("Another live one");
                            // Set button image to bomb
                            boardBtns[r, c].Image = Properties.Resources.bomb; //Image.FromFile("/Users/danielcender/Documents/GCU/2020/CST-227/Wk5/Milestone/Milestone1/Images/bomb");
                            boardBtns[r, c].ImageAlign = ContentAlignment.MiddleCenter;
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
                decimal playerTime = watch.Elapsed.Seconds;
                watch.Reset();
                // Show Game Over Message
                Results nextForm = new Results("GAME OVER", timeElapsed, playerName, playerTime);
                nextForm.Show();
            } else
            {
                // Check if all unarmed tiles have been visited
                if(board.AllSafeTilesVisited())
                {
                    // End game and see results
                    timeElapsed = getCurrentWatchTime();
                    decimal playerTime = watch.Elapsed.Seconds;
                    watch.Reset();
                    Results nextForm = new Results("GAME WON", timeElapsed, playerName, playerTime);
                    
                    nextForm.FormClosed += new System.Windows.Forms.FormClosedEventHandler(specialFormCloseEventHandler);
                    nextForm.Show();
                } else
                {
                    board.floodFill(row, col);
                    
                            // Re-display all button Text properties
                            setButtonTexts();
                }
            }
        }

        // This handler makes sure when the Results page closes, this frame gets hidden too
        private void specialFormCloseEventHandler(object sender, FormClosedEventArgs e)
        {
            Console.Out.WriteLine("Firing the close event handler....");
            this.Close();
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
