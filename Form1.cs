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
        int counter;
        public Form1()
        {
            InitializeComponent();
            rules.Text = "lllalllalalallala";
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

        private void HandleCardsAmount()
        {
            nickname1.Text = $"Гравець {game.gamers[0].Name}: {game.gamers[0].Set.Count}";
            nickname2.Text = $"Гравець {game.gamers[1].Name}: {game.gamers[1].Set.Count}";
        }

        private void HandleStepBtn()
        {
            step.Enabled = true;
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
            step.Visible = false;
            step.Enabled = false;
        }

        private void TimerDistirbute_Tick(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                TimerDistirbute.Stop();
                game.deck.Distribute(game.gamers);  // роздаєм карти гравцям
                HandleCardsAmount();
                step.Visible = true;
                step.Enabled = true;
                return;
            }

            int coordTop = 10;                                     
            int coordBottom = this.ClientSize.Height - Card.cardHeight - 10;

            if (counter > game.deckSize/2)
            {
                Move((this.ClientSize.Width - Card.cardWidth) / 2, coordTop, game.deck[counter - 1]);
                --counter;
            }
            else
            {
                Move((this.ClientSize.Width - Card.cardWidth) / 2, coordBottom, game.deck[counter - 1]);
                --counter;
            }
        }

        private void Move(int x, int y , Card card)
        {
            Timer timerMove = new Timer();
            timerMove.Interval = 14;
            int diffY = y - card.Location.Y;
            timerMove.Tick += (object sender, EventArgs e) =>
            {
                if (card.Location.Y >= 10 && card.Location.Y <= this.ClientSize.Height - Card.cardHeight - 10)
                {
                    if (diffY > 0)
                        card.Location = new Point(x, card.Location.Y + 4);
                    else
                        card.Location = new Point(x, card.Location.Y - 4);
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
            game = new Game(new List<Gamer> { new Gamer(gamerNameInput1.Text), new Gamer(gamerNameInput2.Text) }, cards52.Checked ? 52 : 36, (int)predictionVal.Value);
            game.MyEvent += HandleCardsAmount;
            game.StepBtnEvent += HandleStepBtn;
            counter = game.deckSize;
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
            step.Enabled = false;
            if ( game.count < (int)predictionVal.Value)
            {
                foreach(Gamer g in game.gamers)
                {
                    for (int i = 0; i < g.Set.Count; i++)
                        Console.WriteLine($"{i}: X: {g.Set[i].Location.X}, Y: {g.Set[i].Location.Y}");
                        Console.WriteLine();
                }
               game.Step(this.ClientSize.Width, this.ClientSize.Height);
            }
            else
                MessageBox.Show("Гра не закінчилась за передбачену кількість кроків");
        }
        
    }
}
