using System;

class Program
{
    static void Main(string[] args)
    {
        foreach (var number in new object[] { 123, "2017", "-1", "1a2b3c", '5' })
        {
            try
            {
                (bool parsed, int result) = IntegerParser.TryParse(number);
                if (parsed)
                {
                    Console.WriteLine($"Parsed {number.GetType()} {number}, got {result}");
                }
                else
                {
                    Console.WriteLine($"Could not parse {number.GetType()} {number}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error when parsing: {e.Message}");
            }
        }
    }
}
