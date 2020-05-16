using System;
using System.Threading.Tasks;


namespace R5T.D0010
{
    public interface IMessageRepository : IMessageSink, IMessageSource
    {
        Task ClearAsync();
    }
}
