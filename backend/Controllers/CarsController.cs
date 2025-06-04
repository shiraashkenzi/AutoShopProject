using Microsoft.AspNetCore.Mvc;
using AutoShop.API.DTOs;
using AutoShop.API.Services;

namespace AutoShop.API.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class CarsController : ControllerBase {
        private readonly ICarService _carService;

        public CarsController(ICarService carService) {
            _carService = carService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateCarDto dto) {
            var car = await _carService.CreateAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = car.Id }, car);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id) {
            var car = await _carService.GetByIdAsync(id);
            return car == null ? NotFound() : Ok(car);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() {
            var cars = await _carService.GetAllAsync();
            return Ok(cars);
        }


    }
}