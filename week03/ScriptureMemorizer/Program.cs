using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public bool IsHidden => _isHidden;

    public void Hide()
    {
        _isHidden = true;
    }

    public override string ToString()
    {
        return _isHidden ? new string('_', _text.Length) : _text;
    }
}

public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = verse;
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public override string ToString()
    {
        if (_startVerse == _endVerse)
            return $"{_book} {_chapter}:{_startVerse}";
        return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
    }
}
public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ')
                     .Select(word => new Word(word))
                     .ToList();
        _random = new Random();
    }

    public bool IsCompletelyHidden => _words.All(w => w.IsHidden);

    public void HideRandomWords(int count = 3)
    {
        var visibleWords = _words.Where(w => !w.IsHidden).ToList();
        
        count = Math.Min(count, visibleWords.Count);
        
        for (int i = 0; i < count; i++)
        {
            if (visibleWords.Count == 0) break;
            
            int index = _random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public override string ToString()
    {
        return $"{_reference}\n{string.Join(" ", _words)}";
    }
}

public class Program
{
    public static void Main()
    {
        var scriptures = new List<Scripture>
        {
            new Scripture(
                new Reference("John", 3, 16),
                "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life"
            ),
            new Scripture(
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight"
            ),
            // This should add more scriptures :s
        };

        var random = new Random();
        var scripture = scriptures[random.Next(scriptures.Count)];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture);
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit:");
            
            string input = Console.ReadLine().ToLower();
            if (input == "quit")
                break;

            if (scripture.IsCompletelyHidden)
                break;

            scripture.HideRandomWords();
        }

        Console.WriteLine("\nGreat job with your memorization practice!");
    }
}