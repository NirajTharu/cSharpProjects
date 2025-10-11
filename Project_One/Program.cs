// Project One contains the Data base About the Pet Management system
using System;
namespace PetManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string animalSpecies = "";
            string animalID = "";
            string animalAge = "";
            string animalPhysicalDescription = "";
            string animalPersonalityDescription = "";
            string animalNickName = "";

            int maxPets = 8;
            string? readResult;
            string menuSelection = "";
            string[,] ourAnimals = new string[maxPets, 8];

            for (int i = 0; i < maxPets; i++)
            {
                switch (i)
                {
                    case 0:

                        animalSpecies = "dog";
                        animalID = "d1";
                        animalAge = "2";
                        animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pound. housebroken.";
                        animalPersonalityDescription = "loves to have her belly rubbed and likes to chese her tail. gives lot of kisses.";
                        animalNickName = "lola";
                        break;

                    case 1:

                        animalSpecies = "dog";
                        animalID = "d2";
                        animalAge = "9";
                        animalPhysicalDescription = "large radish brown male golden retriever weighing about 85 pound. housebroken.";
                        animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
                        animalNickName = "loki";
                        break;

                    case 2:

                        animalSpecies = "cat";
                        animalID = "c3";
                        animalAge = "1";
                        animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained ";
                        animalPersonalityDescription = "friendly";
                        animalNickName = "Puss";
                        break;

                    case 3:

                        animalSpecies = "cat";
                        animalID = "c4";
                        animalAge = "?";
                        animalPhysicalDescription = "";
                        animalPersonalityDescription = "";
                        animalNickName = "";
                        break;

                    default:

                        animalSpecies = "";
                        animalID = "";
                        animalAge = "";
                        animalPhysicalDescription = "";
                        animalPersonalityDescription = "";
                        animalNickName = "";
                        break;

                }
                ourAnimals[i, 0] = "ID #: " + animalID;
                ourAnimals[i, 1] = "Species: " + animalSpecies;
                ourAnimals[i, 2] = "Age: " + animalAge;
                ourAnimals[i, 3] = "Nickname: " + animalNickName;
                ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
                ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
            }

            do
            {
                Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
                Console.WriteLine(" 1. List all of our current pet information");
                Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
                Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
                Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
                Console.WriteLine(" 5. Edit an animal’s age");
                Console.WriteLine(" 6. Edit an animal’s personality description");
                Console.WriteLine(" 7. Display all cats with a specified characteristic");
                Console.WriteLine(" 8. Display all dogs with a specified characteristic");
                Console.WriteLine();
                Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    menuSelection = readResult.ToLower();
                }
                Console.WriteLine($"You selected menu option {menuSelection}.");
                Console.WriteLine("Press the Enter key to continue");

                switch (menuSelection)
                {
                    case "1":
                        // List our current pet infomration
                        for (int i = 0; i < maxPets; i++)
                        {
                            if (ourAnimals[i, 0] != "ID #:")
                            {
                                Console.WriteLine();
                                for (int j = 0; j < 6; j++)
                                {
                                    Console.WriteLine(ourAnimals[i, j]);
                                }
                            }
                        }
                        Console.WriteLine("Press the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;
                    case "2":
                        // Add a new animal friend to our animal's array
                        for (int i = 0; i < maxPets; i++)
                        {

                        }
                        break;
                }

            } while (menuSelection != "exit");

        }
    }
}