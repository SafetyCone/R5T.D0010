using System;
using System.IO;
using System.Threading.Tasks;

using R5T.Lombardy;
using R5T.Magyar.IO;

using R5T.T0064;


namespace R5T.D0010.Default
{
    /// <summary>
    /// * Manual construction intended (not DI).
    /// </summary>
    [ServiceImplementationMarker]
    public class FileFormattedMessageSink : IFormattedMessageSink, IServiceImplementation
    {
        private string MessagesOutputFilePath { get; }


        public FileFormattedMessageSink(
            [NotServiceComponent] string messagesOutputFilePath,
            IStringlyTypedPathOperator stringlyTypedPathOperator)
        {
            // Create the directory if it does not exist.
            var messagesOutputDirectoryPath = stringlyTypedPathOperator.GetDirectoryPathForFilePath(messagesOutputFilePath);

            DirectoryHelper.CreateDirectoryOkIfExists(messagesOutputDirectoryPath);

            // Delete the output file path, if it exists.
            FileHelper.DeleteOnlyIfExists(messagesOutputFilePath);

            this.MessagesOutputFilePath = messagesOutputFilePath;
        }

        public async Task AddAsync(string formattedMessage)
        {
            // Add to messages output file path sink.
            using (var file = File.AppendText(this.MessagesOutputFilePath))
            {
                await file.WriteLineAsync(formattedMessage);
            }
        }
    }
}
