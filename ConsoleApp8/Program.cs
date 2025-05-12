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

        }

        static void printInOrder()
        {

        }

        static void printNotInOrder()
        {

        }

        static void printSortList()
        {

        }

        static void printBigItem()
        {

        }

        static void printLowItem()
        {

        }


        static void printAverageOfList()
        {

        }


        static void printCountOfAlements()
        {

        }


        static void printSumOfAllAlements()
        {

        }

        static void menu(List<string> list)
        {
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    list = insertingInput();
                    break;
                case 2:
                    printInOrder();
                    break;
                case 3:
                    printNotInOrder();
                    break;
                case 4:
                    printSortList();
                    break;
                case 5:
                    printBigItem();
                    break;
                case 6:
                    printLowItem();
                    break;
                case 7:
                    printAverageOfList();
                    break;
                case 8:
                    printCountOfAlements();
                    break;
                case 9:
                    printSumOfAllAlements();
                    break;
                case 10:
                    printSortList();
                    break;
            }
        }




        static void Main(string[] args)
        {




        }
    }
}
