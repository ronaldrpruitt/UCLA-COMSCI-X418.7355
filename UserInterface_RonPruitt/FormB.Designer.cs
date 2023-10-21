namespace UserInterface_RonPruitt
{
    partial class FormB
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
            this.TextAreaLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.messageBox1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messageBox2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RightClickLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextAreaLabel
            // 
            this.TextAreaLabel.AutoSize = true;
            this.TextAreaLabel.Location = new System.Drawing.Point(57, 70);
            this.TextAreaLabel.Name = "TextAreaLabel";
            this.TextAreaLabel.Size = new System.Drawing.Size(61, 13);
            this.TextAreaLabel.TabIndex = 0;
            this.TextAreaLabel.Text = "FormB Text";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(152, 121);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.formBExitBtn_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.messageBox1ToolStripMenuItem,
            this.messageBox2ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(152, 48);
            this.contextMenuStrip1.Text = "Right Click me!";
            // 
            // messageBox1ToolStripMenuItem
            // 
            this.messageBox1ToolStripMenuItem.Name = "messageBox1ToolStripMenuItem";
            this.messageBox1ToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.messageBox1ToolStripMenuItem.Text = "Message Box 1";
            this.messageBox1ToolStripMenuItem.Click += new System.EventHandler(this.messageBox1ToolStripMenuItem_Click);
            // 
            // messageBox2ToolStripMenuItem
            // 
            this.messageBox2ToolStripMenuItem.Name = "messageBox2ToolStripMenuItem";
            this.messageBox2ToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.messageBox2ToolStripMenuItem.Text = "Message Box 2";
            this.messageBox2ToolStripMenuItem.Click += new System.EventHandler(this.messageBox2ToolStripMenuItem_Click);
            // 
            // RightClickLabel
            // 
            this.RightClickLabel.AutoSize = true;
            this.RightClickLabel.ContextMenuStrip = this.contextMenuStrip1;
            this.RightClickLabel.Location = new System.Drawing.Point(60, 96);
            this.RightClickLabel.Name = "RightClickLabel";
            this.RightClickLabel.Size = new System.Drawing.Size(79, 13);
            this.RightClickLabel.TabIndex = 3;
            this.RightClickLabel.Text = "Right Click Me!";
            // 
            // FormB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 266);
            this.Controls.Add(this.RightClickLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.TextAreaLabel);
            this.Name = "FormB";
            this.Text = "FormB";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TextAreaLabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem messageBox1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem messageBox2ToolStripMenuItem;
        private System.Windows.Forms.Label RightClickLabel;
    }
}