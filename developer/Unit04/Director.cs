using System;

namespace Unit04
{
    public class Director
    {
        bool _isPlaying = true;
        int _score = 0;
        int _totalScore = 0;

        public Director()
        {
            /// Add Current card or deck of cards
        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {
            while (_isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }
          public void GetInputs()
        {
            Console.Write("Higher or lower? [h/l] ");
            //verify if the guess is correct
        }

        public void DoUpdates()
        {
            if (!_isPlaying)
            {
                return;
            }

            _score = 0;
            /// update score according to the guess
        }
        public void DoOutputs()
        {
            if (!_isPlaying)
            {
                return;
            }

            Console.WriteLine($"The next card was:"); /// add value (next card)
            Console.WriteLine($"Your score is: {_totalScore}\n");
            _isPlaying = (_score > 0);
        }
    }
}
