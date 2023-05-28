using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrunkManGame
{
    public partial class Form1 : Form
    {
        

        int indexCard;
        Game game;
        
        int counter = 1;
        public Form1()
        {

            InitializeComponent();
            //WindowState = FormWindowState.Maximized;


            game = new Game(new List<Gamer> { new Gamer("Ostap"), new Gamer("Bohdan") }, 36);
            ShowDeck();
            indexCard = game.deck.deck.Count - 1;
            MessageBox.Show(indexCard.ToString());
            Card card = new Card("8","spades",8);
            Card.AddBackImage(card);
            Controls.Add(card);
            card.Left = (this.ClientSize.Width - card.Width) ;
            card.Top = (this.ClientSize.Height - card.Height) ;
            
            
        }


        public void ShowDeck()
        {
            foreach (Card card in game.deck)
            {
                Controls.Add(card);
                card.Left = (this.ClientSize.Width - card.Width) / 2;
                card.Top = (this.ClientSize.Height - card.Height) / 2;
                card.Anchor = AnchorStyles.None;
            }

        }

        private void btnDistribute_Click(object sender, EventArgs e)
        {
            TimerDistirbute.Enabled = true;
            TimerDistirbute.Start();
            timer2.Start();
           
        }

        private void TimerDistirbute_Tick(object sender, EventArgs e)
        {
            if (indexCard < 0)
            {
                TimerDistirbute.Stop();
                return;
            }
            int coordTop = (this.ClientSize.Width - Card.cardWidth);
            int coordBottom = (this.ClientSize.Height - Card.cardHeight);
           
            if (indexCard %2 == 0)
            {
                indexCard -= 1;
                //MessageBox.Show($"{game.deck[indexCard]} , {indexCard}");
                Move((this.ClientSize.Width - Card.cardWidth) / 2, coordTop, game.deck[indexCard]);
                

            }
            else
            {
                indexCard -= 1;
                //MessageBox.Show($"{game.deck[indexCard]} , {indexCard}");
                Move((this.ClientSize.Width - Card.cardWidth) / 2, coordBottom, game.deck[indexCard]);
               
            }

        }

        private void Move(int x, int y , Card card)
        {
            Timer timerMove = new Timer();
            timerMove.Interval = 1000;
            int diffY = y - card.Location.Y;
           
          
            timerMove.Tick += (object sender, EventArgs e) =>
            {
                while ( card.Location.Y != y)
                {
                    if (diffY > 0)
                    {
                        card.Location = new Point(x, diffY--);
                        MessageBox.Show(card.Location.ToString());
                        card.Update();
                    }

                    else
                    {
                        card.Location = new Point(x, diffY++);
                        MessageBox.Show(card.Location.ToString());
                        card.Update();
                    }


                }
            };
            timerMove.Start();

           




        }
    }
}
