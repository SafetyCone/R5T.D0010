using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.D0010.Default
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="MessageFormatter"/> implementation of <see cref="IMessageFormatter"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddMessageFormatter(this IServiceCollection services)
        {
            services.AddSingleton<IMessageFormatter, MessageFormatter>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="MessageFormatter"/> implementation of <see cref="IMessageFormatter"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IMessageFormatter> AddMessageFormatterAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction<IMessageFormatter>.New(() => services.AddMessageFormatter());

            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="ConsoleFormattedMessageSink"/> implementation of <see cref="IFormattedMessageSink"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddConsoleFormattedMessageSink(this IServiceCollection services)
        {
            services.AddSingleton<IFormattedMessageSink, ConsoleFormattedMessageSink>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="ConsoleFormattedMessageSink"/> implementation of <see cref="IFormattedMessageSink"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IFormattedMessageSink> AddConsoleFormattedMessageSinkAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction<IFormattedMessageSink>.New(() => services.AddConsoleFormattedMessageSink());

            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="ConsoleMessageSink"/> implementation of <see cref="IMessageSink"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddConsoleMessageSink(this IServiceCollection services,
            IServiceAction<IMessageFormatter> messageFormatterAction)
        {
            services
                .AddSingleton<IMessageSink, ConsoleMessageSink>()
                .Run(messageFormatterAction)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="ConsoleMessageSink"/> implementation of <see cref="IMessageSink"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IMessageSink> AddConsoleMessageSinkAction(this IServiceCollection services,
            IServiceAction<IMessageFormatter> messageFormatterAction)
        {
            var serviceAction = ServiceAction<IMessageSink>.New(() => services.AddConsoleMessageSink(
                messageFormatterAction));

            return serviceAction;
        }

        public static (
            IServiceAction<IMessageSink> Main,
            IServiceAction<IMessageFormatter> MessageFormatterAction)
            AddConsoleMessageSinkAction(this IServiceCollection services)
        {
            // 0.
            var messageFormatterAction = services.AddMessageFormatterAction();

            // 1.
            var messageSinkAction = services.AddConsoleMessageSinkAction(
                messageFormatterAction);

            return (
                messageSinkAction,
                messageFormatterAction);
        }

        /// <summary>
        /// Adds the <see cref="InMemoryMessageRepository"/> implementation of <see cref="IMessageRepository"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddInMemoryMessageRepository(this IServiceCollection services)
        {
            services.AddSingleton<IMessageRepository, InMemoryMessageRepository>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="InMemoryMessageRepository"/> implementation of <see cref="IMessageRepository"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IMessageRepository> AddInMemoryMessageRepositoryAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction<IMessageRepository>.New(() => services.AddInMemoryMessageRepository());

            return serviceAction;
        }
    }
}
