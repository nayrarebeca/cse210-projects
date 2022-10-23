// Director
    //Starts Game
    //GetInputs
    //DoUpdates
    //DoOutputs

using System;
namespace Unit03;
    public class Director
    {
        bool isAlive = true;
        string userGuess;
        public void StartGame()
        {
            while(isAlive)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        public void GetInputs()
        {
            Console.WriteLine("Guess a letter (a-z): ");
            userGuess = Console.ReadLine();
        }

        public void DoUpdates(){}

        public void DoOutputs(){}
    }