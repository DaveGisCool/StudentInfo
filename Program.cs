using System;

namespace StudentInfoLab3Dot1
{
    class Program
    {
        static void Main(string[] args)
        {
            int userChoice, userSelection = 0;
            bool keepLooping = true;

            while (keepLooping)
            {

                string[] studentNames = new string[] { "Philip J. Fry", "Teranga Leela", "Amy Wong" };
                string[] studentCandy = new string[] { "Sour Patch Kids", "Black Licorice", "Dark Chocolate" };
                string[] studentTitles = new string[] { "Freshman", "Senior", "Junior" };

                Console.Write($"Welcome to our Dev.Build class. Which student would you like to learn more about? (enter a number 1-{studentNames.Length}): ");
                string userInput = Console.ReadLine();
                bool validInput = Int32.TryParse(userInput, out userChoice);

                
                while (validInput == false)
                {
                    Console.Write($"That student does not exist. Please try again. (enter a number 1-{studentNames.Length}): ");
                    string userInput2 = Console.ReadLine();
                    validInput = Int32.TryParse(userInput2, out userChoice);
                }

                while ((userChoice < 1) || (userChoice > studentNames.Length))
                {
                    Console.Write($"That student does not exist. Please try again. (enter a number 1-{studentNames.Length}): ");
                    string userInput2 = Console.ReadLine();
                    validInput = Int32.TryParse(userInput2, out userChoice);
                } 

                userSelection = userChoice - 1;

                Console.Write($"\r\nStudent {userChoice} is {studentNames[userSelection]}. What would you like to know about {studentNames[userSelection]}? (enter \"favorite candy\" or \"previous title\"):");
                string userPick = Console.ReadLine();

                while ((userPick != "favorite candy") && (userPick != "previous title"))
                {
                    Console.Write($"\r\nThat data does not exist. Please try again. (enter \"favorite candy\" or \"previous title\"): ");
                    string userPick2 = Console.ReadLine();
                    userPick = userPick2;
                }  

                if (userPick == "previous title")
                {
                    Console.WriteLine($"\r\n{studentNames[userSelection]}'s previous title is {studentTitles[userSelection]}");
                }
                else
                {
                    Console.WriteLine($"\r\n{studentNames[userSelection]}'s favorite candy is {studentCandy[userSelection]}");
                }


                


                

                Console.Write($"\r\nWould you like to know about another student? enter \"yes\" or \"no): ");
                string cont = Console.ReadLine();
                if (cont == "no" || cont == "NO" || cont == "No" || cont == "nO")
                {
                    keepLooping = false;
                }
                else if (cont != "yes" && cont != "YES" && cont != "Yes")
                {
                    Console.WriteLine("You have not selected yes or no, exiting");
                    keepLooping = false;
                }

                Console.WriteLine("\r\nThanks!");
            }
        }
    }
}
