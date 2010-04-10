using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Klaberjass
{
    class Deck
    {
        private int decksize = 52;
        private bool[] cards;
        private int[] deck;
        private int decktop;
        private int rseed;

        public int seed
        {
            set { rseed = Math.Abs((int)(DateTime.Now.Ticks * (long)(value + 1))); }
        }

        public Deck()
        {
            rseed = 0;
            cards = new bool[decksize];
            for (int i = 0; i < decksize; i++)
                cards[i] = true;
            decktop = decksize;
            deck = new int[decksize];
            this.shuffle();
        }
        public Deck(bool[] moddeck)
        {
            rseed = 0;
            decktop = 0;
            cards = moddeck;
            for (int i = 0; i < decksize; i++)
                if (cards[i])
                    decktop++;
            deck = new int[decksize];
            this.shuffle();
        }

        public override string ToString()
        {
            string res = "";
            for (int i = 0; i < decksize; i++)
                if (cards[i])
                    res += (i + 1) + " ";
            return res;
        }

        public void shuffle()
        {
            if (rseed == 0)
                rseed = (int)DateTime.Now.Ticks;
            Random r = new Random(rseed);
            int left = decktop;
            while (left > 0)
            {
                int drawfrom = r.Next(left);
                int k = 0;
                for (int i = 0; i < decksize; i++)
                {
                    if (cards[i])
                    {
                        if (k == drawfrom)
                        {
                            deck[left - 1] = i + 1;
                            cards[i] = false;
                            break;
                        }
                        k++;
                    }
                }
                left--;
            }
        }

        public int drawCard()
        {
            if(decktop == 0)
                return -1;
            decktop--;
            return deck[decktop];
        }
    }
}
