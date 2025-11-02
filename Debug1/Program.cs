// Debuging 
/* 
This code uses a names array and corresponding methods to display
greeting messages
*/
using System;
namespace Debuging1
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] names = new string[] { "Sophia", "Andrew", "AllGreetings" };

            string messageText = "";

            foreach (string name in names)
            {
                if (name == "Sophia")
                    messageText = SophiaMessage();
                else if (name == "Andrew")
                    messageText = AndrewMessage();
                else if (name == "AllGreetings")
                    messageText = SophiaMessage() + "\n\r" + AndrewMessage();
                Console.WriteLine(messageText);
            }

            bool pauseCode = true;
            while (pauseCode == true) ;

            static string SophiaMessage()
            {
                return "Hello, my name is Sophia.";
            }

            static string AndrewMessage()
            {
                return "Hi, my name is Andrew. Good to meet you.";
            }
        }
    }
}