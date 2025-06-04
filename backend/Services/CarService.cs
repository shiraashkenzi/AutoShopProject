using AutoShop.API.Data;
using AutoShop.API.DTOs;
using AutoShop.API.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoShop.API.Services {
    public class CarService : ICarService {
        private readonly AutoShopDbContext _context;

        public CarService(AutoShopDbContext context) {
            _context = context;
        }

        public async Task<Car> CreateAsync(CreateCarDto dto) {
            var car = new Car {
                Company = dto.Company,
                Model = dto.Model,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            await _context.Cars.AddAsync(car);
            await _context.SaveChangesAsync();
            return car;
        }
        public async Task<IEnumerable<Car>> GetAllAsync() {
            return await _context.Cars.ToListAsync();
       }

        public async Task<Car?> GetByIdAsync(int id) => await _context.Cars.FindAsync(id);
    }
}