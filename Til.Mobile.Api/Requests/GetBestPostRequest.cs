using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Til.Mobile.Api.Requests.Base;

namespace Til.Mobile.Api.Requests
{
    public class GetBestPostRequest : BaseParamRequest
    {
        public override string Controller
        {
            get { return "api"; }

        }
        public override string MethodName
        {
            get { return "BestByDate"; }
        }
    }
}
