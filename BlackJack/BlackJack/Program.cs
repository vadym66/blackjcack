using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        public enum SuitName
        {
            heart,
            diamond,
            spade,
            club
        }
        public enum CardNumber
        {
            six = 6, seven, eight, nine, ten, jack = 2, qeen, king, ace = 11
        }
        public struct CardStruct
        {
            public SuitName Suit;
            public CardNumber Card;
        }
        
        static void Main(string[] args)
        {
            

            CardStruct[] deckOfCards = new CardStruct[]
            {
               new CardStruct {Card = CardNumber.six, Suit = SuitName.club},
               new CardStruct {Card = CardNumber.seven, Suit = SuitName.club},
               new CardStruct {Card = CardNumber.eight, Suit = SuitName.club},
               new CardStruct { Card = CardNumber.nine, Suit = SuitName.club },
               new CardStruct { Card = CardNumber.ten, Suit = SuitName.club },
               new CardStruct { Card = CardNumber.jack, Suit = SuitName.club },
               new CardStruct { Card = CardNumber.qeen, Suit = SuitName.club },
               new CardStruct { Card = CardNumber.king, Suit = SuitName.club },
               new CardStruct { Card = CardNumber.ace, Suit = SuitName.club },

               new CardStruct {Card = CardNumber.six, Suit = SuitName.spade},
               new CardStruct {Card = CardNumber.seven, Suit = SuitName.spade},
               new CardStruct {Card = CardNumber.eight, Suit = SuitName.spade},
               new CardStruct { Card = CardNumber.nine, Suit = SuitName.spade },
               new CardStruct { Card = CardNumber.ten, Suit = SuitName.spade },
               new CardStruct { Card = CardNumber.jack, Suit = SuitName.spade },
               new CardStruct { Card = CardNumber.qeen, Suit = SuitName.spade },
               new CardStruct { Card = CardNumber.king, Suit = SuitName.spade },
               new CardStruct { Card = CardNumber.ace, Suit = SuitName.spade },

               new CardStruct {Card = CardNumber.six, Suit = SuitName.diamond},
               new CardStruct {Card = CardNumber.seven, Suit = SuitName.diamond},
               new CardStruct {Card = CardNumber.eight, Suit = SuitName.diamond},
               new CardStruct { Card = CardNumber.nine, Suit = SuitName.diamond },
               new CardStruct { Card = CardNumber.ten, Suit = SuitName.diamond },
               new CardStruct { Card = CardNumber.jack, Suit = SuitName.diamond },
               new CardStruct { Card = CardNumber.qeen, Suit = SuitName.diamond },
               new CardStruct { Card = CardNumber.king, Suit = SuitName.diamond },
               new CardStruct { Card = CardNumber.ace, Suit = SuitName.diamond },

               new CardStruct {Card = CardNumber.six, Suit = SuitName.heart},
               new CardStruct {Card = CardNumber.seven, Suit = SuitName.heart},
               new CardStruct {Card = CardNumber.eight, Suit = SuitName.heart},
               new CardStruct { Card = CardNumber.nine, Suit = SuitName.heart },
               new CardStruct { Card = CardNumber.ten, Suit = SuitName.heart },
               new CardStruct { Card = CardNumber.jack, Suit = SuitName.heart },
               new CardStruct { Card = CardNumber.qeen, Suit = SuitName.heart },
               new CardStruct { Card = CardNumber.king, Suit = SuitName.heart },
               new CardStruct { Card = CardNumber.ace, Suit = SuitName.heart },
            };
            Console.WriteLine("================================");
            //Random rnd = new Random();

            //for (int i = deckOfCards.Length; i > 1; i--)
            //{

            //    int j = rnd.Next(i); 
            //    var tmp = deckOfCards[j];
            //    deckOfCards[j] = deckOfCards[i - 1];
            //    deckOfCards[i - 1] = tmp;
            //}
            Console.WriteLine("================================");
            //for (int i = 0; i < deckOfCards.Length; i++)
            //{
            //    //Console.WriteLine($"[{i}] ===> {deckOfCards[i].Card} {deckOfCards[i].Suit}");
            //}
            //for (int i = 0; i < deckOfCards.Length; i++)
            //{
            //    string ace = "ace";
            //    CardNumber tmp = (CardNumber)Enum.Parse(typeof(CardNumber), ace);
            //    if (deckOfCards[i].Card == tmp)
            //    {
            //        Console.WriteLine($"[{i}] ======>> {deckOfCards[i].Card} {deckOfCards[i].Suit}");
            //    }
            //}
            Console.WriteLine("================================");
            
        }

        



    }
}
