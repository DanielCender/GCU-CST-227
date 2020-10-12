namespace Milestone1
{
    partial class Results
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
            this.resultsTextLabel = new System.Windows.Forms.Label();
            this.timeElapsedLabel = new System.Windows.Forms.Label();
            this.timeElapsedValue = new System.Windows.Forms.Label();
            this.leaderBoardBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultsTextLabel
            // 
            this.resultsTextLabel.AutoSize = true;
            this.resultsTextLabel.Location = new System.Drawing.Point(44, 25);
            this.resultsTextLabel.Name = "resultsTextLabel";
            this.resultsTextLabel.Size = new System.Drawing.Size(35, 13);
            this.resultsTextLabel.TabIndex = 0;
            this.resultsTextLabel.Text = "label1";
            this.resultsTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timeElapsedLabel
            // 
            this.timeElapsedLabel.AutoSize = true;
            this.timeElapsedLabel.Location = new System.Drawing.Point(44, 65);
            this.timeElapsedLabel.Name = "timeElapsedLabel";
            this.timeElapsedLabel.Size = new System.Drawing.Size(74, 13);
            this.timeElapsedLabel.TabIndex = 1;
            this.timeElapsedLabel.Text = "Time Elapsed:";
            this.timeElapsedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timeElapsedValue
            // 
            this.timeElapsedValue.AutoSize = true;
            this.timeElapsedValue.Location = new System.Drawing.Point(124, 65);
            this.timeElapsedValue.Name = "timeElapsedValue";
            this.timeElapsedValue.Size = new System.Drawing.Size(32, 13);
            this.timeElapsedValue.TabIndex = 2;
            this.timeElapsedValue.Text = "(time)";
            this.timeElapsedValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // leaderBoardBtn
            // 
            this.leaderBoardBtn.Location = new System.Drawing.Point(67, 122);
            this.leaderBoardBtn.Name = "leaderBoardBtn";
            this.leaderBoardBtn.Size = new System.Drawing.Size(118, 33);
            this.leaderBoardBtn.TabIndex = 3;
            this.leaderBoardBtn.Text = "View LeaderBoard";
            this.leaderBoardBtn.UseVisualStyleBackColor = true;
            this.leaderBoardBtn.Click += new System.EventHandler(this.playAgainBtn_Click);
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 167);
            this.Controls.Add(this.leaderBoardBtn);
            this.Controls.Add(this.timeElapsedValue);
            this.Controls.Add(this.timeElapsedLabel);
            this.Controls.Add(this.resultsTextLabel);
            this.Name = "Results";
            this.Text = "Results";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label resultsTextLabel;
        private System.Windows.Forms.Label timeElapsedLabel;
        private System.Windows.Forms.Label timeElapsedValue;
        private System.Windows.Forms.Button leaderBoardBtn;
    }
}