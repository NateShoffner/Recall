namespace Recall
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btnToggle = new Button();
            notifyIcon1 = new NotifyIcon(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            toggleMenuItem = new ToolStripMenuItem();
            lblIcon = new LinkLabel();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnToggle
            // 
            btnToggle.Location = new Point(12, 12);
            btnToggle.Name = "btnToggle";
            btnToggle.Size = new Size(218, 62);
            btnToggle.TabIndex = 0;
            btnToggle.Text = "Enable";
            btnToggle.UseVisualStyleBackColor = true;
            btnToggle.Click += ToggleService;
            // 
            // notifyIcon1
            // 
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "Recall";
            notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toggleMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(110, 26);
            // 
            // toggleMenuItem
            // 
            toggleMenuItem.Name = "toggleMenuItem";
            toggleMenuItem.Size = new Size(109, 22);
            toggleMenuItem.Text = "Enable";
            toggleMenuItem.Click += ToggleService;
            // 
            // lblIcon
            // 
            lblIcon.AutoSize = true;
            lblIcon.Location = new Point(61, 111);
            lblIcon.Name = "lblIcon";
            lblIcon.Size = new Size(138, 15);
            lblIcon.TabIndex = 1;
            lblIcon.TabStop = true;
            lblIcon.Text = "Icons provided by Icons8";
            lblIcon.LinkClicked += lblIcon_LinkClicked;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(242, 155);
            Controls.Add(lblIcon);
            Controls.Add(btnToggle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recall";
            Load += MainForm_Load;
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnToggle;
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toggleMenuItem;
        private LinkLabel lblIcon;
    }
}