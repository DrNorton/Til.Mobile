using System.Collections.Generic;
using System.Threading.Tasks;
using Til.Mobile.Api.ExceptionRouter;
using Til.Mobile.Api.Executer;
using Til.Mobile.Api.Models;
using Til.Mobile.Api.Requests;
using Til.Mobile.Api.Requests.Base;

namespace Til.Mobile.Api.Facade
{
    public class ApiFacade : IApiFacade
    {
        private readonly IApiExceptionRouter _exceptionRouter;
        private IApiExecuter _apiExecuter;
        private readonly IApiSettings _apiSettings;
        

        public ApiFacade(IApiExecuter apiExecuter,IApiSettings apiSettings)
        {
            _apiExecuter = apiExecuter;
            _apiSettings = apiSettings;
   
        }

        public Task<GetPostsResponse> GetPosts(int skip,int take)
        {
            var getPostRequest = new GetPostsRequest();
            getPostRequest.AddParam("skip", skip.ToString());
            getPostRequest.AddParam("take", take.ToString());
            return ExecuteWithErrorHandling<GetPostsResponse>(getPostRequest);
        }

        public async Task<Token> Auth(string phoneNumber,string password)
        {
            var authRequest = new AuthRequest();
            authRequest.AddParam("grant_type", "password");
            authRequest.AddParam("userName", phoneNumber);
            authRequest.AddParam("password", password);
            var token=await ExecuteWithErrorHandling<Token>(authRequest);
            _apiSettings.SavedToken = token;
            return token;
        }



        private Task<T> ExecuteWithErrorHandling<T>(IRequest request)
        {
            try
            {
                request.Token = _apiSettings.SavedToken;//Добавляем токен
               return _apiExecuter.Execute<T>(request);
            }
            catch (ApiException ex)
            {
             
               throw ex;
            }
        }


        public Task<object> Register(string phone)
        {
            var registerRequest = new RegisterRequest();
            registerRequest.AddParam("Phone",phone);
            return ExecuteWithErrorHandling<object>(registerRequest);
        }

        public Task<object> Recover(string phone)
        {
            var recoverRequest = new RecoverRequest();
            recoverRequest.AddParam("Phone", phone);
            return ExecuteWithErrorHandling<object>(recoverRequest);
        }
    }
}
