using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0010
{
    [ServiceDefinitionMarker]
    public interface IFormattedMessageSink : IServiceDefinition
    {
        Task AddAsync(string formattedMessage);
    }
}
