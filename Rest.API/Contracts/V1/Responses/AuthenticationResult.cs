using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rest.API.Contracts.V1.Responses
{
    public class AuthenticationResult
    {
        public string Token { get; set; }
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
        public IEnumerable<string> Errors { get; internal set; }
        public string RefreshToken { get; internal set; }
    }
}
