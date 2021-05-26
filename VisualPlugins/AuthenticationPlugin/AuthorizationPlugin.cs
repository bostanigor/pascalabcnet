using System;
using System.Collections.Generic;
using System.Text;

namespace VisualPascalABCPlugins
{
    //имя класса *_VisualPascalABCPlugin
    public class AuthorizationPlugin_VisualPascalABCPlugin : IVisualPascalABCPlugin
    {
        public static string StringsPrefix = "VPP_AUTHORIZATIONPLUGIN_";
        IVisualEnvironmentCompiler VisualEnvironmentCompiler;
        IWorkbench Workbench;
        private AuthorizionForm testForm = new AuthorizionForm();
        
        public string Name
        {
            get
            {
                return "Authorization Plugin";
            }
        }
        public string Version
        {
            get
            {
                return "1.0";
            }
        }
        public string Copyright
        {
            get
            {
                return "NO DATA";
            }
        }

        public void Execute()
        {
            testForm.Show();
        }

        public AuthorizationPlugin_VisualPascalABCPlugin(IWorkbench Workbench)
        {
            this.Workbench = Workbench;
            VisualEnvironmentCompiler = Workbench.VisualEnvironmentCompiler;
            testForm.VisualEnvironmentCompiler = VisualEnvironmentCompiler;

        }
        public void GetGUI(List<IPluginGUIItem> MenuItems, List<IPluginGUIItem> ToolBarItems)
        {
            PluginGUIItem Item = new PluginGUIItem(StringsPrefix + "NAME", StringsPrefix + "DESCRIPTION", testForm.PluginImage.Image, testForm.PluginImage.BackColor, Execute);
            MenuItems.Add(Item);
            ToolBarItems.Add(Item);
        }
    }
}

