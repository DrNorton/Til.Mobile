using Til.Mobile.Api.Requests.Base;

namespace Til.Mobile.Api.Requests
{
    public class RecoverRequest : BaseParamRequest
    {
        public override string Controller
        {
            get { return "account"; }
        }

        public override string MethodName
        {
            get { return "RecoverPassword"; }
        }
    }
}
