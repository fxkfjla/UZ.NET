public class Program
{
    public static void Main(string[] args)
    {
        foreach(string str in args)
        {
            string? var = Environment.GetEnvironmentVariable(str);

            if(var != null)
            {
                Console.WriteLine(var);
            }
        }
    }
}