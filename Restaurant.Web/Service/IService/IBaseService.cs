using Restaurant.Web.Models;

namespace Restaurant.Web.Service.IService
{
    public interface IBaseService
    {
       Task<ResponseDto?> SendASync(RequestDto requestDto);
    }
}
