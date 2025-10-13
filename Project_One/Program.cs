// Project One contains the Data base About the Pet Management system
using System;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
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

            // For the variables that supports the data entry
            int maxPets = 8;
            string? readResult;
            int petCount = 0;
            string menuSelection = "";
            string anotherPet = "y";
            bool validEntry = false;
            int petAge = 0;


            string[,] ourAnimals = new string[maxPets, 6];

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
                        // int petCount = 0;
                        // string anotherPet = "y";
                        for (int i = 0; i < maxPets; i++)
                        {
                            if (ourAnimals[i, 0] != "ID #: ")
                            {
                                petCount += 1;
                            }
                        }

                        if (petCount < maxPets)
                        {
                            Console.WriteLine($"We currently have {petCount} pets that need home. We can manage {maxPets - petCount} more.");
                        }

                        while (anotherPet == "y" && petCount < maxPets)
                        {
                            // bool validEntry = false;
                            do
                            {
                                Console.WriteLine("Enter the new cat and dot to begin new entry:");
                                readResult = Console.ReadLine();
                                if (readResult != null)
                                {
                                    animalSpecies = readResult.ToLower();
                                    if (animalSpecies != "dog" && animalSpecies != "cat")
                                    {
                                        validEntry = false;
                                    }
                                    else
                                    {
                                        validEntry = true;
                                    }
                                }
                            } while (validEntry == false);

                            animalID = animalSpecies.Substring(0, 1) + (petCount + 1).ToString();

                            do
                            {
                                // int petAge;
                                Console.WriteLine("Enter the pet's age or entry ? If unknown");
                                readResult = Console.ReadLine();
                                if (readResult != null)
                                {
                                    animalAge = readResult;
                                    if (animalAge != "?")
                                    {
                                        validEntry = int.TryParse(animalAge, out petAge);
                                    }
                                    else
                                    {
                                        validEntry = true;
                                    }
                                }
                            } while (validEntry == false);
                            do
                            {
                                Console.WriteLine("Enter a physical description of the pet (size ,color, gender, weight, housebroken)");
                                readResult = Console.ReadLine();
                                if (readResult != null)
                                {
                                    animalPhysicalDescription = readResult.ToLower();
                                    if (animalPhysicalDescription == "")
                                    {
                                        animalPhysicalDescription = "tbd";
                                    }
                                }

                            } while (validEntry == false);
                            // (animalPhysicalDescription == "");

                            do
                            {
                                Console.WriteLine("Enter a description of the pet's  personality (like or dislikes, tricks, energy lebel)");
                                readResult = Console.ReadLine();
                                if (readResult != null)
                                {
                                    animalPersonalityDescription = readResult.ToLower();
                                    if (animalPersonalityDescription == "")
                                    {
                                        animalPersonalityDescription = "tbd";
                                    }
                                }
                            } while (validEntry == false);
                            //while (animalPersonalityDescription == "");

                            do
                            {
                                Console.WriteLine("Enters the pet's nickname:");
                                readResult = Console.ReadLine();
                                if (readResult != null)
                                {
                                    animalNickName = readResult.ToLower();
                                    if (animalNickName == "")
                                    {
                                        animalNickName = "tbd";
                                    }
                                }
                            } while (validEntry == false);

                            ourAnimals[petCount, 0] = "ID #: " + animalID;
                            ourAnimals[petCount, 1] = "Species: " + animalSpecies;
                            ourAnimals[petCount, 2] = "Age: " + animalAge;
                            ourAnimals[petCount, 3] = "Nickname: " + animalNickName;
                            ourAnimals[petCount, 4] = "Physical description: " + animalPhysicalDescription;
                            ourAnimals[petCount, 5] = "Personlaity: " + animalPersonalityDescription;

                            petCount = petCount + 1;
                            if (petCount < maxPets)
                            {
                                Console.WriteLine("Do you want to enter info for another pet (y/n)");
                                do
                                {
                                    readResult = Console.ReadLine();
                                    if (readResult != null)
                                    {
                                        anotherPet = readResult.ToLower();
                                    }
                                } while (anotherPet != "y" && anotherPet != "n");
                            }

                        }
                        if (petCount >= maxPets)
                        {
                            Console.WriteLine("We have reached our limit on the number of pets that we can manage.");
                            Console.WriteLine("Press the Enter key to continue.");
                            readResult = Console.ReadLine();
                        }

                        break;
                    case "3":
                        // Console.WriteLine("Challenge Projcet - please check back soon to see progress.");
                        // Console.WriteLine("Press the Enter key to continue.");
                        // readResult = Console.ReadLine();

                        for (int i = 0; i < maxPets; i++)
                        {
                            if (ourAnimals[i, 2] == "Age: ?" && ourAnimals[i, 0] != "ID #:")
                            {
                                do
                                {
                                    Console.WriteLine($"Enter an age for {ourAnimals[i, 0]}");
                                    readResult = Console.ReadLine();
                                    if (readResult != null)
                                    {
                                        animalAge = readResult;
                                        validEntry = int.TryParse(animalAge, out petAge);
                                    }
                                } while (validEntry == false);
                                ourAnimals[i, 2] = "Age:" + animalAge.ToString();
                            }
                            if (ourAnimals[i, 4] == "Physical description: " && ourAnimals[i, 0] != "ID #:")
                            {
                                do
                                {
                                    Console.WriteLine($"Enter a physical descriptioin for {ourAnimals[i, 0]} (size, color,gender, weight, housebroken)");
                                    readResult = Console.ReadLine();
                                    if (readResult != null)
                                    {
                                        animalPhysicalDescription = readResult.ToLower();
                                        if (animalPhysicalDescription == "")
                                        {
                                            validEntry = false;
                                        }
                                        else
                                        {
                                            validEntry = true;
                                        }
                                    }
                                } while (validEntry == false);
                                ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
                            }
                        }
                        Console.WriteLine("Age and physical description fields are compolete for all of our friends.\n\rPress the Enter key to continue");
                        readResult = Console.ReadLine();
                        break;

                    case "4":
                        // Console.WriteLine("Challenge Project - please check back soon to see progress.");
                        // Console.WriteLine("Press the Enter key to continue.");
                        // readResult = Console.ReadLine();
                        for (int i = 0; i < maxPets; i++)
                        {
                            if (ourAnimals[i, 3] == "NickName: " && ourAnimals[i, 0] != "ID #:")
                            {
                                do
                                {
                                    Console.WriteLine($"Enter a nick name for {ourAnimals[i, 0]}");
                                    readResult = Console.ReadLine();
                                    if (readResult != null)
                                    {
                                        animalNickName = readResult;
                                        if (animalNickName == "")
                                        {
                                            validEntry = false;
                                        }
                                        else
                                        {
                                            validEntry = true;
                                        }
                                    }
                                } while (validEntry == false);
                                ourAnimals[i, 3] = "Nickname: " + animalNickName;
                            }
                            if (ourAnimals[i, 5] == "Personality: " && ourAnimals[i, 0] != "ID #: ")
                            {
                                do
                                {
                                    Console.WriteLine($"Enter a personality description for {ourAnimals[i, 0]}(likes or disliks ,ticks, energy level)");
                                    readResult = Console.ReadLine();
                                    if (readResult != null)
                                    {
                                        animalPersonalityDescription = readResult.ToLower();
                                        if (animalPersonalityDescription == "")
                                        {
                                            validEntry = false;
                                        }
                                        else
                                        {
                                            validEntry = true;
                                        }
                                    }
                                } while (validEntry == false);
                                ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
                            }
                        }
                        Console.WriteLine("Age and physical description fields are complete for all of our friends.\n\r Press the Enter key to continue");
                        readResult = Console.ReadLine();
                        break;
                    case "5":
                        Console.WriteLine("UNDER_CONSTRUCTION - please check back next month to see progress.");
                        Console.WriteLine("Press the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;
                    case "6":
                        Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
                        Console.WriteLine("Press the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;
                    case "7":
                        Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
                        Console.WriteLine("Press the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;
                    case "8":
                        Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
                        Console.WriteLine("Press the Enter key to continue.");
                        readResult = Console.ReadLine();
                        break;
                    default:
                        break;
                }

            } while (menuSelection != "exit");

        }
    }
}