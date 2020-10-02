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
        public Form1()
        {
            InitializeComponent();
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
            if(button4.Visible)
                button4.Location = new Point(rand.Next(60, 660), rand.Next(30, 490));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            // Stop watch to record time taken to click the "mole" button
            watch.Stop();
        }
    }
}
