using System;
using TimerImitationLogic;
using TimerImitationLogic.Receivers;

namespace TimerImitationConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer();

            Client client = new Client(timer);
            Chief chief = new Chief(timer);

            timer.StartWork(9, "Test1");

            client.UnSubscribe(timer);

            timer.StartWork(5, "Test2");

            Console.ReadLine();
        }
    }
}
