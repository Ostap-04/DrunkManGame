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
        Card card = new Card(Card.Values52[6], Card.Suits["spades"], 6);
        Timer myTimer = new Timer();
        int counter = 1;
        Game game;

        public Form1()
        {
            InitializeComponent();
            game = new Game(new List<Gamer> { new Gamer("Ostap"), new Gamer("Bohdan") },36);
            ShowDeck();
        }


        public void ShowDeck()
        {
            foreach (Card card in game.deck)
            {
                Controls.Add(card);
               
                card.Location = new Point(ClientSize.Width/2, ClientSize.Height/2);
                

            }
        }

    }
}
