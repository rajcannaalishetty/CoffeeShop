using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace CoffeeShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int result=0;
        ComeAgain:
            
            Console.WriteLine("\nwelcome to coffee day please enter u coffee size.\n1    small size   2$\n2    medium size   4$\n3    large size   6$");
            int CustomerChoice = int.Parse(Console.ReadLine());

            switch (CustomerChoice)
            {
                case 1:
                    Console.WriteLine("\nthe coffee u have chosen is small size ");
                    result = result+2;
                    break;

                case 2:
                    Console.WriteLine("\nthe coffee u have chosen is medium size  ");
                    result = result+4;
                    break;

                case 3:
                    Console.WriteLine("\nthe coffee u have chosen is large size is ");
                    result = result+6;
                    break;
                default:
                    Console.WriteLine("\nooops ...something went wrong...please try again");
                    break;
                    
            }

            Console.WriteLine("\n\ndo u want to shop again in the coffee day....?????\npress \"yes\" to shop again\npress\"no\" to check out");
            
            string Reply = Console.ReadLine();
            Rechoice:
            switch (Reply.ToUpper())
            {
                case "YES":
                    Console.WriteLine("\nthanks for shopping again");
                    goto ComeAgain;
                    

                case "NO":
                    Console.WriteLine("\n\nwe are sorry to see u go..look at the bill");
                    goto GoToBill;

                default:
                    Console.WriteLine("\nsomething went wrong ...pleasse try again");
                    goto Rechoice;
                    
                       

            }

            GoToBill:
            Console.WriteLine("\nyour final bill is {0}",result);
            Console.WriteLine("\n\n********thank u********");
            Console.Read();
        }
    }
}
