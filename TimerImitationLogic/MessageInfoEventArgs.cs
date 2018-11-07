using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimerImitationLogic
{
    public class MessageInfoEventArgs : EventArgs
    {
        private string _message;

        public string Message { get => _message; }

        public MessageInfoEventArgs(string message)
        {
            _message = message;
        }
    }
}
