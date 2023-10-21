namespace week7_rpruitt
{
    partial class SignInBase
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
            this.SubmitButton = new System.Windows.Forms.Button();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ApartmentTextBox = new System.Windows.Forms.TextBox();
            this.TitleHeadingLabel = new System.Windows.Forms.Label();
            this.AlertLabel = new System.Windows.Forms.Label();
            this.AlertBaselabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(227, 281);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(308, 98);
            this.SubmitButton.TabIndex = 0;
            this.SubmitButton.Text = "button1";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(145, 119);
            this.FirstNameTextBox.MaximumSize = new System.Drawing.Size(175, 35);
            this.FirstNameTextBox.MinimumSize = new System.Drawing.Size(175, 35);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(175, 26);
            this.FirstNameTextBox.TabIndex = 1;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(349, 119);
            this.LastNameTextBox.MaximumSize = new System.Drawing.Size(175, 35);
            this.LastNameTextBox.MinimumSize = new System.Drawing.Size(175, 35);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(175, 26);
            this.LastNameTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(560, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apartment #";
            // 
            // ApartmentTextBox
            // 
            this.ApartmentTextBox.Location = new System.Drawing.Point(557, 119);
            this.ApartmentTextBox.MaximumSize = new System.Drawing.Size(100, 25);
            this.ApartmentTextBox.MinimumSize = new System.Drawing.Size(100, 35);
            this.ApartmentTextBox.Name = "ApartmentTextBox";
            this.ApartmentTextBox.Size = new System.Drawing.Size(100, 26);
            this.ApartmentTextBox.TabIndex = 6;
            // 
            // TitleHeadingLabel
            // 
            this.TitleHeadingLabel.AutoSize = true;
            this.TitleHeadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleHeadingLabel.Location = new System.Drawing.Point(217, 9);
            this.TitleHeadingLabel.Name = "TitleHeadingLabel";
            this.TitleHeadingLabel.Size = new System.Drawing.Size(346, 58);
            this.TitleHeadingLabel.TabIndex = 7;
            this.TitleHeadingLabel.Text = "Please Sign In";
            // 
            // AlertLabel
            // 
            this.AlertLabel.AutoSize = true;
            this.AlertLabel.Location = new System.Drawing.Point(227, 211);
            this.AlertLabel.Name = "AlertLabel";
            this.AlertLabel.Size = new System.Drawing.Size(0, 20);
            this.AlertLabel.TabIndex = 8;
            // 
            // AlertBaselabel
            // 
            this.AlertBaselabel.AutoSize = true;
            this.AlertBaselabel.BackColor = System.Drawing.SystemColors.Control;
            this.AlertBaselabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.AlertBaselabel.Location = new System.Drawing.Point(227, 211);
            this.AlertBaselabel.Name = "AlertBaselabel";
            this.AlertBaselabel.Size = new System.Drawing.Size(0, 29);
            this.AlertBaselabel.TabIndex = 9;
            // 
            // SignInBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AlertBaselabel);
            this.Controls.Add(this.AlertLabel);
            this.Controls.Add(this.TitleHeadingLabel);
            this.Controls.Add(this.ApartmentTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.SubmitButton);
            this.Name = "SignInBase";
            this.Text = "SignInBase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Label TitleHeadingLabel;
        protected System.Windows.Forms.Label AlertLabel;
        protected System.Windows.Forms.TextBox FirstNameTextBox;
        protected System.Windows.Forms.TextBox LastNameTextBox;
        protected System.Windows.Forms.TextBox ApartmentTextBox;
        protected System.Windows.Forms.Label AlertBaselabel;
    }
}