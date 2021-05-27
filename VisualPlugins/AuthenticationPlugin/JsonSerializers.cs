using System;

namespace VisualPascalABCPlugins
{    
    public class AuthenticationParams
    { 
        public string email { get; set; }
        public string password { get; set; }
    }
    
    public class JwtData
    {
        public string token { get; set; }
    }

    public class JwtTokenResponse
    {        
        public JwtData data { get; set; }
        public string errors;
        public override string ToString()
        {
            return $"{{data: {data.ToString()}; jwt: {data.token}}}";
        }
    }

    public class FetchData
    {
        public string email { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
    }
    public class FetchResponse
    {
        public FetchData data { get; set; }
    }
}
