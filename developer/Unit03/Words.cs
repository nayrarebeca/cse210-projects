// Create a list of strings
// Choose a word at random
using System;
using System.Collections.Generic;
namespace Unit03;
public class words {
    static void wordList(string[] args) {
    var random = new Random();
    var fruits = new List<string>{
            "apple",
            "banana",
            "coconut",
            "strawbeery",
            "watermelon",
            "pineapple",
            "lemon",
            "orange",
            "grape",
            "starfruit",
            "blueberry"
            };
    int index = random.Next(fruits.Count);
    var randomWord = (fruits[index]);
    }
}