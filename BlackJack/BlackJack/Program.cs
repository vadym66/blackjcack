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

            string question = "";
            string questionExit ="";
            int scoreFirstPlayer = 0;
            int scoreSecondPlayer = 0;

            do
            {                
                Random rnd = new Random();

                for (int i = deckOfCards.Length; i > 1; i--)
                {

                    int j = rnd.Next(i);
                    var tmp = deckOfCards[j];
                    deckOfCards[j] = deckOfCards[i - 1];
                    deckOfCards[i - 1] = tmp;
                } // shuffling the deck of cards

                

                var resultFirst = 0;
                var resultSecond = 0;
                
                for (int i = 0; i < deckOfCards.Length; i++) // first two cards recived player 
                {
                    if (i < 2)
                    {
                        Console.WriteLine($"{deckOfCards[i].Card} {deckOfCards[i].Suit}");
                        resultFirst += (int)deckOfCards[i].Card;

                    }

                }
                Console.WriteLine(resultFirst);
                for (int i = 2; i < deckOfCards.Length; i++)  // first two cards recived computer
                {
                    if (i < 4)
                    {
                        resultSecond += (int)deckOfCards[i].Card;
                    }
                }

                int l = 3; //continue initilizatian of array 
                int k = l;

                if (resultFirst != 21 && resultSecond != 21)
                {
                    do
                    {

                        Console.WriteLine("do you want more ?");
                        question = Console.ReadLine();

                        if (question == "yes" && resultFirst < 21)
                        {

                            l++;
                            Console.WriteLine($"{deckOfCards[l].Card} {deckOfCards[l].Suit}");
                            resultFirst += (int)deckOfCards[l].Card;
                            Console.WriteLine(resultFirst);


                            k++;
                            resultSecond += (int)deckOfCards[k].Card;
                        }
                    } while (question == "yes" && resultFirst < 21);
                    
                }
                if (resultFirst > 21 || resultSecond > 21)
                {
                    if (resultFirst < resultSecond)
                    {
                        Console.WriteLine("You have won");
                        Console.WriteLine(resultSecond);
                        scoreFirstPlayer++;
                    }
                    else
                    {
                        Console.WriteLine("compter has wone");
                        Console.WriteLine(resultSecond);
                        scoreSecondPlayer++;
                    }
                }
                else if (resultFirst == 21 && resultSecond == 21)
                {
                    if (resultFirst == 21)
                    {
                        Console.WriteLine("You have won");
                        scoreFirstPlayer++;
                    }
                    else
                    {
                        Console.WriteLine("compter has wone");
                        Console.WriteLine(resultSecond);
                        scoreSecondPlayer++;
                    }
                }
                else if (resultFirst < 21 && resultFirst > resultSecond)
                {
                    Console.WriteLine("You have won");
                    Console.WriteLine(resultSecond);
                    scoreFirstPlayer++;
                }
                else if (resultFirst == resultSecond)
                {
                    Console.WriteLine("draw");
                }
                else
                {
                    Console.WriteLine("compter has wone");
                    Console.WriteLine(resultSecond);
                    scoreSecondPlayer++;
                }
                Console.WriteLine("do you want to continue ? yes/no");
                questionExit = Console.ReadLine();
            } while (questionExit == "yes");
            Console.WriteLine($"You have won:" + scoreFirstPlayer);
            Console.WriteLine("Computer has won", + scoreSecondPlayer);
        }                        
    }
}
