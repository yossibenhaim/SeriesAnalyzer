using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleApp8
{
    internal class Program
    {
        public static List<double> list = new List<double>();


        //----------------------------------------------

        static List<double> chengeStringToDouble(string[] list)
        {
            List<double> newList = new List<double>();

            foreach (string item in list)
            {
                try { newList.Add(Convert.ToDouble(item)); } catch { }
            }
            return newList;
        }

        //----------------------------------------------

        static void print_all_item(List<double> list)
        {
            foreach (double item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("");
        }

        //----------------------------------------------

        static List<double> integrityCheck()
        {
            bool stopLoop = true;
            while (stopLoop)
            {
                if (inputValidation() < 3)
                {
                    Console.WriteLine("Incorrect insertion of a limb. Insert again!");
                    insertingInput();
                }
                else
                {
                    stopLoop = false;
                }
            }
            return Program.list;
        }

        //----------------------------------------------

        static int inputValidation()
        {
            int countPositive = 0;
            
            foreach (double item in Program.list)
            { if (Convert.ToDouble(item) >= 0) {countPositive++;} }
            
            return countPositive;
        }

        //----------------------------------------------

        static void insertingInput()
        {
            Console.WriteLine("insertingInput");

            string[] list = Console.ReadLine().Split(' ');

            Program.list = chengeStringToDouble(list);
        }

        //----------------------------------------------

        static void printInOrder(List<double> list)
        {
            Console.Write("the list is: ");
            print_all_item(list);
        }

        //----------------------------------------------

        static void printReversInOrder(List<double> list)
        {
            
            Console.Write("The reverse list is: ");

            for (int i = list.Count-1; i >= 0; i--)
            { Console.Write (list[i] + " "); }
            Console.WriteLine("");

        }

        //----------------------------------------------

        static void printSortList(List<double> list)
        {
            List<double> sortlist = list;
            sortlist.Sort();
            Console.Write("The sorted series: "); print_all_item(list);
        }

        //----------------------------------------------

        static void printBigItem(List<double> list)
        {
            double big = list[0];

            foreach (double item in list) { if (item > big) { big = item; } }

            Console.WriteLine($"The itam of big is: {big}");
        }

        //----------------------------------------------

        static void printLowItem(List<double> list)
        {
            double low = list[0];

            foreach (double item in list) { if (item < low) { low = item; } }

            Console.WriteLine($"The itam of big is: {low}");
        }

        //----------------------------------------------

        static void printAverageOfList(List<double> list)
        {
            double sum = 0;

            foreach (double item in list) { sum += item; }

            Console.WriteLine($"The average of list is: {sum / list.Count()}");
        }

        //----------------------------------------------

        static void printCountOfAlements(List<double> list)
        {
            Console.WriteLine($"The count of list is: {list.Count()}");
        }

        //----------------------------------------------

        static void printSumOfAllAlements(List<double> list)
        {
            double total = 0;
           
            foreach(double item in list) { total += item; }

            Console.WriteLine($"The totel the sum is: {total}");
        }

        //----------------------------------------------

        static bool menu()
        {
            Program.list = integrityCheck();

            while (true)
            {
                Console.WriteLine("\n\n---------------Series Analyzer---------------" +
                    "\n\nTo replace the input, press 1.\r\n" +
                "To print the input in the order it was printed, press 2.\r\n" +
                "To print the input in reverse order, press 3.\r\n" +
                "To print the input in sorted order, press 4.\r\n" +
                "To print the largest element in the input, press 5.\r\n" +
                "To print the smallest element in the input, press 6.\r\n" +
                "To print the average of the input, press 7.\r\n" +
                "To print the number of elements in the input, press 8.\r\n" +
                "To print the sum of the elements in the input, press 9.\r\n" +
                "To exit, press 10.");


                string chiech = Console.ReadLine();
                try
                {
                    switch (Convert.ToInt32(chiech))

                    {
                        case 1:
                            insertingInput();
                            integrityCheck();
                            return true;
                        case 2:
                            printInOrder(list);
                            return true;
                        case 3:
                            printReversInOrder(list);
                            return true;
                        case 4:
                            printSortList(list);
                            return true;
                        case 5:
                            printBigItem(list);
                            return true;
                        case 6:
                            printLowItem(list);
                            return true;
                        case 7:
                            printAverageOfList(list);
                            return true;
                        case 8:
                            printCountOfAlements(list);
                            return true;
                        case 9:
                            printSumOfAllAlements(list);
                            return true;
                        case 10:
                            return false;
                        default:
                            return false;

                    }
                }
                catch
                {
                    Console.WriteLine("You have sent invalid input.\n" +
                        "Please try again.\n" +
                        "Be sure to choose between 1 - 10.\n");
                }
            }
        }


        //----------------------------------------------

        static void Main(string[] args)
        {
            Program.list = chengeStringToDouble(args);
            bool stopingLoop = true;

            while (stopingLoop) { stopingLoop = menu(); }

        }
    }
}
