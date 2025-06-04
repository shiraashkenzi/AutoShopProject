using AutoShop.API.Data;
using AutoShop.API.DTOs;
using AutoShop.API.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoShop.API.Services {
    public class UserService : IUserService {
        private readonly AutoShopDbContext _context;

        public UserService(AutoShopDbContext context) {
            _context = context;
        }

        public async Task<User> CreateAsync(CreateUserDto dto) {
            var user = new User {
                Name = dto.Name,
                Email = dto.Email,
                Password = dto.Password,
                CarId = dto.CarId,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return user;
        }
     public async Task<IEnumerable<User>> GetAllAsync()
        {        
        return await _context.Users.Include(u => u.Car).ToListAsync();
        }

        public async Task<User?> GetByIdAsync(int id) =>
            await _context.Users.Include(u => u.Car).FirstOrDefaultAsync(u => u.Id == id);
    }
}