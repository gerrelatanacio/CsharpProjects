using System;
using System.IO;

// the ourAnimals array will store the following: 
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";
int petCount = 0;
string anotherPet = "y";
bool validEntry = false;
int petAge = 0;
string petDescription = "";
string petNickname = "";
string petPersonality = "";


// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6];

// create some initial ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            break;

        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "loki";
            break;

        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "Puss";
            break;

        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "?";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";

            break;

        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;

    }

    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
}

// display the top-level menu options
do
{
    Console.Clear();

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
        // NOTE: We could put a do statement around the menuSelection entry to ensure a valid entry, but we
        //  use a conditional statement below that only processes the valid entry values, so the do statement 
        //  is not required here. 
    }

    // use switch-case to process the selected menu option
    switch (menuSelection)
    {
        case "1":
            // List all of our current pet information
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    Console.WriteLine();
                    for (int j = 0; j < 6; j++)
                    {
                        Console.WriteLine(ourAnimals[i, j].ToString());
                    }
                }
            }
            Console.WriteLine("\n\rPress the Enter key to continue");
            readResult = Console.ReadLine();

            break;

        case "2":
            // Add a new animal friend to the ourAnimals array
            //
            // The ourAnimals array contains
            //    1. the species (cat or dog). a required field
            //    2. the ID number - for example C17
            //    3. the pet's age. can be blank at initial entry.
            //    4. the pet's nickname. can be blank.
            //    5. a description of the pet's physical appearance. can be blank.
            //    6. a description of the pet's personality. can be blank.

            anotherPet = "y";
            petCount = 0;
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    petCount += 1;
                }
            }

            if (petCount < maxPets)
            {
                Console.WriteLine($"We currently have {petCount} pets that need homes. We can manage {(maxPets - petCount)} more.");
            }

            while (anotherPet == "y" && petCount < maxPets)
            {
                // get species (cat or dog) - string animalSpecies is a required field 
                do
                {
                    Console.WriteLine("\n\rEnter 'dog' or 'cat' to begin a new entry");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalSpecies = readResult.ToLower();
                        if (animalSpecies != "dog" && animalSpecies != "cat")
                        {
                            //Console.WriteLine($"You entered: {animalSpecies}.");
                            validEntry = false;
                        }
                        else
                        {
                            validEntry = true;
                        }
                    }
                } while (validEntry == false);

                // build the animal the ID number - for example C1, C2, D3 (for Cat 1, Cat 2, Dog 3)
                animalID = animalSpecies.Substring(0, 1) + (petCount + 1).ToString();

                // get the pet's age. can be ? at initial entry.
                do
                {
                    Console.WriteLine("Enter the pet's age or enter ? if unknown");
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


                // get a description of the pet's physical appearance - animalPhysicalDescription can be blank.
                do
                {
                    Console.WriteLine("Enter a physical description of the pet (size, color, gender, weight, housebroken)");
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


                // get a description of the pet's personality - animalPersonalityDescription can be blank.
                do
                {
                    Console.WriteLine("Enter a description of the pet's personality (likes or dislikes, tricks, energy level)");
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


                // get the pet's nickname. animalNickname can be blank.
                do
                {
                    Console.WriteLine("Enter a nickname for the pet");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalNickname = readResult.ToLower();
                        if (animalNickname == "")
                        {
                            animalNickname = "tbd";
                        }
                    }
                } while (validEntry == false);

                // store the pet information in the ourAnimals array (zero based)
                ourAnimals[petCount, 0] = "ID #: " + animalID;
                ourAnimals[petCount, 1] = "Species: " + animalSpecies;
                ourAnimals[petCount, 2] = "Age: " + animalAge;
                ourAnimals[petCount, 3] = "Nickname: " + animalNickname;
                ourAnimals[petCount, 4] = "Physical description: " + animalPhysicalDescription;
                ourAnimals[petCount, 5] = "Personality: " + animalPersonalityDescription;

                // increment petCount (the array is zero-based, so we increment the counter after adding to the array)
                petCount = petCount + 1;

                // check maxPet limit
                if (petCount < maxPets)
                {
                    // another pet?
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
                //NOTE: The value of anotherPet (either "y" or "n") is evaluated in the while statement expression - at the top of the while loop
            }

            if (petCount >= maxPets)
            {
                Console.WriteLine("We have reached our limit on the number of pets that we can manage.");
                Console.WriteLine("Press the Enter key to continue.");
                readResult = Console.ReadLine();
            }

            break;

        case "3":
            bool modifyPetDataFlag = true;
            int petWithIncorrectData = 0;
            List<int> petIndexWithIncorrectDataList = new List<int>();

            bool validResponseFlag = false;

            //Initial check of petcount
            if (petCount == 0)
            {
                for (int i = 0; i < maxPets; i++)

                {
                    if (ourAnimals[i, 0] != "ID #: ")
                    {
                        petCount++;
                    }
                }
            }
            Console.WriteLine($"\nThere are currently {petCount} friend animals in our care");

            // //Check how many animals have incorrect age
            // for (int i = 0; i < petCount; i++)
            // {
            //     //And if the loop find a match with age of "?" value
            //     if (ourAnimals[i, 2] == "Age: ?")
            //     {
            //         petWithIncorrectAgeIndices.Add(i);
            //         petWithIncorrectAge++;
            //     }
            // }
            // Console.WriteLine($"There are {petWithIncorrectAge} animal entries with incorrect age");

            //Alternate implementation to combine checking whether an entry is missing any required information (age, physical description, personality and nickname)
            for (int i = 0; i < petCount; i++)
            {
                if (ourAnimals[i, 2] == "Age: ?" || ourAnimals[i, 3] == "Nickname: tbd" || ourAnimals[i, 4] == "Physical description: tbd" || ourAnimals[i, 5] == "Personality: tbd")
                {
                    petIndexWithIncorrectDataList.Add(i);
                    petWithIncorrectData++;
                }
            }


            for (int i = 0; i < petIndexWithIncorrectDataList.Count; i++)
            {
                Console.WriteLine($"OurAnimals Array with Index {petIndexWithIncorrectDataList[i]} with {ourAnimals[petIndexWithIncorrectDataList[i], 0]} has an incorrect data i.e. age, physical description, personality and/or nickname");
            }


            Console.WriteLine($"\nThere's are {petWithIncorrectData} animal entry with incorrect data based on our checking");
            //Create a while loop that will continously run while the following conditions are true
            //modifyPetAge flag is true
            //petwithIncorrectAge > 0

            while (modifyPetDataFlag && petWithIncorrectData > 0)
            {

                for (int i = 0; i < petIndexWithIncorrectDataList.Count; i++)
                {
                    Console.WriteLine($"\nCurrent index at {i}");
                    //Check and modify wrong age of an animal friend instance
                    if (ourAnimals[petIndexWithIncorrectDataList[i], 2] == "Age: ?")
                    {
                        do
                        {
                            Console.WriteLine($"\nAnimal Friend with {ourAnimals[petIndexWithIncorrectDataList[i], 0]} has an Invalid {ourAnimals[petIndexWithIncorrectDataList[i], 2]}");
                            Console.WriteLine("Please correct animal entry's age!");
                            Console.WriteLine($"Enter a new age for Animal Friend with {ourAnimals[petIndexWithIncorrectDataList[i], 0]}: ");
                            readResult = Console.ReadLine();
                            if (readResult != null && !string.Equals(readResult, "?") && int.TryParse(readResult, out petAge))
                            {
                                ourAnimals[petIndexWithIncorrectDataList[i], 2] = "Age: " + petAge;
                                Console.WriteLine($"Animal Friend with {ourAnimals[petIndexWithIncorrectDataList[i], 0]} now has an updated age of {petAge}");
                                validEntry = true;
                            }
                            else
                            {
                                Console.WriteLine("\nYou've entered an invalid input. Please enter a numeric number for new age.");
                                validEntry = false;
                            }
                        } while (validEntry == false);
                        Console.WriteLine("You have successfully updated our animal friend's age.");
                    }

                    //Check and modify the physical description of our animal friend instance
                    if (ourAnimals[petIndexWithIncorrectDataList[i], 4] == "Physical description: tbd")
                    {
                        do
                        {
                            Console.WriteLine($"\nAnimal Friend with {ourAnimals[petIndexWithIncorrectDataList[i], 0]} has an Invalid {ourAnimals[petIndexWithIncorrectDataList[i], 4]}");
                            Console.WriteLine("Please correct animal entry's physical description!");
                            Console.WriteLine($"Enter a new physical description for Animal Friend with {ourAnimals[petIndexWithIncorrectDataList[i], 0]}: ");
                            readResult = Console.ReadLine();
                            if (readResult != null && !string.Equals(readResult, "tbd") && readResult.Length > 5)
                            {
                                petDescription = readResult;
                                ourAnimals[petIndexWithIncorrectDataList[i], 4] = "Physical description: " + petDescription;
                                Console.WriteLine($"Animal Friend with {ourAnimals[petIndexWithIncorrectDataList[i], 0]} now has an updated description of {petDescription}");
                                validEntry = true;
                            }
                            else
                            {
                                Console.WriteLine("\nYou've entered an invalid input. Please enter a new description with at least 5 min characters.");
                                validEntry = false;
                            }
                        } while (validEntry == false);
                        Console.WriteLine("You have successfully updated our animal friend's description.");
                    }

                    //Check and modify the nickname of our animal friend instance
                    if (ourAnimals[petIndexWithIncorrectDataList[i], 3] == "Nickname: tbd")
                    {
                        do
                        {
                            Console.WriteLine($"\nAnimal Friend with {ourAnimals[petIndexWithIncorrectDataList[i], 0]} has an Invalid {ourAnimals[petIndexWithIncorrectDataList[i], 3]}");
                            Console.WriteLine("Please correct animal entry's nickname!");
                            Console.WriteLine($"Enter a new nickname for Animal Friend with {ourAnimals[petIndexWithIncorrectDataList[i], 0]}: ");
                            readResult = Console.ReadLine();
                            if (readResult != null && !string.Equals(readResult, "tbd") && readResult.Length > 3)
                            {
                                petNickname = readResult;
                                ourAnimals[petIndexWithIncorrectDataList[i], 3] = "Nickname: " + petNickname;
                                Console.WriteLine($"Animal Friend with {ourAnimals[petIndexWithIncorrectDataList[i], 0]} now has an updated nickname of {petNickname}");
                                validEntry = true;
                            }
                            else
                            {
                                Console.WriteLine("\nYou've entered an invalid input. Please enter a new nickname with at least 5 min characters.");
                                validEntry = false;
                            }
                        } while (validEntry == false);
                        Console.WriteLine("You have successfully updated our animal friend's nickname.");
                    }

                    //Check and modify the personality of our animal friend instance
                    if (ourAnimals[petIndexWithIncorrectDataList[i], 5] == "Personality: tbd")
                    {
                        do
                        {
                            Console.WriteLine($"\nAnimal Friend with {ourAnimals[petIndexWithIncorrectDataList[i], 0]} has an Invalid {ourAnimals[petIndexWithIncorrectDataList[i], 5]}");
                            Console.WriteLine("Please correct animal entry's personality!");
                            Console.WriteLine($"Enter a new personality for Animal Friend with {ourAnimals[petIndexWithIncorrectDataList[i], 0]}: ");
                            readResult = Console.ReadLine();
                            if (readResult != null && !string.Equals(readResult, "tbd") && readResult.Length > 5)
                            {
                                petPersonality = readResult;
                                ourAnimals[petIndexWithIncorrectDataList[i], 5] = "Personality: " + petPersonality;
                                Console.WriteLine($"Animal Friend with {ourAnimals[petIndexWithIncorrectDataList[i], 0]} now has an updated personality of {petPersonality}");
                                validEntry = true;
                            }
                            else
                            {
                                Console.WriteLine("\nYou've entered an invalid input. Please enter a new personality with at least 5 min characters.");
                                validEntry = false;
                            }
                        } while (validEntry == false);
                        Console.WriteLine("You have successfully updated our animal friend's personality.");
                    }

                    petWithIncorrectData--;
                    
                }

                Console.WriteLine("Now outside of the FOR loop");

                // while (modifyPetAgeFlag && petWithIncorrectAge > 0)
                // {
                //     for (int i = 0; i < petWithIncorrectAge; i++)
                //     {

                //         do
                //         {
                //             Console.WriteLine($"Currently at index {petWithIncorrectAgeIndices[i]}");
                //             Console.WriteLine($"\nAnimal Friend with {ourAnimals[petWithIncorrectAgeIndices[i], 0]} has an Invalid {ourAnimals[petWithIncorrectAgeIndices[i], 2]}");
                //             Console.WriteLine("Would you like to correct its age? (y/n)");

                //             readResult = Console.ReadLine();

                //             if (readResult == "y")
                //             {
                //                 validResponseFlag = true;

                //                 do
                //                 {
                //                     Console.WriteLine($"Enter a new age for Animal Friend with {ourAnimals[petWithIncorrectAgeIndices[i], 0]}: ");
                //                     readResult = Console.ReadLine();
                //                     if (readResult != null && !string.Equals(readResult, "?") && int.TryParse(readResult, out petAge))
                //                     {
                //                         ourAnimals[petWithIncorrectAgeIndices[i], 2] = "Age: " + petAge;
                //                         Console.WriteLine($"Animal Friend with {ourAnimals[petWithIncorrectAgeIndices[i], 0]} now has an updated age of {petAge}");
                //                         petWithIncorrectAge--;
                //                         validEntry = true;
                //                     }
                //                     else
                //                     {
                //                         Console.WriteLine("You entered an invalid input. Please enter a numeric number for new age.");
                //                         validEntry = false;
                //                     }
                //                 } while (validEntry == false);
                //             }
                //             else if (readResult == "n")
                //             {
                //                 validResponseFlag = true;
                //                 modifyPetAgeFlag = false;
                //             }
                //             else
                //             {
                //                 validResponseFlag = false;
                //             }
                //         } while (validResponseFlag == false);


                //         if (i == petWithIncorrectAge)
                //         {
                //             modifyPetAgeFlag = false;
                //         }

                //         Console.WriteLine(modifyPetAgeFlag);
                //     }
                // }
            }

            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "4":
            // Ensure animal nicknames and personality descriptions are complete
            Console.WriteLine("Challenge Project - please check back soon to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "5":
            // Edit an animal’s age");
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "6":
            // Edit an animal’s personality description");
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "7":
            // Display all cats with a specified characteristic
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "8":
            // Display all dogs with a specified characteristic
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        default:
            break;
    }

} while (menuSelection != "exit");
