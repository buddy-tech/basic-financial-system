namespace Basic_Financial_System
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.leftPanel = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.processesIndexButton = new System.Windows.Forms.Button();
            this.billsIndexButton = new System.Windows.Forms.Button();
            this.registerIndexButton = new System.Windows.Forms.Button();
            this.leftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.leftPanel.Controls.Add(this.registerIndexButton);
            this.leftPanel.Controls.Add(this.billsIndexButton);
            this.leftPanel.Controls.Add(this.processesIndexButton);
            this.leftPanel.Controls.Add(this.exitButton);
            this.leftPanel.Location = new System.Drawing.Point(0, -1);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(52, 478);
            this.leftPanel.TabIndex = 0;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.ForeColor = System.Drawing.Color.Transparent;
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.Location = new System.Drawing.Point(0, 169);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(52, 32);
            this.exitButton.TabIndex = 1;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // processesIndexButton
            // 
            this.processesIndexButton.BackColor = System.Drawing.Color.Transparent;
            this.processesIndexButton.FlatAppearance.BorderSize = 0;
            this.processesIndexButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.processesIndexButton.ForeColor = System.Drawing.Color.Transparent;
            this.processesIndexButton.Image = ((System.Drawing.Image)(resources.GetObject("processesIndexButton.Image")));
            this.processesIndexButton.Location = new System.Drawing.Point(0, 117);
            this.processesIndexButton.Name = "processesIndexButton";
            this.processesIndexButton.Size = new System.Drawing.Size(51, 32);
            this.processesIndexButton.TabIndex = 2;
            this.processesIndexButton.UseVisualStyleBackColor = false;
            // 
            // billsIndexButton
            // 
            this.billsIndexButton.BackColor = System.Drawing.Color.Transparent;
            this.billsIndexButton.FlatAppearance.BorderSize = 0;
            this.billsIndexButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.billsIndexButton.ForeColor = System.Drawing.Color.Transparent;
            this.billsIndexButton.Image = ((System.Drawing.Image)(resources.GetObject("billsIndexButton.Image")));
            this.billsIndexButton.Location = new System.Drawing.Point(0, 64);
            this.billsIndexButton.Name = "billsIndexButton";
            this.billsIndexButton.Size = new System.Drawing.Size(51, 32);
            this.billsIndexButton.TabIndex = 3;
            this.billsIndexButton.UseVisualStyleBackColor = false;
            // 
            // registerIndexButton
            // 
            this.registerIndexButton.BackColor = System.Drawing.Color.Transparent;
            this.registerIndexButton.FlatAppearance.BorderSize = 0;
            this.registerIndexButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerIndexButton.ForeColor = System.Drawing.Color.Transparent;
            this.registerIndexButton.Image = ((System.Drawing.Image)(resources.GetObject("registerIndexButton.Image")));
            this.registerIndexButton.Location = new System.Drawing.Point(0, 14);
            this.registerIndexButton.Name = "registerIndexButton";
            this.registerIndexButton.Size = new System.Drawing.Size(51, 32);
            this.registerIndexButton.TabIndex = 4;
            this.registerIndexButton.UseVisualStyleBackColor = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 477);
            this.Controls.Add(this.leftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.leftPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button billsIndexButton;
        private System.Windows.Forms.Button processesIndexButton;
        private System.Windows.Forms.Button registerIndexButton;
    }
}