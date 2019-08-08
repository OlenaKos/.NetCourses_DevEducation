using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_Homework_08_08_2019
{
    class Program
    {
        static void header(string text)
        {
            Console.WriteLine("********* Task {0} ***********", text);
        }
        private static Random random = new Random();

        static void Main(string[] args)
        {

            //    static void arrPrint(int[] arr)
            //{
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        Console.WriteLine("arr[{0}] = {1}", i, arr[i]);
            //    }
            //}


            string task = "";
            do
            {
                Console.WriteLine("Enter number of task to be performed. 0 is for exit");
                task = Console.ReadLine(); //"1";

                switch (task)
                {
                    case "0":
                        {
                            Console.WriteLine("Exit");
                            break;
                        }

                    case "1":
                        {
                            // Task #1
                            //1. найти корни квадратного уравнения, где a, b, c – данные вещественные числа;
                            header("1");
                            double a = 1; //roots 1, 3 //random.Next(0, 10) * random.NextDouble(); 
                            double b = -4;//random.Next(0, 10) * random.NextDouble();
                            double c = 3;//random.Next(0, 10) * random.NextDouble();
                            task1(a, b, c);
                            break;
                        }
                    case "2":
                        {
                            // Task 2
                            //2. какая из цифр двухзначного числа больше: первая или вторая;
                            header("2");
                            int num = random.Next(10, 99);
                            task2(num);
                            break;
                        }
                    case "3":
                        {
                            //3. одинаковы ли цифры данного двухзначного числа; 
                            header("3");
                            int num = random.Next(10, 99);
                            bool b = task3(num);
                            if (b)
                            {
                                Console.WriteLine("Digits are equal");
                            }
                            else
                            {
                                Console.WriteLine("Digits are not equal");
                            }
                            break;
                        }
                    case "4":
                        {
                            //4. является ли сумма цифр двухзначного числа четной или нечетной;
                            header("4");
                            int num = random.Next(10, 99);
                            bool b = task4(num);
                            if (b)
                            {
                                Console.WriteLine("Summa of digits is even");
                            }
                            else
                            {
                                Console.WriteLine("Summa of digits is odd");
                            }
                            break;
                        }
                    case "5":
                        {
                            //5. кратна ли числу А сумма цифр двухзначного числа;
                            header("5");
                            int num = random.Next(10, 99);
                            int a = 2;
                            bool b = task5(num, a);
                            if (b)
                            {
                                Console.WriteLine("Summa of digits is a multiple of {0}", a);
                            }
                            else
                            {
                                Console.WriteLine("Summa of digits is not a multiple of {0}", a);
                            }
                            break;
                        }
                    case "6":
                        {
                            //6. какая из цифр трехзначного числа больше;
                            header("6");
                            int num = random.Next(100, 999);
                            int maxDigID = task6(num);
                            Console.WriteLine("id of max digit equal to {0}", maxDigID);
                            break;
                        }
                    case "7":
                        {
                            //7. какая из цифр трехзначного числа меньше;
                            header("7");
                            int num = random.Next(100, 999);
                            int minDigID = task7(num);
                            Console.WriteLine("id of min digit equal to {0}", minDigID);
                            break;
                        }
                    case "8":
                        {
                            //8. все ли цифры трехзначного числа одинаковые;
                            header("8");
                            int num = 888;//random.Next(100, 999);
                            bool b = task8(num);
                            if (b)
                            {
                                Console.WriteLine("All digits are equal");
                            }
                            else
                            {
                                Console.WriteLine("Not all digits are equal");
                            }
                            break;
                        }
                    //case "9":
                    //    {
                    //        //9. существует ли треугольник с длинами сторон a, b, c; является ли треугольник с длинами сторон a, b, c прямоугольным; является ли треугольник с длинами сторон a, b, c равнобедренным;  является ли треугольник с длинами сторон a, b, c равносторонним.
                    //        header("9");
                    //        string s = RandomString(8) + " " + RandomString(3) + " " + RandomString(6);
                    //        task9(s);
                    //        break;
                    //    }
                    //case "10":
                    //    {
                    //        //10. Пользователь вводит с клавиатуры время начала и время завершения телефонного разговора (часы, минуты и секунды). Рассчитать стоимость разговора, если стоимость минуты – 30 копеек.
                    //        header("10");
                    //        task10();
                    //        break;
                    //    }
                    //case "11":
                    //    {
                    //        //11. Пользователь вводит с клавиатуры расстояние, расход бензина на 100 км и стоимость трех видов бензина. Вывести на экран сравнительную таблицу со стоимостью поездки на разных видах бензина.
                    //        header("11");
                    //        string[] arr = new string[3] { "RGA", "", "VGA" };// { RandomString(18), RandomString(18), RandomString(18) };
                    //        task11(arr);

                    //        break;
                    //    }
                    //case "12":
                    //    {
                    //        //12. Дана точка на плоскости с координатами (х, у). Составить программу, которая выдает одно из сообщений Да, Нет, На границе в зависимости от того, лежит ли точка внутри заштрихованной области, вне заштрихованной области или на ее границе.
                    //        header("12");
                    //        string s = RandomString(8) + " " + RandomString(3) + " " + RandomString(6) + " " + RandomString(6) + " " + RandomString(6) + " " + RandomString(6) + " " + RandomString(6) + " " + RandomString(6) + " " + RandomString(6) + " " + RandomString(6);
                    //        task12(s);
                    //        break;
                    //    }

                    default:
                        {
                            Console.WriteLine("You've entered wrong number of task");
                            break;
                        }
                }
            }
            while (task != "0");
            Console.ReadLine();

        }

        private static bool task8(int num)
        {
            bool res = true;
            int[] digits = getDigits(num);
            Console.WriteLine("Num = {0}", num);

            for (int i = 0; i < getDigitsCount(num); i++)
            {
                if (digits[i] != digits[0])
                {
                    res = false;
                    break;
                }
            }

            return res;

        }

        private static int task7(int num)
        {
            int minDigID = 0;
            int[] digits = getDigits(num);
            Console.WriteLine("Num = {0}", num);
            int minDig = digits[0];
            for (int i = 0; i < getDigitsCount(num); i++)
            {
                if (digits[i] < minDig)
                {
                    minDig = digits[i];
                    minDigID = i;
                }
            }
            return minDigID;
        }

        private static int task6(int num)
        {
            int maxDigID = 0; 
            int[] digits = getDigits(num);
            Console.WriteLine("Num = {0}", num);
            int maxDig = digits[0];
            for (int i = 0; i < getDigitsCount(num); i++)
            {
                if (digits[i] > maxDig)
                { 
                    maxDig = digits[i];
                    maxDigID = i;
                }
            }
            return maxDigID;
        }

        private static bool task5(int num, int a)
        {
            bool res = false;
            int[] digits = getDigits(num);
            Console.WriteLine("Num = {0}", num);
            int digitsCount = getDigitsCount(num);
            int sum = 0;
            for (int i = 0; i < digitsCount; i++)
            {
                sum += digits[i];
            }
            if (sum % a == 0)
            {
                res = true;
            }
            return res;
        }

        private static bool task4(int num)
        {
            bool res = false;
            int[] digits = getDigits(num);
            Console.WriteLine("Num = {0}", num);
            int digitsCount = getDigitsCount(num);
            int sum = 0;
            for (int i = 0; i < digitsCount; i++)
            {
                sum += digits[i];
            }
            if (sum % 2 == 0)
            {
                res = true;
            }
            return res;
        }

        private static bool task3(int num)
        {
            bool res = false;
            int[] digits = getDigits(num);
            Console.WriteLine("Num = {0}", num);
            if (digits[0] == digits[1])
            {
                res = true;
            }
            return res;
        }

        private static void task2(int num)
        {
            int[] digits = getDigits(num);
            Console.WriteLine("Num = {0}", num);
            if (digits[0] > digits[1])
            {
                Console.WriteLine("First digit is bigger than second");
            }
            else if (digits[0] == digits[1])
            {
                Console.WriteLine("Digits are equal");
            }
            else
            {
                Console.WriteLine(" First digit is smaller than second");
            }
        }

        private static int[] getDigits(int num)
        {
            int[] digits = new int[10];
            int digitsCount = getDigitsCount(num);
            int j = digitsCount - 1;

            for (int i = 0; i < digitsCount; i++)
            {
                digits[j] = num % 10;
                num = num / 10;
                j--;
            }

            return digits;
        }

        private static int getDigitsCount(int num)
        {
            int digitsCount = 0;
            while (num / 10 != 0)
            {
                digitsCount++;
                num = num / 10;
            }
            digitsCount++;

            return digitsCount;
        }

        private static void task1(double a, double b, double c)
        {
            double D = Math.Pow(b, 2) - 4 * a * c;
            Console.WriteLine("Equasion {0}*X*X +{1}*X + {2} = 0 has discriminant D = {3}", a, b, c, D);
            double x1 = 0, x2 = 0;

            if (D > 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("Equasion has two roots x1 = {0}, x2 = {1}", x1, x2);
            }
            else if (D == 0)
            {
                x1 = (-b) / (2 * a * c);
                x2 = x1;
                Console.WriteLine("Equasion has two equal roots x1 = {0}, x2 = {1}", x1, x2);
            }
            else
            {
                Console.WriteLine("Equasion has no real roots");
            }

        }
    }
}
