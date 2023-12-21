using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat_App.DataAccesL
{
    public class ChatMessages
    {
        public DateTime MessageTime { get; set; }
        public string MessageClient { get; set; }
        public string MessageText { get; set; }
    }
}
