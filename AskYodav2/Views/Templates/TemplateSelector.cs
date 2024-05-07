using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AskYodav2.Model;

namespace AskYodav2.Views.Templates
{
    public class ChatMessageTemplateSelector : DataTemplateSelector
    {
        public DataTemplate? InboundTemplate { get; set; }
        public DataTemplate? OutboundTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return ((ChatMessage)item).MessageType == Enums.ChatMessageTypeEnum.Inbound ? InboundTemplate : OutboundTemplate;
        }
    }
}
