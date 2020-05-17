using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using R5T.T0001;


namespace R5T.D0010
{
    public interface IMessageSource
    {
        Task<IEnumerable<Message>> GetMessagesAsync(Func<Message, bool> predicate);
    }
}
