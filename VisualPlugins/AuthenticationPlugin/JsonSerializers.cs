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
}
