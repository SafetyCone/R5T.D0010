using System;
using System.Threading.Tasks;


namespace R5T.D0010
{
    public interface IFormattedMessageSink
    {
        Task AddAsync(string formattedMessage);
    }
}
