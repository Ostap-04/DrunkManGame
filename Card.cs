﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrunkManGame
{
    public class Card : IComparable
    {
        public string Value { get; set; }
        public string Suit { get; set; }
        public int Priority { get; set; }
        public bool IsBack { get; set; } = true;

        public Card(string value, string suit, int priority)
        {
            Value = value;
            Suit = suit;
            Priority = priority;
        }

        public Card(Card another)
        {
            Value = another.Value;
            Suit = another.Suit;
            Priority = another.Priority;
        }

        public static Dictionary<string, string> Suits = new Dictionary<string, string>()
        {
            { "spades", "♠" },
            { "clubs", "♣" },
            { "diamonds", "♦" },
            { "hearts", "♥" }
        };

        public static Dictionary<int, string> Values36 = new Dictionary<int, string>()
        {
            { 6, "6" },
            { 7, "7" },
            { 8, "8" },
            { 9, "9" },
            { 10, "10" },
            { 11, "J" },
            { 12, "Q" },
            { 13, "K" },
            { 14, "A" }
        };
        public static Dictionary<int, string> Values52 = new Dictionary<int, string>()
        {
            { 2, "2" },
            { 3, "3" },
            { 4, "4" },
            { 5, "5" },
            { 6, "6" },
            { 7, "7" },
            { 8, "8" },
            { 9, "9" },
            { 10, "10" },
            { 11, "J" },
            { 12, "Q" },
            { 13, "K" },
            { 14, "A" }
        };

        //public override string ToString()
        //{
        //    int sizeCol= 7;
        //    int sizeRow = 5;

        //    for (int i = 0; i < sizeRow; i++) {
        //        for (int j = 0; j < sizeCol; j++)
        //        {
        //            if (i == 0 && j == 0 || i == sizeRow - 1 && j == sizeCol - 1)
        //            {
        //                Console.Write(Value);
        //            }
        //            else if (i == 0 || i == sizeRow - 1)
        //            {
        //                if (j % 2 != 0)
        //                {
        //                    Console.Write(' ');
        //                }
        //                else if (j % 2 == 0)
        //                {
        //                    Console.Write("#");
        //                }    
        //            }
        //            else if (j == 0 || j == sizeCol - 1)
        //            {
        //                Console.Write("#");
        //            }
        //            else if (j == 3 && i == 2)
        //            {
        //                Console.Write(Suit);
        //            }
        //            else
        //            {
        //                Console.Write(" ");
        //            }
        //        }
        //        Console.WriteLine();
        //    }
        //    return "";
        //}

        public override string ToString()
        {
            return $"{Value} {Suit} {Priority}";
        }

        public int CompareTo(object obj)
        {
            return Priority.CompareTo((obj as Card).Priority);
        }
        public static bool operator ==(Card card1, Card card2)
        {
            return card1.Priority == card2.Priority;
        }
        public static bool operator !=(Card card1, Card card2)
        {
            return card1.Priority != card2.Priority;
        }

        public static Bitmap GetCardPicture(Card card)
        {
            if (card.IsBack)
                return Properties.Resources.Back;
            return Resources.cardPics[new KeyValuePair<string, string>(card.Value, card.Suit)];
        }

        public static Bitmap GetCardPicture(string val, string suit)
        {
            return Resources.cardPics[new KeyValuePair<string, string>(val, suit)];
        }
    }

}
