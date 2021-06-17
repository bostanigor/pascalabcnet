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
            this.errorLabel = new System.Windows.Forms.Label();
            this.logInButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.serverStatus = new System.Windows.Forms.Label();
            this.userInfo = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.authPage = new System.Windows.Forms.TabPage();
            this.testPage = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.testButton = new System.Windows.Forms.Button();
            this.taskInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.statusInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.codeTextInput = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.authPage.SuspendLayout();
            this.testPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(196, 95);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(28, 13);
            this.errorLabel.TabIndex = 5;
            this.errorLabel.Text = "error";
            // 
            // logInButton
            // 
            this.logInButton.Location = new System.Drawing.Point(221, 111);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(148, 32);
            this.logInButton.TabIndex = 4;
            this.logInButton.Text = "Войти";
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 16);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(80, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Имя\r\nПользователя";
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(115, 60);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '*';
            this.passwordInput.Size = new System.Drawing.Size(254, 20);
            this.passwordInput.TabIndex = 1;
            // 
            // usernameInput
            // 
            this.usernameInput.Location = new System.Drawing.Point(115, 22);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(254, 20);
            this.usernameInput.TabIndex = 0;
            // 
            // serverStatus
            // 
            this.serverStatus.AutoSize = true;
            this.serverStatus.Location = new System.Drawing.Point(12, 192);
            this.serverStatus.Name = "serverStatus";
            this.serverStatus.Size = new System.Drawing.Size(54, 13);
            this.serverStatus.TabIndex = 1;
            this.serverStatus.Text = "Загрузка";
            // 
            // userInfo
            // 
            this.userInfo.AutoSize = true;
            this.userInfo.Location = new System.Drawing.Point(211, 191);
            this.userInfo.Name = "userInfo";
            this.userInfo.Size = new System.Drawing.Size(89, 13);
            this.userInfo.TabIndex = 2;
            this.userInfo.Text = "Не авторизован";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.authPage);
            this.tabControl1.Controls.Add(this.testPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(383, 175);
            this.tabControl1.TabIndex = 3;
            // 
            // authPage
            // 
            this.authPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.authPage.Controls.Add(this.errorLabel);
            this.authPage.Controls.Add(this.label1);
            this.authPage.Controls.Add(this.logInButton);
            this.authPage.Controls.Add(this.usernameInput);
            this.authPage.Controls.Add(this.label2);
            this.authPage.Controls.Add(this.passwordInput);
            this.authPage.Location = new System.Drawing.Point(4, 22);
            this.authPage.Name = "authPage";
            this.authPage.Padding = new System.Windows.Forms.Padding(3);
            this.authPage.Size = new System.Drawing.Size(375, 149);
            this.authPage.TabIndex = 0;
            this.authPage.Text = "Аутентификация";
            // 
            // testPage
            // 
            this.testPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.testPage.Controls.Add(this.label3);
            this.testPage.Controls.Add(this.codeTextInput);
            this.testPage.Controls.Add(this.label4);
            this.testPage.Controls.Add(this.testButton);
            this.testPage.Controls.Add(this.taskInput);
            this.testPage.Controls.Add(this.label5);
            this.testPage.Controls.Add(this.statusInput);
            this.testPage.Location = new System.Drawing.Point(4, 22);
            this.testPage.Name = "testPage";
            this.testPage.Padding = new System.Windows.Forms.Padding(3);
            this.testPage.Size = new System.Drawing.Size(375, 149);
            this.testPage.TabIndex = 1;
            this.testPage.Text = "Тестирование";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 25);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Имя задачи";
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(221, 111);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(148, 32);
            this.testButton.TabIndex = 10;
            this.testButton.Text = "Послать запрос";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // taskInput
            // 
            this.taskInput.Location = new System.Drawing.Point(115, 22);
            this.taskInput.Name = "taskInput";
            this.taskInput.Size = new System.Drawing.Size(254, 20);
            this.taskInput.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Статус";
            // 
            // statusInput
            // 
            this.statusInput.Location = new System.Drawing.Point(115, 48);
            this.statusInput.Name = "statusInput";
            this.statusInput.Size = new System.Drawing.Size(254, 20);
            this.statusInput.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Текст решения";
            // 
            // codeTextInput
            // 
            this.codeTextInput.Location = new System.Drawing.Point(115, 74);
            this.codeTextInput.Name = "codeTextInput";
            this.codeTextInput.Size = new System.Drawing.Size(254, 20);
            this.codeTextInput.TabIndex = 8;
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 216);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.userInfo);
            this.Controls.Add(this.serverStatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AuthorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FORMNAME";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
            this.Load += new System.EventHandler(this.Form_Load);
            this.Shown += new System.EventHandler(this.Form_Shown);
            this.tabControl1.ResumeLayout(false);
            this.authPage.ResumeLayout(false);
            this.authPage.PerformLayout();
            this.testPage.ResumeLayout(false);
            this.testPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label serverStatus;
        private System.Windows.Forms.Label userInfo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage authPage;
        private System.Windows.Forms.TabPage testPage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.TextBox taskInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox statusInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox codeTextInput;
    }
}