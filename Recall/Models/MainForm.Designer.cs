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
            btnEnable = new Button();
            btnDisable = new Button();
            SuspendLayout();
            // 
            // btnEnable
            // 
            btnEnable.Location = new Point(12, 12);
            btnEnable.Name = "btnEnable";
            btnEnable.Size = new Size(218, 62);
            btnEnable.TabIndex = 0;
            btnEnable.Text = "Enable";
            btnEnable.UseVisualStyleBackColor = true;
            btnEnable.Click += btnEnable_Click;
            // 
            // btnDisable
            // 
            btnDisable.Location = new Point(12, 81);
            btnDisable.Name = "btnDisable";
            btnDisable.Size = new Size(218, 62);
            btnDisable.TabIndex = 1;
            btnDisable.Text = "Disable";
            btnDisable.UseVisualStyleBackColor = true;
            btnDisable.Click += btnDisable_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(242, 155);
            Controls.Add(btnDisable);
            Controls.Add(btnEnable);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recall";
            ResumeLayout(false);
        }

        #endregion

        private Button btnEnable;
        private Button btnDisable;
    }
}