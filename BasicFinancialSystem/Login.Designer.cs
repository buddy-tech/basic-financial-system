namespace BasicFinancialSystem
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.loginUsernameLabel = new System.Windows.Forms.Label();
            this.loginUsernameText = new System.Windows.Forms.TextBox();
            this.loginPasswordLabel = new System.Windows.Forms.Label();
            this.loginPasswordText = new System.Windows.Forms.TextBox();
            this.loginSignInButton = new System.Windows.Forms.Button();
            this.loginExitButton = new System.Windows.Forms.Button();
            this.loginLinkLabel = new System.Windows.Forms.LinkLabel();
            this.loginInFormTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginUsernameLabel
            // 
            resources.ApplyResources(this.loginUsernameLabel, "loginUsernameLabel");
            this.loginUsernameLabel.Name = "loginUsernameLabel";
            // 
            // loginUsernameText
            // 
            resources.ApplyResources(this.loginUsernameText, "loginUsernameText");
            this.loginUsernameText.Name = "loginUsernameText";
            // 
            // loginPasswordLabel
            // 
            resources.ApplyResources(this.loginPasswordLabel, "loginPasswordLabel");
            this.loginPasswordLabel.Name = "loginPasswordLabel";
            // 
            // loginPasswordText
            // 
            resources.ApplyResources(this.loginPasswordText, "loginPasswordText");
            this.loginPasswordText.Name = "loginPasswordText";
            this.loginPasswordText.UseSystemPasswordChar = true;
            // 
            // loginSignInButton
            // 
            resources.ApplyResources(this.loginSignInButton, "loginSignInButton");
            this.loginSignInButton.Name = "loginSignInButton";
            this.loginSignInButton.UseVisualStyleBackColor = true;
            this.loginSignInButton.Click += new System.EventHandler(this.loginSignInButton_Click);
            // 
            // loginExitButton
            // 
            resources.ApplyResources(this.loginExitButton, "loginExitButton");
            this.loginExitButton.Name = "loginExitButton";
            this.loginExitButton.UseVisualStyleBackColor = true;
            this.loginExitButton.Click += new System.EventHandler(this.loginExitButton_Click);
            // 
            // loginLinkLabel
            // 
            resources.ApplyResources(this.loginLinkLabel, "loginLinkLabel");
            this.loginLinkLabel.Name = "loginLinkLabel";
            this.loginLinkLabel.TabStop = true;
            // 
            // loginInFormTitle
            // 
            resources.ApplyResources(this.loginInFormTitle, "loginInFormTitle");
            this.loginInFormTitle.Name = "loginInFormTitle";
            // 
            // LoginForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.loginInFormTitle);
            this.Controls.Add(this.loginLinkLabel);
            this.Controls.Add(this.loginExitButton);
            this.Controls.Add(this.loginSignInButton);
            this.Controls.Add(this.loginPasswordText);
            this.Controls.Add(this.loginPasswordLabel);
            this.Controls.Add(this.loginUsernameText);
            this.Controls.Add(this.loginUsernameLabel);
            this.Name = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginUsernameLabel;
        private System.Windows.Forms.TextBox loginUsernameText;
        private System.Windows.Forms.Label loginPasswordLabel;
        private System.Windows.Forms.TextBox loginPasswordText;
        private System.Windows.Forms.Button loginSignInButton;
        private System.Windows.Forms.Button loginExitButton;
        private System.Windows.Forms.LinkLabel loginLinkLabel;
        private System.Windows.Forms.Label loginInFormTitle;
    }
}