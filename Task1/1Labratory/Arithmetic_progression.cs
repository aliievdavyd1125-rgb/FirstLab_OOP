using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _1Labratory
{
    using System;

    namespace _1Labratory
    {
        internal class Progression
        {
            private double a1;
            private int n;
            private double d;
            private double[] nums;


            public Progression(double[] inputNums)
            {        

                if (Check_Full_Progression(inputNums))
                {         

                    n = inputNums.Length;
                    a1 = inputNums[0];
                    d = inputNums[1] - inputNums[0];

                    this.nums = new double[n];

                    Array.Copy(inputNums, nums, n);
                }

                else
                {
                    throw new ArgumentException("Переданий масив не є дійсною арифметичною прогресією.");
                }
            }

            public double this[int i]
            {
                get
                {
                    if (i < 1) throw new ArgumentOutOfRangeException();

                    return a1 + (i - 1) * d;
                }
            }

            public void Input()
            {        

                double[] inputNums = Console.ReadLine()
                               .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                               .Select(double.Parse)
                               .ToArray();
              
                if (Check_Full_Progression(inputNums))
                {   
                   
                    n = inputNums.Length;
                    a1 = inputNums[0];
                    d = inputNums[1] - inputNums[0];

                    this.nums = new double[n];
                    Array.Copy(inputNums, nums, n);
                }

                
            }

            public void Read()
            {
               Console.WriteLine(string.Join(" ", nums));
            }



            public bool Check_Full_Progression(double[] inputNums)
            {
                if (inputNums == null || inputNums.Length <= 1)
                {
                    throw new ArgumentException("Для дійсності роботи,передайте прогресію щоанайменше з 2 елемнетів");
                }

                double difference = inputNums[1] - inputNums[0];

                for (int i = 1; i < inputNums.Length - 1; i++)
                {
                    if (inputNums[i + 1] - inputNums[i] != difference)
                    {
                        return false;
                    }
                }

                return true;
            }

            public double CountProgression()
            {
                double sum = ((2 * a1 + d * (n - 1)) / 2) * n;
                return sum;
            }
        }
    }
}
