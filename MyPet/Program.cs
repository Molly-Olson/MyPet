namespace MyPet
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            bool loop = true;
            string path = @"C:\Temp\TigerData.txt";

            Console.WriteLine("----------------------------");
            Console.WriteLine("Meet your new pet TIGER!");
            Console.WriteLine("----------------------------");

            // code to display image of tiger.jpgfrom forms image list

            Console.WriteLine("----------------------------");
            Console.WriteLine("What would you like to name your new pet?");
            Console.WriteLine("----------------------------");

            string tigerName = Console.ReadLine();

            Tiger tiger = new Tiger { Name = tigerName };

            Console.WriteLine("----------------------------");
            Console.WriteLine($"Your pet tiger is now named {tiger.Name}, exceptional choice!");
            Console.WriteLine("----------------------------");

            // code to display image of highfivebruhtiger.jpg from forms image list

           


            //    string relativePath = Path.Combine("Images", "Tiger.jpg");
            //    string absolutePath = Path.GetFullPath(relativePath);
            //    Console.WriteLine($"Image Path: {absolutePath}");
            //    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(absolutePath) { UseShellExecute = true });
        }
    }
}
