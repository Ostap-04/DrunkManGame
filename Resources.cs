using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrunkManGame
{
    internal static class Resources
    {
        internal static Dictionary<KeyValuePair<string, string>, Bitmap> cardPics = new Dictionary<KeyValuePair<string, string>, Bitmap>() {
            {new KeyValuePair<string, string>(Card.Values52[2], Card.Suits["spades"]), Properties.Resources._2_of_spades},
            {new KeyValuePair<string, string>(Card.Values52[3], Card.Suits["spades"]), Properties.Resources._3_of_spades},
            {new KeyValuePair<string, string>(Card.Values52[4], Card.Suits["spades"]), Properties.Resources._4_of_spades},
            {new KeyValuePair<string, string>(Card.Values52[5], Card.Suits["spades"]), Properties.Resources._5_of_spades},

            {new KeyValuePair<string, string>(Card.Values52[6], Card.Suits["spades"]), Properties.Resources._6_of_spades},
            {new KeyValuePair<string, string>(Card.Values52[7], Card.Suits["spades"]), Properties.Resources._7_of_spades},
            {new KeyValuePair<string, string>(Card.Values52[8], Card.Suits["spades"]), Properties.Resources._8_of_spades},
            {new KeyValuePair<string, string>(Card.Values52[9], Card.Suits["spades"]), Properties.Resources._9_of_spades},
            {new KeyValuePair<string, string>(Card.Values52[10], Card.Suits["spades"]), Properties.Resources._10_of_spades},
            {new KeyValuePair<string, string>(Card.Values52[11], Card.Suits["spades"]), Properties.Resources.jack_of_spades},
            {new KeyValuePair<string, string>(Card.Values52[12], Card.Suits["spades"]), Properties.Resources.queen_of_spades},
            {new KeyValuePair<string, string>(Card.Values52[13], Card.Suits["spades"]), Properties.Resources.king_of_spades},
            {new KeyValuePair<string, string>(Card.Values52[14], Card.Suits["spades"]), Properties.Resources.ace_of_spades},
            
            {new KeyValuePair<string, string>(Card.Values52[2], Card.Suits["hearts"]), Properties.Resources._2_of_hearts},
            {new KeyValuePair<string, string>(Card.Values52[3], Card.Suits["hearts"]), Properties.Resources._3_of_hearts},
            {new KeyValuePair<string, string>(Card.Values52[4], Card.Suits["hearts"]), Properties.Resources._4_of_hearts},
            {new KeyValuePair<string, string>(Card.Values52[5], Card.Suits["hearts"]), Properties.Resources._5_of_hearts},
            
            {new KeyValuePair<string, string>(Card.Values52[6], Card.Suits["hearts"]), Properties.Resources._6_of_hearts},
            {new KeyValuePair<string, string>(Card.Values52[7], Card.Suits["hearts"]), Properties.Resources._7_of_hearts},
            {new KeyValuePair<string, string>(Card.Values52[8], Card.Suits["hearts"]), Properties.Resources._8_of_hearts},
            {new KeyValuePair<string, string>(Card.Values52[9], Card.Suits["hearts"]), Properties.Resources._9_of_hearts},
            {new KeyValuePair<string, string>(Card.Values52[10], Card.Suits["hearts"]), Properties.Resources._10_of_hearts},
            {new KeyValuePair<string, string>(Card.Values52[11], Card.Suits["hearts"]), Properties.Resources.jack_of_hearts},
            {new KeyValuePair<string, string>(Card.Values52[12], Card.Suits["hearts"]), Properties.Resources.queen_of_hearts},
            {new KeyValuePair<string, string>(Card.Values52[13], Card.Suits["hearts"]), Properties.Resources.king_of_hearts},
            {new KeyValuePair<string, string>(Card.Values52[14], Card.Suits["hearts"]), Properties.Resources.ace_of_hearts},
            
            {new KeyValuePair<string, string>(Card.Values52[2], Card.Suits["diamonds"]), Properties.Resources._2_of_diamonds},
            {new KeyValuePair<string, string>(Card.Values52[3], Card.Suits["diamonds"]), Properties.Resources._3_of_diamonds},
            {new KeyValuePair<string, string>(Card.Values52[4], Card.Suits["diamonds"]), Properties.Resources._4_of_diamonds},
            {new KeyValuePair<string, string>(Card.Values52[5], Card.Suits["diamonds"]), Properties.Resources._5_of_diamonds},

            {new KeyValuePair<string, string>(Card.Values52[6], Card.Suits["diamonds"]), Properties.Resources._6_of_diamonds},
            {new KeyValuePair<string, string>(Card.Values52[7], Card.Suits["diamonds"]), Properties.Resources._7_of_diamonds},
            {new KeyValuePair<string, string>(Card.Values52[8], Card.Suits["diamonds"]), Properties.Resources._8_of_diamonds},
            {new KeyValuePair<string, string>(Card.Values52[9], Card.Suits["diamonds"]), Properties.Resources._9_of_diamonds},
            {new KeyValuePair<string, string>(Card.Values52[10], Card.Suits["diamonds"]), Properties.Resources._10_of_diamonds },
            {new KeyValuePair<string, string>(Card.Values52[11], Card.Suits["diamonds"]), Properties.Resources.jack_of_diamonds },
            {new KeyValuePair<string, string>(Card.Values52[12], Card.Suits["diamonds"]), Properties.Resources.queen_of_diamonds },
            {new KeyValuePair<string, string>(Card.Values52[13], Card.Suits["diamonds"]), Properties.Resources.king_of_diamonds },
            {new KeyValuePair<string, string>(Card.Values52[14], Card.Suits["diamonds"]), Properties.Resources.ace_of_diamonds },
            
            {new KeyValuePair<string, string>(Card.Values52[2], Card.Suits["clubs"]), Properties.Resources._2_of_clubs},
            {new KeyValuePair<string, string>(Card.Values52[3], Card.Suits["clubs"]), Properties.Resources._3_of_clubs},
            {new KeyValuePair<string, string>(Card.Values52[4], Card.Suits["clubs"]), Properties.Resources._4_of_clubs},
            {new KeyValuePair<string, string>(Card.Values52[5], Card.Suits["clubs"]), Properties.Resources._5_of_clubs},

            {new KeyValuePair<string, string>(Card.Values52[6], Card.Suits["clubs"]), Properties.Resources._6_of_clubs},
            {new KeyValuePair<string, string>(Card.Values52[7], Card.Suits["clubs"]), Properties.Resources._7_of_clubs},
            {new KeyValuePair<string, string>(Card.Values52[8], Card.Suits["clubs"]), Properties.Resources._8_of_clubs},
            {new KeyValuePair<string, string>(Card.Values52[9], Card.Suits["clubs"]), Properties.Resources._9_of_clubs},
            {new KeyValuePair<string, string>(Card.Values52[10], Card.Suits["clubs"]), Properties.Resources._10_of_clubs },
            {new KeyValuePair<string, string>(Card.Values52[11], Card.Suits["clubs"]), Properties.Resources.jack_of_clubs },
            {new KeyValuePair<string, string>(Card.Values52[12], Card.Suits["clubs"]), Properties.Resources.queen_of_clubs },
            {new KeyValuePair<string, string>(Card.Values52[13], Card.Suits["clubs"]), Properties.Resources.king_of_clubs },
            {new KeyValuePair<string, string>(Card.Values52[14], Card.Suits["clubs"]), Properties.Resources.ace_of_clubs }
        };

        //public static void InitializeDictionary()
        //{
        //    cardPics = new Dictionary<KeyValuePair<string, string>, Bitmap>();
        //    cardPics.Add(new KeyValuePair<string, string>(Card.Values52[2], Card.Suits["spades"]), Properties.Resources._2_of_spades);
        //    cardPics.Add(new KeyValuePair<string, string>(Card.Values52[3], Card.Suits["spades"]), Properties.Resources._3_of_spades);
        //    cardPics.Add(new KeyValuePair<string, string>(Card.Values52[4], Card.Suits["spades"]), Properties.Resources._4_of_spades);
        //    cardPics.Add(new KeyValuePair<string, string>(Card.Values52[5], Card.Suits["spades"]), Properties.Resources._5_of_spades);

        //    cardPics.Add(new KeyValuePair<string, string>(Card.Values52[6], Card.Suits["spades"]), Properties.Resources._6_of_spades);
        //    cardPics.Add(new KeyValuePair<string, string>(Card.Values52[7], Card.Suits["spades"]), Properties.Resources._7_of_spades);
        //    cardPics.Add(new KeyValuePair<string, string>(Card.Values52[8], Card.Suits["spades"]), Properties.Resources._8_of_spades);
        //    cardPics.Add(new KeyValuePair<string, string>(Card.Values52[9], Card.Suits["spades"]), Properties.Resources._9_of_spades);
        //    cardPics.Add(new KeyValuePair<string, string>(Card.Values52[10], Card.Suits["spades"]), Properties.Resources._10_of_spades);
        //    cardPics.Add(new KeyValuePair<string, string>(Card.Values52[11], Card.Suits["spades"]), Properties.Resources.jack_of_spades);
        //    cardPics.Add(new KeyValuePair<string, string>(Card.Values52[12], Card.Suits["spades"]), Properties.Resources.queen_of_spades);
        //    cardPics.Add(new KeyValuePair<string, string>(Card.Values52[13], Card.Suits["spades"]), Properties.Resources.king_of_spades);
        //    cardPics.Add(new KeyValuePair<string, string>(Card.Values52[14], Card.Suits["spades"]), Properties.Resources.ace_of_spades);

        //    cardPics.Add(new KeyValuePair<string, string>(Card.Values52[2], Card.Suits["hearts"]), Properties.Resources._2_of_hearts);
        //    cardPics.Add(new KeyValuePair<string, string>(Card.Values52[3], Card.Suits["hearts"]), Properties.Resources._3_of_hearts);
        //    cardPics.Add(new KeyValuePair<string, string>(Card.Values52[4], Card.Suits["hearts"]), Properties.Resources._4_of_hearts);
        //    cardPics.Add(new KeyValuePair<string, string>(Card.Values52[5], Card.Suits["hearts"]), Properties.Resources._5_of_hearts);

        //    cardPics.Add(new KeyValuePair<string, string>(Card.Values52[6], Card.Suits["hearts"]), Properties.Resources._6_of_hearts);
        //    cardPics.Add(new KeyValuePair<string, string>(Card.Values52[7], Card.Suits["hearts"]), Properties.Resources._7_of_hearts);
        //    cardPics.Add(new KeyValuePair<string, string>(Card.Values52[8], Card.Suits["hearts"]), Properties.Resources._8_of_hearts);
        //    cardPics.Add(new KeyValuePair<string, string>(Card.Values52[9], Card.Suits["hearts"]), Properties.Resources._9_of_hearts);
        //    cardPics.Add(new KeyValuePair<string, string>(Card.Values52[10], Card.Suits["hearts"]), Properties.Resources._10_of_hearts);
        //    cardPics.Add(new KeyValuePair<string, string>(Card.Values52[11], Card.Suits["hearts"]), Properties.Resources.jack_of_hearts);
        //    cardPics.Add(new KeyValuePair<string, string>(Card.Values52[12], Card.Suits["hearts"]), Properties.Resources.queen_of_hearts);
        //    cardPics.Add(new KeyValuePair<string, string>(Card.Values52[13], Card.Suits["hearts"]), Properties.Resources.king_of_hearts);
        //    cardPics.Add(new KeyValuePair<string, string>(Card.Values52[14], Card.Suits["hearts"]), Properties.Resources.ace_of_hearts);

        //    cardPics.Add(new KeyValuePair<string, string>(Card.Values52[2], Card.Suits["diamonds"]), Properties.Resources._2_of_diamonds);
        //    cardPics.Add(new KeyValuePair<string, string>(Card.Values52[3], Card.Suits["diamonds"]), Properties.Resources._3_of_diamonds);
        //    cardPics.Add(new KeyValuePair<string, string>(Card.Values52[4], Card.Suits["diamonds"]), Properties.Resources._4_of_diamonds);
        //    cardPics.Add(new KeyValuePair<string, string>(Card.Values52[5], Card.Suits["diamonds"]), Properties.Resources._5_of_diamonds);

        //    cardPics.Add(new KeyValuePair<string, string>(Card.Values52[6], Card.Suits["diamonds"]), Properties.Resources._6_of_diamonds);
        //    cardPics.Add(new KeyValuePair<string, string>(Card.Values52[7], Card.Suits["diamonds"]), Properties.Resources._7_of_diamonds);
        //    cardPics.Add(new KeyValuePair<string, string>(Card.Values52[8], Card.Suits["diamonds"]), Properties.Resources._8_of_diamonds);
        //    cardPics.Add(new KeyValuePair<string, string>(Card.Values52[9], Card.Suits["diamonds"]), Properties.Resources._9_of_diamonds);
        //    cardPics.Add(new KeyValuePair<string, string>(Card.Values52[10], Card.Suits["diamonds"]), Properties.Resources._10_of_diamonds);
        //    cardPics.Add(new KeyValuePair<string, string>(Card.Values52[11], Card.Suits["diamonds"]), Properties.Resources.jack_of_diamonds);
        //    cardPics.Add(new KeyValuePair<string, string>(Card.Values52[12], Card.Suits["diamonds"]), Properties.Resources.queen_of_diamonds);
        //    cardPics.Add(new KeyValuePair<string, string>(Card.Values52[13], Card.Suits["diamonds"]), Properties.Resources.king_of_diamonds);
        //    cardPics.Add(new KeyValuePair<string, string>(Card.Values52[14], Card.Suits["diamonds"]), Properties.Resources.ace_of_diamonds);

        //    cardPics.Add(new KeyValuePair<string, string>(Card.Values52[2], Card.Suits["clubs"]), Properties.Resources._2_of_clubs);
        //    cardPics.Add(new KeyValuePair<string, string>(Card.Values52[3], Card.Suits["clubs"]), Properties.Resources._3_of_clubs);
        //    cardPics.Add(new KeyValuePair<string, string>(Card.Values52[4], Card.Suits["clubs"]), Properties.Resources._4_of_clubs);
        //    cardPics.Add(new KeyValuePair<string, string>(Card.Values52[5], Card.Suits["clubs"]), Properties.Resources._5_of_clubs);

        //    cardPics.Add(new KeyValuePair<string, string>(Card.Values52[6], Card.Suits["clubs"]), Properties.Resources._6_of_clubs);
        //    cardPics.Add(new KeyValuePair<string, string>(Card.Values52[7], Card.Suits["clubs"]), Properties.Resources._7_of_clubs);
        //    cardPics.Add(new KeyValuePair<string, string>(Card.Values52[8], Card.Suits["clubs"]), Properties.Resources._8_of_clubs);
        //    cardPics.Add(new KeyValuePair<string, string>(Card.Values52[9], Card.Suits["clubs"]), Properties.Resources._9_of_clubs);
        //    cardPics.Add(new KeyValuePair<string, string>(Card.Values52[10], Card.Suits["clubs"]), Properties.Resources._10_of_clubs);
        //    cardPics.Add(new KeyValuePair<string, string>(Card.Values52[11], Card.Suits["clubs"]), Properties.Resources.jack_of_clubs);
        //    cardPics.Add(new KeyValuePair<string, string>(Card.Values52[12], Card.Suits["clubs"]), Properties.Resources.queen_of_clubs);
        //    cardPics.Add(new KeyValuePair<string, string>(Card.Values52[13], Card.Suits["clubs"]), Properties.Resources.king_of_clubs);
        //    cardPics.Add(new KeyValuePair<string, string>(Card.Values52[14], Card.Suits["clubs"]), Properties.Resources.ace_of_clubs);
        //}
    }
}
