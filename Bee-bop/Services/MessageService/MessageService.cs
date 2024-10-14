using Bee_bop.Models;
using Bee_bop.Models.Dtos;
namespace Bee_bop.Services.MessageService.MessageService

{
    public class MessageService : IMessageService
    {
        private static List<Message> messages = new List<Message>();

        public async Task SubmitMessage(MessageSendDto message)
        {
            messages.Add(new Message
            {
               id = messages.Count + 1,
                message = message.message
            });

            await Task.CompletedTask;

        }
    }
}
