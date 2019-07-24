using System;

namespace GetToKnowYourClassmates
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = { "Tom Sanders", "Eric Fiddlestick", "Grant Chirpus", "Aretha Franklin", "Barock Obama" };
            string[] food = { "Pizza", "Greens", "Bannas", "Pasta", "Potato Salad" };
            string[] hometown = { "Detoit, MI", "Cleveland, OH", "Dallas, TX", "Atlanan, GA", "Seattle, WA" };

            bool go = true;
            while (go)
            {
                try
                {
                    Console.WriteLine("Which student do you want to learn more about?");
                    DisplayPeople(students);
                    int input = GetUserInput();
                    DisplayInfo(input, students, food, hometown);
                    
                    go=Continue();
                }
                catch
                {
                    Console.WriteLine("mmmmmm.....try again.");
                }
            }
        }
        public static void DisplayPeople(string[] students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"{i + 1}: {students[i]}");
            }
        }
        public static void DisplayInfo(int input, string[] students, string[] food, string[] hometown)
        {
            Console.WriteLine($"You picked {students[input - 1]}, What would you like to know about them?(hometown or favorite food)");
            string userInput= Console.ReadLine();

            if (userInput=="hometown")
            {
                Console.WriteLine($"They are from {hometown[input-1]}!");
            }
            else if(userInput=="favorite food")
            {
                Console.WriteLine($"Their favorite food is {food[input -1]}");
            }
            else
            {
                
            }
        }
        public static int GetUserInput()
        {
            return int.Parse(Console.ReadLine());
        }
        public static bool Continue()
        {
            Console.WriteLine($"Press {'y'} to continue or press any other key to exit.");
            char response = Console.ReadKey(true).KeyChar;
            if (response=='y')
            {
                return true;
            }
            else if (response != 'y')
            {
                return false;
            }
            else
            {
                return Continue();
            }
        }
    }
}
