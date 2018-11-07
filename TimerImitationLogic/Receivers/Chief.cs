using System;

namespace TimerImitationLogic.Receivers
{
    public class Chief
    {
        public Chief() { }

        public Chief(Timer timer)
        {
            CheckData(timer);

            timer.NewMessage += GetMessage;
        }

        public void Subscribe(Timer timer)
        {
            CheckData(timer);

            timer.NewMessage += GetMessage;
        }

        public void UnSubscribe(Timer timer)
        {
            CheckData(timer);

            timer.NewMessage -= GetMessage;
        }

        private void GetMessage(object sender, MessageInfoEventArgs messageInfo)
        {
            if (ReferenceEquals(sender, null))
            {
                throw new ArgumentNullException($"The {nameof(sender)} can not be null.");
            }

            if (ReferenceEquals(messageInfo, null))
            {
                throw new ArgumentNullException($"The {nameof(messageInfo)} can not be null.");
            }

            Console.WriteLine("Chief has recived a new message" + messageInfo.Message);
        }

        private void CheckData(Timer timer)
        {
            if (ReferenceEquals(timer, null))
            {
                throw new ArgumentNullException($"The {nameof(timer)} can not be null.");
            }
        }
    }
}
