using Bee_bop.Models;
using Bee_bop.Models.Dtos;

namespace Bee_bop.Services
{
    public interface IMessageService
    {
        public Task SubmitMessage(MessageSendDto message);
    }
}
