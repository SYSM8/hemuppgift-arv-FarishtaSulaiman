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
        
    }
}
