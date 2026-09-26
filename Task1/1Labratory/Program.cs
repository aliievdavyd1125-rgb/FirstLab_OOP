using _1Labratory._1Labratory;

namespace _1Labratory
{

    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введіть номер задачі(1,2,3):");
            int switch_between = int.Parse(Console.ReadLine());
            switch(switch_between)
            {
                case 1:
                    TTriangle triangle1 = new TTriangle(3, 4, 5);

                    //Console.WriteLine($"Периметр: {triangle1.count_perimeter()}");
                    //Console.WriteLine($"Площа: {triangle1.count_area()}");


                    Console.WriteLine($"Сторона А: {triangle1.FillSide_A}");


                    triangle1.FillSide_A = -6;

                    Console.WriteLine($"Площа: {triangle1.count_area()}");
                    Console.WriteLine($"Сторона А: {triangle1.FillSide_A}");

                    Console.ReadKey();
                    break;

                case 2:
                    // Некоретний виадок
                    //double[] mas = { 5, 6, 8, 10 };
                    //Progression my_prog = new Progression(mas);

                    double[] mas = new double[] { 5, 6, 7, 8 };


                    Progression my_prog = new Progression(mas);
                    Console.WriteLine(my_prog[2]);

                    Console.WriteLine(my_prog.CountProgression());

                    my_prog.Input();

                    Console.WriteLine(my_prog.CountProgression());



                    break;

                    

            }       
        }
    }
}
