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
        public static List<double> list = new List<double>();

        static void printDouble(double item)
        {
            Console.WriteLine(item);
        }

        static void printString(string str)
        {
            Console.WriteLine(str);
        }

        static void print_all_item(List<double> list)
        {
            foreach (double item in list)
            {
                printDouble(item);
            }
        }

        static List<double> integrityCheck()
        {
            bool stopLoop = true;
            while (stopLoop)
            {
                if (inputValidation3Int() < 3)
                {
                    printString("Incorrect insertion of a limb. Insert again!");
                    insertingInput();
                }
                else
                {
                    stopLoop = false;
                }
            }
            return Program.list;
        }

        static int inputValidation3Int()
        {
            int countPositive = 0;
            foreach (double item in Program.list)
            {
                if (Convert.ToDouble(item) >= 0)
                {
                    countPositive++;
                }
            }
            return countPositive;
        }

        static void insertingInput()
        {
            printString("insertingInput");
            List<string> list = new List<string>(Console.ReadLine().Split(' '));
            List<double> newList = new List<double>();

            foreach (string item in list)
            {
                try
                {
                    newList.Add(Convert.ToDouble(item));
                }
                catch { }
            }
            Program.list = newList;
        }

        static void printInOrder(List<double> list)
        {
            print_all_item(list);
            printString("printInOrder");

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
                printDouble(item);
            }
            
            Console.WriteLine("printNotInOrder");
        }

        static void printSortList(List<double> list)
        {
            list.Sort();
            print_all_item(list);
            printString("printSortList");
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
            printString($"The itam of big is {big}");
            printString("printBigItem");
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
            printString($"The itam of big is {low}");
            printString("printLowItem");
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
            printString($"The average of list is {sum / count}");
            printString("printAverageOfList");
        }


        static void printCountOfAlements(List<double> list)
        {
            int count = 0;
            foreach (double _ in list)
            {
                count++;
            }
            printString($"The count of list is {count}");
            printString("printCountOfAlements");
        }


        static void printSumOfAllAlements(List<double> list)
        {
            double total = 0;
            foreach(double item in list)
            {
                total += item;
            }
            printString($"The totel the sum is {total}");
            printString("printSumOfAllAlements");
        }






        static bool menu()
        {

            Program.list = integrityCheck();

            while (true)
            {
                printString("To replace the input, press 1.\r\n" +
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
                    printString("You have sent invalid input.\n" +
                        "Please try again.\n" +
                        "Be sure to choose between 1 - 10.\n");
                }
            }
        }




        static void Main(string[] args)
        {
            bool stopingLoop = true;


            while (stopingLoop)
            {
                stopingLoop = menu();
            }



        }
    }
}
