using AutoMapper;
using Bee_bop.Models;
using Bee_bop.Models.Dtos;
using Bee_bop.Data;

namespace Bee_bop.Services

{
    public class MessageService : IMessageService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public MessageService(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task SubmitMessage(MessageSendDto message)
        {
            var messages = _mapper.Map<Message>(message);

             _context.Messages.Add(messages);
            await _context.SaveChangesAsync();

        }
    }
}
