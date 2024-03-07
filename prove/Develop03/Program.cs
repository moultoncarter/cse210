using System;

// I just want it on record that this feels bad to code
// why am i using 3 classes here
public class Word
{
    // ??? with my (albeit very limited) experience a string list does this better (even if it doesnt its easier)
    private string _word;
    private bool _visible;

    public Word(string word)
    {
        _word = word;
        _visible = true;
    }

    //for testing
    public void ShowWord()
    {
        Console.WriteLine(_word);
    }

    public string DisplayWord()
    {
        if (_visible)
        {
            return _word;
        }
        string conversion = "";
        foreach (char character in _word)
        {
            conversion += "-";
        }
        return conversion;
    }

    public void HideWord()
    {
        _visible = false;
    }
}

public class Name
{
    // ????? its just the name of the scripture
    private string _name;

    //only one constructor because functionally theres no difference between one and two verses
    public Name(string newName)
    {
        _name = newName;
    }

    public string ReturnName()
    {
        return _name;
    }

}


public class Scripture
{
    private Name _name;
    private List<Word> _words;
    private int _erosion = 5;

    //see above
    public Scripture(string name, string scripture)
    {
        _name = new Name(name);
        List<Word> tempScript = new List<Word>();
        foreach (string word in scripture.Split())
        {
            Word tempWord = new Word(word);
            tempScript.Add(tempWord);
        }
        _words = tempScript;
    } 

    public void Display()
    {
        foreach (Word word in _words)
        {
            word.ShowWord();
        }
    }

    public void ShowScripture()
    {
        Console.Write(_name.ReturnName() + ":");
        foreach (Word word in _words)
        {
            Console.Write(" " + word.DisplayWord());
        }
    }

    public void ErodeScripture()
    {
        Random random = new Random();
        foreach (Word word in _words)
        {
            int erosionChance = random.Next(1, 100);
            if (erosionChance <= _erosion)
            {
                word.HideWord();
            }
        }
        _erosion += 5;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        Scripture john = new Scripture("John 3:16", "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        // john.Display();

        string response = "";
        bool notfinished = true;

        while (response != "quit" && notfinished){
            Console.Clear();
            Console.WriteLine("Press enter to hide more of the scripture or 'Quit' to stop.");
            john.ShowScripture();
            response = Console.ReadLine();
            if (response.ToLower() == "quit")
            {
                break;
            }
            john.ErodeScripture();
        }
    }
}