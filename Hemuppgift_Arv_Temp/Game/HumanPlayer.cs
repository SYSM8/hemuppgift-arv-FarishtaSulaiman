using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    public class HumanPlayer : Player
    {
        // konstruktor från basklass
        public HumanPlayer(string UserId) : base(UserId) 
        {
            //skickats till basklass
        }

             // metod för att humanplayer ska ta stickor
            public override int TakePins(Board board)
        {
            int pins;
            Console.WriteLine($"{UserId}, hur många stickor vill du ta?, 1 eller 2");
        }
    }
}
