using System;

using R5T.Magyar.Extensions;

using TextStringBuilder = System.Text.StringBuilder;


namespace R5T.Piraeus.StringBuilder
{
    public class StringBuilderBasedCommandBuilder : ICommandBuilder
    {
        private TextStringBuilder StringBuilder { get; } = new TextStringBuilder();
        private string TokenSeparator { get; }
        

        public StringBuilderBasedCommandBuilder(string tokenSeparator = CommandTokenSeparator.DefaultValue)
        {
            this.TokenSeparator = tokenSeparator;
        }

        public void Append(string token)
        {
            var appendix = $"{token}{this.TokenSeparator}";

            this.StringBuilder.Append(appendix);
        }

        public string BuildCommand()
        {
            var command = this.StringBuilder.ToString().ExceptLast(this.TokenSeparator); // Build the string, then remove characters to allow multiple builds of the command.
            return command;
        }
    }
}
