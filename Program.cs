/*
 * Project Name: Interactive Country Capital Quiz
 * Author: Tina Ying Wang
 * Date: Feb 2026
 * Description: A console-based quiz application with input validation 
 * and progress tracking features.
 */

string[,] countryCapital = { { "Australia", "Canberra" }, { "Japan", "Tokyo" }, { "China", "Beijing" }, { "France", "Paris" }, { "Germany", "Berlin" }, { "UK", "London" } };

int arrayLength = countryCapital.GetLength(0);

// Flag array to track user progress and prevent duplicate selections
bool[] isChosen = new bool[arrayLength];

int serialNo;

string replyForRetry = "";

string yourAnswer = "";

int count;

string yourRlyNext = "";

string replyForNextCountry = "";


Console.WriteLine("Program to Guess Capital of a Country");
Console.WriteLine("==========================================================\n");
Console.WriteLine("Countries to choose\n");

// display the country list
for (int i = 0; i < arrayLength; i++)
{
    Console.WriteLine($"{i + 1}. {countryCapital[i, 0]}");
}


// outer loop: allow the user to continue with next country
do
{
    // deal with choosing the country
    do
    {
        Console.Write($"\nPlease choose a country [1 - {arrayLength}]: ");

        // ask user to choose a country until valid input entered
        // Use TryParse and while loop to ensure "Defensive Programming" 
        // (prevents the program from crashing if user enters non-numeric input)
        while (!int.TryParse(Console.ReadLine(), out serialNo) || serialNo < 1 || serialNo > arrayLength)
        {
            Console.Write("\nInvalid input. Please re-enter a serial number: ");
        }

        if (!isChosen[serialNo - 1])
        {
            isChosen[serialNo - 1] = true;
            break;
        }
        else
        {
            Console.WriteLine("\nYou have chosen this country.");


            // check if user wants to choose another country
            do
            {
                replyForNextCountry = "";

                Console.Write("\nDo you want to choose another country? (Y/N) ");
                replyForNextCountry = Console.ReadLine().Trim().ToLower();
                if (replyForNextCountry == "y" || replyForNextCountry == "n")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nInvalid input. Please try again with 'Y' or 'N' only.");
                    continue;
                }

            } while (replyForNextCountry != "y" && replyForNextCountry != "n");

            if (replyForNextCountry == "y")
            {
                Console.WriteLine("\nPlease choose another country.");
                continue;
            }
            else
            {
                Console.WriteLine("\nYou chose not to continue. End of game.");
                break;
            }

        }

    } while (isChosen[serialNo - 1]);

    if (replyForNextCountry == "n")
    {
        break;
    }



    // deal with guessing the capital
    do
    {
        Console.Write($"\nPlease guess the capital of this country ({countryCapital[serialNo - 1, 0]}): ");

        // Normalize input to handle accidental spaces and case sensitivity
        yourAnswer = Console.ReadLine().Trim().ToLower();

        if (yourAnswer == countryCapital[serialNo - 1, 1].Trim().ToLower())
        {
            Console.WriteLine("\nYour answer is correct!");
            break;
        }
        else
        {
            Console.WriteLine("\nYour answer is incorrect!");

            do
            {
                replyForRetry = "";

                Console.Write("\nDo you want to try again? (Y/N) ");
                replyForRetry = Console.ReadLine().Trim().ToLower();
                if (replyForRetry == "y" || replyForRetry == "n")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nInvalid input. Please try again with 'Y' or 'N' only.");
                    continue;
                }

            } while (replyForRetry != "y" && replyForRetry != "n");

            if (replyForRetry == "y")
            {
                Console.WriteLine("\nYou chose to try again with this country.");
                continue;
            }
            else
            {
                Console.WriteLine("\nYou chose not to try again with this country.");
                break;
            }

        }

    } while (yourAnswer != countryCapital[serialNo - 1, 1].Trim().ToLower());


    //check progress with countries
    count = 0;
    foreach (bool status in isChosen)
    {
        if (status)
        {
            count++;
        }
    }


    if (count == arrayLength)
    {
        Console.WriteLine($"\nYou have finished all {countryCapital.GetLength(0)} countries. End of game.");
        break;
    }
    else
    {
        Console.WriteLine($"\nYou have finished {count} out of {arrayLength} countries.");
    }

    // check if the user wants to continue with next country
    do
    {
        yourRlyNext = "";

        Console.Write("\nDo you want to continue with another country? (Y/N) ");
        yourRlyNext = Console.ReadLine().Trim().ToLower();
        if (yourRlyNext == "y" || yourRlyNext == "n")
        {
            break;
        }
        else
        {
            Console.WriteLine("\nInvalid input. Please try again with 'Y' or 'N' only.");
            continue;
        }

    } while (yourRlyNext != "y" && yourRlyNext != "n");


    if (yourRlyNext == "y")
    {
        Console.WriteLine("\nYou chose to continue with another country.");
        continue;
    }
    else
    {
        Console.WriteLine("\nYou chose not to continue with another country. End of game.");
        break;
    }


} while (yourRlyNext == "y");