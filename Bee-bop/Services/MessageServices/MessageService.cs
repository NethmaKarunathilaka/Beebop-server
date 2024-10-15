using AutoMapper;
using Bee_bop.Models;
using Bee_bop.Models.Dtos;

namespace Bee_bop.Services

{
    public class MessageService : IMessageService
    {
        private static List<Message> messages = new List<Message>();
        private readonly IMapper _mapper;

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
