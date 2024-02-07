using System;
using System.IO;

public class Entry
{
    string _content;
    DateTime _timeCreated;
    string _usedPrompt;

    public Entry (string entryText, DateTime date, string prompt)
    {
        _content = entryText;
        _timeCreated = date;
        _usedPrompt = prompt;
    }
    public void ReadEntry()
    {
        Console.WriteLine($"Date: {_timeCreated}\nPrompt: {_usedPrompt}\nEntry: {_content}");
    }
    public string GetEntry()
    {
        return $"{_timeCreated},{_usedPrompt},{_content}";
    }
}
public class Journal
{
    private string _name;
    List <Entry> _entries;

    public Journal(string name)
    {
        _name = $"{name}.csv";
        _entries = new List <Entry>();
    }

    public void AddNewEntry(Entry addedEntry)
    {
        _entries.Add(addedEntry);
    }

    public void DisplayEntries()
    {
        foreach (Entry written in _entries)
        {
            written.ReadEntry();
        }
    }

    public void SaveJournal()
    {
        string filename = @$"journals\{_name}";
        using (StreamWriter file = new StreamWriter(filename))
        {
            foreach (Entry written in _entries)
            {
                Console.WriteLine(written.GetEntry());
                file.WriteLine(written.GetEntry());
            }
            
        }
    }
    public void LoadJournal()
    {
        string filename = @$"journals\{_name}";
            string[] lines = File.ReadAllLines(filename);
            if (lines != null && lines[0] != "")
            {
                foreach (string line in lines)
                {
                string[] part = line.Split(",");
                DateTime date = DateTime.Parse(part[0]);
                string prompt = part[1];
                string content= part[2];
                Entry loadEntry = new Entry(content, date, prompt);
                this.AddNewEntry(loadEntry);
                }
            }
    }
}


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        Console.WriteLine("Welcome to your journal.");

        Random rand = new Random();
        string[] prompts = {"What productive thing did you do today?", "Where did you go today?", "What have you eaten today?",
        "What have you done for fun today?", "Who did you talk to today?"};
        bool willContinue = true;
        Journal currentJournal = null;
        while (willContinue)
        {
            if (currentJournal != null)
            {
                Console.WriteLine("Please choose from the following options.\n1. Write a new entry.\n2. Display previous entries.\n3. Save the journal.\n4. Load a journal.");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    int promptNum = rand.Next(0,4);
                    string usedPrompt = prompts[promptNum];
                    Console.WriteLine(usedPrompt);

                    string writtenEntry = Console.ReadLine();
                    DateTime entryDate = DateTime.Now;
                    Entry newWrittenEntry = new Entry(writtenEntry, entryDate, usedPrompt);
                    currentJournal.AddNewEntry(newWrittenEntry);
                break;
                case 2:
                    currentJournal.DisplayEntries();
                break;
                case 3:
                    currentJournal.SaveJournal();
                break;
                case 4:
                    Console.WriteLine($"These are the currently saved journals. Which do you want to load?");
                        string journalFolder = @"journals";
                        string[] journalList = Directory.GetFiles(journalFolder);
                        foreach (string journalFile in journalList)
                        {
                            Console.WriteLine(journalFile);
                        }
                        string wantedJournal = Console.ReadLine();
                        currentJournal = new Journal(wantedJournal);
                        currentJournal.LoadJournal();
                break;
                default:
                    Console.WriteLine("That doesn't match any of the options. Please retry.");
                break;
            }
            
            } else
            {
                Console.WriteLine("There is no journal currently loaded.\n1. Create a new journal.\n2. Load a previously created journal.");
                int startupChoice = int.Parse(Console.ReadLine());
                switch (startupChoice)
                {
                    case 1:
                        Console.WriteLine("What do you want to call the new journal? Names are not case sensitive.");
                        string newName = Console.ReadLine();
                        string newJournal = newName.ToLower();
                        currentJournal = new Journal(newJournal);
                        currentJournal.SaveJournal();
                        break;
                    case 2:
                        Console.WriteLine($"These are the currently saved journals. Which do you want to load?");
                        string journalFolder = @"journals";
                        string[] journalList = Directory.GetFiles(journalFolder);
                        foreach (string journalFile in journalList)
                        {
                            Console.WriteLine(journalFile);
                        }
                        string wantedJournal = Console.ReadLine();
                        currentJournal = new Journal(wantedJournal);
                        currentJournal.LoadJournal();
                        break;
                }
            }
        }
    }
}