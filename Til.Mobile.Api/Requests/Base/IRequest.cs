using System.Collections.Generic;
using System.Net.Http;
using Til.Mobile.Api.Models;

namespace Til.Mobile.Api.Requests.Base
{
    public interface IRequest
    {
        string Controller { get; }
        string MethodName { get; }

        HttpMethod Type { get; set; }

        Token Token { get; set; }
        Dictionary<string, string> Params { get; } 
    }
}
