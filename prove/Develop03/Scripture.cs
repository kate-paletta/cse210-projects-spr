using System.IO;
using System.Collections.Generic;

class Scripture
{
    //Variable from Reference class
    private static string scripRef = Reference.fullRef;
    private static string scripVerse = Reference.fullVerse;

    //display scripture
    public static void displayMethod()
    {
        Console.WriteLine($"{scripRef} {scripVerse}");
        Console.Write($"{_hideWord}");
        Console.WriteLine($"{hiddenWord2}");
        Console.WriteLine("Press enter to continue or type 'quit' to finish");
    }

    //split versetxt into words & put in a list
    private static string[] _wordsArray = scripVerse.Split(" ");
    public static void getWord()
    {
        foreach (string word in _wordsArray)
        {
            _words.Add(word);
        }
    }

    //Pick random word from word list
    private static Random rndm = new Random();
    private static int _rndmWord = rndm.Next(_words.Count);
    private static string _usedWord = _rndmWord.ToString(_words[_rndmWord]);
    public static string _hideWord = _usedWord;

    //the variables from Word class
    private static string hiddenWord2 = Word.hiddenWord.ToString();
    private static List<string> _words = new List<string>();
}