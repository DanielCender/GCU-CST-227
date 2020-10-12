namespace Milestone1
{
    partial class LeaderBoard
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
            this.label1 = new System.Windows.Forms.Label();
            this.playerStatsBox = new System.Windows.Forms.ListBox();
            this.playAgainBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "10 Top High Scores";
            // 
            // playerStatsBox
            // 
            this.playerStatsBox.FormattingEnabled = true;
            this.playerStatsBox.Location = new System.Drawing.Point(83, 59);
            this.playerStatsBox.Name = "playerStatsBox";
            this.playerStatsBox.Size = new System.Drawing.Size(247, 238);
            this.playerStatsBox.TabIndex = 1;
            this.playerStatsBox.SelectedIndexChanged += new System.EventHandler(this.playerStatsBox_SelectedIndexChanged);
            // 
            // playAgainBtn
            // 
            this.playAgainBtn.Location = new System.Drawing.Point(165, 303);
            this.playAgainBtn.Name = "playAgainBtn";
            this.playAgainBtn.Size = new System.Drawing.Size(75, 23);
            this.playAgainBtn.TabIndex = 2;
            this.playAgainBtn.Text = "Play Again";
            this.playAgainBtn.UseVisualStyleBackColor = true;
            this.playAgainBtn.Click += new System.EventHandler(this.playAgainBtn_Click);
            // 
            // LeaderBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 347);
            this.Controls.Add(this.playAgainBtn);
            this.Controls.Add(this.playerStatsBox);
            this.Controls.Add(this.label1);
            this.Name = "LeaderBoard";
            this.Text = "LeaderBoard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox playerStatsBox;
        private System.Windows.Forms.Button playAgainBtn;
    }
}