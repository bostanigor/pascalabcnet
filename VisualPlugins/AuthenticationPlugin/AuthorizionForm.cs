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
    public partial class AuthorizionForm : Form
    {
        public IVisualEnvironmentCompiler VisualEnvironmentCompiler;        

        public AuthorizionForm()
        {
            InitializeComponent();
            PascalABCCompiler.StringResources.SetTextForAllObjects(this, AuthorizationPlugin_VisualPascalABCPlugin.StringsPrefix);
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
    }
}
