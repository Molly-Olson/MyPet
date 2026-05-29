namespace MyPet
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            bool loop = true;

            Console.WriteLine("----------------------------");
            Console.WriteLine("Meet your new pet TIGER!");
            Console.WriteLine("----------------------------");

            string relativePath = "Tiger.jpg";
            string absolutePath = Path.GetFullPath(relativePath);
            Console.WriteLine($"Image Path: {absolutePath}");
        }
    }
}
