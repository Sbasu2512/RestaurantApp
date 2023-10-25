using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CouponAPI.Models
{
    //core model of our db
    public class Coupon
    {
        [Key]
        public int CouponId { get; set; }
        [Required]
        public string CouponCode { get; set; }
        [Required]
        public double  DiscountAmount { get; set; }
        public int MinAmount { get; set; }
        //public DateTime LastUpdated { get; set; }
    }
}
