using System;
using Unit02.Game;
namespace Unit02
{
    public class Director
    {

        bool isPlaying = true;
        int score = 300;
        string userGuess;
        Card currentCard;
       
        public Director()
        {
            currentCard = new Card();
            userGuess = "lower";
        }

        public void StartGame()
        {
            while (isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }

            Console.WriteLine("Thank you for playing today!");
        }
        public void GetInputs()
        {
            Console.WriteLine($"The current card is {currentCard.cardValue}");
            Console.WriteLine("Higher or lower? [h/l] ");
            userGuess = Console.ReadLine();
        }

        public void DoUpdates()
        {

            Card nextCard = new Card();
            Console.WriteLine($"The card was: {nextCard.cardValue}");

            if (nextCard.cardValue > currentCard.cardValue && userGuess == "h" ||
            nextCard.cardValue < currentCard.cardValue && userGuess == "l")
            {
                score += 100;
            }

            else
            {
                score -= 75;
            }

            currentCard = nextCard;
        }
        
        public void DoOutputs()
        {
            Console.WriteLine($"Your score is: {score}");
            isPlaying = (score > 0);
            
            if (score <= 0)
            {
                isPlaying = false;
            }

            else
            {
                Console.WriteLine("Keep guessing?(yes/no) ");
                string keepGuessing = Console.ReadLine();
                
                if (keepGuessing == "yes"){
                    isPlaying = true;
                }
                else
                {
                    isPlaying = false;
                }
            }
        }
    }
}
