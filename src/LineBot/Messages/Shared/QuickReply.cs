using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Line
{
    /// <summary>
    /// Quick reply for message.
    /// </summary>
    /// <seealso cref="Line.ISendMessage" />
    public sealed class QuickReply : ISendMessage
    {
        [JsonProperty("items")]
        [JsonConverter(typeof(EnumConverter<ActionType>))]
        private IAction[] Actions { get; set; }

        void ISendMessage.Validate()
        {
            throw new NotImplementedException();
        }
    }
}