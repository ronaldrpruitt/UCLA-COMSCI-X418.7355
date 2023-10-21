namespace GatesCandyStore_PruittRon
{
    partial class MainCandyStore
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.candyComboBox = new System.Windows.Forms.ComboBox();
            this.candyTypeLabel = new System.Windows.Forms.Label();
            this.selectedTypeLabel = new System.Windows.Forms.Label();
            this.processSelectionButton = new System.Windows.Forms.Button();
            this.chocolateSelectionLabel = new System.Windows.Forms.Label();
            this.gumSelectionLabel = new System.Windows.Forms.Label();
            this.lollipopSelectionLabel = new System.Windows.Forms.Label();
            this.nameInputTextbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mainChocolateSelectionResultLabel = new System.Windows.Forms.Label();
            this.selectedCandyResultLabel = new System.Windows.Forms.Label();
            this.mainGumSelectionResultLabel = new System.Windows.Forms.Label();
            this.mainLollipopSelectionResultLabel = new System.Windows.Forms.Label();
            this.SelectionPricelabel = new System.Windows.Forms.Label();
            this.quantityPriceLabel = new System.Windows.Forms.Label();
            this.candySelectionType = new System.Windows.Forms.Label();
            this.candySelectionFlavor = new System.Windows.Forms.Label();
            this.mainChocolateSelectionQuantityResultLabel = new System.Windows.Forms.Label();
            this.mainGumSelectionQuantityResultLabel = new System.Windows.Forms.Label();
            this.mainLollipopSelectionQuantityResultLabel = new System.Windows.Forms.Label();
            this.mainChocolateSelectionPriceResultLabel = new System.Windows.Forms.Label();
            this.mainGumSelectionPriceResultLabel = new System.Windows.Forms.Label();
            this.mainLollipopSelectionPriceResultLabel = new System.Windows.Forms.Label();
            this.mainChocolateTotalLabel = new System.Windows.Forms.Label();
            this.mainGumTotalLabel = new System.Windows.Forms.Label();
            this.mainlollipopTotalLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainOrderTotalLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(74, 80);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(194, 29);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Enter your name:";
            // 
            // candyComboBox
            // 
            this.candyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.candyComboBox.FormattingEnabled = true;
            this.candyComboBox.Location = new System.Drawing.Point(302, 141);
            this.candyComboBox.MinimumSize = new System.Drawing.Size(200, 0);
            this.candyComboBox.Name = "candyComboBox";
            this.candyComboBox.Size = new System.Drawing.Size(200, 28);
            this.candyComboBox.TabIndex = 2;
            this.candyComboBox.SelectedIndexChanged += new System.EventHandler(this.candyComboBox_SelectedIndexChanged);
            // 
            // candyTypeLabel
            // 
            this.candyTypeLabel.AutoSize = true;
            this.candyTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.candyTypeLabel.Location = new System.Drawing.Point(74, 141);
            this.candyTypeLabel.Name = "candyTypeLabel";
            this.candyTypeLabel.Size = new System.Drawing.Size(207, 29);
            this.candyTypeLabel.TabIndex = 3;
            this.candyTypeLabel.Text = "Select candy type:";
            // 
            // selectedTypeLabel
            // 
            this.selectedTypeLabel.AutoSize = true;
            this.selectedTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedTypeLabel.Location = new System.Drawing.Point(74, 205);
            this.selectedTypeLabel.Name = "selectedTypeLabel";
            this.selectedTypeLabel.Size = new System.Drawing.Size(259, 29);
            this.selectedTypeLabel.TabIndex = 4;
            this.selectedTypeLabel.Text = "Selected candy type is:";
            // 
            // processSelectionButton
            // 
            this.processSelectionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processSelectionButton.Location = new System.Drawing.Point(79, 277);
            this.processSelectionButton.Name = "processSelectionButton";
            this.processSelectionButton.Size = new System.Drawing.Size(299, 49);
            this.processSelectionButton.TabIndex = 6;
            this.processSelectionButton.Text = "Process Candy Selection";
            this.processSelectionButton.UseVisualStyleBackColor = true;
            this.processSelectionButton.Click += new System.EventHandler(this.processSelectionButton_Click);
            // 
            // chocolateSelectionLabel
            // 
            this.chocolateSelectionLabel.AutoSize = true;
            this.chocolateSelectionLabel.Location = new System.Drawing.Point(359, 464);
            this.chocolateSelectionLabel.Name = "chocolateSelectionLabel";
            this.chocolateSelectionLabel.Size = new System.Drawing.Size(81, 20);
            this.chocolateSelectionLabel.TabIndex = 7;
            this.chocolateSelectionLabel.Text = "Chocolate";
            // 
            // gumSelectionLabel
            // 
            this.gumSelectionLabel.AutoSize = true;
            this.gumSelectionLabel.Location = new System.Drawing.Point(359, 525);
            this.gumSelectionLabel.Name = "gumSelectionLabel";
            this.gumSelectionLabel.Size = new System.Drawing.Size(44, 20);
            this.gumSelectionLabel.TabIndex = 8;
            this.gumSelectionLabel.Text = "Gum";
            // 
            // lollipopSelectionLabel
            // 
            this.lollipopSelectionLabel.AutoSize = true;
            this.lollipopSelectionLabel.Location = new System.Drawing.Point(359, 584);
            this.lollipopSelectionLabel.Name = "lollipopSelectionLabel";
            this.lollipopSelectionLabel.Size = new System.Drawing.Size(63, 20);
            this.lollipopSelectionLabel.TabIndex = 9;
            this.lollipopSelectionLabel.Text = "Lollipop";
            // 
            // nameInputTextbox
            // 
            this.nameInputTextbox.Location = new System.Drawing.Point(302, 80);
            this.nameInputTextbox.Name = "nameInputTextbox";
            this.nameInputTextbox.Size = new System.Drawing.Size(230, 26);
            this.nameInputTextbox.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(74, 402);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "Your selections:";
            // 
            // mainChocolateSelectionResultLabel
            // 
            this.mainChocolateSelectionResultLabel.AutoSize = true;
            this.mainChocolateSelectionResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainChocolateSelectionResultLabel.Location = new System.Drawing.Point(492, 464);
            this.mainChocolateSelectionResultLabel.MinimumSize = new System.Drawing.Size(100, 0);
            this.mainChocolateSelectionResultLabel.Name = "mainChocolateSelectionResultLabel";
            this.mainChocolateSelectionResultLabel.Size = new System.Drawing.Size(100, 22);
            this.mainChocolateSelectionResultLabel.TabIndex = 14;
            // 
            // selectedCandyResultLabel
            // 
            this.selectedCandyResultLabel.AutoSize = true;
            this.selectedCandyResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.selectedCandyResultLabel.Location = new System.Drawing.Point(353, 205);
            this.selectedCandyResultLabel.MinimumSize = new System.Drawing.Size(300, 0);
            this.selectedCandyResultLabel.Name = "selectedCandyResultLabel";
            this.selectedCandyResultLabel.Size = new System.Drawing.Size(300, 22);
            this.selectedCandyResultLabel.TabIndex = 15;
            // 
            // mainGumSelectionResultLabel
            // 
            this.mainGumSelectionResultLabel.AutoSize = true;
            this.mainGumSelectionResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainGumSelectionResultLabel.Location = new System.Drawing.Point(492, 525);
            this.mainGumSelectionResultLabel.MinimumSize = new System.Drawing.Size(100, 0);
            this.mainGumSelectionResultLabel.Name = "mainGumSelectionResultLabel";
            this.mainGumSelectionResultLabel.Size = new System.Drawing.Size(100, 22);
            this.mainGumSelectionResultLabel.TabIndex = 16;
            // 
            // mainLollipopSelectionResultLabel
            // 
            this.mainLollipopSelectionResultLabel.AutoSize = true;
            this.mainLollipopSelectionResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainLollipopSelectionResultLabel.Location = new System.Drawing.Point(492, 582);
            this.mainLollipopSelectionResultLabel.MinimumSize = new System.Drawing.Size(100, 0);
            this.mainLollipopSelectionResultLabel.Name = "mainLollipopSelectionResultLabel";
            this.mainLollipopSelectionResultLabel.Size = new System.Drawing.Size(100, 22);
            this.mainLollipopSelectionResultLabel.TabIndex = 17;
            // 
            // SelectionPricelabel
            // 
            this.SelectionPricelabel.AutoSize = true;
            this.SelectionPricelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectionPricelabel.Location = new System.Drawing.Point(740, 409);
            this.SelectionPricelabel.Name = "SelectionPricelabel";
            this.SelectionPricelabel.Size = new System.Drawing.Size(49, 20);
            this.SelectionPricelabel.TabIndex = 18;
            this.SelectionPricelabel.Text = "Price";
            // 
            // quantityPriceLabel
            // 
            this.quantityPriceLabel.AutoSize = true;
            this.quantityPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityPriceLabel.Location = new System.Drawing.Point(628, 409);
            this.quantityPriceLabel.Name = "quantityPriceLabel";
            this.quantityPriceLabel.Size = new System.Drawing.Size(76, 20);
            this.quantityPriceLabel.TabIndex = 19;
            this.quantityPriceLabel.Text = "Quantity";
            // 
            // candySelectionType
            // 
            this.candySelectionType.AutoSize = true;
            this.candySelectionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.candySelectionType.Location = new System.Drawing.Point(359, 411);
            this.candySelectionType.Name = "candySelectionType";
            this.candySelectionType.Size = new System.Drawing.Size(102, 20);
            this.candySelectionType.TabIndex = 20;
            this.candySelectionType.Text = "Candy Type";
            // 
            // candySelectionFlavor
            // 
            this.candySelectionFlavor.AutoSize = true;
            this.candySelectionFlavor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.candySelectionFlavor.Location = new System.Drawing.Point(488, 411);
            this.candySelectionFlavor.Name = "candySelectionFlavor";
            this.candySelectionFlavor.Size = new System.Drawing.Size(58, 20);
            this.candySelectionFlavor.TabIndex = 21;
            this.candySelectionFlavor.Text = "Flavor";
            // 
            // mainChocolateSelectionQuantityResultLabel
            // 
            this.mainChocolateSelectionQuantityResultLabel.AutoSize = true;
            this.mainChocolateSelectionQuantityResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainChocolateSelectionQuantityResultLabel.Location = new System.Drawing.Point(632, 464);
            this.mainChocolateSelectionQuantityResultLabel.MinimumSize = new System.Drawing.Size(50, 0);
            this.mainChocolateSelectionQuantityResultLabel.Name = "mainChocolateSelectionQuantityResultLabel";
            this.mainChocolateSelectionQuantityResultLabel.Size = new System.Drawing.Size(50, 22);
            this.mainChocolateSelectionQuantityResultLabel.TabIndex = 22;
            // 
            // mainGumSelectionQuantityResultLabel
            // 
            this.mainGumSelectionQuantityResultLabel.AutoSize = true;
            this.mainGumSelectionQuantityResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainGumSelectionQuantityResultLabel.Location = new System.Drawing.Point(632, 525);
            this.mainGumSelectionQuantityResultLabel.MinimumSize = new System.Drawing.Size(50, 0);
            this.mainGumSelectionQuantityResultLabel.Name = "mainGumSelectionQuantityResultLabel";
            this.mainGumSelectionQuantityResultLabel.Size = new System.Drawing.Size(50, 22);
            this.mainGumSelectionQuantityResultLabel.TabIndex = 23;
            // 
            // mainLollipopSelectionQuantityResultLabel
            // 
            this.mainLollipopSelectionQuantityResultLabel.AutoSize = true;
            this.mainLollipopSelectionQuantityResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainLollipopSelectionQuantityResultLabel.Location = new System.Drawing.Point(632, 584);
            this.mainLollipopSelectionQuantityResultLabel.MinimumSize = new System.Drawing.Size(50, 0);
            this.mainLollipopSelectionQuantityResultLabel.Name = "mainLollipopSelectionQuantityResultLabel";
            this.mainLollipopSelectionQuantityResultLabel.Size = new System.Drawing.Size(50, 22);
            this.mainLollipopSelectionQuantityResultLabel.TabIndex = 24;
            // 
            // mainChocolateSelectionPriceResultLabel
            // 
            this.mainChocolateSelectionPriceResultLabel.AutoSize = true;
            this.mainChocolateSelectionPriceResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainChocolateSelectionPriceResultLabel.Location = new System.Drawing.Point(744, 464);
            this.mainChocolateSelectionPriceResultLabel.MinimumSize = new System.Drawing.Size(75, 0);
            this.mainChocolateSelectionPriceResultLabel.Name = "mainChocolateSelectionPriceResultLabel";
            this.mainChocolateSelectionPriceResultLabel.Size = new System.Drawing.Size(75, 22);
            this.mainChocolateSelectionPriceResultLabel.TabIndex = 25;
            // 
            // mainGumSelectionPriceResultLabel
            // 
            this.mainGumSelectionPriceResultLabel.AutoSize = true;
            this.mainGumSelectionPriceResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainGumSelectionPriceResultLabel.Location = new System.Drawing.Point(744, 525);
            this.mainGumSelectionPriceResultLabel.MinimumSize = new System.Drawing.Size(75, 0);
            this.mainGumSelectionPriceResultLabel.Name = "mainGumSelectionPriceResultLabel";
            this.mainGumSelectionPriceResultLabel.Size = new System.Drawing.Size(75, 22);
            this.mainGumSelectionPriceResultLabel.TabIndex = 26;
            // 
            // mainLollipopSelectionPriceResultLabel
            // 
            this.mainLollipopSelectionPriceResultLabel.AutoSize = true;
            this.mainLollipopSelectionPriceResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainLollipopSelectionPriceResultLabel.Location = new System.Drawing.Point(744, 582);
            this.mainLollipopSelectionPriceResultLabel.MinimumSize = new System.Drawing.Size(75, 0);
            this.mainLollipopSelectionPriceResultLabel.Name = "mainLollipopSelectionPriceResultLabel";
            this.mainLollipopSelectionPriceResultLabel.Size = new System.Drawing.Size(75, 22);
            this.mainLollipopSelectionPriceResultLabel.TabIndex = 27;
            // 
            // mainChocolateTotalLabel
            // 
            this.mainChocolateTotalLabel.AutoSize = true;
            this.mainChocolateTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainChocolateTotalLabel.Location = new System.Drawing.Point(867, 466);
            this.mainChocolateTotalLabel.MinimumSize = new System.Drawing.Size(75, 0);
            this.mainChocolateTotalLabel.Name = "mainChocolateTotalLabel";
            this.mainChocolateTotalLabel.Size = new System.Drawing.Size(75, 22);
            this.mainChocolateTotalLabel.TabIndex = 28;
            // 
            // mainGumTotalLabel
            // 
            this.mainGumTotalLabel.AutoSize = true;
            this.mainGumTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainGumTotalLabel.Location = new System.Drawing.Point(867, 525);
            this.mainGumTotalLabel.MinimumSize = new System.Drawing.Size(75, 0);
            this.mainGumTotalLabel.Name = "mainGumTotalLabel";
            this.mainGumTotalLabel.Size = new System.Drawing.Size(75, 22);
            this.mainGumTotalLabel.TabIndex = 29;
            // 
            // mainlollipopTotalLabel
            // 
            this.mainlollipopTotalLabel.AutoSize = true;
            this.mainlollipopTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainlollipopTotalLabel.Location = new System.Drawing.Point(867, 582);
            this.mainlollipopTotalLabel.MinimumSize = new System.Drawing.Size(75, 0);
            this.mainlollipopTotalLabel.Name = "mainlollipopTotalLabel";
            this.mainlollipopTotalLabel.Size = new System.Drawing.Size(75, 22);
            this.mainlollipopTotalLabel.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(871, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Total";
            // 
            // mainOrderTotalLabel
            // 
            this.mainOrderTotalLabel.AutoSize = true;
            this.mainOrderTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainOrderTotalLabel.Location = new System.Drawing.Point(867, 644);
            this.mainOrderTotalLabel.MinimumSize = new System.Drawing.Size(75, 0);
            this.mainOrderTotalLabel.Name = "mainOrderTotalLabel";
            this.mainOrderTotalLabel.Size = new System.Drawing.Size(75, 22);
            this.mainOrderTotalLabel.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(740, 644);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Order Total";
            // 
            // MainCandyStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 830);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mainOrderTotalLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainlollipopTotalLabel);
            this.Controls.Add(this.mainGumTotalLabel);
            this.Controls.Add(this.mainChocolateTotalLabel);
            this.Controls.Add(this.mainLollipopSelectionPriceResultLabel);
            this.Controls.Add(this.mainGumSelectionPriceResultLabel);
            this.Controls.Add(this.mainChocolateSelectionPriceResultLabel);
            this.Controls.Add(this.mainLollipopSelectionQuantityResultLabel);
            this.Controls.Add(this.mainGumSelectionQuantityResultLabel);
            this.Controls.Add(this.mainChocolateSelectionQuantityResultLabel);
            this.Controls.Add(this.candySelectionFlavor);
            this.Controls.Add(this.candySelectionType);
            this.Controls.Add(this.quantityPriceLabel);
            this.Controls.Add(this.SelectionPricelabel);
            this.Controls.Add(this.mainLollipopSelectionResultLabel);
            this.Controls.Add(this.mainGumSelectionResultLabel);
            this.Controls.Add(this.selectedCandyResultLabel);
            this.Controls.Add(this.mainChocolateSelectionResultLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nameInputTextbox);
            this.Controls.Add(this.lollipopSelectionLabel);
            this.Controls.Add(this.gumSelectionLabel);
            this.Controls.Add(this.chocolateSelectionLabel);
            this.Controls.Add(this.processSelectionButton);
            this.Controls.Add(this.selectedTypeLabel);
            this.Controls.Add(this.candyTypeLabel);
            this.Controls.Add(this.candyComboBox);
            this.Controls.Add(this.nameLabel);
            this.Name = "MainCandyStore";
            this.Text = "Welcome To Gate\'s Candy Store";
            this.Load += new System.EventHandler(this.MainCandyStore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ComboBox candyComboBox;
        private System.Windows.Forms.Label candyTypeLabel;
        private System.Windows.Forms.Label selectedTypeLabel;
        private System.Windows.Forms.Button processSelectionButton;
        private System.Windows.Forms.Label chocolateSelectionLabel;
        private System.Windows.Forms.Label gumSelectionLabel;
        private System.Windows.Forms.Label lollipopSelectionLabel;
        private System.Windows.Forms.TextBox nameInputTextbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label mainChocolateSelectionResultLabel;
        private System.Windows.Forms.Label selectedCandyResultLabel;
        private System.Windows.Forms.Label mainGumSelectionResultLabel;
        private System.Windows.Forms.Label mainLollipopSelectionResultLabel;
        private System.Windows.Forms.Label SelectionPricelabel;
        private System.Windows.Forms.Label quantityPriceLabel;
        private System.Windows.Forms.Label candySelectionType;
        private System.Windows.Forms.Label candySelectionFlavor;
        private System.Windows.Forms.Label mainChocolateSelectionQuantityResultLabel;
        private System.Windows.Forms.Label mainGumSelectionQuantityResultLabel;
        private System.Windows.Forms.Label mainLollipopSelectionQuantityResultLabel;
        private System.Windows.Forms.Label mainChocolateSelectionPriceResultLabel;
        private System.Windows.Forms.Label mainGumSelectionPriceResultLabel;
        private System.Windows.Forms.Label mainLollipopSelectionPriceResultLabel;
        private System.Windows.Forms.Label mainChocolateTotalLabel;
        private System.Windows.Forms.Label mainGumTotalLabel;
        private System.Windows.Forms.Label mainlollipopTotalLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label mainOrderTotalLabel;
        private System.Windows.Forms.Label label2;
    }
}

