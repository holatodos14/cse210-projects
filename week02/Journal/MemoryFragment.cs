public class MemoryFragment
{
    public string Reflection { get; set; }  // el prompt
    public string Chronicle { get; set; }   // el response
    public string Timestamp { get; set; }   // el date

    public MemoryFragment(string reflection, string chronicle)
    {
        Reflection = reflection;
        Chronicle = chronicle;
        Timestamp = DateTime.Now.ToShortDateString();
    }

    public MemoryFragment(string reflection, string chronicle, string timestamp)
    {
        Reflection = reflection;
        Chronicle = chronicle;
        Timestamp = timestamp;
    }

    public override string ToString()
    {
        return $"Timestamp: {Timestamp}\nReflection: {Reflection}\n{Chronicle}\n";
    }
}