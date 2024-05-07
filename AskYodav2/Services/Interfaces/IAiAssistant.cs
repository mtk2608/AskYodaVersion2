using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AskYodav2.Model;

namespace AskYodav2.Services.Interfaces
{
    public interface IAiAssistant
    {
        ChatMessage GetCompletion(IList<ChatMessage> chatInboundHistory, ChatMessage userMessage);
    }
}
