using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch
{
    public partial class Form1 : Form
    {
        public static Stopwatch watch = new Stopwatch();
        public static Random rand = new Random();
        public static int nbrHits = 0;
        public static int formClicks = 0;
        public Form1()
        {
            InitializeComponent();
            nbrHitsLabel.Text = String.Format("Hits: {0}", nbrHits);
            nbrFalseHitsLabel.Text = String.Format("False Hits: {0}", formClicks);
            playAgainBtn.Visible = false;
            // Start timer automatically
            watch.Start();
        }

        public void disableButtons()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
        }
        public void enableButtons()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            watch.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            watch.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            watch.Restart();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = watch.Elapsed;

            // Format and display the TimeSpan value in more readable format.
            label1.Text = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);

            // Move the button to a random place on the form
           //if(button4.Visible)
           // Originally, button was only clickable once.
           //   Now, it can be clicked until a game-ending state is arrived
           button4.Location = new Point(rand.Next(60, 660), rand.Next(30, 490));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // button4.Visible = false;
            nbrHits += 1;
            nbrHitsLabel.Text = String.Format("Hits: {0}", nbrHits);
            if (nbrHits >= 5)
            {
                watch.Stop();
                button4.Visible = false;
                label2.Text += " Game Won!";
                disableButtons();
                playAgainBtn.Visible = true;
            }
            // Stop watch to record time taken to click the "mole" button
            //watch.Stop();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            // Add to illegal form clicks, counts towards game ending
            formClicks += 1;
            nbrFalseHitsLabel.Text = string.Format("False Hits: {0}", formClicks);
            if (formClicks >= 3)
            {
                watch.Stop();
                button4.Visible = false;
                // Set game state to "defeat"
                label2.Text += " Game Over";
                disableButtons();
                playAgainBtn.Visible = true;
            }
        }

        private void playAgainBtn_Click(object sender, EventArgs e)
        {
            formClicks = 0;
            nbrFalseHitsLabel.Text = string.Format("False Hits: {0}", formClicks);
            nbrHits = 0;
            nbrHitsLabel.Text = String.Format("Hits: {0}", nbrHits);
            label2.Text += "";
            enableButtons();
            playAgainBtn.Visible = true;
            watch.Start();
        }
    }
}
