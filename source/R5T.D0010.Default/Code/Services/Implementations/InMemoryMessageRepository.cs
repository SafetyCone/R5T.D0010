using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using R5T.T0001;

using R5T.Magyar.Extensions;using R5T.T0064;


namespace R5T.D0010.Default
{[ServiceImplementationMarker]
    public class InMemoryMessageRepository : IMessageRepository,IServiceImplementation
    {
        private List<Message> Messages { get; } = new List<Message>();


        public Task AddAsync(Message message)
        {
            this.Messages.Add(message);

            return Task.CompletedTask;
        }

        public Task ClearAsync(Func<Message, bool> predicate)
        {
            var messagesToClear = this.Messages
                .Where(predicate);

            this.Messages.RemoveRange(messagesToClear);

            return Task.CompletedTask;
        }

        public Task<IEnumerable<Message>> GetAsync(Func<Message, bool> predicate)
        {
            var messages = this.Messages
                .Where(predicate);

            return Task.FromResult(messages);
        }
    }
}
