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
        public List<Gamer> gamers;
        public Deck deck;
        public int deckSize;
        public int stepsPrediction;
        int lowestPrior;
        int count = 0;  // лічильник ходів
        bool gameEnded = false;
        Timer myTimer;
        List<Card> stepSet = new List<Card>();
        public Game (List <Gamer> _gamers, int _deckSize, int _stepsPrediction)
        {
            deckSize = _deckSize;
            int lowestPrior = deckSize == 36 ? 6 : 2;
            stepsPrediction = _stepsPrediction;
            deck = new Deck(deckSize);
            gamers = _gamers;
            deck.Shuffle();
        }
        public bool Step(int clientWidth, int clientHeight)
        {
            //foreach (Card card in gamers[0].Set)
            //{
            //    MessageBox.Show($"X: {card.Location.X}, Y: {card.Location.Y}");
            //}
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
                StepMove(stepSet, clientWidth, clientHeight);



                //Card MaxCard = GetCardWithHighestPrior(stepSet);
                //Card MinCard = GetCardWithLowestPrior(stepSet);
                //List<Card> sameCards = GetEqualCard(stepSet);

                //if (MinCard.Priority == lowestPrior && MaxCard.Priority == 14)
                //{
                //    Gamer stepWinner = gamers[stepSet.FindIndex(card => card == MinCard)];
                //    foreach (Card card in stepSet)
                //        stepWinner.Set.Insert(0, card);
                //    //EndMove(stepSet, clientWidth, clientHeight);
                //}
                //else if (sameCards.Count != 0 && sameCards.Contains(MaxCard))
                //{
                //    List<Gamer> warriors = GetUsersWithSameCards(gamers, sameCards.Max(), stepSet);
                //    War(warriors, stepSet, lowestPrior);
                //}
                //else
                //{
                //    Gamer stepWinner = gamers[stepSet.FindIndex(card => card == MaxCard)];
                //    foreach (Card card in stepSet)
                //        stepWinner.Set.Insert(0, card);

                //    //EndMove(stepSet, MaxCard, clientWidth, clientHeight);
                //}
            }
            else
            {
                RemoveEmptyPlayers(gamers);
            }
            return gameEnded;
            //return true;
        }

        private void StepMove(List<Card> cards, int clientWidth, int clientHeight)
        {
            myTimer = new Timer();
            myTimer.Interval = 7;

            foreach(Card card in cards)
            {
                myTimer.Tick += (object sender, EventArgs e) =>
                {
                    if (card.Location.Y > clientHeight / 2 - card.Height / 2)
                    {
                        card.Location = new Point(card.Location.X + 1, card.Location.Y - 2);
                    }
                    else if (card.Location.Y < clientHeight / 2 - card.Height / 2)
                    {
                        card.Location = new Point(card.Location.X - 1, card.Location.Y + 2);
                    }
                    //else if (card.Location.Y < (clientHeight + card.Height) / 2 + 10 && card.Location.Y > (clientHeight - card.Height) / 2 + 10)
                    else
                    {
                        myTimer.Stop();
                        EndMove(stepSet, GetCardWithHighestPrior(stepSet), clientWidth, clientHeight);

                    }
                };
            }
            myTimer.Start();
        }

        private void EndMove(List<Card> cards, Card maxCard, int clientWidth, int clientHeight)
        {
            myTimer = new Timer();
            myTimer.Interval = 14;
            int counter = 0;
            myTimer.Tick += (object sender, EventArgs e) =>
            {
                if (maxCard.Location.X < clientWidth / 2)
                {
                    foreach (Card card in cards)
                    {
                        if (card.Location.X < clientWidth / 2 - card.Width / 2)
                        {
                            card.Location = new Point(card.Location.X + 1, card.Location.Y - 2);
                        }
                        else if (card.Location.X > clientWidth / 2 - card.Width / 2)
                        {
                            card.Location = new Point(card.Location.X - 1, card.Location.Y - 2);
                        }
                        else
                        {
                            myTimer.Stop();
                        }
                    }

                }
                else
                {
                    //foreach (Card card in cards)
                    //{
                    //    //if (card.Location.X != clientWidth / 2 && card.Location.Y != clientHeight - card.Height - 10)

                    //    if (card.Location.X < clientWidth / 2)
                    //    {
                    //        //Console.WriteLine(card.Location.X.ToString());
                    //        card.Location = new Point(card.Location.X + 1, card.Location.Y + 2);
                    //    }
                    //    else if (card.Location.X > clientWidth / 2)
                    //    {
                    //        //Console.WriteLine(card.Location.X.ToString());
                    //        card.Location = new Point(card.Location.X - 1, card.Location.Y + 2);
                    //    }
                    //    else
                    //    {
                    //        myTimer.Stop();
                    //    }
                    //}
                    if (cards[0].Location.X > 375 && cards[0].Location.X < 400)
                    {
                        cards[0].Location = new Point(clientWidth / 2 - cards[0].Width / 2, clientHeight - Card.cardHeight - 10);
                        myTimer.Stop();
                    }
                    if (cards[0].Location.X < clientWidth / 2)
                    {
                        //Console.WriteLine(card.Location.X.ToString());
                        cards[0].Location = new Point(cards[0].Location.X + 1, cards[0].Location.Y + 2);
                    }
                    else if (cards[0].Location.X > clientWidth / 2)
                    {
                        //Console.WriteLine(card.Location.X.ToString());
                        cards[0].Location = new Point(cards[0].Location.X - 1, cards[0].Location.Y + 2);
                    }
                    else
                    {
                        myTimer.Stop();
                    }
                    //if (cards[1].Location.X < clientWidth / 2 - cards[1].Width / 2)
                    //{
                    //    //Console.WriteLine(card.Location.X.ToString());
                    //    cards[1].Location = new Point(cards[1].Location.X + 1, cards[1].Location.Y + 2);
                    //}
                    //else if (cards[1].Location.X > clientWidth / 2 - cards[1].Width / 2)
                    //{
                    //    //Console.WriteLine(card.Location.X.ToString());
                    //    cards[1].Location = new Point(cards[1].Location.X - 1, cards[1].Location.Y + 2);
                    //}
                    //else
                    //{
                    //    myTimer.Stop();
                    //}
                }
                //else
                //{
                //    myTimer.Stop();
                //}
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
                {
                    RemoveEmptyPlayers(gamers);
                }
            }
            if (!gameEnded)
                Console.WriteLine("Гра не закінчилась за {0}", stepsPrediction);
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
            {
                result *= i;
            }
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
                        {
                            equalsCards.Add(stepcards[i]);
                        }
                        else if (!equalsCards.Contains(stepcards[i]))
                        {
                            equalsCards.Add(stepcards[i]);
                        }
                        else
                        {
                            continue;
                        }
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
                        Console.WriteLine($"{warrior.Name} set count: {warrior.Set.Count}");
                        stepset.Add(warrior.GiveCard());
                    }
                }
                List<Card> lastCards = new List<Card>();
                for (int i = 1; i <= warriors.Count; ++i)
                {
                    lastCards.Add(stepset[stepset.Count - i]);
                }

                Card maxCard = lastCards.Max();
                Card minCard = lastCards.Min();
                List<Card> sameCards = GetEqualCard(lastCards);
                if (sameCards.Count != 0)
                {
                    Console.WriteLine("*** Second War **********************************");
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
    }
}
