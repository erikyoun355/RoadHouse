namespace RoadHouse
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
            this.colorLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.subTitleLabel = new System.Windows.Forms.Label();
            this.pricingLabel = new System.Windows.Forms.Label();
            this.burgerBox = new System.Windows.Forms.TextBox();
            this.fryBox = new System.Windows.Forms.TextBox();
            this.drinkBox = new System.Windows.Forms.TextBox();
            this.priceButton = new System.Windows.Forms.Button();
            this.subPLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.payBox = new System.Windows.Forms.TextBox();
            this.changeLabel = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.reciptButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // colorLabel
            // 
            this.colorLabel.BackColor = System.Drawing.Color.SaddleBrown;
            this.colorLabel.Location = new System.Drawing.Point(277, 63);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(319, 433);
            this.colorLabel.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Sienna;
            this.titleLabel.Font = new System.Drawing.Font("Road Rage", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.Black;
            this.titleLabel.Location = new System.Drawing.Point(-2, 1);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(613, 37);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Ragin\' Andy\'s Ragin\' Angry Roadhouse";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // subTitleLabel
            // 
            this.subTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.subTitleLabel.Font = new System.Drawing.Font("Road Rage", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTitleLabel.ForeColor = System.Drawing.Color.Black;
            this.subTitleLabel.Location = new System.Drawing.Point(101, 38);
            this.subTitleLabel.Name = "subTitleLabel";
            this.subTitleLabel.Size = new System.Drawing.Size(390, 25);
            this.subTitleLabel.TabIndex = 2;
            this.subTitleLabel.Text = "\"Our prices\'ll drive you mad!\"";
            this.subTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pricingLabel
            // 
            this.pricingLabel.BackColor = System.Drawing.Color.Sienna;
            this.pricingLabel.Font = new System.Drawing.Font("Road Rage", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricingLabel.Location = new System.Drawing.Point(13, 64);
            this.pricingLabel.Name = "pricingLabel";
            this.pricingLabel.Size = new System.Drawing.Size(234, 469);
            this.pricingLabel.TabIndex = 3;
            this.pricingLabel.Text = " Burger @ $3.50 = \r\n\r\n Fries @ $1.50 =\r\n\r\nDrinks @ $1.00 = \r\n\r\n\r\n\r\nSub-Total = \r\n" +
    "\r\nTax @ 13% = \r\n\r\nTotal = \r\n\r\n\r\nTendered = \r\n\r\n\r\nChange = \r\n\r\n";
            // 
            // burgerBox
            // 
            this.burgerBox.BackColor = System.Drawing.Color.LightSalmon;
            this.burgerBox.Font = new System.Drawing.Font("Road Rage", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burgerBox.Location = new System.Drawing.Point(161, 63);
            this.burgerBox.Name = "burgerBox";
            this.burgerBox.Size = new System.Drawing.Size(86, 25);
            this.burgerBox.TabIndex = 4;
            // 
            // fryBox
            // 
            this.fryBox.BackColor = System.Drawing.Color.LightSalmon;
            this.fryBox.Font = new System.Drawing.Font("Road Rage", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fryBox.Location = new System.Drawing.Point(161, 100);
            this.fryBox.Name = "fryBox";
            this.fryBox.Size = new System.Drawing.Size(86, 25);
            this.fryBox.TabIndex = 5;
            // 
            // drinkBox
            // 
            this.drinkBox.BackColor = System.Drawing.Color.LightSalmon;
            this.drinkBox.Font = new System.Drawing.Font("Road Rage", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkBox.Location = new System.Drawing.Point(161, 142);
            this.drinkBox.Name = "drinkBox";
            this.drinkBox.Size = new System.Drawing.Size(86, 25);
            this.drinkBox.TabIndex = 6;
            // 
            // priceButton
            // 
            this.priceButton.BackColor = System.Drawing.Color.SandyBrown;
            this.priceButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.priceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.priceButton.Font = new System.Drawing.Font("Road Rage", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceButton.Location = new System.Drawing.Point(12, 173);
            this.priceButton.Name = "priceButton";
            this.priceButton.Size = new System.Drawing.Size(235, 33);
            this.priceButton.TabIndex = 7;
            this.priceButton.Text = "Calculate Price";
            this.priceButton.UseVisualStyleBackColor = false;
            this.priceButton.Click += new System.EventHandler(this.priceButton_Click);
            // 
            // subPLabel
            // 
            this.subPLabel.BackColor = System.Drawing.Color.Sienna;
            this.subPLabel.Font = new System.Drawing.Font("Road Rage", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subPLabel.Location = new System.Drawing.Point(151, 218);
            this.subPLabel.Name = "subPLabel";
            this.subPLabel.Size = new System.Drawing.Size(96, 23);
            this.subPLabel.TabIndex = 8;
            // 
            // taxLabel
            // 
            this.taxLabel.BackColor = System.Drawing.Color.Sienna;
            this.taxLabel.Font = new System.Drawing.Font("Road Rage", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.Location = new System.Drawing.Point(155, 263);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(92, 23);
            this.taxLabel.TabIndex = 9;
            // 
            // priceLabel
            // 
            this.priceLabel.BackColor = System.Drawing.Color.Sienna;
            this.priceLabel.Font = new System.Drawing.Font("Road Rage", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(151, 299);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(96, 23);
            this.priceLabel.TabIndex = 10;
            // 
            // payBox
            // 
            this.payBox.BackColor = System.Drawing.Color.LightSalmon;
            this.payBox.Font = new System.Drawing.Font("Road Rage", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payBox.Location = new System.Drawing.Point(161, 360);
            this.payBox.Name = "payBox";
            this.payBox.Size = new System.Drawing.Size(86, 25);
            this.payBox.TabIndex = 11;
            // 
            // changeLabel
            // 
            this.changeLabel.BackColor = System.Drawing.Color.Sienna;
            this.changeLabel.Font = new System.Drawing.Font("Road Rage", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.Location = new System.Drawing.Point(161, 423);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(86, 23);
            this.changeLabel.TabIndex = 12;
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.SandyBrown;
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeButton.Font = new System.Drawing.Font("Road Rage", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.Location = new System.Drawing.Point(12, 392);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(235, 28);
            this.changeButton.TabIndex = 13;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // reciptButton
            // 
            this.reciptButton.BackColor = System.Drawing.Color.SandyBrown;
            this.reciptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reciptButton.Font = new System.Drawing.Font("Road Rage", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reciptButton.Location = new System.Drawing.Point(12, 469);
            this.reciptButton.Name = "reciptButton";
            this.reciptButton.Size = new System.Drawing.Size(235, 45);
            this.reciptButton.TabIndex = 14;
            this.reciptButton.Text = "Print Recipt";
            this.reciptButton.UseVisualStyleBackColor = false;
            this.reciptButton.Click += new System.EventHandler(this.reciptButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SandyBrown;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Road Rage", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(277, 493);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(319, 40);
            this.button1.TabIndex = 15;
            this.button1.Text = "New Order";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(608, 541);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reciptButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.payBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subPLabel);
            this.Controls.Add(this.priceButton);
            this.Controls.Add(this.drinkBox);
            this.Controls.Add(this.fryBox);
            this.Controls.Add(this.burgerBox);
            this.Controls.Add(this.pricingLabel);
            this.Controls.Add(this.subTitleLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.colorLabel);
            this.Name = "Form1";
            this.Text = "Roadhouse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label subTitleLabel;
        private System.Windows.Forms.Label pricingLabel;
        private System.Windows.Forms.TextBox burgerBox;
        private System.Windows.Forms.TextBox fryBox;
        private System.Windows.Forms.TextBox drinkBox;
        private System.Windows.Forms.Button priceButton;
        private System.Windows.Forms.Label subPLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox payBox;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button reciptButton;
        private System.Windows.Forms.Button button1;
    }
}

