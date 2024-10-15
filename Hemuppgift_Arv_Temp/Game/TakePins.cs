namespace Hemuppgift_Arv_Temp.Game
{
    public class TakePins
    {
        //Här är main klassen där koden ska testas, lägg in mappen
        static void Main(string[] args)
        {
            // Skapar ett Board-objekt med 10 stickor
            Board board = new Board();
            board.SetUp(10);

            // Skapar en mänsklig spelare och en datorspelare
            Player player1 = new HumanPlayer("Människospelare");
            //Player player2 = new ComputerPlayer("Dator");
            Player player3 = new AdvancedComputerPlayer("Avancerad Datorspelare");

            Player currentPlayer = player1;

            // loop för spelet 
            while (board.GetNoPins() > 0)
            {
               Console.WriteLine($"Antal stickor på bordet just nu: {board.GetNoPins()}");

                // Spelaren tar stickor
                int pinsTaken = currentPlayer.TakePins(board);
                board.TakePins(pinsTaken);

                // Kontrollera om någon har vunnit
                if (board.GetNoPins() == 0)
                {
                    Console.WriteLine($"Grattis! \n {currentPlayer.GetUserId()} vinner!");
                    break;
                }

                // Växla spelare
                currentPlayer = currentPlayer == player1 ? player3 : player1;
            }
        }
    }
}
        
    

   

