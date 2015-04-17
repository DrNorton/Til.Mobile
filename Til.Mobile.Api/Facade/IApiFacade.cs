using System.Collections.Generic;
using System.Threading.Tasks;
using Til.Mobile.Api.Models;

namespace Til.Mobile.Api.Facade
{
    public interface IApiFacade
    {
        Task<GetPostsResponse> GetPosts(int skip, int take);
        Task<Token> Auth(string phoneNumber,string password);
        Task<object> Register(string phone);
        Task<object> Recover(string phone);
    }
}