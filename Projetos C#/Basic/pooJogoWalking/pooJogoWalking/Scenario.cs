using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooJogoWalking
{
    public class Scenario
    {

        public String Floor { set; get; }
        public Byte Size { set; get; }

        public Scenario(string floor, byte size)
        {
            this.Floor = floor;
            this.Size = size;
        }

        public void Print(Player P)
        {
            Console.Clear();
            Console.WriteLine();

            //Primeira Linha
            if (P.Jumping)
            {
                for (Byte i = 0; i < P.Position; i++)
                {
                    Console.WriteLine(" ");
                }
                Console.WriteLine(P.Appearence);
            }
            else
            {
                Console.WriteLine();
            }

            //Segunda Linha
            for (Byte i = 0 ;i < P.Position; i++)
            {
                Console.WriteLine(Floor);
            }
            if (P.Jumping) Console.WriteLine(Floor);
            else Console.WriteLine(P.Appearence);

            for (Byte i = 0; i < (Size - P.Position); i++)
            {
                Console.WriteLine(Floor);
            }
        }
    }
}
