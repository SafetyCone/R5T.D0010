using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0010
{
    [ServiceDefinitionMarker]
    public interface IMessageSinkProvider : IServiceDefinition
    {
        Task<IMessageSink> GetMessageSinkAsync();
    }
}
