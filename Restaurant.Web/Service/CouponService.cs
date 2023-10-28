using Restaurant.Web.Models;
using Restaurant.Web.Service.IService;
using Restaurant.Web.Utility;
using static Restaurant.Web.Utility.ApiTypeEnum;

namespace Restaurant.Web.Service
{
    public class CouponService: BaseCouponService
    {
        private readonly IBaseService _baseService;
        //ctor
        public CouponService(IBaseService baseService)
        {
            _baseService = baseService;
        }

        public async Task<ResponseDto?> CreateCouponsAsync(CouponDto couponDto)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = ApiTypeEnum.ApiType.POST,
                Data=couponDto,
                Url = ApiTypeEnum.CouponAPIBase + "/api/coupon/"
            });
        }

        public async Task<ResponseDto?> DeleteCouponsAsync(int id)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = ApiTypeEnum.ApiType.DELETE,
                Url = ApiTypeEnum.CouponAPIBase + "/api/coupon/"+id
            });
        }

        public async Task<ResponseDto?> GetAllCouponAsync()
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = ApiTypeEnum.ApiType.GET,
                Url = ApiTypeEnum.CouponAPIBase + "/api/coupon"
            });
        }

        public async Task<ResponseDto?> GetCouponAsync(string couponCode)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = ApiTypeEnum.ApiType.GET,
                Url = ApiTypeEnum.CouponAPIBase + "/api/coupon/GetByCode/"+couponCode
            });
        }

        public async Task<ResponseDto?> GetCouponByIdAsync(int id)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = ApiTypeEnum.ApiType.GET,
                Url = ApiTypeEnum.CouponAPIBase + "/api/coupon/"+id
            });
        }

        public async Task<ResponseDto?> UpdateCouponsAsync(CouponDto couponDto)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = ApiTypeEnum.ApiType.PUT,
                Data = couponDto,
                Url = ApiTypeEnum.CouponAPIBase + "/api/coupon/"
            });
        }
    }
}
