using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TakeAwayNight.Discount.Dtos;
using TakeAwayNight.Discount.Services;

namespace TakeAwayNight.Discount.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountCouponsController : ControllerBase
    {
        private readonly IDiscountCouponService _discountCouponService;

        public DiscountCouponsController(IDiscountCouponService discountCouponService)
        {
            _discountCouponService = discountCouponService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllDiscountCoupons()
        {
            var values=await _discountCouponService.GetResultDiscountCouponAsync();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateDiscountCoupons(CreateDiscountCouponDto createDiscountCouponDto)
        {
            await _discountCouponService.CreateDiscountCouponAsync(createDiscountCouponDto);
            return Ok("Kupon Oluşturuldu");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteDiscountCoupon(int id)
        {
            await _discountCouponService.DeleteDiscountCouponAsync(id);
            return Ok("Kupon Silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateDiscountCoupon(UpdateDiscountCouponDto updateDiscountCouponDto)
        {
            await _discountCouponService.UpdateDiscountCouponAsync(updateDiscountCouponDto);
            return Ok("Kupon Güncellendi");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDiscountCoupon(int id)
        {
            var values=await _discountCouponService.GetByIdDiscountCouponAsync(id);
            return Ok(values);
        }
    }
}
