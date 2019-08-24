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
                    case "10":
                        {
                            //10. С некоторой даты по настоящий день прошло n дней, найти неизвестную дату.
                            header("10");
                            Console.WriteLine("Enter date in format mm/dd/yyyy");
                            string enteredDate = Console.ReadLine();
                            Console.WriteLine("Enter passed days value:");
                            int n = Int32.Parse(Console.ReadLine());
                            string currentDate = task10(enteredDate, n);
                            Console.WriteLine("Current date is " + currentDate);
                            break;
                        }
                    case "11":
                        {
                            //11. С 1 января 1990 года по некоторый день прошло m месяцев и n дней,
                            // определить название текущего месяца.
                            header("11");

                            Console.WriteLine("Enter passed days value:");
                            int n = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Enter passed months value");
                            int m = Int32.Parse(Console.ReadLine());
                            string currentDate = task11(n, m);
                            Console.WriteLine("Current date is " + currentDate);

                            break;
                        }
                    case "12":
                        {
                            //12.  Дано расписание приемных часов врача. Вывести на экран приемные часы врача в заданный день недели (расписание придумать самостоятельно).
                            header("12");
                            task12();
                            break;
                        }

                    case "13":
                        {
                            // 13.  Проведен тест, оцениваемый в целочисленный баллах от нуля до ста. Вывести на экран оценку тестируемого в зависимости от набранного количества баллов: от 90 до 100 - отлично от 70 до 89 - хорошо, от 50 до 69 - удовлетворительно, менее 50 - неудовлетворительно;.
                            header("13");
                            task13();
                            break;
                        }

                    case "14":
                        {
                            //14.  Дан год. Вывести на экран название животного, символизирующего заданный год по восточному календарю.
                            header("14");
                            task14();
                            break;
                        }

                    case "15":
                        {
                            // Дан возраст человека мужского пола в годах. Вывести на экран возрастную категорию: до года - младенец, от года до 11 лет - ребенок, от 12 до 15 лет - подросток, от 16 до 25 лет - юноша, от 26 до 70 лет - мужчина, более 70 лет - старик.
                            header("15");
                            task15();
                            break;
                        }

                    case "16":
                        {
                            //16.  Дан пол человека: м - мужчина, ж - женщина. Вывести на экран возможные мужские и женские имена в зависимости от введенного пола.
                            header("16");
                            task16();
                            break;
                        }

                    case "17":
                        {
                            //17.  Дан признак транспортного средства: a - автомобиль, в - велосипед, м - мотоцикл, с - самолет, п - поезд. Вывести на экран максимальную скорость транспортного средства в зависимости от введенного признака.
                            header("17");
                            task17();
                            break;
                        }

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

        private static void task17()
        {
            Console.Write(" Enter your vechicle: ");
            char chr = '0';
            chr = Console.ReadLine()[0];
            Console.Clear();
            switch (chr)
            {
                case 'c':
                    {
                        Console.Write("  car 200 km/h");
                        Console.ReadKey(); 
                        break;
                    }
                case 'r':
                    {
                        Console.Write("  Rover 30 км/ч");
                        Console.ReadKey(); 
                        break;
                    }
                case 'b':
                    {
                        Console.Write("  Bike 230 km/h");
                        Console.ReadKey();
                        break;
                    }
                case 'p':
                    {
                        Console.Write("  Plane 1000 km/h");
                        Console.ReadKey(); 
                        break;

                    }
                case 't':
                    {
                        Console.Write("  Train 160 km/h");
                        Console.ReadKey(); 
                        break;
                    }
            }
        }

        private static void task16()
        {
            Console.Write(" Enter desired sex:");
            char chr = '0';
            chr = Console.ReadLine()[0];
            Console.Clear();
            switch (chr)
            {
                case 'm':
                    {
                        Console.Write(" Андрей, Дмитрий, Александр");
                        Console.ReadKey(); break;
                    }
                case 'w':
                    {
                        Console.Write(" Татьяна, Ольга, Алена");
                        Console.ReadKey(); break;
                    }
            }

        }

        private static void task15()
        {
            Console.Write(" Enter age:");
            int year = int.Parse(Console.ReadLine());
            char chr = '0';
            if (year <= 1)
                chr = 'm';
            if (year > 1 && year <= 11)
                chr = 'r';
            if (year > 11 && year <= 15)
                chr = 'p';
            if (year >= 16 && year <= 25)
                chr = 'y';
            if (year >= 26 && year <= 70)
                chr = 'M';
            if (year > 70)
                chr = 's';

            Console.Clear();
            switch (chr)
            {
                case 'm':
                    {
                        Console.Write(" Baby");
                        Console.ReadKey(); break;
                    }
                case 'r':
                    {
                        Console.Write(" Toddler");
                        Console.ReadKey(); break;
                    }
                case 'p':
                    {
                        Console.Write(" Boy ");
                        Console.ReadKey(); break;
                    }
                case 'y':
                    {
                        Console.Write(" Teenager");
                        Console.ReadKey(); break;
                    }
                case 'M':
                    {
                        Console.Write(" Man");
                        Console.ReadKey(); break;
                    }
                case 's':
                    {
                        Console.Write(" Oldman");
                        Console.ReadKey(); break;
                    }
            }
        }

        private static void task14()
        {
            DateTime date = DateTime.Today;
            string sDate = date.ToString("MM/dd/yyyy");
            int year = int.Parse(sDate.Substring(6, 4));
            char chr = '0';
            int punct = (year-800) % 12;
            string str = punct.ToString();
            if (str.Length > 1)
            {  
                chr = str[0];
                char chr1 = str[1];

                if (chr == '1' && chr1 == '0')
                    chr = 'a';
                if (chr == '1' && chr1 == '1')
                    chr = 'b';
                if (chr == '1' && chr1 == '2')
                    chr = 'c';
            }
            else
            {
                chr = str[0];
            }

            switch (chr)
            {
                case '0':
                    {
                        Console.Write("  Dragon");
                        Console.ReadKey(); 
                        break;
                    }
                case '1':
                    {
                        Console.Write("  Snake");
                        Console.ReadKey();
                        break;
                    }
                case '2':
                    {
                        Console.Write("  Horse");
                        Console.ReadKey(); 
                        break;
                    }
                case '3':
                    {
                        Console.Write("  Goat");
                        Console.ReadKey(); 
                        break;
                    }
                case '4':
                    {
                        Console.Write("  Monkey");
                        Console.ReadKey(); 
                        break;
                    }
                case '5':
                    {
                        Console.Write("  Rooster");
                        Console.ReadKey(); 
                        break;
                    }
                case '6':
                    {
                        Console.Write("  Dog");
                        Console.ReadKey();
                        break;
                    }
                case '7':
                    {
                        Console.Write("   Pig");
                        Console.ReadKey(); 
                        break;
                    }
                case '8':
                    {
                        Console.Write("   Rat");
                        Console.ReadKey(); 
                        break;
                    }
                case '9':
                    {
                        Console.Write("    Bull");
                        Console.ReadKey(); 
                        break;
                    }
                case 'a':
                    {
                        Console.Write("  Tiger");
                        Console.ReadKey(); 
                        break;
                    }
                case 'b':
                    {
                        Console.Write("   Rabbit");
                        Console.ReadKey(); 
                        break;
                    }
            }
        }

        private static void task13()
        {
            Console.Write(" Enter score of a student: ");
            int count = int.Parse(Console.ReadLine());
            char chr = 'o';
            if (count >= 90 && count <= 100)
                chr = 'o';
            if (count >= 70 && count < 90)
                chr = 'h';
            if (count >= 50 && count < 70)
                chr = 'u';
            if (count < 50)
                chr = 'n';

            switch (chr)
            {
                case 'o':
                    {
                        Console.Write(" Excellent - A");
                        Console.ReadKey(); break;
                    }
                case 'h':
                    {
                        Console.Write(" Good - B");
                        Console.ReadKey(); break;
                    }
                case 'u':
                    {
                        Console.Write(" Well - C");
                        Console.ReadKey(); break;
                    }
                case 'n':
                    {
                        Console.Write(" No Good - D");
                        Console.ReadKey(); break;
                    }
            }
        }

        private static void task12()
        {
            Console.Write("Enter day of week: m - monday, t - tuesday, w - wednesday, T- Thursday, f -Friday ");
            char chr = Console.ReadLine()[0];
            Console.Clear();
            switch (chr)
            {
                case 'm':
                    {
                        Console.Write("  Monday 8.00-12.00");
                        Console.ReadKey(); break;
                    }
                case 't':
                    {
                        Console.Write("  Tuesday 13.00-16.00");
                        Console.ReadKey(); break;
                    }
                case 'w':
                    {
                        Console.Write("  Wednesday 16.00-20.00");
                        Console.ReadKey(); break;

                    }
                case 'T':
                    {
                        Console.Write("  Thursday 9.00-13.00");
                        Console.ReadKey(); break;
                    }
                case 'f':
                    {
                        Console.Write("  Friday  8.00-12.00");
                        Console.ReadKey(); break;

                    }
                case 's':
                    {
                        Console.Write(" Doctor's day off ");
                        Console.ReadKey(); break;

                    }
                case 'S':
                    {
                        Console.Write(" Doctor's day off ");
                        Console.ReadKey(); break;
                    }
            }

        }

        private static string task11(int n, int m)
        //11. С 1 января 1990 года по некоторый день прошло m месяцев и n дней,
        {
            //mm/dd/yyyy
            DateTime dateStart = new DateTime(1990, 1, 1);
            DateTime finalDate = dateStart.AddDays(n);
            finalDate = finalDate.AddMonths(m);
            string currentDate = finalDate.ToString("MM/dd/yyyy");
            return currentDate;
        }

        private static string task10(string enteredDate, int n)
        //10. С некоторой даты по настоящий день прошло n дней, найти неизвестную дату.
        {
            //mm/dd/yyyy
            int iDays = Int32.Parse(enteredDate.Substring(0, 2));
            int iMonths = Int32.Parse(enteredDate.Substring(3, 2));
            int iYears = Int32.Parse(enteredDate.Substring(6, 4));
            DateTime dEnteredDate = new DateTime(iYears, iMonths, iDays);
            DateTime finalDate = dEnteredDate.AddDays(n);
            string currentDate = finalDate.ToString("MM/dd/yyyy");
            return currentDate;
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

        private static int getLengthOfMonth(int month)
        {
            int[] lengthOfMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            return lengthOfMonth[month];
        }

        private static int getPassedMonthCount(int days, int startingMonth)
        {
            int[] lengthOfMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            int passedMonthCount = 1;
            int currentMonthCount = startingMonth;

            while (days > 0)
            {
                days = days - lengthOfMonth[currentMonthCount];
                passedMonthCount++;
                currentMonthCount++;
                if (currentMonthCount > 12)
                {
                    currentMonthCount = 1;
                }
            }
            return passedMonthCount;
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