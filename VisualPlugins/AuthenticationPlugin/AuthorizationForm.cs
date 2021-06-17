using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PascalABCCompiler.Errors;
using System.IO;

namespace VisualPascalABCPlugins
{
    public partial class AuthorizationForm : Form
    {
        public IVisualEnvironmentCompiler VisualEnvironmentCompiler;
        private AuthorizationPlugin_VisualPascalABCPlugin plugin;

        public AuthorizationForm(AuthorizationPlugin_VisualPascalABCPlugin parent)
        {
            InitializeComponent();
            plugin = parent;
            PascalABCCompiler.StringResources.SetTextForAllObjects(this, AuthorizationPlugin_VisualPascalABCPlugin.StringsPrefix);
            errorLabel.Visible = false;
            this.Enabled = false;
        }
        public void SetConnectionStatus(bool online, string message)
        {
            if (online)
            {
                authorizationGroup.Enabled = true;
                serverStatus.ForeColor = Color.Green;
            }
            else
            {
                authorizationGroup.Enabled = false;
                serverStatus.ForeColor = Color.Red;
            }
            serverStatus.Text = message;
        }

        public void SetUserInfo(bool authorized, string message)
        {
            userInfo.ForeColor = authorized ?
                Color.Green :
                Color.Red;
            userInfo.Text = message;
        }

        public void SetLoading()
        {
            this.Enabled = false;
            serverStatus.ForeColor = Color.Black;
            serverStatus.Text = "Загрузка";
            userInfo.ForeColor = Color.Black;
            userInfo.Text = "Загрузка";
        }

        public void EnableAuthForm()
        {
            this.Enabled = true;
            authorizationGroup.Enabled = true;            
        }
        public void SetError(bool error, string message = null)
        {
            if (error)
            {
                errorLabel.Text = message;
                errorLabel.Visible = true;
            }
            else
                errorLabel.Visible = false;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            plugin.FetchUserAsync();
        }

        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Visible = false;
        }

        private void Form_Shown(object sender, EventArgs e)
        {
            VisualEnvironmentCompiler.Compiler.OnChangeCompilerState += new PascalABCCompiler.ChangeCompilerStateEventDelegate(Compiler_OnChangeCompilerState);
        }

        void Compiler_OnChangeCompilerState(PascalABCCompiler.ICompiler sender, PascalABCCompiler.CompilerState State, string FileName)
        {
            //compiler states
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            var username = usernameInput.Text;
            var password = passwordInput.Text;
            plugin.AuthenticateUserAsync(username, password);
        }
    }
}
