namespace CarShopGUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.makeLabel = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.bodyConditionLabel = new System.Windows.Forms.Label();
            this.makeInput = new System.Windows.Forms.TextBox();
            this.modelInput = new System.Windows.Forms.TextBox();
            this.priceInput = new System.Windows.Forms.TextBox();
            this.newRadio = new System.Windows.Forms.RadioButton();
            this.usedRadio = new System.Windows.Forms.RadioButton();
            this.isNewGroupBox = new System.Windows.Forms.GroupBox();
            this.bodyConditionInput = new System.Windows.Forms.NumericUpDown();
            this.createCarButton = new System.Windows.Forms.Button();
            this.addToCartButton = new System.Windows.Forms.Button();
            this.checkoutButton = new System.Windows.Forms.Button();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.totalCostValueLabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.isNewGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bodyConditionInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.createCarButton);
            this.groupBox1.Controls.Add(this.bodyConditionInput);
            this.groupBox1.Controls.Add(this.isNewGroupBox);
            this.groupBox1.Controls.Add(this.priceInput);
            this.groupBox1.Controls.Add(this.modelInput);
            this.groupBox1.Controls.Add(this.makeInput);
            this.groupBox1.Controls.Add(this.bodyConditionLabel);
            this.groupBox1.Controls.Add(this.priceLabel);
            this.groupBox1.Controls.Add(this.modelLabel);
            this.groupBox1.Controls.Add(this.makeLabel);
            this.groupBox1.Location = new System.Drawing.Point(63, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 574);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create a Car";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(621, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(394, 602);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Car Inventory:";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBox2);
            this.groupBox3.Location = new System.Drawing.Point(1255, 42);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(394, 602);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Shopping Cart:";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // makeLabel
            // 
            this.makeLabel.AutoSize = true;
            this.makeLabel.Location = new System.Drawing.Point(34, 80);
            this.makeLabel.Name = "makeLabel";
            this.makeLabel.Size = new System.Drawing.Size(71, 25);
            this.makeLabel.TabIndex = 0;
            this.makeLabel.Text = "Make:";
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(34, 127);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(77, 25);
            this.modelLabel.TabIndex = 1;
            this.modelLabel.Text = "Model:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(34, 177);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(67, 25);
            this.priceLabel.TabIndex = 2;
            this.priceLabel.Text = "Price:";
            // 
            // bodyConditionLabel
            // 
            this.bodyConditionLabel.AutoSize = true;
            this.bodyConditionLabel.Location = new System.Drawing.Point(34, 361);
            this.bodyConditionLabel.Name = "bodyConditionLabel";
            this.bodyConditionLabel.Size = new System.Drawing.Size(215, 25);
            this.bodyConditionLabel.TabIndex = 4;
            this.bodyConditionLabel.Text = "Body Condition (1-5):";
            this.bodyConditionLabel.Click += new System.EventHandler(this.bodyConditionLabel_Click);
            // 
            // makeInput
            // 
            this.makeInput.Location = new System.Drawing.Point(112, 80);
            this.makeInput.Name = "makeInput";
            this.makeInput.Size = new System.Drawing.Size(100, 31);
            this.makeInput.TabIndex = 5;
            // 
            // modelInput
            // 
            this.modelInput.Location = new System.Drawing.Point(112, 127);
            this.modelInput.Name = "modelInput";
            this.modelInput.Size = new System.Drawing.Size(100, 31);
            this.modelInput.TabIndex = 6;
            // 
            // priceInput
            // 
            this.priceInput.Location = new System.Drawing.Point(112, 177);
            this.priceInput.Name = "priceInput";
            this.priceInput.Size = new System.Drawing.Size(100, 31);
            this.priceInput.TabIndex = 7;
            // 
            // newRadio
            // 
            this.newRadio.AutoSize = true;
            this.newRadio.Location = new System.Drawing.Point(38, 30);
            this.newRadio.Name = "newRadio";
            this.newRadio.Size = new System.Drawing.Size(85, 29);
            this.newRadio.TabIndex = 8;
            this.newRadio.TabStop = true;
            this.newRadio.Text = "New";
            this.newRadio.UseVisualStyleBackColor = true;
            // 
            // usedRadio
            // 
            this.usedRadio.AutoSize = true;
            this.usedRadio.Location = new System.Drawing.Point(38, 65);
            this.usedRadio.Name = "usedRadio";
            this.usedRadio.Size = new System.Drawing.Size(93, 29);
            this.usedRadio.TabIndex = 9;
            this.usedRadio.TabStop = true;
            this.usedRadio.Text = "Used";
            this.usedRadio.UseVisualStyleBackColor = true;
            // 
            // isNewGroupBox
            // 
            this.isNewGroupBox.Controls.Add(this.usedRadio);
            this.isNewGroupBox.Controls.Add(this.newRadio);
            this.isNewGroupBox.Location = new System.Drawing.Point(39, 231);
            this.isNewGroupBox.Name = "isNewGroupBox";
            this.isNewGroupBox.Size = new System.Drawing.Size(206, 106);
            this.isNewGroupBox.TabIndex = 10;
            this.isNewGroupBox.TabStop = false;
            this.isNewGroupBox.Text = "Condition:";
            // 
            // bodyConditionInput
            // 
            this.bodyConditionInput.Location = new System.Drawing.Point(255, 359);
            this.bodyConditionInput.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.bodyConditionInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bodyConditionInput.Name = "bodyConditionInput";
            this.bodyConditionInput.Size = new System.Drawing.Size(120, 31);
            this.bodyConditionInput.TabIndex = 11;
            this.bodyConditionInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // createCarButton
            // 
            this.createCarButton.Location = new System.Drawing.Point(112, 454);
            this.createCarButton.Name = "createCarButton";
            this.createCarButton.Size = new System.Drawing.Size(151, 55);
            this.createCarButton.TabIndex = 12;
            this.createCarButton.Text = "Create Car";
            this.createCarButton.UseVisualStyleBackColor = true;
            this.createCarButton.Click += new System.EventHandler(this.createCarButton_Click);
            // 
            // addToCartButton
            // 
            this.addToCartButton.Location = new System.Drawing.Point(1033, 325);
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.Size = new System.Drawing.Size(192, 54);
            this.addToCartButton.TabIndex = 13;
            this.addToCartButton.Text = "Add to Cart ->";
            this.addToCartButton.UseVisualStyleBackColor = true;
            this.addToCartButton.Click += new System.EventHandler(this.addToCartButton_Click);
            // 
            // checkoutButton
            // 
            this.checkoutButton.Location = new System.Drawing.Point(1367, 673);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(192, 54);
            this.checkoutButton.TabIndex = 14;
            this.checkoutButton.Text = "Checkout:";
            this.checkoutButton.UseVisualStyleBackColor = true;
            this.checkoutButton.Click += new System.EventHandler(this.checkoutButton_Click);
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Location = new System.Drawing.Point(1320, 768);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(116, 25);
            this.totalCostLabel.TabIndex = 15;
            this.totalCostLabel.Text = "Total Cost:";
            this.totalCostLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // totalCostValueLabel
            // 
            this.totalCostValueLabel.AutoSize = true;
            this.totalCostValueLabel.Location = new System.Drawing.Point(1485, 768);
            this.totalCostValueLabel.Name = "totalCostValueLabel";
            this.totalCostValueLabel.Size = new System.Drawing.Size(0, 25);
            this.totalCostValueLabel.TabIndex = 16;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(24, 45);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(348, 529);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 25;
            this.listBox2.Location = new System.Drawing.Point(23, 45);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(348, 529);
            this.listBox2.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1754, 834);
            this.Controls.Add(this.totalCostValueLabel);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.checkoutButton);
            this.Controls.Add(this.addToCartButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.isNewGroupBox.ResumeLayout(false);
            this.isNewGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bodyConditionInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton newRadio;
        private System.Windows.Forms.TextBox priceInput;
        private System.Windows.Forms.TextBox modelInput;
        private System.Windows.Forms.TextBox makeInput;
        private System.Windows.Forms.Label bodyConditionLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label makeLabel;
        private System.Windows.Forms.NumericUpDown bodyConditionInput;
        private System.Windows.Forms.GroupBox isNewGroupBox;
        private System.Windows.Forms.RadioButton usedRadio;
        private System.Windows.Forms.Button createCarButton;
        private System.Windows.Forms.Button addToCartButton;
        private System.Windows.Forms.Button checkoutButton;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Label totalCostValueLabel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

