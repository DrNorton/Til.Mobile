using Til.Mobile.Api.Models;

namespace Til.Mobile.Api
{
    public interface IApiSettings
    {
        string BaseUrl { get; }
        Token SavedToken { get; set; }


     
    }
}
