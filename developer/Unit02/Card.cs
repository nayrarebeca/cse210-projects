using System;

namespace Unit02.Game
{
    /// <summary>
    //Gets a card with a number value//
    /// </summary> 
    public class Card
   {
        public int cardValue;

        public Card()
        {
            Random randomNumber = new Random();

            cardValue = randomNumber.Next(1,14);
        }
   }
}