using System;
using System.Threading;

namespace TimerImitationLogic
{
    public class Timer 
    {
        private DateTime currentTime;

        public event EventHandler<MessageInfoEventArgs> NewMessage = delegate { };

        public Timer() { }

        public void StartWork(int waitingSeconds, string message)
        {
            Console.WriteLine($"The message will recived after {waitingSeconds} seconds.");

            currentTime = DateTime.Now;
            for (int i = 0; i < waitingSeconds; i++)
            {
                Thread.Sleep(1000);

                currentTime = currentTime.AddSeconds(-1);

                Console.WriteLine(currentTime);
            }

            OnNewMessage(new MessageInfoEventArgs(message));
        }       

        protected virtual void OnNewMessage(MessageInfoEventArgs e)
        {
            NewMessage?.Invoke(this, e);
        }        
    }
}
