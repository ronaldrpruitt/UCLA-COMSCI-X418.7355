namespace GatesCandyStore_PruittRon
{
    partial class CandyForm
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
            this.candyComboBox = new System.Windows.Forms.ComboBox();
            this.candyFlavorResultLabel = new System.Windows.Forms.Label();
            this.candyReturnButton = new System.Windows.Forms.Button();
            this.candyClearButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.candyQuantityTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.candyPriceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pick the candy flavor you want to buy:";
            // 
            // candyComboBox
            // 
            this.candyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.candyComboBox.FormattingEnabled = true;
            this.candyComboBox.Location = new System.Drawing.Point(153, 138);
            this.candyComboBox.MinimumSize = new System.Drawing.Size(200, 0);
            this.candyComboBox.Name = "candyComboBox";
            this.candyComboBox.Size = new System.Drawing.Size(200, 28);
            this.candyComboBox.TabIndex = 1;
            this.candyComboBox.SelectionChangeCommitted += new System.EventHandler(this.lollipopComboBox_SelectedChangeCommitted);
            // 
            // candyFlavorResultLabel
            // 
            this.candyFlavorResultLabel.AutoSize = true;
            this.candyFlavorResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.candyFlavorResultLabel.Location = new System.Drawing.Point(153, 289);
            this.candyFlavorResultLabel.MinimumSize = new System.Drawing.Size(250, 0);
            this.candyFlavorResultLabel.Name = "candyFlavorResultLabel";
            this.candyFlavorResultLabel.Size = new System.Drawing.Size(250, 22);
            this.candyFlavorResultLabel.TabIndex = 2;
            // 
            // candyReturnButton
            // 
            this.candyReturnButton.Location = new System.Drawing.Point(327, 344);
            this.candyReturnButton.Name = "candyReturnButton";
            this.candyReturnButton.Size = new System.Drawing.Size(155, 37);
            this.candyReturnButton.TabIndex = 3;
            this.candyReturnButton.Text = "Return to Main";
            this.candyReturnButton.UseVisualStyleBackColor = true;
            this.candyReturnButton.Click += new System.EventHandler(this.lollipopReturnButton_Click);
            // 
            // candyClearButton
            // 
            this.candyClearButton.Location = new System.Drawing.Point(153, 344);
            this.candyClearButton.Name = "candyClearButton";
            this.candyClearButton.Size = new System.Drawing.Size(128, 36);
            this.candyClearButton.TabIndex = 4;
            this.candyClearButton.Text = "Clear Selection";
            this.candyClearButton.UseVisualStyleBackColor = true;
            this.candyClearButton.Click += new System.EventHandler(this.lollipopClearButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(279, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select A Quantity";
            // 
            // candyQuantityTextBox
            // 
            this.candyQuantityTextBox.Location = new System.Drawing.Point(283, 222);
            this.candyQuantityTextBox.Name = "candyQuantityTextBox";
            this.candyQuantityTextBox.Size = new System.Drawing.Size(100, 26);
            this.candyQuantityTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(153, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Price";
            // 
            // candyPriceLabel
            // 
            this.candyPriceLabel.AutoSize = true;
            this.candyPriceLabel.Location = new System.Drawing.Point(153, 225);
            this.candyPriceLabel.MinimumSize = new System.Drawing.Size(100, 0);
            this.candyPriceLabel.Name = "candyPriceLabel";
            this.candyPriceLabel.Size = new System.Drawing.Size(100, 20);
            this.candyPriceLabel.TabIndex = 8;
            // 
            // CandyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.candyPriceLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.candyQuantityTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.candyClearButton);
            this.Controls.Add(this.candyReturnButton);
            this.Controls.Add(this.candyFlavorResultLabel);
            this.Controls.Add(this.candyComboBox);
            this.Controls.Add(this.label1);
            this.Name = "CandyForm";
            this.Text = "Candy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox candyComboBox;
        private System.Windows.Forms.Label candyFlavorResultLabel;
        private System.Windows.Forms.Button candyReturnButton;
        private System.Windows.Forms.Button candyClearButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox candyQuantityTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label candyPriceLabel;
    }
}