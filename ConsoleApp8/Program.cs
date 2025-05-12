using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static bool inputValidation3Int()
        {

        }

        static List<string> insertingInput()
        {
            Console.WriteLine("insertingInput");
        }

        static void printInOrder(List<string> list)
        {
            Console.WriteLine("printInOrder");

        }

        static void printNotInOrder(List<string> list)
        {
            Console.WriteLine("printNotInOrder");
        }

        static void printSortList(List<string> list)
        {
            Console.WriteLine("printSortList");
        }

        static void printBigItem(List<string> list)
        {
            Console.WriteLine("printBigItem");
        }

        static void printLowItem(List<string> list)
        {
            Console.WriteLine("printLowItem");
        }


        static void printAverageOfList(List<string> list)
        {
            Console.WriteLine("printAverageOfList");
        }


        static void printCountOfAlements(List<string> list)
        {
            Console.WriteLine("printCountOfAlements");
        }


        static void printSumOfAllAlements(List<string> list)
        {
            Console.WriteLine("printSumOfAllAlements");
        }

        static bool menu(List<string> list)
        {
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    list = insertingInput();
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




        static void Main(string[] args)
        {




        }
    }
}
