﻿namespace StopWatch
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.nbrHitsLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nbrFalseHitsLabel = new System.Windows.Forms.Label();
            this.playAgainBtn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 504);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(163, 504);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 47);
            this.button2.TabIndex = 4;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(297, 504);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 47);
            this.button3.TabIndex = 5;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(93, 193);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(359, 163);
            this.button4.TabIndex = 6;
            this.button4.Text = "TARGET";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // nbrHitsLabel
            // 
            this.nbrHitsLabel.AutoSize = true;
            this.nbrHitsLabel.Location = new System.Drawing.Point(267, 21);
            this.nbrHitsLabel.Name = "nbrHitsLabel";
            this.nbrHitsLabel.Size = new System.Drawing.Size(133, 25);
            this.nbrHitsLabel.TabIndex = 7;
            this.nbrHitsLabel.Text = "nbrHitsLabel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(467, 515);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Game State:";
            // 
            // nbrFalseHitsLabel
            // 
            this.nbrFalseHitsLabel.AutoSize = true;
            this.nbrFalseHitsLabel.Location = new System.Drawing.Point(510, 21);
            this.nbrFalseHitsLabel.Name = "nbrFalseHitsLabel";
            this.nbrFalseHitsLabel.Size = new System.Drawing.Size(133, 25);
            this.nbrFalseHitsLabel.TabIndex = 9;
            this.nbrFalseHitsLabel.Text = "nbrFalseHits";
            // 
            // playAgainBtn
            // 
            this.playAgainBtn.Location = new System.Drawing.Point(750, 12);
            this.playAgainBtn.Name = "playAgainBtn";
            this.playAgainBtn.Size = new System.Drawing.Size(207, 47);
            this.playAgainBtn.TabIndex = 10;
            this.playAgainBtn.Text = "Play Again";
            this.playAgainBtn.UseVisualStyleBackColor = true;
            this.playAgainBtn.Click += new System.EventHandler(this.playAgainBtn_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(492, 193);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(359, 163);
            this.button5.TabIndex = 11;
            this.button5.Text = "FALSE TARGET";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 578);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.playAgainBtn);
            this.Controls.Add(this.nbrFalseHitsLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nbrHitsLabel);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label nbrHitsLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nbrFalseHitsLabel;
        private System.Windows.Forms.Button playAgainBtn;
        private System.Windows.Forms.Button button5;
    }
}

