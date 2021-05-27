using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace VisualPascalABCPlugins
{
    [DataContract]
    public class AuthenticationParams
    {
        [DataMember]
        public string email { get; set; }
        [DataMember]
        public string password { get; set; }
    }

    [DataContract]
    public class JwtData
    {
        [DataMember]
        public string jwt { get; set; }
    }

    [DataContract]
    public class JwtTokenResponse
    {
        [DataMember]
        public JwtData data { get; set; }
        public string ToString()
        {
            return $"{{data: {data.ToString()}; jwt: {data.jwt}}}";
        }
    }
}
