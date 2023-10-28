namespace Restaurant.Web.Utility
{
    public class ApiTypeEnum
    {
        public static string CouponAPIBase { get;set; }
        public enum ApiType
        {
            GET,
            POST,
            PUT, 
            DELETE
        }
    }
}
