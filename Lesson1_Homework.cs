using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            task 1
            Console.WriteLine ("Enter square size = ");
            double square;
            double.TryParse(Console.ReadLine(), out square);
            double p = 4 * Math.Sqrt(square);
            Console.WriteLine ($"Perimeter = {p}");
    
            task 2
            Console.WriteLine ("Enter perimeter of triangle = ");
            double perimeter;
            double.TryParse(Console.ReadLine(), out perimeter);
            double a = perimeter / 3; //length of each side
            double s = (Math.Pow(a, 2) * Math.Sqrt(3) / 4);
            Console.WriteLine ($"a = {a}, Square = {s}");
    
            task 3
            Console.WriteLine ("Enter first number = ");
            double firstNum;
            double.TryParse(Console.ReadLine(), out firstNum);
            Console.WriteLine ("Enter second number = ");
            double secondNum;
            double.TryParse(Console.ReadLine(), out secondNum);
            double res = (Math.Pow(firstNum, 3) + Math.Pow(secondNum, 3))/2;
            Console.WriteLine ($"result = {res}"); 
    
            task 4
            Console.WriteLine ("Enter first number = ");
            double firstNum;
            double.TryParse(Console.ReadLine(), out firstNum);
            Console.WriteLine ("Enter second number = ");
            double secondNum;
            double.TryParse(Console.ReadLine(), out secondNum);
            double res = Math.Sqrt(Math.Abs(firstNum) * Math.Abs(secondNum));
            Console.WriteLine ($"result = {res}"); 
    
            task 5
            Console.WriteLine ("Enter first number = ");
            double firstNum;
            double.TryParse(Console.ReadLine(), out firstNum);
            Console.WriteLine ("Enter second number = ");
            double secondNum;
            double.TryParse(Console.ReadLine(), out secondNum);
            double res = firstNum * secondNum/2;
            Console.WriteLine ($"result = {res}"); 
    
            task 6
            Console.WriteLine ("Enter first number = ");
            double firstNum;
            double.TryParse(Console.ReadLine(), out firstNum);
            Console.WriteLine ("Enter second number = ");
            double secondNum;
            double.TryParse(Console.ReadLine(), out secondNum);
            double res = (firstNum + secondNum)*2;
            Console.WriteLine ($"result = {res}"); 
    
            task 7
            Console.WriteLine ("Enter cube square = ");
            double s;
            double.TryParse(Console.ReadLine(), out s);
            double res = Math.Sqrt (s/6);
            Console.WriteLine ($"result = {res}"); 
    
            task 8
            int[] arr = new int[6];
            string[] coord = new string[6] {"x1", "y1", "x2", "y2", "x3", "y3"};
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine ("Enter {0} = ", coord[i]);
                arr[i] = Int32.Parse(Console.ReadLine());
            }
            double [] side = new double [3];
            side[0] = Math.Sqrt(Math.Pow((arr[2] - arr[0]), 2) + Math.Pow((arr[3] - arr[1]), 2));
            side[1] = Math.Sqrt(Math.Pow((arr[4] - arr[0]), 2) + Math.Pow((arr[5] - arr[1]), 2));
            side[2] = Math.Sqrt(Math.Pow((arr[4] - arr[2]), 2) + Math.Pow((arr[5] - arr[3]), 2));

            double per = side[0] + side[1] + side[2];
            double p = per / 2;
            double s = Math.Sqrt(p * (p - side[0]) * (p - side[1]) * (p - side[2]));
            Console.WriteLine ("perimeter = {0}, square = {1}", per, s);  //4,5,6 per = 15, s = 9,92

             task 9 
            Console.WriteLine("Enter length of circle  = ");
            double len = double.Parse(Console.ReadLine());
            Console.WriteLine (" Radius of circle is {0}", len/(2*Math.PI));

            task 10
            Console.WriteLine("Enter r1  = ");
            double r1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter r2  = ");
            double r2 = double.Parse(Console.ReadLine());
            double s1 = Math.PI * Math.Pow(r1, 2);
            double s2 = Math.PI * Math.Pow(r2, 2);
            Console.WriteLine("Result is {0}", s2 - s1);

            task 11
            Random random = new Random();
            Console.WriteLine(random.Next());

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(random.Next(0, 11));
                Console.WriteLine(random.Next(20, 51));
                Console.WriteLine(random.Next(-10, 11));
            }

            task 12
            Random random = new Random();
            int diap = random.Next(3, 16);
            for (int i = 0; i < diap; i++)
            {
                Console.WriteLine(random.Next(-10, 36));
            }

            task 13
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                int sign = random.Next(1, 11);

                Console.WriteLine(sign > 5 ? random.NextDouble() * 100 : random.NextDouble() * (-100));
            }

            Console.ReadKey();
        }
    }
}
