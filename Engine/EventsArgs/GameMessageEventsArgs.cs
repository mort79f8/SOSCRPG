using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.EventsArgs
{
    public class GameMessageEventsArgs : System.EventArgs
    {
        public string Message { get; private set; }

        public GameMessageEventsArgs(string message)
        {
            Message = message;
        }
    }
}
