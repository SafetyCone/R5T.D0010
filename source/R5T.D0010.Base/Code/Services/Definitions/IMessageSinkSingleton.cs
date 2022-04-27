using System;

using R5T.T0064;


namespace R5T.D0010
{
    [ServiceDefinitionMarker]
    public interface IMessageSinkSingleton : IMessageSink, IServiceDefinition
    {
    }
}
