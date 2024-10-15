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
            int remainingPins = board.GetNoPins();
            int pinsToTake = 0;

            Console.WriteLine($"Det är {UserId}s tur.");

            // While-loop 
            while (true)
            {
                Console.Write("Hur många stickor vill du ta (1 eller 2)? ");
                string input = Console.ReadLine();

                // Försök att konvertera input till ett heltal
                bool validInput = int.TryParse(input, out pinsToTake);

                // Kolla om input är giltig
                if (validInput && pinsToTake >= 1 && pinsToTake <= 2 && pinsToTake <= remainingPins)
                {
                    // Om input är giltig, bryt ur loopen
                    break;
                }
                else
                {
                    // Om det är ogiltig input, visa ett felmeddelande
                    Console.WriteLine($"Felaktig inmatning! Du måste ta 1 eller 2 stickor och inte mer än vad som finns kvar ({remainingPins} stickor). Försök igen.");
                }
            }

            return pinsToTake;
        }
    }
}
    

