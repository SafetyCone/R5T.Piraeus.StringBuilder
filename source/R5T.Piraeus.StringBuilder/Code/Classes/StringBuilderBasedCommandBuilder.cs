using System;

using TextStringBuilder = System.Text.StringBuilder;


namespace R5T.Piraeus.StringBuilder
{
    public class StringBuilderBasedCommandBuilder : ICommandBuilder
    {
        private TextStringBuilder StringBuilder { get; } = new TextStringBuilder();
        

        public void Append(string token)
        {
            this.StringBuilder.Append(token);
        }

        public string BuildCommand()
        {
            var command = this.StringBuilder.ToString();
            return command;
        }
    }
}
