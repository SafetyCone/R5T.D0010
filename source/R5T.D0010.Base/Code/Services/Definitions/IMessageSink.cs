using System;
using System.Threading.Tasks;

using R5T.T0001;
using R5T.T0064;


namespace R5T.D0010
{
    [ServiceDefinitionMarker]
    public interface IMessageSink : IServiceDefinition
    {
        Task AddAsync(Message message);
    }
}
