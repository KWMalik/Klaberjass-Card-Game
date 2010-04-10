using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Resources;

namespace Klaberjass
{
    public partial class CardHand : UserControl
    {
        //dimensions of the card images.
        private Size cardsize;
        //the width the partial visible portian of cards that being overlapped
        private int partwidth;
        // the hand.
        public int[] hand;
        //the current size of the hand.
        private int hsize;
        //the index in the hand of the card selected.
        public int selected = -1;

        //creates a control to display a players hand.
        //param: maxhsize the maximum capacity of a hand.
        public CardHand(int maxhsize)
        {
            InitializeComponent();
            DoubleBuffered = true;
            hand = new int[maxhsize];
            for (int i = 0; i < hsize; i++)
            {
                hand[i] = 0;
            }
            hsize = 0;
            partwidth = 14;
            cardsize = new Size(72, 96);
            this.Size = new Size(cardsize.Width, cardsize.Height);
        }

        public Boolean deal(int card)
        {
            if (card <= 0)
                return false;
            if (hsize < hand.Length)
            {
                hand[hsize] = card;
                hsize++;
                this.Size = new Size(hsize * partwidth + cardsize.Width - partwidth, this.Size.Height);
                Invalidate();
                return true;
            }
            return false;
        }

        private void CardHand_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            ResourceManager manager = new ResourceManager("Klaberjass.Properties.Resources", GetType().Assembly);
            for (int i = 0; i < hsize; i++)
            {
                if (hand[i] > 0)
                {//Image.FromFile(imagepath + hand[i] + ".png")
                    Image image = (Image)manager.GetObject("c" + hand[i]);
                    g.DrawImage(image, new Point(i * partwidth, 0));
                }
            }
            if (selected >= 0)
            {
                int w = 0;
                if(selected == hsize - 1)
                    w = cardsize.Width;
                else
                    w = partwidth;
                Rectangle r = new Rectangle(selected * partwidth, 0, w, cardsize.Height);
                g.FillRectangle(new SolidBrush(Color.FromArgb(70,Color.Red)),r);
            }
        }

        private void CardHand_MouseDown(object sender, MouseEventArgs e)
        {
            selected = e.X / partwidth;
            if (selected >= hsize)
                selected = hsize - 1;
            Invalidate();
        }

        public int play()
        {
            if (selected < 0)
                return -1;
            int res = hand[selected];
            for (int i = selected; i < hsize - 1; i++)
            {
                hand[i] = hand[i + 1];
            }
            selected = -1;
            hand[hsize-1] = 0;
            hsize--;
            Invalidate();
            return res;
        }
    }
}
