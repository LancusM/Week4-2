using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //This one was very easy and understandable. Barely did any research!
            //sets up decision of user, anything but 0 ends the loop.
            int decision = 1;
            while (decision != 0) {
                //sets the array up, 1-10
                int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                //Prompts user for which action they wish to perform, or 0 to quit.
                Console.WriteLine("What action would you like to perform?");
                Console.WriteLine("Print the array(1), Sum the array(2), Find Min and Max(3), Reverse the array(4), or Quit (0)?");
                decision = Convert.ToInt32(Console.ReadLine());

                if (decision == 1)
                {
                    //User enters '1', program displays each value in the array until it runs out
                    foreach (int i in ints)
                    {
                        Console.Write(i + " ");
                    }
                    Console.ReadLine();
                }
                else if (decision == 2)
                {
                    //User enters '2', program uses same kind of foreach statement to sum up all the values, then display the result
                    //needed to state sum value to then use in the foreach loop
                    int sum = 0;
                    foreach (int i in ints)
                    {
                        sum += i;
                    }
                    Console.WriteLine("The sum is " + sum);
                    Console.ReadLine();
                }
                else if (decision == 3)
                {
                    //user enters '3', program sets up min and max values at the base of the array, [0] (which is 1 in the array), and then the min checks, stays where it is, max checks, moves on to 10.
                    int min = ints[0];
                    int max = ints[0];
                    foreach (int i in ints)
                    {
                        if (i < min)
                            min = i;
                        if (i > max)
                            max = i;
                    }
                    Console.WriteLine(min + " is the minimum, " + max + " is the maximum.");
                    Console.ReadLine();
                }
                else if (decision == 4)
                {
                    //user inputs '4', the code simply reverses the array and displays it, easy!
                    Array.Reverse(ints);

                    foreach (int i in ints)
                    {
                        Console.Write(i + " ");
                    }
                    Console.ReadLine();
                }
            }
        }
    }
}
