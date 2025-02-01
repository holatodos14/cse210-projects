using System;
using System.Collections.Generic;
using System.IO;

public class MemoryVault
{
    private List<MemoryFragment> memories;
    private List<string> reflections;
    private Random pathfinder;

    public MemoryVault()
    {
        memories = new List<MemoryFragment>();
        reflections = new List<string>
        {
            "Which soul left the strongest impression on your journey today?",
            "What moment made your spirit soar highest?",
            "Where did you witness divine footprints in your path today?",
            "What emotion carved the deepest mark in your heart?",
            "If the sands of time could flow backward today, what would you reshape?",
            "What wisdom did the universe reveal to you today?",
            "What light of kindness did you witness or spark today?",
            "What challenge tested your mettle, and how did you triumph?"
        };
        pathfinder = new Random();
    }

    public void CaptureMemory()
    {
        string reflection = reflections[pathfinder.Next(reflections.Count)];
        Console.WriteLine($"\n{reflection}");
        Console.Write("> ");
        string chronicle = Console.ReadLine();
        
        memories.Add(new MemoryFragment(reflection, chronicle));
        Console.WriteLine("Memory captured and preserved!");
    }

    public void DisplayMemories()
    {
        if (memories.Count == 0)
        {
            Console.WriteLine("\nThe memory vault echoes empty.");
            return;
        }

        Console.WriteLine("\n=== Chronicles of Memory ===");
        foreach (MemoryFragment memory in memories)
        {
            Console.WriteLine(memory.ToString());
        }
    }

    public void ArchiveToVault(string filename)
    {
        try
        {
            using (StreamWriter scribe = new StreamWriter(filename))
            {
                foreach (MemoryFragment memory in memories)
                {
                    scribe.WriteLine($"{memory.Timestamp}~|~{memory.Reflection}~|~{memory.Chronicle}");
                }
            }
            Console.WriteLine("Memories safely sealed in the vault!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"The archival ritual was disrupted: {ex.Message}");
        }
    }

    public void RestoreFromVault(string filename)
    {
        try
        {
            memories.Clear();
            using (StreamReader chronicler = new StreamReader(filename))
            {
                string scroll;
                while ((scroll = chronicler.ReadLine()) != null)
                {
                    string[] fragments = scroll.Split("~|~");
                    if (fragments.Length == 3)
                    {
                        memories.Add(new MemoryFragment(fragments[1], fragments[2], fragments[0]));
                    }
                }
            }
            Console.WriteLine("Memories successfully restored from the vault!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"The restoration ritual encountered a barrier: {ex.Message}");
        }
    }
}