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
                            //1. Дан порядковый номер месяца, вывести на экран количество месяцев оставшихся до конца года.
                            header("1");

                            //double a = 1; //roots 1, 3 //random.Next(0, 10) * random.NextDouble(); 
                            //double b = -4;//random.Next(0, 10) * random.NextDouble();
                            //double c = 3;//random.Next(0, 10) * random.NextDouble();
                            int IDMonth = 4;
                            task1(IDMonth);
                            break;
                        }
                    case "2":
                        {
                            // Task 2
                            //2.  Дан порядковый номер дня месяца, вывести на экран количество дней оставшихся до конца месяца.
                            header("2");
                            int num = random.Next(0, 31);
                            task2(num);
                            break;
                        }
                    case "3":
                        {
                            //3. Вводится символ масти карты (первая буква), определить название масти.
                            header("3");
                            Console.WriteLine("Please enter a character for picking a card suit H U+1F0A1 - Hearts, S - Spades, D - Dimonds, C - Clubs ");
                            string CardSuit = Console.ReadLine();
                            task3(CardSuit);
                          
                            break;
                        }
                    case "4":
                        {
                            //Дан номер карты k (6 k 14), определить достоинство карты. Достоинства определяются по следующему правилу:
                            //туз - 14, король - 13, дама - 12, валет - 11, десятка - 10, …, шестерка - 6.

                            header("4");
                            int k = random.Next(6, 15);
                            Console.WriteLine("k = {0}", k);
                            string card = task4(k);
                            Console.WriteLine("You've picked a " + card);
                            break;
                        }
                    case "5":
                        {
                            //5. Дан номер масти m (1 m 4) и номер достоинства карты k (6 k 14). 
                            // Определить полное название соответствующей карты в виде дама пик, шестерка бубен и т.д.
                            header("5");
                            int m = random.Next(1, 5);
                            Console.WriteLine("m = {0}", m);
                            string cardSuit = task5(m);
                            int k = random.Next(6, 15);
                            Console.WriteLine("k = {0}", k);
                            string card = task4(k);
                            Console.WriteLine( "You've picked {0} of {1}.", card, cardSuit);

                            break;
                        }
                    case "6":
                        {
                            //6. 6.  С 1 января 1990 года по некоторый день прошло n дней, определить название текущего месяца.
                            header("6");
                            int num = random.Next(0, 355);
                            Console.WriteLine("Num = {0}", num);
                            string currentMonth = task6(num);
                            Console.WriteLine("Current month is " + currentMonth);
                            break;
                        }
                    case "7":
                        {
                            //7. С 1 января 1990 года по некоторый день прошло m месяцев, определить название текущего месяца.
                            header("7");
                            int num = random.Next(0, 15);
                            Console.WriteLine("Num = {0}", num);
                            string currentMonth = task7(num);
                            Console.WriteLine("Current month is " + currentMonth);
                            break;
                        }
                    case "8":
                        {
                            //8. С некоторой даты по настоящий день прошло m месяцев, определить название месяца неизвестной даты.
                            header("8");
                            Console.WriteLine("Enter date in format mm/dd/yyyy");
                            string enteredDate = Console.ReadLine();
                            Console.WriteLine("Enter passed months value:");
                            int m = Int32.Parse(Console.ReadLine());
                            string currentMonth = task8(enteredDate, m);
                            Console.WriteLine("Current month is " + currentMonth);
                            break;
                        }
                    case "9":
                        {
                            //9.  С некоторой даты по настоящий день прошло m месяцев, найти неизвестную дату.
                            header("9");
                            Console.WriteLine("Enter date in format mm/dd/yyyy");
                            string enteredDate = Console.ReadLine();
                            Console.WriteLine("Enter passed months value:");
                            int m = Int32.Parse(Console.ReadLine());
                            string currentDate = task9(enteredDate, m);
                            Console.WriteLine("Current date is " + currentDate);
                            break;
                        }
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

        private static string task9(string enteredDate, int m)
        {
            int enteredNum = Int32.Parse(enteredDate.Substring(0, 2));
            int shiftCurrentMonth = 1;
            int currentMonth = ((enteredNum + m - shiftCurrentMonth) % 12);
            int additionalYears = ((enteredNum + m - shiftCurrentMonth) / 12);
            int currentYears = Int32.Parse(enteredDate.Substring(6, 4));
            string currentDate = currentMonth.ToString() + enteredDate.Substring(2, 4) + (currentYears + additionalYears).ToString();
            return currentDate;
        }

        private static string task8(string enteredDate, int m)
        {
            int enteredNum = Int32.Parse (enteredDate.Substring(0,2));
            int shiftCurrentMonth = 1;
            string nameOfCurrentMonth = getNameOfCurrentMonth(enteredNum + m - shiftCurrentMonth);

            return nameOfCurrentMonth;
        }

        private static string getNameOfCurrentMonth(int num)
        {
            string nameOfMonth = "";
            int monthCount = num % 12;

            switch (monthCount)
            {
                case 1:
                    {
                        nameOfMonth = "January";
                        break;
                    }
                case 2:
                    {
                        nameOfMonth = "February";
                        break;
                    }
                case 3:
                    {
                        nameOfMonth = "March";
                        break;
                    }
                case 4:
                    {
                        nameOfMonth = "April";
                        break;
                    }
                case 5:
                    {
                        nameOfMonth = "May";
                        break;
                    }
                case 6:
                    {
                        nameOfMonth = "June";
                        break;
                    }
                case 7:
                    {
                        nameOfMonth = "July";
                        break;
                    }
                case 8:
                    {
                        nameOfMonth = "August";
                        break;
                    }
                case 9:
                    {
                        nameOfMonth = "September";
                        break;
                    }
                case 10:
                    {
                        nameOfMonth = "October";
                        break;
                    }
                case 11:
                    {
                        nameOfMonth = "November";
                        break;
                    }
                case 12:
                    {
                        nameOfMonth = "December";
                        break;
                    }
            }
            return nameOfMonth;
        }

        private static string task7(int num)
        {
            return getNameOfCurrentMonth(num);
        }

        private static string task6(int num)
        {
            int[] lengthOfMonth = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            int monthCount = 1;

            for (int i = 0; i < lengthOfMonth.Length; i++)
            {
                if ((num - lengthOfMonth[i]) > 0)
                {
                    num = num - lengthOfMonth[i];
                    monthCount++;
                }
                else
                {
                    break;
                }
            }

            return getNameOfCurrentMonth (monthCount);
        }

        private static void task2(int IDDays)
        {
            Console.WriteLine("{0} days left till the end of month", (12 - IDDays));
        }

        private static void task1(int IDMonth)
        {
            Console.WriteLine("{0} monthes left till the end of year", (12 - IDMonth));
        }

        private static string task5(int num)
        {
            string CardSuit = "";
            switch (num)
            {

                case 1:
                    {
                        CardSuit ="Hearts";
                        break;
                    }
                case 2:
                    {
                        CardSuit ="Spades";
                        break;
                    }
                case 3:
                    {
                        CardSuit ="Clubs";
                        break;
                    }
                case 4:
                    {
                        CardSuit ="Diamonds";
                        break;
                    }
            }
            return CardSuit;
        }

        private static string task4(int k)
        {
            string card = "";
            switch (k) 
            {
                case 6 : 
                    {
                        card = "six";
                        break;
                    }
                case 7:
                    {
                        card = "seven";
                        break;
                    }
                case 8:
                    {
                        card = "eight";
                        break;
                    }
                case 9:
                    {
                        card = "nine";
                        break;
                    }
                case 10:
                    {
                        card = "ten";
                        break;
                    }
                case 11:
                    {
                        card = "Jack";
                        break;
                    }
                case 12:
                    {
                        card = "Queen";
                        break;
                    }
                case 13:
                    {
                        card = "King";
                        break;
                    }
                case 14:
                    {
                        card = "Ace";
                        break;
                    }
            }
            return card;
        }

        private static void task3(string CardSuit)
        {
            string CardSuitL = CardSuit.ToLower();
            switch (CardSuit[0]){

                case 'h':
                    {
                        Console.WriteLine("You've picked Hearts");
                        break;
                    }
                case 's':
                    {
                        Console.WriteLine("You've picked Spades");
                        break;
                    }
                case 'c':
                    {
                        Console.WriteLine("You've picked Clubs");
                        break;
                    }
                case 'd':
                    {
                        Console.WriteLine("You've picked Diamonds");
                        break;
                    }
            }
        }


    }
}