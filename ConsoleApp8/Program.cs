using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {

        static List<double> integrityCheck(List<double> list)
        {
            bool stopLoop = true;
            while (stopLoop)
            {
                if (inputValidation3Int(list) < 3)
                {
                    list = insertingInput();
                }
                else
                {
                    stopLoop = false;
                }
            }
            return list;
        }

        static int inputValidation3Int(List<double> list)
        {
            int countInt = 0;
            foreach (double item in list)
            {
                if (Convert.ToDouble(item) >= 0)
                {
                    countInt++;
                }
            }
            return countInt;
        }

        static List<double> insertingInput()
        {
            Console.WriteLine("insertingInput");
            List<string> list = new List<string> (Console.ReadLine().Split(' '));

            List<double> newList = new List<double>();


            foreach (string item in list)
            {
                try
                {
                    newList.Add(Convert.ToDouble(item));
                }
                catch
                {

                }

            }
            return newList;
        }

        static void printInOrder(List<double> list)
        {
            foreach (double item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("printInOrder");

        }

        static void printNotInOrder(List<double> list)
        {
            List<double> reversList = new List<double>();
            
            foreach (double item in list)
            {
                reversList.Add(item);
            }

            foreach (double item in reversList)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine("printNotInOrder");
        }

        static void printSortList(List<double> list)
        {
            list.Sort();
            foreach(double item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("printSortList");
        }

        static void printBigItem(List<double> list)
        {
            double big = list[0];
            foreach (double item in list)
            {
                if (item > big)
                {
                    big = item;
                }
            }
            Console.WriteLine($"The itam of big is {big}");
            Console.WriteLine("printBigItem");
        }

        static void printLowItem(List<double> list)
        {
            double low = list[0];
            foreach (double item in list)
            {
                if (item < low)
                {
                    low = item;
                }
            }
            Console.WriteLine($"The itam of big is {low}");
            Console.WriteLine("printLowItem");
        }


        static void printAverageOfList(List<double> list)
        {
            double sum = 0;
            int count = 0;
            foreach (double item in list)
            {
                sum += item;
                count++;
            }
            Console.WriteLine($"The average of list is {sum / count}");
            Console.WriteLine("printAverageOfList");
        }


        static void printCountOfAlements(List<double> list)
        {
            int count = 0;
            foreach (double _ in list)
            {
                count++;
            }
            Console.WriteLine($"The count of list is {count}");
            Console.WriteLine("printCountOfAlements");
        }


        static void printSumOfAllAlements(List<double> list)
        {
            double total = 0;
            foreach(double item in list)
            {
                total += item;
            }
            Console.WriteLine($"The totel the sum is {total}");
            Console.WriteLine("printSumOfAllAlements");
        }






        static bool menu(List<double> list)
        {

            list = integrityCheck(list);

            while (true)
            {
                Console.WriteLine("To replace the input, press 1.\r\n" +
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
                            list = insertingInput();
                            list = integrityCheck(list);

                            return true;
                        case 2:
                            printInOrder(list);
                            return true;
                        case 3:
                            printNotInOrder(list);
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




        static void Main(string[] args)
        {
            bool stopingLoop = true;
            List<double> list = new List<double>();

            while (stopingLoop)
            {
                stopingLoop = menu(list);
            }



        }
    }
}
