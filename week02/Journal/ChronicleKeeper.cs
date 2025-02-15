using System;
using System.Collections.Generic;

class ChronicleKeeper
{
    static void Main(string[] args)
    {
        MemoryVault vault = new MemoryVault();
        bool exploring = true;

        while (exploring)
        {
            Console.WriteLine("\n=== Memory Chronicle System ===");
            Console.WriteLine("1. Capture new memory");
            Console.WriteLine("2. Review memory archives");
            Console.WriteLine("3. Archive memories to vault");
            Console.WriteLine("4. Restore memories from vault");
            Console.WriteLine("5. End Exploration");
            Console.Write("\nSelect your journey (1-5): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    vault.CaptureMemory();
                    break;
                case "2":
                    vault.DisplayMemories();
                    break;
                case "3":
                    Console.Write("Name your memory archive: ");
                    string saveFile = Console.ReadLine();
                    vault.ArchiveToVault(saveFile);
                    break;
                case "4":
                    Console.Write("Enter archive to restore: ");
                    string loadFile = Console.ReadLine();
                    vault.RestoreFromVault(loadFile);
                    break;
                case "5":
                    exploring = false;
                    break;
                default:
                    Console.WriteLine("Unknown path. Please choose again.");
                    break;
            }
        }
    }
}