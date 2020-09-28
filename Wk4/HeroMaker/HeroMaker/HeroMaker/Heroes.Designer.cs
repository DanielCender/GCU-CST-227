namespace HeroMaker
{
    partial class Heroes
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
            this.heroesListBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.heroInfoBox = new System.Windows.Forms.TextBox();
            this.heroesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.heroesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.heroesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heroesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // heroesListBox
            // 
            this.heroesListBox.FormattingEnabled = true;
            this.heroesListBox.ItemHeight = 25;
            this.heroesListBox.Location = new System.Drawing.Point(31, 70);
            this.heroesListBox.Name = "heroesListBox";
            this.heroesListBox.Size = new System.Drawing.Size(220, 279);
            this.heroesListBox.TabIndex = 0;
            this.heroesListBox.SelectedIndexChanged += new System.EventHandler(this.heroesListBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Heroes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dossier:";
            // 
            // heroInfoBox
            // 
            this.heroInfoBox.Location = new System.Drawing.Point(278, 70);
            this.heroInfoBox.Multiline = true;
            this.heroInfoBox.Name = "heroInfoBox";
            this.heroInfoBox.Size = new System.Drawing.Size(483, 279);
            this.heroInfoBox.TabIndex = 4;
            // 
            // heroesBindingSource1
            // 
            this.heroesBindingSource1.DataSource = typeof(HeroMaker.Heroes);
            // 
            // heroesBindingSource
            // 
            this.heroesBindingSource.DataSource = typeof(HeroMaker.Heroes);
            // 
            // Heroes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.heroInfoBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.heroesListBox);
            this.Name = "Heroes";
            this.Text = "Heroes";
            ((System.ComponentModel.ISupportInitialize)(this.heroesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heroesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox heroesListBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox heroInfoBox;
        private System.Windows.Forms.BindingSource heroesBindingSource1;
        private System.Windows.Forms.BindingSource heroesBindingSource;
    }
}