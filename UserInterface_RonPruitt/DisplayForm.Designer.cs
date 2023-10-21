namespace UserInterface_RonPruitt
{
    partial class DisplayForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openAFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openBFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.callAMessageBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messageBox1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messageBox2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openAFormToolStripMenuItem,
            this.processToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(387, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openAFormToolStripMenuItem
            // 
            this.openAFormToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.openAFormToolStripMenuItem.Name = "openAFormToolStripMenuItem";
            this.openAFormToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.openAFormToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // processToolStripMenuItem
            // 
            this.processToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openBFormToolStripMenuItem,
            this.callAMessageBoxToolStripMenuItem});
            this.processToolStripMenuItem.Name = "processToolStripMenuItem";
            this.processToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.processToolStripMenuItem.Text = "Process";
            // 
            // openBFormToolStripMenuItem
            // 
            this.openBFormToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formAToolStripMenuItem,
            this.formBToolStripMenuItem});
            this.openBFormToolStripMenuItem.Name = "openBFormToolStripMenuItem";
            this.openBFormToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openBFormToolStripMenuItem.Text = "Open a form";
            // 
            // formAToolStripMenuItem
            // 
            this.formAToolStripMenuItem.Name = "formAToolStripMenuItem";
            this.formAToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.formAToolStripMenuItem.Text = "Form A";
            this.formAToolStripMenuItem.Click += new System.EventHandler(this.formAToolStripMenuItem_Click);
            // 
            // formBToolStripMenuItem
            // 
            this.formBToolStripMenuItem.Name = "formBToolStripMenuItem";
            this.formBToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.formBToolStripMenuItem.Text = "Form B";
            this.formBToolStripMenuItem.Click += new System.EventHandler(this.formBToolStripMenuItem_Click);
            // 
            // callAMessageBoxToolStripMenuItem
            // 
            this.callAMessageBoxToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.messageBox1ToolStripMenuItem,
            this.messageBox2ToolStripMenuItem});
            this.callAMessageBoxToolStripMenuItem.Name = "callAMessageBoxToolStripMenuItem";
            this.callAMessageBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.callAMessageBoxToolStripMenuItem.Text = "Call a message Box";
            // 
            // messageBox1ToolStripMenuItem
            // 
            this.messageBox1ToolStripMenuItem.Name = "messageBox1ToolStripMenuItem";
            this.messageBox1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.messageBox1ToolStripMenuItem.Text = "Message Box 1";
            this.messageBox1ToolStripMenuItem.Click += new System.EventHandler(this.messageBox1ToolStripMenuItem_Click);
            // 
            // messageBox2ToolStripMenuItem
            // 
            this.messageBox2ToolStripMenuItem.Name = "messageBox2ToolStripMenuItem";
            this.messageBox2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.messageBox2ToolStripMenuItem.Text = "Message Box 2";
            this.messageBox2ToolStripMenuItem.Click += new System.EventHandler(this.messageBox2ToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // DisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 266);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DisplayForm";
            this.Text = "DisplayForm";
            this.Load += new System.EventHandler(this.DisplayForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openAFormToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem processToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openBFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem callAMessageBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem messageBox1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem messageBox2ToolStripMenuItem;
    }
}