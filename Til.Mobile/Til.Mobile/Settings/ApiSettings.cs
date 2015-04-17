using System;
using System.Collections.Generic;
using System.Text;
using Til.Mobile.Api;
using Til.Mobile.Api.Models;

namespace Til.Mobile.Settings
{
    public class ApiSettings : IApiSettings
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
