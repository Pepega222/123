using Microsoft.EntityFrameworkCore;
using test1.Context;
using test1.DTO;
using test1.Models;

namespace test1.Repositories;

public class VisitRequestRepository
{
    private readonly DatabaseContext _context;

    public VisitRequestRepository(DatabaseContext context)
    {
        _context = context;
    }

    public async Task<User> CreateUser(CreateUserDTO user)
    {
        var newUserDTO = new User
        {
            
        }
    }
    public async Task<IEnumerable<User>> GetUsers()
    {
        return await _context.Users.ToListAsync();
    }
}