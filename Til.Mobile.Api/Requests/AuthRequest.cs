using Til.Mobile.Api.Requests.Base;

namespace Til.Mobile.Api.Requests
{
    public class AuthRequest:BaseParamRequest
    {
        
        public override string Controller
        {
            get { return ""; }
        }

        public override string MethodName
        {
            get { return "token"; }
        }

    }
}
