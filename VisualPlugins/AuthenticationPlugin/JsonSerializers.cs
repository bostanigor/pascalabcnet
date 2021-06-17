using System;

namespace VisualPascalABCPlugins
{    
    public class AuthenticationParams
    { 
        public string username { get; set; }
        public string password { get; set; }
    }

    public class SolutionParams
    {
        public string name { get; set; }
        public string status { get; set; }
        public string code_text { get; set; }
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
        public string username { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
    }
    public class FetchResponse
    {
        public FetchData data { get; set; }
    }
}
