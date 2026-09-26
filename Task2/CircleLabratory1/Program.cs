namespace CircleLabratory1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TDisk circle = new TDisk();
            Console.WriteLine(circle.Contains(3,4));

            circle.Input();
            Console.WriteLine(circle.Contains(3, 4));

            Console.WriteLine(circle);

        }
    }
}
