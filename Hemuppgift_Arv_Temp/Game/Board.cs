using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    internal class Board
    {
        // attribut, antal stickor på bord, privat för att skydda mot förändringar
        // utanför klassen, dvs inkapsling, 
        private int noPins; 

        // metod för att sätta startvärde likt en konstruktor 
        public void SetUp(int pins)
        {
            noPins = pins;
        }
        // publik metod och returnerar antal stickor på bord, 
        // pga noPins är privat måste denna metod användas
        // så den kan läsas av utanför klassen
        public int getNoPins()
        {
            return noPins;
        }

        // metod som villkorar dragen i spelet, 
        // skickar felmeddelande om man tar fel antal stickor eller om det inte finns tillräckligt många stickor kvar
        public void takePins(int pins)
        {
            if (pins < 1 || pins > 2)
            {
                throw new ArgumentException("Du kan bara ta 1 eller 2 stickor.");
            }
            if (noPins < pins)
            {
                throw new ArgumentException("Det finns inte tillräckligt med stickor kvar");
            }

            noPins -= pins;
        }
    }
}
