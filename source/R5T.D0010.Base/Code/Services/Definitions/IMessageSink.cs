using System;
using System.Threading.Tasks;

using R5T.T0001;


namespace R5T.D0010
{
    public interface IMessageSink
    {
        Task AddMessageAsync(Message message);
    }
}
