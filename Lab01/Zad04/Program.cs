public class Program
{
    public static void Main(string[] args)
    {
        foreach(string str in args)
        {
            try
            {
                List<string> dirs = Directory.EnumerateDirectories(str).ToList();

                foreach(string dir in dirs)
                {
                    Console.WriteLine(dir);
                }

            }
            catch
            {
                Console.WriteLine("Directory not found.");
            }
        }
    }
}