using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DrunkManGame
{
   
    public class Game
    {
        public event Action MyEvent;
        public event Action StepBtnEvent;

        public List<Gamer> gamers;
        public Deck deck;
        public int deckSize;
        public int stepsPrediction;
        int lowestPrior;
        bool gameEnded = false;
        public int count = 0;
        Timer myTimer;
        List<Card> stepSet = new List<Card>();
        int ClientWidthMain;
        int ClientHeightMain;
        int WarCounter = 1;

        public Game (List <Gamer> _gamers, int _deckSize, int _stepsPrediction)
        {
            deckSize = _deckSize;
            lowestPrior = deckSize == 36 ? 6 : 2;
            stepsPrediction = _stepsPrediction;
            deck = new Deck(deckSize);
            gamers = _gamers;
            deck.Shuffle();
        }
        public bool Step(int clientWidth, int clientHeight)
        {
            ClientWidthMain = clientWidth;
            ClientHeightMain = clientHeight;
            count++;
            if (gamers.Count == 1)
            {
                Console.WriteLine($"Winner: {gamers[0].Name}");
                gameEnded = true;
            }
            if (PlayersNotEmpty(gamers) && gamers.Count > 1)
            {
                stepSet.Clear();
                foreach (Gamer gamer in gamers)
                {
                    Card tempCard = gamer.GiveCard();
                    Card.AddBackImage(tempCard);
                    stepSet.Add(tempCard);
                }
                Card MaxCard = GetCardWithHighestPrior(stepSet);
                Card MinCard = GetCardWithLowestPrior(stepSet);
                List<Card> sameCards = GetEqualCard(stepSet);

                MyEvent.Invoke();

                if (MinCard.Priority == lowestPrior && MaxCard.Priority == 14)
                {
                    Gamer stepWinner = gamers[stepSet.FindIndex(card => card == MinCard)];
                    foreach (Card card in stepSet)
                        stepWinner.Set.Insert(0, card);
                    StepMove(stepSet, MinCard, clientWidth, clientHeight);
                }
                else if (sameCards.Count != 0 && sameCards.Contains(MaxCard))
                {
                    List<Gamer> warriors = GetUsersWithSameCards(gamers, sameCards.Max(), stepSet);
                    War(warriors, stepSet, lowestPrior);
                }
                else
                {
                    Gamer stepWinner = gamers[stepSet.FindIndex(card => card == MaxCard)];
                    foreach (Card card in stepSet)
                        stepWinner.Set.Insert(0, card);
                    StepMove(stepSet, MaxCard, clientWidth, clientHeight);
                }
            }
            else
                RemoveEmptyPlayers(gamers);
            
            return gameEnded;
        }

        private void StepMove(List<Card> cards, Card maxCard, int clientWidth, int clientHeight)
        {
            myTimer = new Timer();
            myTimer.Interval = 7;

            foreach(Card card in cards)
            {
                card.BringToFront();
                myTimer.Tick += (object sender, EventArgs e) =>
                {
                    if (card.Location.Y > clientHeight / 2 - card.Height / 2)
                        card.Location = new Point(card.Location.X + 1, card.Location.Y - 2);
                    else if (card.Location.Y < clientHeight / 2 - card.Height / 2)
                        card.Location = new Point(card.Location.X - 1, card.Location.Y + 2);
                    else
                    {
                        myTimer.Stop();
                        EndMove(stepSet, maxCard, clientWidth, clientHeight);
                    }
                };
            }
            myTimer.Start();
        }

        private void WarMove(List<Card> cards, int clientWidth, int clientHeight)
        {
            myTimer = new Timer();
            myTimer.Interval = 7;

            foreach (Card card in cards)
            {
                myTimer.Tick += (object sender, EventArgs e) =>
                {
                    if (card.Location.Y > clientHeight / 2 - card.Height / 2)
                        card.Location = new Point(card.Location.X + 1, card.Location.Y - 2);
                    else if (card.Location.Y < clientHeight / 2 - card.Height / 2)
                        card.Location = new Point(card.Location.X - 1, card.Location.Y + 2);
                    else
                    {
                        myTimer.Stop();
                        CardMove(new List<Card>() { stepSet[2*WarCounter], stepSet[3*WarCounter] }, clientWidth, clientHeight, true) ;
                    }
                };
            }
            myTimer.Start();
        }

        private void CardMove(List<Card> cards, int clientWidth, int clientHeight, bool end)
        {
            myTimer = new Timer();
            myTimer.Interval = 7;

            foreach (Card card in cards)
            {
                card.BringToFront();
                myTimer.Tick += (object sender, EventArgs e) =>
                {
                    if (card.Location.Y > clientHeight / 2 - card.Height / 2)
                        card.Location = new Point(card.Location.X + 1, card.Location.Y - 2);
                    else if (card.Location.Y < clientHeight / 2 - card.Height / 2)
                        card.Location = new Point(card.Location.X - 1, card.Location.Y + 2);
                    else
                    {
                        myTimer.Stop();
                        if (end)
                            CardMove(new List<Card>() { stepSet[4 * WarCounter], stepSet[5 * WarCounter] }, clientWidth, clientHeight, false);
                        else
                        {
                            Card maxCard = stepSet.GetRange(6, 2).Max();
                            Card minCard = stepSet.GetRange(6, 2).Min();
                            if (minCard.Priority == lowestPrior && maxCard.Priority == 14)
                                StepMove(new List<Card>() { stepSet[6 * WarCounter], stepSet[7 * WarCounter] }, minCard, clientWidth, clientHeight);
                            else
                                StepMove(new List<Card>() { stepSet[6 * WarCounter], stepSet[7 * WarCounter] }, maxCard, clientWidth, clientHeight);
                        }
                    }
                };
            }
            myTimer.Start();
        }

        private void EndMove(List<Card> cards, Card maxCard, int clientWidth, int clientHeight)
        {
            myTimer = new Timer();
            //myTimer.Interval = 500; якщо треба затормозити 
            int counter = 0;
            
            myTimer.Tick += (object sender, EventArgs e) =>
            {
                myTimer.Interval = 14;
                foreach (Card card in cards)
                {
                    card.SendToBack();
                    card.IsBack = true;
                    Card.AddBackImage(card);
                }
                if (maxCard.Location.X < clientWidth /2 - maxCard.Width/2)
                {
                    foreach (Card card in cards)
                    {
                        if (card.Location.X < clientWidth / 2 - card.Width / 2)
                            card.Location = new Point(card.Location.X + 1, card.Location.Y - 2);
                        else if (card.Location.X > clientWidth / 2 - card.Width / 2)
                            card.Location = new Point(card.Location.X - 1, card.Location.Y - 2);
                        else
                        {
                            MyEvent.Invoke();
                            StepBtnEvent.Invoke();
                            ChangeLocation();
                            myTimer.Stop();
                        }
                    }
                }
                else
                {
                    foreach (Card card in cards)
                    {
                        if (card.Location.X < clientWidth / 2 - card.Width / 2)
                            card.Location = new Point(card.Location.X + 1, card.Location.Y + 2);
                        else if (card.Location.X > clientWidth / 2 - card.Width / 2)
                            card.Location = new Point(card.Location.X - 1, card.Location.Y + 2);
                        else
                        {
                            MyEvent.Invoke();
                            StepBtnEvent.Invoke();
                            ChangeLocation();
                            myTimer.Stop();
                        }
                    }
                }
            };
            myTimer.Start();
        }

        public void StartGame()
        {
            while (count < stepsPrediction)
            {
                count++;
                if (gamers.Count == 1)
                {
                    Console.WriteLine($"Winner: {gamers[0].Name}");
                    gameEnded = true;
                    break;
                }
                if (PlayersNotEmpty(gamers) && gamers.Count > 1)
                {
                    stepSet.Clear();
                    foreach (Gamer gamer in gamers)
                        stepSet.Add(gamer.GiveCard());

                    Card MaxCard = GetCardWithHighestPrior(stepSet);
                    Card MinCard = GetCardWithLowestPrior(stepSet);
                    List<Card> sameCards = GetEqualCard(stepSet);

                    if (MinCard.Priority == lowestPrior && MaxCard.Priority == 14)
                    {
                        Gamer stepWinner = gamers[stepSet.FindIndex(card => card == MinCard)];
                        foreach (Card card in stepSet)
                            stepWinner.Set.Insert(0, card);
                    }
                    else if (sameCards.Count != 0 && sameCards.Contains(MaxCard))
                    {
                        List<Gamer> warriors = GetUsersWithSameCards(gamers, sameCards.Max(), stepSet);
                        War(warriors, stepSet, lowestPrior);
                    }
                    else
                    {
                        Gamer stepWinner = gamers[stepSet.FindIndex(card => card == MaxCard)];
                        foreach (Card card in stepSet)
                            stepWinner.Set.Insert(0, card);
                    }
                }
                else
                    RemoveEmptyPlayers(gamers);
            }
            if (!gameEnded)
                Console.WriteLine("Гра не закінчилась за {0}", stepsPrediction); // to change bool flag
        }

        private bool PlayersNotEmpty(List<Gamer> gamers)
        {
            return gamers.All(gamer => gamer.Set.Count > 0);
        }

        private void RemoveEmptyPlayers(List<Gamer> gamers)
        {
            for (int i = 0; i < gamers.Count; i++)
            {
                if (gamers[i].Set.Count == 0)
                {
                    gamers.RemoveAt(i);
                    i--;
                }

            }
        }

        private int Factorial(int n)
        {
            int result = 1;
            for (int i = n; i > 0; i--)
                result *= i;
            return result;
        }

        private List<Card> GetEqualCard(List<Card> stepcards)
        {
            List<Card> equalsCards = new List<Card>();
            int count = stepcards.Count;
            int checkCount = Factorial(count) / Factorial(2) * Factorial(count - 2);
            int iterCount = 0;
            for (int i = 0; i < count; i++)   // ідем по картах
            {
                for (int j = count - 1; j > i; j--)  // порівнюєм поточну з усіма наступними
                {
                    iterCount++;
                    if (stepcards[i] == stepcards[j])
                    {
                        if (equalsCards.Count == 0)
                            equalsCards.Add(stepcards[i]);
                        else if (!equalsCards.Contains(stepcards[i]))
                            equalsCards.Add(stepcards[i]);
                        else
                            continue;
                    }
                }
            }
            return equalsCards;
        }

        private List<Gamer> GetUsersWithSameCards(List<Gamer> gamers, Card card, List<Card> stepCards)
        {
            List<Gamer> resList = new List<Gamer>();
            for (int i = 0; i < stepCards.Count; i++)
            {
                if (stepCards[i] == card)
                    resList.Add(gamers[i]);
            }
            return resList;
        }
        private Card GetCardWithLowestPrior(List<Card> cards) => cards.Min();

        private Card GetCardWithHighestPrior(List<Card> cards) => cards.Max();

        private void War(List<Gamer> warriors, List<Card> stepset, int lowestPrior)
        {
            while (true)
            {
                for (int i = 0; i < warriors.Count; ++i)
                {
                    if (warriors[i].Set.Count < 3)
                    {
                        stepset.AddRange(warriors[i].GiveAllCards());
                        warriors.Remove(warriors[i]);
                    }
                }
                if (warriors.Count == 1)
                {
                    warriors[0].Set.AddRange(stepset);
                    break;
                }
                for (int i = 0; i < 3; ++i)
                {
                    foreach (var warrior in warriors)
                    {
                        stepset.Add(warrior.GiveCard());
                    }  
                }
                MyEvent.Invoke();
                WarMove(stepset.GetRange(0, 2), ClientWidthMain, ClientHeightMain);

                List<Card> lastCards = new List<Card>();
                for (int i = gamers.Count; i > 0; --i)
                    lastCards.Add(stepset[stepset.Count - i]);

                Card maxCard = lastCards.Max();
                Card minCard = lastCards.Min();
                List<Card> sameCards = GetEqualCard(lastCards);
                if (sameCards.Count != 0)
                {
                    WarCounter++;
                    continue;
                }

                if (minCard.Priority == lowestPrior && maxCard.Priority == 14)
                {
                    Gamer warWinner = warriors[lastCards.FindIndex(card => card == minCard)];
                    foreach (Card card in stepset)
                        warWinner.Set.Insert(0, card);
                    break;
                }
                else
                {
                    Gamer stepWinner = warriors[lastCards.FindIndex(card => card == maxCard)];
                    foreach (Card card in stepset)
                        stepWinner.Set.Insert(0, card);
                    break;
                }
            }
        }

        public void ChangeLocation()
        {
            foreach(Card card in gamers[0].Set)
                card.Location = new Point(card.Location.X, gamers[0].Set[gamers[0].Set.Count - 1].Location.Y);
            foreach (Card card in gamers[1].Set)
                card.Location = new Point(card.Location.X, gamers[1].Set[gamers[1].Set.Count - 1].Location.Y);
        }
    }
}
