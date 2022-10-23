// Create the "GameBoard" (like tic-tac-toe)
using System;
using System.Collections.Generic;
namespace Unit03;

    public class Parachute {
        private List<string> jumper = new List<string>();

        public Parachute()
        {
            jumper.Add("  ___");
            jumper.Add(" /___\\");
            jumper.Add(" \\   /");
            jumper.Add("  \\ /");
            jumper.Add("   O");
            jumper.Add("  /|\\");
            jumper.Add("  / \\");
        }

        public void removeDash(){
            //if the user guesses a letter that's not in the word,
            //remove a dash from the parachute and from the # of tries/mistakes
        }


    }
