using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Klaberjass
{
    class Game
    {
        public Deck deck;
        public Game()
        {

            //initialize deck to 32 card deck of all cards from A, K to 7
            bool[] b = new bool[52];    //
            int i;                      //
            for (i = 1; i <= 32; i++)   //
                b[i - 1] = true;        //
            for (; i <= 52; i++)        //
                b[i - 1] = false;       //

            deck = new Deck(b);         //
            
            //create player 1 and 2
        }

        //game creator is player 1 usually human.

        //player 2 is set to another client either networked or AI.


    }


}
