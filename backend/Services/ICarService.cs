using AutoShop.API.DTOs;
using AutoShop.API.Models;

namespace AutoShop.API.Services {
    public interface ICarService {
        Task<Car> CreateAsync(CreateCarDto dto);
        Task<Car?> GetByIdAsync(int id);
        Task<IEnumerable<Car>> GetAllAsync();

    }
}