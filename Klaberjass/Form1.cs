using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Klaberjass
{
    public partial class Form1 : Form
    {
        private CardHand hand;
        private Game klabberjassGame;
        public Form1()
        {
            InitializeComponent();
            hand = new CardHand(9);
            this.Controls.Add(hand);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (hand.hand[hand.hand.Length - 1] != 0)
                return;
            int c = klabberjassGame.deck.drawCard();
            hand.deal(c);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hand.play();
        }
    }
}
