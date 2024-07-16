using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TakeAwayNight.Catalog.Dtos.SliderDtos;
using TakeAwayNight.Catalog.Services.SliderServices;

namespace TakeAwayNight.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SliderController : ControllerBase
    {
        private readonly ISliderService _sliderService;

        public SliderController(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }
        [HttpGet]
        public async Task<IActionResult> SliderList()
        {
            var values = await _sliderService.GetAllSliderAsync();
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateSlider(CreateSliderDto createSliderDto)
        {
            await _sliderService.CreateSliderAsync(createSliderDto);
            return Ok("Slider başarıyla eklendi");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteSlider(string id)
        {
            await _sliderService.DeleteSliderAsync(id);
            return Ok("Slider başarıyla silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateSlider(UpdateSliderDto updateSliderDto)
        {
            await _sliderService.UpdateSliderAsync(updateSliderDto);
            return Ok("Slider başarıyla güncellendi");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSlider(string id)
        {
            var value = await _sliderService.GetByIdSliderAsync(id);
            return Ok(value);
        }
    }
}
