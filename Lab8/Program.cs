using System;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayOfStudents students = new ArrayOfStudents(); //Calling a class and a method within a class - create an object only if data type of the method is not void.
            //Just call the class and pass method into it
            ArrayOfStudents.Arrays();

            //Another way for passing voer method through class:
            //Data type is bool, this is why we are using object.
            //LoopYesOrNo loop = new LoopYesOrNo();
            //LoopYesOrNo.LoopAgain();
        }
        /// <summary>
        /// Method LoopAgain was created to know more about another student or not
        /// </summary>
        /// <returns></returns>

        public class LoopYesOrNo
        {
            public static bool LoopAgain()
            {
                bool playAgain = true;
                Console.WriteLine("Would you like to know more? (enter yes or no)");
                try
                {
                    string againInput = Console.ReadLine();


                    if (againInput == "yes")
                    {
                        return playAgain = true;

                    }
                    else if (againInput == "no")
                    {
                        Console.WriteLine("Thanks!");

                        return playAgain = false;
                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter words only. Please try again.");
                }
                return playAgain;
            }
        }

        public class ArrayOfStudents
        {
            public static void Arrays()
            {
                string[] names = { "Ilona", "Michael", "Viktoriya", "Sarah", "Angela", "Maria", "Scott", "David", "Victor", "Ivan" };
                string[] food = { "Tacos", "Potato Salad", "Borsch", "Ice Cream", "Meat Loaf", "Soup", "Steak", "Beef Stew", "Pizza", "Donuts" };
                string[] hometown = { "Kiev", "Dnipro", "Lugansk", "Detroit", "Ann Arbor", "Grand Rapids", "Las Vegas", "New York", "Chicago", "Los Angeles" };

                //try use "\n".
                //Used + 1 in writeLine to list the names starting from 1 instead of default 0.
                Console.WriteLine("Welcome to our C# class.  ");

                for (int i = 0; i < names.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {names[i]}");

                }

                bool playAgain = true;
                while (playAgain)
                {
                    Console.WriteLine("Which student would you like to learn more about? (enter a number 1 - 10):");
                    try
                    {
                        string stringUserInput = Console.ReadLine();

                        //Converted to integer and added -1 to count user input starting from 1 instead of 2. Example: typed in 1, Michael appears as 1.
                        int intUserInput = int.Parse(stringUserInput) - 1;

                        bool knowMoreInput = true;

                        while (knowMoreInput)
                        {
                            Console.WriteLine($"Student {stringUserInput} is {names[intUserInput]}. What would you like to know about {names[intUserInput]}? (enter or “hometown” or “favorite food”):");

                            string userInput = Console.ReadLine();
                            if (userInput == "hometown")
                            {
                                Console.WriteLine($"{names[intUserInput]} is from {hometown[intUserInput]}.  ");
                                knowMoreInput = false;

                            }
                            else if (userInput == "favorite food")
                            {
                                Console.WriteLine($"{names[intUserInput]} likes {food[intUserInput]}.  ");
                                knowMoreInput = false;
                            }
                            else
                            {
                                Console.WriteLine("That data does not exist. Please try again. (enter “hometown” or “favorite food”)");
                                knowMoreInput = true;
                            }

                        }
                        //Connected the main loop to the method that is resposible for continue and end the program (Added class)
                        playAgain = LoopYesOrNo.LoopAgain();

                    }

                    catch (FormatException) //Used when the user typed in in a wrong format, in this case in words instead of numbers.
                    {
                        Console.WriteLine("Enter numbers only. Please try again.");
                    }
                    catch (IndexOutOfRangeException) //Used when the number exceedes 1-10 range.
                    {
                        Console.WriteLine("That student does not exist. Please try again.");
                    }
                    catch (ArgumentNullException)
                    {
                        Console.WriteLine("Value cannot be null. Try again.");
                    }

                }

            }
        }

    }
}

