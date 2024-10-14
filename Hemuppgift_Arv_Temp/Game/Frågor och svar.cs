using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    internal class Frågor_och_svar
    {


        // klassen player är subklass/superklass till klasserna humanplayer och computerplayer


        // Både Vilka av följande tilldelningssatser är korrekta?
        // Player p = new Player("Aegon");
        // player p = new HumanPlayer("Alicent");

        // av tilldelningssatserna skulle jag vilja säga att följande är korrekta med anledning av:

        //HumanPlayer p = new HumanPlayer("Rhaenyra"); Denna är korrekt då både instans och variabeltyp är av samma typ 
        // HumanPlayer p = new ComputerPlayer("Aemond"); Eftersom HumanPlayerär en underklass till Player kan man skapa en instans av
        // HumanPlayeroch tilldela den en variabel av typen Player. Detta fungerar eftersom en underklass kan refereras till genom och superklassreferens.

        //  Arv mellan Player, HumanPlayer, och ComputerPlayer hjälper oss att återanvända kod, minska duplicering, och underlätta hanteringen av de
        // En abstrakt metod är en metod utan implementation i basklassen som måste implementeras av alla underklasser. På det sättet kan underklasserna definiera egna villkor i underklasserna tex hur dragen ska ske



    }
}
