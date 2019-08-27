using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8
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
                            // Task #1  Дан массив размером n×n, элементы которого целые числа.
                            //1. Подсчитать среднее арифметическое нечетных элементов, расположенных выше главной диагонали.
                            header("1");
                            int n = 4;
                            int[,] arr = new int[n, n];
                            fillRandomArr(arr);
                            printArr(arr);
                            task1(arr);
                            break;
                        }
                    case "2":
                        {
                            // Task 2
                            //2. Подсчитать среднее арифметическое четных элементов, расположенных ниже главной диагонали.
                            int n = 4;
                            int[,] arr = new int[n, n];
                            fillRandomArr(arr);
                            printArr(arr);
                            task2(arr);
                            break;
                        }
                    case "3":
                        {
                            //3. Подсчитать сумму элементов, расположенных на побочной диагонали.
                            int n = 4;
                            int[,] arr = new int[n, n];
                            fillRandomArr(arr);
                            printArr(arr);
                            task3(arr);
                            break;
                        }
                    case "4":
                        {
                            // 4. Подсчитать среднее арифметическое ненулевых элементов, расположенных над
                            // побочной диагональю.

                            header("4");
                            int n = 4;
                            int[,] arr = new int[n, n];
                            fillRandomArr(arr);
                            printArr(arr);
                            task4(arr);
                            break;
                        }
                    case "5":
                        {
                            //5. Подсчитать среднее арифметическое элементов, расположенных под побочной диагональю.

                            header("5");
                            int n = 4;
                            int[,] arr = new int[n, n];
                            fillRandomArr(arr);
                            printArr(arr);
                            task5(arr);

                            break;
                        }
                    case "6":
                        {
                            //6. Поменять местами столбцы по правилу: первый с последним, второй с предпоследним и т.д.
                            header("6");
                            int n = 4;
                            int[,] arr = new int[n, n];
                            fillRandomArr(arr);
                            printArr(arr);
                            task6(arr);
                            printArr(arr);
                            break;
                        }
                    //case "7":
                    //    {
                    //        //7. С 1 января 1990 года по некоторый день прошло m месяцев, определить название текущего месяца.
                    //        header("7");
                    //        int num = random.Next(0, 15);
                    //        Console.WriteLine("Num = {0}", num);
                    //        string currentMonth = task7(num);
                    //        Console.WriteLine("Current month is " + currentMonth);
                    //        break;
                    //    }
                    //case "8":
                    //    {
                    //        //8. С некоторой даты по настоящий день прошло m месяцев, определить название месяца неизвестной даты.
                    //        header("8");
                    //        Console.WriteLine("Enter date in format mm/dd/yyyy");
                    //        string enteredDate = Console.ReadLine();
                    //        Console.WriteLine("Enter passed months value:");
                    //        int m = Int32.Parse(Console.ReadLine());
                    //        string currentMonth = task8(enteredDate, m);
                    //        Console.WriteLine("Current month is " + currentMonth);
                    //        break;
                    //    }
                    //case "9":
                    //    {
                    //        //9.  С некоторой даты по настоящий день прошло m месяцев, найти неизвестную дату.
                    //        header("9");
                    //        Console.WriteLine("Enter date in format mm/dd/yyyy");
                    //        string enteredDate = Console.ReadLine();
                    //        Console.WriteLine("Enter passed months value:");
                    //        int m = Int32.Parse(Console.ReadLine());
                    //        string currentDate = task9(enteredDate, m);
                    //        Console.WriteLine("Current date is " + currentDate);
                    //        break;
                    //    }
                    //case "10":
                    //    {
                    //        //10. С некоторой даты по настоящий день прошло n дней, найти неизвестную дату.
                    //        header("10");
                    //        Console.WriteLine("Enter date in format mm/dd/yyyy");
                    //        string enteredDate = Console.ReadLine();
                    //        Console.WriteLine("Enter passed days value:");
                    //        int n = Int32.Parse(Console.ReadLine());
                    //        string currentDate = task10(enteredDate, n);
                    //        Console.WriteLine("Current date is " + currentDate);
                    //        break;
                    //    }
                    //case "11":
                    //    {
                    //        //11. С 1 января 1990 года по некоторый день прошло m месяцев и n дней,
                    //        // определить название текущего месяца.
                    //        header("11");

                    //        Console.WriteLine("Enter passed days value:");
                    //        int n = Int32.Parse(Console.ReadLine());
                    //        Console.WriteLine("Enter passed months value");
                    //        int m = Int32.Parse(Console.ReadLine());
                    //        string currentDate = task11(n, m);
                    //        Console.WriteLine("Current date is " + currentDate);

                    //        break;
                    //    }
                    //case "12":
                    //    {
                    //        //12.  Дано расписание приемных часов врача. Вывести на экран приемные часы врача в заданный день недели (расписание придумать самостоятельно).
                    //        header("12");
                    //        task12();
                    //        break;
                    //    }

                    //case "13":
                    //    {
                    //        // 13.  Проведен тест, оцениваемый в целочисленный баллах от нуля до ста. Вывести на экран оценку тестируемого в зависимости от набранного количества баллов: от 90 до 100 - отлично от 70 до 89 - хорошо, от 50 до 69 - удовлетворительно, менее 50 - неудовлетворительно;.
                    //        header("13");
                    //        task13();
                    //        break;
                    //    }

                    //case "14":
                    //    {
                    //        //14.  Дан год. Вывести на экран название животного, символизирующего заданный год по восточному календарю.
                    //        header("14");
                    //        task14();
                    //        break;
                    //    }

                    //case "15":
                    //    {
                    //        // Дан возраст человека мужского пола в годах. Вывести на экран возрастную категорию: до года - младенец, от года до 11 лет - ребенок, от 12 до 15 лет - подросток, от 16 до 25 лет - юноша, от 26 до 70 лет - мужчина, более 70 лет - старик.
                    //        header("15");
                    //        task15();
                    //        break;
                    //    }

                    //case "16":
                    //    {
                    //        //16.  Дан пол человека: м - мужчина, ж - женщина. Вывести на экран возможные мужские и женские имена в зависимости от введенного пола.
                    //        header("16");
                    //        task16();
                    //        break;
                    //    }

                    //case "17":
                    //    {
                    //        //17.  Дан признак транспортного средства: a - автомобиль, в - велосипед, м - мотоцикл, с - самолет, п - поезд. Вывести на экран максимальную скорость транспортного средства в зависимости от введенного признака.
                    //        header("17");
                    //        task17();
                    //        break;
                        //}

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

        private static void task6(int[,] arr)
        {
            throw new NotImplementedException();
        }

        private static void task5(int[,] arr)
        {
            double sum = 0;
            double elementsCount = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = arr.GetLength(0) - 1 - i + 1; j < arr.GetLength(1); j++)
                {
                    sum += arr[i, j];
                    elementsCount++;
                }
            }

            Console.WriteLine("sum of all even elements under the second diagonal = {0}", sum);
            Console.WriteLine("count of all even elements under the second diagonal = {0}", elementsCount);
            Console.WriteLine("Average of all even elements under the second diagonal = {0}", sum / elementsCount);
        }

        private static void task4(int[,] arr)
        {

            double sum = 0;
            double elementsCount = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0) - 1 - i ; j++)
                {
                    if (!IsNull(arr[i, j]))
                    {
                        sum += arr[i, j];
                        elementsCount++;
                    }
                }
            }

            Console.WriteLine("sum of all not-null elements under the second diagonal = {0}", sum);
            Console.WriteLine("count of all not-null elements under the second diagonal = {0}", elementsCount);
            Console.WriteLine("Average of all not-null elements under the second diagonal = {0}", sum / elementsCount);
        }

        private static bool IsNull(int p)
        {
            return (p == 0);
        }

        private static void task3(int[,] arr)
        {
            double sum = 0;
            double elementsCount = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {

                sum += arr[i, arr.GetLength(0) - 1 - i];
                elementsCount++;
            }

            Console.WriteLine("sum of all elements on the second diagonal = {0}", sum);
            Console.WriteLine("count of all elements on the second diagonal = {0}", elementsCount);
        }

        private static void task2(int[,] arr)
        {
            double sum = 0;
            double elementsCount = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0 ; j < i; j++)
                {
                    if (IsEven(arr[i, j]))
                    {
                        sum += arr[i, j];
                        elementsCount++;
                    }
                }
            }

            Console.WriteLine("sum of all even elements under the main diagonal = {0}", sum);
            Console.WriteLine("count of all even elements under the main diagonal = {0}", elementsCount);
            Console.WriteLine("Average of all even elements under the main diagonal = {0}", sum / elementsCount);
        }

        private static bool IsEven(int num)
        {
            return (num % 2 == 0);
        }

        private static void fillRandomArr(int[,] arr)
        {
            Random random = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = random.Next(-20, 21);
                }
            }
        }

        private static void printArr(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("{0}\t", arr[i, j]);
                }
                Console.WriteLine();
            }
        }

        private static void task1(int[,] arr)
        {
            double sum = 0;
            double elementsCount = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = i + 1; j < arr.GetLength(1); j++)
                {

                    if (IsOdd(arr[i, j]))
                    {
                        sum += arr[i, j];
                        elementsCount++;
                    }
                }
            }

            Console.WriteLine("sum of all odd elements up the main diagonal = {0}", sum );
            Console.WriteLine("count of all odd elements up the main diagonal = {0}", elementsCount);
            Console.WriteLine("Average of all odd elements up the main diagonal = {0}", sum / elementsCount  );
        }

        private static bool IsOdd(int num)
        {
            return (!(num % 2 == 0));
        }

   

    }
}