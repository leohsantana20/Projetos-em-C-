using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooJogoWalking
{
    public class Player
    {

        public Byte Position { set; get; }
        public String Appearence { set; get; }
        public String FacingRight { set; get; }
        public String FacingLeft { set; get; }
        public Boolean Jumping { set; get; }

        public Player(String rigth, String left)
        {
            Position = 0;
            FacingRight = rigth;
            FacingLeft = left;
            Appearence = FacingRight;
            Jumping = false;
        }

        public void Jump()
        {
            Console.Beep(234, 100);
        }

        public void Walk( Boolean Direction, Byte Limit)
        {
            if (Direction)
            {
                if (Position < Limit)
                {
                    Position++;
                    Appearence = FacingRight;
                }
            }
            else
            {
                if (Position > 0)
                {
                    Position--;
                    Appearence = FacingLeft;
                }
            }
        }
    }
}
