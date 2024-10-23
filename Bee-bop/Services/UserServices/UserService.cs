using AutoMapper;
using Bee_bop.Data;
using Bee_bop.Models;
using Bee_bop.Models.Dtos;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;

namespace Bee_bop.Services
{
    public class UserService : IUserService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;



        public UserService(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public  Task Authenticate(LoginRequestDto loginuser)
        {
            if (loginuser == null)
            {
               return null;
            }
            return  _context.Users.FirstOrDefaultAsync(x => x.username == loginuser.username && x.password == loginuser.password);

        }

        public async Task Create(UserRegDto newUser)
        {
            var user = _mapper.Map<User>(newUser);
            _context.Users.Add(user);

            await _context.SaveChangesAsync();

        }
    }
}
