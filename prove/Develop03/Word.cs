using System;
using System.Collections.Generic;

class Word
{
    private static string _hide = Scripture._hideWord;
    public static char[] hiddenWord = _hide.ToCharArray();

    //change random word to dashes
    public static void getHidden()
    {
        for (var i = 0; i < hiddenWord.Length; i++)
        {
            hiddenWord[i] = '-';
        }
    }
}