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
            this.loginUsernameLabel.AutoSize = true;
            this.loginUsernameLabel.Location = new System.Drawing.Point(55, 102);
            this.loginUsernameLabel.Name = "loginUsernameLabel";
            this.loginUsernameLabel.Size = new System.Drawing.Size(58, 13);
            this.loginUsernameLabel.TabIndex = 0;
            this.loginUsernameLabel.Text = "Username:";
            // 
            // loginUsernameText
            // 
            this.loginUsernameText.Location = new System.Drawing.Point(58, 136);
            this.loginUsernameText.Name = "loginUsernameText";
            this.loginUsernameText.Size = new System.Drawing.Size(286, 20);
            this.loginUsernameText.TabIndex = 1;
            // 
            // loginPasswordLabel
            // 
            this.loginPasswordLabel.AutoSize = true;
            this.loginPasswordLabel.Location = new System.Drawing.Point(58, 181);
            this.loginPasswordLabel.Name = "loginPasswordLabel";
            this.loginPasswordLabel.Size = new System.Drawing.Size(56, 13);
            this.loginPasswordLabel.TabIndex = 2;
            this.loginPasswordLabel.Text = "Password:";
            // 
            // loginPasswordText
            // 
            this.loginPasswordText.Location = new System.Drawing.Point(58, 216);
            this.loginPasswordText.Name = "loginPasswordText";
            this.loginPasswordText.Size = new System.Drawing.Size(286, 20);
            this.loginPasswordText.TabIndex = 3;
            // 
            // loginSignInButton
            // 
            this.loginSignInButton.Location = new System.Drawing.Point(58, 279);
            this.loginSignInButton.Name = "loginSignInButton";
            this.loginSignInButton.Size = new System.Drawing.Size(286, 23);
            this.loginSignInButton.TabIndex = 4;
            this.loginSignInButton.Text = "Sign In";
            this.loginSignInButton.UseVisualStyleBackColor = true;
            this.loginSignInButton.Click += new System.EventHandler(this.loginSignInButton_Click);
            // 
            // loginExitButton
            // 
            this.loginExitButton.Location = new System.Drawing.Point(58, 321);
            this.loginExitButton.Name = "loginExitButton";
            this.loginExitButton.Size = new System.Drawing.Size(286, 23);
            this.loginExitButton.TabIndex = 5;
            this.loginExitButton.Text = "Exit";
            this.loginExitButton.UseVisualStyleBackColor = true;
            this.loginExitButton.Click += new System.EventHandler(this.loginExitButton_Click);
            // 
            // loginLinkLabel
            // 
            this.loginLinkLabel.AutoSize = true;
            this.loginLinkLabel.Location = new System.Drawing.Point(121, 412);
            this.loginLinkLabel.Name = "loginLinkLabel";
            this.loginLinkLabel.Size = new System.Drawing.Size(168, 13);
            this.loginLinkLabel.TabIndex = 6;
            this.loginLinkLabel.TabStop = true;
            this.loginLinkLabel.Text = "Software created by: @daviskooo";
            // 
            // loginInFormTitle
            // 
            this.loginInFormTitle.AutoSize = true;
            this.loginInFormTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginInFormTitle.Location = new System.Drawing.Point(159, 40);
            this.loginInFormTitle.Name = "loginInFormTitle";
            this.loginInFormTitle.Size = new System.Drawing.Size(71, 37);
            this.loginInFormTitle.TabIndex = 7;
            this.loginInFormTitle.Text = "B.F.S";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 450);
            this.Controls.Add(this.loginInFormTitle);
            this.Controls.Add(this.loginLinkLabel);
            this.Controls.Add(this.loginExitButton);
            this.Controls.Add(this.loginSignInButton);
            this.Controls.Add(this.loginPasswordText);
            this.Controls.Add(this.loginPasswordLabel);
            this.Controls.Add(this.loginUsernameText);
            this.Controls.Add(this.loginUsernameLabel);
            this.Name = "LoginForm";
            this.Text = "Basic Financial System - Login";
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