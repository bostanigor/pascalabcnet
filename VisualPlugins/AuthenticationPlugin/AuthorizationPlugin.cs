using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using System.Net.Http.Headers;

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
        private string jwt = "";
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

        private void Init()
        {
            authForm.Enabled = false;
            InitApiURL();
            InitJwt();            
            authForm.EnableAuthForm();            
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
            var token = File.Exists(@".\jwt") ?
                    File.ReadAllText(@".\jwt") : null;            
            SetJwt(token);
        }

        private void SetJwt(string token)
        {
            this.jwt = token;
            httpClient.DefaultRequestHeaders.Authorization =
                jwt != null && jwt.Length > 1 ?
                new AuthenticationHeaderValue("Bearer", jwt) :
                null;
        }

        public async Task AuthenticateUserAsync(string username, string password)
        {
            authForm.SetLoading();
            var authParams = new AuthenticationParams
            {
                username = username,
                password = password
            };
            var json = JsonSerializer.Serialize(authParams);
            var body = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync($"{apiUrl}/api/auth", body);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();                
                SetJwt(JsonSerializer.Deserialize<JwtTokenResponse>(content).data.token);                
                File.WriteAllText(@".\jwt", jwt);                
                authForm.SetError(false);
                await FetchUserAsync();
            }
            else
            {
                SetJwt(null);
                File.Delete(@".\jwt");
                authForm.SetError(true, "Неверные данные");
                FetchUserAsync();
            }            
            authForm.EnableAuthForm();            
        }

        public async Task FetchUserAsync()
        {
            try
            {
                var response = await httpClient.GetAsync($"{apiUrl}/api/auth").ConfigureAwait(false);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                                        
                    var data = JsonSerializer.Deserialize<FetchResponse>(content).data;                 
                    authForm.SetUserInfo(true, $"{data.first_name} {data.last_name}");
                    authForm.SetConnectionStatus(true, "Сервер онлайн");
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {                    
                    authForm.SetUserInfo(false, "");
                    authForm.SetConnectionStatus(true, "Сервер онлайн");
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    SetJwt("");
                    File.Delete(@".\jwt");
                    authForm.SetUserInfo(false, "Не авторизован");
                    authForm.SetConnectionStatus(true, "Сервер онлайн");
                }
                else
                {             
                    authForm.SetConnectionStatus(false, "Сервер недоступен");
                }
            }
            catch (HttpRequestException e)
            {                
                File.Delete(@".\jwt");
                authForm.SetConnectionStatus(false, "Сервер недоступен");
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
        }
    }
}

