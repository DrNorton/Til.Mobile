using System.Threading.Tasks;
using Til.Mobile.Api.Requests.Base;

namespace Til.Mobile.Api.Executer
{
    public interface IApiExecuter
    {
        Task<T> Execute<T>(IRequest request);
    }
}