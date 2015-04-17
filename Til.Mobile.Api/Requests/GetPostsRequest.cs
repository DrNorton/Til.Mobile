using System.Collections.Generic;
using Til.Mobile.Api.Models;
using Til.Mobile.Api.Requests.Base;

namespace Til.Mobile.Api.Requests
{
    public class GetPostsRequest:BaseParamRequest
    {
        public override string Controller
        {
            get { return "api"; }
            
        }
        public override string MethodName
        {
            get { return "list"; }
        }

        
    }
}
