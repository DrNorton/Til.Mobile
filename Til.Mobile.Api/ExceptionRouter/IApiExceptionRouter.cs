
namespace Til.Mobile.Api.ExceptionRouter
{
    public interface IApiExceptionRouter
    {
        void Route(ApiException exception);
    }
}
