using System.IO;
using System;
using System.Collections.Generic;


class Journal
{
    private List<Entry> entries = new List<Entry>();
    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using(StreamWriter writer = new StreamWriter(filename))
        {
            
            foreach(Entry entry in entries)
            {
                writer.WriteLine($"{entry.date}|{entry.prompt}|{entry.text}");

            }
        }
    }

    public void LoadFromFile(string filename)
    {
        entries.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            DateTime date = DateTime.Parse(parts[0]);
            string prompt = parts[1];
            string text = parts[2];
            Entry entry = new  Entry (date, prompt, text);
            entries.Add(entry);
        }
    }

}