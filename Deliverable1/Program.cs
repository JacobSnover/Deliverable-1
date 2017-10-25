using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliverable1
{
    class Program
    {   /*I create a constant to determine the size of
        *the array's that I will create later*/
        public const int MAX_SIZE = 10;

        static void Main(string[] args)
        {
            /*I first use the class EnhancedArray that I have created
             * to declare my objects, that will be my array's
             * which I will later populate with user responses
             * I also use my max size to establish my array size*/
            EnhancedArray firstArray = new EnhancedArray(MAX_SIZE);
            EnhancedArray secondArray = new EnhancedArray(MAX_SIZE);

            //My first interaction with the user, through a console write command
            Console.WriteLine("Hello, my name is ShaKyTop. What is your name?");

            //I want to create a variable "name", and let the user define its output
            string name = Console.ReadLine();

            /*I add the user response to my next console write method,
             * while giving the user a task which allows me to populate
             * the empty array's which I have created*/
            Console.WriteLine("Hello " + name + ", I will now need 3 numbers from you, " +
                              "and please press enter after each number");
            firstArray.PromptUserForInput();


            //I now ask the user for another task, to populate my second array
            Console.WriteLine("And now " + name + ", I will need 3 more numbers, " +
                              "and please press enter after each number. ");
            secondArray.PromptUserForInput();



            /*I use console write method to explain the equation,
             * which uses a class that was created to determine our outcome*/
            Console.WriteLine("And now if I take the 2 groups of numbers you gave me. ");
            Console.WriteLine("I will use a simple math equation, ");
            Console.WriteLine("and determine if each corresponding place, has equal sums. ");
           
                



            /*I do not have to show the answers to the user just prove whether true or false
             *I use the bool type to determine a true/false value 
             *I also use the if\else statement to create my "equation"
             *I create a numberPairs array, which I will use in the "equation"
             * I then tell the program to use this new array in my addition process.
             * After the math is done, I use the equality operator to determine
             * whether my outcome is true or false, and then breaks the loop after completed*/

            bool allNumsAreSame = false;
            int[] numberPairs = new int[firstArray.Pointer];
            for (int i = 0; i < numberPairs.Length; i++)
            {
                numberPairs[i] = firstArray.ArrayOfNumbers[i] + secondArray.ArrayOfNumbers[i];
            }
            for (int i = 0; i < firstArray.Pointer - 1; i++)
            {
                if (numberPairs[i] == numberPairs[i + 1])
                {
                    allNumsAreSame = true;
                }
                else
                {
                    allNumsAreSame = false;
                    break;
                }
            }


            /*I use the outcome determined by the if/else statement,
             * to produce a written outcome to the user*/
            if (allNumsAreSame)
            {
                Console.WriteLine("And with the numbers you have entered, this is true. ");
            }
            else
            {
                Console.WriteLine("I'm sorry but with the numbers you have entered, this is false. ");
            }
            /*I use console readkey to have to program,
             * pause and wait for a key press from the user
             * which will also give the user time to read 
             * the programs response*/
            Console.ReadKey();

        }
        /*Here I use a data conversion to make sure that,
         * my user input is in correct format. I also
         * use the parse method to search the string
         * for the data that I need to use */

        public static int ConvertToInt32(string parse)
        {
            return Int32.Parse(parse);
        }
        /*This will be the EnhancedArray private class that,
         * can only be accessed within this class
         * I will use to build my arrays. */
        private class EnhancedArray
        {
            /*Here is where I first create a public array that I can populate with user inputs
             * I also declare my object pointer, which I will use to populate the array in the correct order
             * And then I use the Push method, to determine what I will be doing with the user input
             * which uses the pointer object to dtermine where to place the data*/
            public int[] ArrayOfNumbers { get; set; }
            public int Pointer { get; set; }
            public void PushToArray(int value)
            {
                ArrayOfNumbers[Pointer] = value;
                Pointer++;
            }
            public EnhancedArray(int size)
            {
                this.ArrayOfNumbers = new int[size];
                this.Pointer = 0;
            }
            /*I setup my PropmtUser function, which I will
             * use to take the user input and populate
             * my array's. I first use a for loop which will
             * start at the first point of the array, I then
             * state that if the variable i is less then 3 in my array
             * to continue with the loop. I also tell the loop to
             * incrementally add 1 to the variable i with the logical operator ++
             * I use the console write command to ask the user for input
             * which then use the PushTo method to add the user input to my array.
             * Once the loop is complete I use console write to let the user know*/
            public void PromptUserForInput()
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Please input a number. ");
                    this.PushToArray(ConvertToInt32(Console.ReadLine()));
                }
                Console.WriteLine("Thank you for the three numbers. ")
            }

        }
    }
}


