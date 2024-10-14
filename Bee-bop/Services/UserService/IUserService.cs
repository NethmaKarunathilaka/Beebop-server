using Bee_bop.Models;
using Bee_bop.Models.Dtos;

namespace Bee_bop.Services.UserService.UserService

{
    public interface IUserService
    {
        public Task Create(UserRegDto newUser);

    }
}
