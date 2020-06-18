using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using R5T.D0001;
using R5T.D0010;


namespace System.Linq
{
    public static class IEnumerableExtenstions
    {
        public static async Task<bool> SequenceEqualAsync<T>(this IEnumerable<T> x, IEnumerable<T> y, IEqualityComparer<T> equalityComparer, INowUtcProvider nowUtcProvider, IMessageSink messageSink, bool stopAtFirstElementDifference = true)
        {
            async Task MessageHandler(string message)
            {
                await messageSink.AddErrorMessageAsync(nowUtcProvider, message);
            }

            var result = await x.SequenceEqualAsync(y, equalityComparer, MessageHandler, stopAtFirstElementDifference);
            return result;
        }

        public static async Task<bool> SetEqualAsync<T>(this IEnumerable<T> x, IEnumerable<T> y, IEqualityComparer<T> equalityComparer, INowUtcProvider nowUtcProvider, IMessageSink messageSink)
        {
            async Task MessageHandler(string message)
            {
                await messageSink.AddErrorMessageAsync(nowUtcProvider, message);
            }

            var result = await x.SetEqualAsync(y, equalityComparer, MessageHandler);
            return result;
        }
    }
}
