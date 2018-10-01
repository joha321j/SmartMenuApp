using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FunctionLibrary;

namespace SmartMenuLibrary
{
    class Bindings
    {
        internal static void Call(string callId)
        {
            switch(callId)
            {
                case "linie1":
                    Console.WriteLine(Functions.DoThis());
                    break;
                case "linie2":
                    Console.WriteLine(Functions.DoThat());
                    break;
                case "linie3":
                    Console.WriteLine("Tell me what to do.");
                    string userInput = Console.ReadLine();
                    Console.WriteLine(Functions.DoSomething(userInput));
                    break;
                case "linie4":
                    Console.WriteLine(Functions.GetTheAnswerToLifeTheUniverseAndEverything());
                    break;
                default:
                    Console.WriteLine("This is the default switch");
                    break;
            }
        }
    }
}
