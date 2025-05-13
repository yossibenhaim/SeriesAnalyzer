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
        public static int[] list ;



        //----------------------------------------------

        static void print_all_item(int[] list)
        {
            foreach (int item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("");
        }

        //----------------------------------------------

        static int[] integrityCheck()
        {
            bool stopLoop = true;
            while (stopLoop)
            {
                if (inputValidation3Int(Program.list) < 3)
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

        static int inputValidation3Int(int[] list)
        {
            int countPositive = 0;

            foreach (int item in list)
            { if (item >= 0) {countPositive++;} }
            
            return countPositive;
        }

        //----------------------------------------------

        static void insertingInput()
        {
            Console.WriteLine("insertingInput");

            List<string> list = new List<string>(Console.ReadLine().Split(' '));

            int[] newList = new int[list.Count()];

            for (int i = 0; i > newList.Length; i++)
            {
                try { newList[i] = Convert.ToInt32(list[i]); } catch { }
            }
            Program.list = newList;
        }

        //----------------------------------------------

        static void printInOrder(int[] list)
        {
            Console.Write("the list is: ");
            print_all_item(list);
        }

        //----------------------------------------------

        static void printReversInOrder(int[] list)
        {
            Console.Write("The reverse list is: ");

            for (int i = list.Length-1; i >= 0; i--)
            { Console.Write (list[i] + " "); }
            Console.WriteLine("");

        }

        //----------------------------------------------

        static void printSortList(int[] list)
        {
            int[] sortlist = list;
            Array.Sort(sortlist);
            Console.Write("The sorted series: "); print_all_item(sortlist);
        }

        //----------------------------------------------

        static void printBigItem(int[] list)
        {
            int big = list[0];

            foreach (int item in list) { if (item > big) { big = item; } }

            Console.WriteLine($"The itam of big is: {big}");
        }

        //----------------------------------------------

        static void printLowItem(int[] list)
        {
            int low = list[0];

            foreach (int item in list) { if (item < low) { low = item; } }

            Console.WriteLine($"The itam of big is: {low}");
        }

        //----------------------------------------------

        static void printAverageOfList(int[] list)
        {
            int sum = 0;

            foreach (int item in list) { sum += item; }

            Console.WriteLine($"The average of list is: {sum / list.Count()}");
        }

        //----------------------------------------------

        static void printCountOfAlements(int[] list)
        {
            Console.WriteLine($"The count of list is: {list.Count()}");
        }

        //----------------------------------------------

        static void printSumOfAllAlements(int[] list)
        {
            int total = 0;
           
            foreach(int item in list) { total += item; }

            Console.WriteLine($"The totel the sum is: {total}");
        }

        //----------------------------------------------

        static bool menu()
        {
            Program.list = integrityCheck();

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
            bool stopingLoop = true;

            while (stopingLoop) { stopingLoop = menu(); }

        }
    }
}
