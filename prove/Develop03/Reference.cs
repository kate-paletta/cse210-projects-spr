using System.IO;
using System.Collections.Generic;

class Reference
{
    static List<string> references = new List<string>
    {
        "Moses/ 1:/39/ For behold this is my work and my glory to bring to pass the immortality and eternal life of man.",
        "John/ 7:/17/ If any man will do his will he shall know of the doctrine whether it be of God or whether I speak of myself.",
        "Alma/ 47:/6-7/ Now ye may suppose that this is foolishness in me. But behold I say unto you that by small and simple things are great things brought to pass and small means in many instances doth confound the wise. And the Lord God doth work by means to bring about his great and eternal purposes and by very small means the Lord doth confound the wise and bringeth about the salvation of many souls.",
        "Doctrine & Covenants/ 8:/ 2-3/ Yea behold I will tell you in your mind and in your heart by the Holy Ghost which shall come upon you and which shall dwell in your heart. Now behold this is the spirit of revelation. Behold this is the spirit by which Moses abrought the children of Israel through the Red Sea on dry ground."
    };

    //Select a scripture at random
    private static Random rndm = new Random();
    private static int _rndmRef = rndm.Next(references.Count);
    private static string _usedRef = _rndmRef.ToString(references[_rndmRef]);

    //Split the chosen scripture into parts
    private static string[] split = _usedRef.Split('/');
    private static string _book = split[0];
    private static string _chp = split[1];
    private static string _verse = split[2];
    private static string _verseTxt = split[3];

    // public Reference (string _book, string _chp, string _verse)
    // {
    //     string fullRef = _book + _chp + _verse;
    // }

    // public Reference(string _verseTxt)
    // {
    //     string fullVerse = _verseTxt;
    // }

    public static string fullRef = _book + _chp + _verse;
    public static string fullVerse = _verseTxt;

}