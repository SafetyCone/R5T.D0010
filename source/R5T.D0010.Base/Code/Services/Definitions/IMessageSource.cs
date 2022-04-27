using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using R5T.T0001;
using R5T.T0064;


namespace R5T.D0010
{
    [ServiceDefinitionMarker]
    public interface IMessageSource : IServiceDefinition
    {
        Task<IEnumerable<Message>> GetAsync(Func<Message, bool> predicate);
    }
}
