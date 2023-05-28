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
        Game game;
        int counter = 1;
        public Form1()
        {
            InitializeComponent();
            rules.Text = "lllalllalalallala";
            game = new Game(new List<Gamer> { new Gamer(gamerNameInput1.Text), new Gamer(gamerNameInput2.Text) }, cards36.Checked ? 36 : 52, (int)predictionVal.Value);
        }

        public void ShowDeck()
        {
            foreach (Card card in game.deck)
            {
                Controls.Add(card);
                card.Left = (this.ClientSize.Width - card.Width) / 2;
                card.Top = (this.ClientSize.Height - card.Height) / 2;
                card.Anchor = AnchorStyles.None;
                card.BringToFront();
            }
        }

        private void btnDistribute_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            TimerDistirbute.Enabled = true;
            TimerDistirbute.Start();
            btnDistribute.Visible = false;
            btnDistribute.Enabled = false;
            step.Visible = true;
            step.Enabled = true;
        }

        private void TimerDistirbute_Tick(object sender, EventArgs e)
        {
            if (counter == 53)
            {
                TimerDistirbute.Stop();
                game.deck.Distribute(game.gamers);  // роздаєм карти гравцям
                return;
            }

            int coordTop = 10;                                     
            int coordBottom = this.ClientSize.Height - Card.cardHeight - 10;

            if (counter <= 26 )
            {
                Move((this.ClientSize.Width - Card.cardWidth) / 2, coordTop, game.deck[counter - 1]);
                ++counter;
            }
            else
            {
                Move((this.ClientSize.Width - Card.cardWidth) / 2, coordBottom, game.deck[counter - 1]);
                ++counter;
            }
        }

        private void Move(int x, int y , Card card)
        {
            Timer timerMove = new Timer();
            timerMove.Interval = 14;
            int diffY = y - card.Location.Y;
            timerMove.Tick += (object sender, EventArgs e) =>
            {
                if (card.Location.Y >= 50 && card.Location.Y <= this.ClientSize.Height - Card.cardHeight - 50)
                {
                    if (diffY > 0)
                        card.Location = new Point(x, card.Location.Y + 10);
                    else
                        card.Location = new Point(x, card.Location.Y - 10);
                }
                else
                {
                    timerMove.Stop();
                }
            };
            timerMove.Start();
        }

        private void start_Click(object sender, EventArgs e)
        {
            ShowDeck();
            btnDistribute.Visible = true;
            gameSettings.Visible = false;
            rules.Visible = false;
            start.Visible = false;
            gameTitle.Visible = false;
            nickname1.Visible = true;
            nickname2.Visible = true;
            nickname1.Text += " " + gamerNameInput1.Text;
            nickname2.Text += " " + gamerNameInput2.Text;
        }

        private void step_Click(object sender, EventArgs e)
        {
           game.Step(this.ClientSize.Width, this.ClientSize.Height);
        }
    }
}
