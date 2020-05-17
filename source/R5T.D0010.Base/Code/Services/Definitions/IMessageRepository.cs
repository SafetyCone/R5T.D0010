using System;
using System.Threading.Tasks;

using R5T.T0001;


namespace R5T.D0010
{
    public interface IMessageRepository : IMessageSink, IMessageSource
    {
        Task ClearAsync(Func<Message, bool> predicate); // Synchronous predicate ok for now.
    }
}
