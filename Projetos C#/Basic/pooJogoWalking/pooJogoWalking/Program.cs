using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooJogoWalking
{
    public class Program
    {
        static void Main(string[] args)
        {

            Player P = new Player("P", "T");
            Scenario S = new Scenario("_", 60);
            ConsoleKey keys;

            S.Print(P);

            do {
                keys = Console.ReadKey().Key;

                switch (keys)
                {
                    case ConsoleKey.LeftArrow:
                        P.Walk(false, S.Size);
                        S.Print(P);
                        break;

                    case ConsoleKey.RightArrow:
                        P.Walk(true, S.Size);
                        S.Print(P);
                        break;

                    case ConsoleKey.UpArrow:
                        P.Jumping = true;
                        S.Print(P);
                        P.Jump();
                        P.Jumping = false;
                        S.Print(P);
                        break;

                    default:
                        S.Print(P);
                        break;
                }
            } while (keys != ConsoleKey.Escape);
        }
    }
}
