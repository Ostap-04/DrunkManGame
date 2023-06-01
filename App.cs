using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrunkManGame
{
    public partial class App : Form
    {
        Game game;
        int counter;
        SoundPlayer music = new SoundPlayer(@"..\..\music\music.wav");
        public App()
        {
            InitializeComponent();
            rules.Text = "Колоду перемішують, карти роздають порівну обом гравцям, які тримають карти стопкою сорочкою догори. \r\nХід гри: кожен гравець бере одну карту з верху своєї стопки і кладе на стіл лицем догори – це здача. Хто поклав найстаршу незалежно від масті карту, той забирає всю здачу і кладе її під низ своєї стопки. Якщо в здачі є більше ніж одна найстарша карта, наприклад, два королі, то між власниками цих карт виникає «війна»: вони повинні викласти по три карти, і переможе той, чия третя карта старша. Якщо в одній здачі є туз і наймолодша карта колоди (шістка чи двійка), то перемагає наймолодша.\r\n Гравець, який позбувся всіх карт, програє. Виграє той, хто забрав усі карти.\r\n";
            rules.Select(0,0);
            rules.SelectionAlignment = HorizontalAlignment.Center;
            music.Play();
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
            nickname1.Text += " " + gamerNameInput1.Text;
            nickname2.Text += " " + gamerNameInput2.Text;
            toggleState();
            btnDistribute.Enabled = true;
        }

        private void step_Click(object sender, EventArgs e)
        {
            step.Enabled = false;
            if (game.count < (int)predictionVal.Value)
            {
                game.Step(this.ClientSize.Width, this.ClientSize.Height);
            }
            else
            { 
                MessageBox.Show("Гра не закінчилась за передбачену кількість кроків", "Кінець!", MessageBoxButtons.OK);
                toggleState();
                EndSession();
            }
        }

        private void cards36_CheckedChanged(object sender, EventArgs e)
        {
            if (cards36.Checked == true) cards36.ForeColor = Color.DarkRed;
            else cards36.ForeColor = Color.White;
        }

        private void cards52_CheckedChanged(object sender, EventArgs e)
        {
            if (cards52.Checked == true) cards52.ForeColor = Color.DarkRed;
            else cards52.ForeColor = Color.White;
        }

        private void toggleState() 
        {
            btnDistribute.Visible = !btnDistribute.Visible;
            gameSettings.Visible = !gameSettings.Visible;
            rules.Visible = !rules.Visible;
            start.Visible = !start.Visible;
            gameTitle.Visible = !gameTitle.Visible;
            nickname1.Visible = !nickname1.Visible;
            nickname2.Visible = !nickname2.Visible;
            rulesText.Visible = !rulesText.Visible;
        }

        private void EndSession()
        {
            step.Visible = false;
            btnDistribute.Visible = false;
            for (int i = Controls.Count - 1; i >= 0; i--)
            {
                if (Controls[i] is Card)
                {
                    Controls.RemoveAt(i);
                }
            }
            nickname1.Text = "Гравець";
            nickname2.Text = "Гравець";
            gamerNameInput1.Text = "";
            gamerNameInput2.Text = "";
            cards36.Checked = false;
            cards52.Checked = false;
            predictionVal.Value = 0;
        }
    }
}
