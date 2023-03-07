public class Program
{
    public static void Main(string[] args)
    {
        foreach (string str in args)
        {
            try
            {
                Console.WriteLine("Directory: " + Directory.GetCurrentDirectory());

                List<string> dirs = Directory.EnumerateDirectories(str).ToList();
                List<string> files = Directory.EnumerateFiles(str).ToList();

                foreach (string dir in dirs)
                {
                    Console.WriteLine(dir);
                }

                foreach(string file in files)
                {
                    Console.WriteLine(file);
                }
            }
            catch
            {
                Console.WriteLine("Directory not found.");
            }
        }
    }
} 
