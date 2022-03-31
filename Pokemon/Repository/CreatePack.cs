using Pokemon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pokemon.Repository
{
    public class CreatePack
    {
        public static List<Card> NewPack(int packvalue,List<Card> cards,string userid)
        {
            Random rnd = new Random();
            var listOfCards = new List<Card>();
            
         
            
            List<int> randomNumbers = new List<int>();
            int numberOfCards = 0;
            switch (packvalue)
            {
                case 3:numberOfCards = 3; break;
                case 5:numberOfCards = 5; break;
                case 7:numberOfCards = 10; break;
                default:
                    break;
            }

            for (int i = 1; i <= numberOfCards; i++)
            {
                randomNumbers.Add(rnd.Next((cards.Count)+1));
            }

            foreach (var number in randomNumbers)
            {
                cards[number].ApplicationUserId = userid;
                listOfCards.Add(cards[number]);
            }

            return listOfCards;




        }
    }
}