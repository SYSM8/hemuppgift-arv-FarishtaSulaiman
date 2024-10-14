using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    public class AdvancedComputerPlayer : Player
    {
        public AdvancedComputerPlayer(string Userid) : base(Userid)
        {

        }


        // skapar ny avancerad datorspelare som alltid tar två stickor när det är möjligt. 
        public override int TakePins(Board board)
        {
            int pins = board.GetNoPins() >= 2 ? 2 : 1;
            Console.WriteLine($"{UserId} tar {pins} stickor.");
            return pins;
        }
    }
}
