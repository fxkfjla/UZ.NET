public class Program
{
    public static void Main(string[] args)
    {
        string word0 = args[0];
        string word1 = args[1];

        StreamReader reader = new StreamReader(Console.OpenStandardInput()); 
        StreamWriter writer = new StreamWriter(Console.OpenStandardOutput());

        while(!reader.EndOfStream)
        {
            string? line = reader.ReadLine();

            if(line != null && line.Contains(word0))
            {
                line = line.Replace(word0, word1);
                writer.WriteLine(line);
            }
        }

        reader.Close();
        writer.Close();
    }
}