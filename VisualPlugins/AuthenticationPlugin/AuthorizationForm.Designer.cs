namespace VisualPascalABCPlugins
{
    partial class AuthorizationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            this.authorizationGroup = new System.Windows.Forms.Panel();
            this.errorLabel = new System.Windows.Forms.Label();
            this.logInButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.serverStatus = new System.Windows.Forms.Label();
            this.userInfo = new System.Windows.Forms.Label();
            this.authorizationGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // authorizationForm
            // 
            this.authorizationGroup.Controls.Add(this.errorLabel);
            this.authorizationGroup.Controls.Add(this.logInButton);
            this.authorizationGroup.Controls.Add(this.label2);
            this.authorizationGroup.Controls.Add(this.label1);
            this.authorizationGroup.Controls.Add(this.passwordInput);
            this.authorizationGroup.Controls.Add(this.emailInput);
            this.authorizationGroup.Location = new System.Drawing.Point(13, 13);
            this.authorizationGroup.Name = "authorizationForm";
            this.authorizationGroup.Size = new System.Drawing.Size(362, 153);
            this.authorizationGroup.TabIndex = 0;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(173, 89);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(28, 13);
            this.errorLabel.TabIndex = 5;
            this.errorLabel.Text = "error";
            // 
            // logInButton
            // 
            this.logInButton.Location = new System.Drawing.Point(198, 105);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(148, 32);
            this.logInButton.TabIndex = 4;
            this.logInButton.Text = "Log in";
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email";
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(92, 54);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '*';
            this.passwordInput.Size = new System.Drawing.Size(254, 20);
            this.passwordInput.TabIndex = 1;
            // 
            // emailInput
            // 
            this.emailInput.Location = new System.Drawing.Point(92, 16);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(254, 20);
            this.emailInput.TabIndex = 0;
            // 
            // serverStatus
            // 
            this.serverStatus.AutoSize = true;
            this.serverStatus.Location = new System.Drawing.Point(12, 192);
            this.serverStatus.Name = "serverStatus";
            this.serverStatus.Size = new System.Drawing.Size(66, 13);
            this.serverStatus.TabIndex = 1;
            this.serverStatus.Text = "serverStatus";
            // 
            // userInfo
            // 
            this.userInfo.AutoSize = true;
            this.userInfo.Location = new System.Drawing.Point(211, 191);
            this.userInfo.Name = "userInfo";
            this.userInfo.Size = new System.Drawing.Size(35, 13);
            this.userInfo.TabIndex = 2;
            this.userInfo.Text = "label3";
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 214);
            this.Controls.Add(this.userInfo);
            this.Controls.Add(this.serverStatus);
            this.Controls.Add(this.authorizationGroup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AuthorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AUTHORIZATION";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
            this.Load += new System.EventHandler(this.Form_Load);
            this.Shown += new System.EventHandler(this.Form_Shown);
            this.authorizationGroup.ResumeLayout(false);
            this.authorizationGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Panel authorizationGroup;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label serverStatus;
        private System.Windows.Forms.Label userInfo;
    }
}