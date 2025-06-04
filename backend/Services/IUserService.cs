using AutoShop.API.DTOs;
using AutoShop.API.Models;

namespace AutoShop.API.Services {
    public interface IUserService {
        Task<User> CreateAsync(CreateUserDto dto);
        Task<User?> GetByIdAsync(int id);
        Task<IEnumerable<User>> GetAllAsync();

    }
}