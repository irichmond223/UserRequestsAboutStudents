using System;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = {"Ilona","Michael","Viktoriya", "Sarah","Angela","Maria","Scott","David","Victor","Ivan"};
            string[] food = {"Tacos","Potato Salad","Borsch","Ice Cream","Meat Loaf","Soup","Steak","Beef Stew","Pizza","Donuts"};
            string[] hometown = {"Kiev","Dnipro","Lugansk","Detroit","Ann Arbor","Grand Rapids","Las Vegas","New York","Chicago","Los Angeles"};

            //try use "\n" 
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
                                Console.WriteLine("That data does not exist. Please try again. (enter or “hometown” or “favorite food”)");
                                knowMoreInput = true;
                                
                            }
                        }

                        Console.WriteLine("Would you like to know more? (enter yes or no)");
                        string againInput = Console.ReadLine();


                        if (againInput == "yes")
                        {
                            knowMoreInput = true;
                        }
                        else if (againInput == "no")
                        {
                            Console.WriteLine("Thanks!");
                            knowMoreInput = false;
                            playAgain = false;
                        }       
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("That student does not exist.Please try again. (enter a number 1 - 3)");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter words only.Please try again.");
                }
            
            }
        }
    }
}
