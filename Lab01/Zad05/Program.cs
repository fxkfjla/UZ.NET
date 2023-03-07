public class Program
{
    public static void Main(string[] args)
    {
        string word0 = args[0];
        string word1 = args[1];

        string? line = Console.ReadLine();

        while(line!= null)
        {
            if (line.Contains(word0))
                line = line.Replace(word0, word1);

            Console.WriteLine(line);
            line = Console.ReadLine();
        }
    }
}
