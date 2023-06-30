using System.IO;
using System.Collections.Generic;

class Entry
{
    //variables
    static int _numprompt = 0;
    static string _userEntry = string.Empty;
    static string _journalEntry = string.Empty;
    static string _usedPrompt = string.Empty;
    static string _fileName = string.Empty;
    static string _loadFile = string.Empty;
    static List<string> addEntries = new List<string>();

    public static void promptMethod()
    {
        //Method to create the prompt and display it
        var random = new Random();
        var prompts = new List<string>
        {
            "What was your favorite part of the day?",
            "Did you help anyone today?",
            "Did you learn something new?",
            "What is a goal that you have for the week?",
            "When do you see the Lord's hand in your day?",
            "What is something you are looking forward to?",
            "What did you learn from your scripture studies?",
            "Who is someone that you admire?",
            "Where would you tavel to if you could go anywhere?",
            "What is something that you like about yourself?"

        };
        _numprompt = random.Next(prompts.Count);

        _usedPrompt = _numprompt.ToString(prompts[_numprompt]);
        Console.WriteLine(_usedPrompt);
        _userEntry = Console.ReadLine();

        //Method to create the journal entry format
        string _currentDate = DateTime.Now.ToString("MM/dd/yyyy");
        _journalEntry = "Date: " + _currentDate + " - Prompt: " + _usedPrompt + "\n" + _userEntry +"\n";
        //add the journal entry to a list to display
        addEntries.Add(_journalEntry);
    }

    public static void readMethod()
    {
        //display list
        foreach (string _entry in addEntries)
        {
            Console.WriteLine(_entry);
        }
    }
    public static void saveMethod()
    {
        //Save a text file
        Console.WriteLine("What is the name of the file you would like to save?");
        _fileName = Console.ReadLine();
        System.IO.File.WriteAllLines(_fileName, addEntries);
    }

    public static void loadMethod() 
    {
        //Read a file
        Console.WriteLine("What is the name of the file you would like to load?");
        _loadFile = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(_loadFile);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
        }
    }
}