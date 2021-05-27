using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace VisualPascalABCPlugins
{
    public class AuthorizationPlugin_VisualPascalABCPlugin : IVisualPascalABCPlugin
    {
        public static string StringsPrefix = "VPP_AUTHORIZATIONPLUGIN_";
        IVisualEnvironmentCompiler VisualEnvironmentCompiler;
        IWorkbench Workbench;
        private AuthorizationForm authForm;

        private HttpClient httpClient = new HttpClient();
        private string apiUrl = null;
        private string jwt = null;
        private bool serverStatus = false;

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
            authForm.Show();
        }

        public AuthorizationPlugin_VisualPascalABCPlugin(IWorkbench Workbench)
        {
            authForm = new AuthorizationForm(this);            
            this.Workbench = Workbench;
            VisualEnvironmentCompiler = Workbench.VisualEnvironmentCompiler;
            authForm.VisualEnvironmentCompiler = VisualEnvironmentCompiler;
            Init();
        }
        public void GetGUI(List<IPluginGUIItem> MenuItems, List<IPluginGUIItem> ToolBarItems)
        {
            PluginGUIItem Item = new PluginGUIItem(StringsPrefix + "NAME", StringsPrefix + "DESCRIPTION", authForm.Icon.ToBitmap(), authForm.BackColor, Execute);
            MenuItems.Add(Item);
            ToolBarItems.Add(Item);
        }

        private async void Init()
        {
            authForm.Enabled = false;
            InitApiURL();
            InitJwt();
            PingApi().Wait();
            if (serverStatus)
                authForm.SetConnectionStatus(true, "Сервер онлайн");
            else
                authForm.SetConnectionStatus(false, "Сервер недоступен");
            authForm.Enabled = true;
        }

        private void InitApiURL()
        {            
            apiUrl = File.Exists(@".\AuthorizationConfig.txt") ?
                    File.ReadAllText(@".\AuthorizationConfig.txt") :
                    null;
        }

        private void InitJwt()
        {
            jwt = File.Exists(@".\jwt") ?
                    File.ReadAllText(@".\jwt") :
                    null;
        }

        public async void AuthenticateUser(string email, string password)
        {            
            var authParams = new AuthenticationParams
            {
                email = email,
                password = password
            };
            var json = JsonSerializer.Serialize(authParams);            
            var body = new StringContent(json, Encoding.UTF8, "application/json");            
            var response = await httpClient.PostAsync($"{apiUrl}/api/auth", body);            

            if (response.IsSuccessStatusCode)
            {                
                var content = await response.Content.ReadAsStringAsync();                

                using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(content)))
                {
                    var jwt = JsonSerializer.Deserialize<JwtTokenResponse>(content).data.token;                    
                    File.WriteAllText(@".\jwt", jwt);                    
                }
            }
            else
            {
                File.Delete(@".\jwt");
            }
        }

        private async Task PingApi()
        {
            try
            {
                var response = await httpClient.GetAsync(apiUrl).ConfigureAwait(false);
                response.EnsureSuccessStatusCode();
                serverStatus = response.IsSuccessStatusCode;                
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }            
        }
    }
}

