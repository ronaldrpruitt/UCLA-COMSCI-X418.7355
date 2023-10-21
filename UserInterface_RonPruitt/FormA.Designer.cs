namespace UserInterface_RonPruitt
{
    partial class FormA
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
            this.TextAreaLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextAreaLabel
            // 
            this.TextAreaLabel.AutoSize = true;
            this.TextAreaLabel.Location = new System.Drawing.Point(57, 70);
            this.TextAreaLabel.Name = "TextAreaLabel";
            this.TextAreaLabel.Size = new System.Drawing.Size(67, 13);
            this.TextAreaLabel.TabIndex = 0;
            this.TextAreaLabel.Text = "Form A Text ";
            this.TextAreaLabel.Click += new System.EventHandler(this.formALbl_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(152, 121);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.formAExitBtn_Click);
            // 
            // FormA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 266);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.TextAreaLabel);
            this.Name = "FormA";
            this.Text = "FormA";
            this.Load += new System.EventHandler(this.FormA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TextAreaLabel;
        private System.Windows.Forms.Button ExitButton;
    }
}

