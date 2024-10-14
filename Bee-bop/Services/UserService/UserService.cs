using Bee_bop.Models;
using Bee_bop.Models.Dtos;
namespace Bee_bop.Services.UserService.UserService
{
    public class UserService : IUserService
    {
        private static List<User> users = new List<User>();

       public async Task Create(UserRegDto newUser)
        {
            users.Add(new User
            {
                Id = users.Count + 1,
                username = newUser.username,
                password = newUser.password
            });

            await Task.CompletedTask;
        }
    }
}
