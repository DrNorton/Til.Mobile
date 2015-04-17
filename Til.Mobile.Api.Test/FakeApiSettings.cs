using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Til.Mobile.Api.Models;

namespace Til.Mobile.Api.Test
{
    public class FakeApiSettings : IApiSettings
    {
        private Token _token;


        public string BaseUrl
        {
            get { return "https://todayilearned.ru"; }
        }
        public Api.Models.Token SavedToken
        {
            get { return _token; }
            set { _token = value; }
        }
    }
}
