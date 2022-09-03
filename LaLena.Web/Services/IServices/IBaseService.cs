using LaLena.Web.Models;

namespace LaLena.Web.Services.IServices
{
    public interface IBaseService : IDisposable
    {

        ResponseDto responseModel { get; set; }

        Task<T> SendAsync<T>(ApiRequest apiRequest);




    }
}
