using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fortunetellerremake
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Fortune Teller App\n");

            Console.WriteLine("Let me see into your future. \nEnter information below to help me predict your future. \n\nYou can Quit at anytime by entering \"Quit\". \nYou can restart at anytime by entering \"Restart\".\n\n");
            string playAgain = "";
            do
            {
                Console.WriteLine("Enter Your First Name: ");
                string firstName = Console.ReadLine();
                string firstNameLower = firstName.ToLower();

                if (firstNameLower == "quit")
                {
                    quitProgram();
                    break;
                }
                else if (firstNameLower == "restart")
                {
                    Main(args);
                    break;
                }

                Console.WriteLine("Enter Your Last Name: ");
                string lastName = Console.ReadLine();
                string lastNameLower = lastName.ToLower();

                if (lastNameLower == "quit")
                {
                    quitProgram();
                    break;
                }
                else if (lastNameLower == "restart")
                {
                    Main(args);
                    break;
                }

                string fullName = firstNameLower + lastNameLower;

                Console.WriteLine("Enter Your Age: ");
                string userAge = Console.ReadLine().ToLower();

                if (userAge == "quit")
                {
                    quitProgram();
                    break;
                }
                else if (userAge == "restart")
                {
                    Main(args);
                    break;
                }

                int userAgeInt = int.Parse(userAge);

                //age if else conditional
                string retireYears;
                if (userAgeInt % 2 == 0)
                {
                    retireYears = 10.ToString();
                }
                else
                {
                    retireYears = 25.ToString();
                }

                Console.WriteLine("Enter Your Birth Month: ");
                string birthMonth = Console.ReadLine().ToLower();

                if (birthMonth == "quit")
                {
                    quitProgram();
                    break;
                }
                else if (birthMonth == "restart")
                {
                    Main(args);
                    break;
                }

                Console.WriteLine("Enter Your Favorite ROYGBIV Color (If you do not know ROYGBIV, enter \"Help\" to show a list of ROYGBIV colors):");
                string color = Console.ReadLine().ToLower();

                if (color == "quit")
                {
                    quitProgram();
                    break;
                }
                else if (color == "restart")
                {
                    Main(args);
                    break;
                }

                //ROYGBIV Switch Case conditional
                string transportation = "";

                if (color == "help")
                {
                    Console.WriteLine("ROYGBIV COLORS: \nR is for Red. \nO is for Orange. \nY is for Yellow. \nG is for Green. \nB is for Blue. \nI is for Indigo. \nV is for Violet. \nEnter a ROYGBIV color. \nPlease type in the full name of the color, not the ROYGBIV letter: ");
                    color = Console.ReadLine().ToLower();
                }

                switch (color)
                {
                    case "red":
                        transportation = "Electric Car";
                        break;
                    case "orange":
                        transportation = "Bike";
                        break;
                    case "yellow":
                        transportation = "SUV";
                        break;
                    case "green":
                        transportation = "Toyota Prius";
                        break;
                    case "blue":
                        transportation = "Scooter";
                        break;
                    case "indigo":
                        transportation = "Private Jet";
                        break;
                    case "violet":
                        transportation = "Yacht";
                        break;
                }

                Console.WriteLine("Enter the # of Siblings You Have: ");
                string sibNum = Console.ReadLine();

                if (sibNum == "quit")
                {
                    quitProgram();
                    break;
                }
                else if (sibNum == "restart")
                {
                    Main(args);
                    break;
                }

                int sibNumInt = int.Parse(sibNum);

                // sibling sequenced if else conditional
                string sibFortune = "";
                if (sibNumInt == 0)
                {
                    sibFortune = "Toyko";
                }
                else if (sibNumInt == 1)
                {
                    sibFortune = "Washington DC";
                }
                else if (sibNumInt == 2)
                {
                    sibFortune = "Tanzania";
                }
                else if (sibNumInt == 3)
                {
                    sibFortune = "a cardboard box in New York City";
                }
                else if (sibNumInt > 3)
                {
                    sibFortune = "South Beach Miami";
                }
                else
                {
                    sibFortune = "your ex's basement";
                }

                double bankRoll = 0;

                for (int i = 0; i < fullName.Length; i++)
                {
                    if (birthMonth[0] == fullName[i])
                    {
                        bankRoll = 1000000.00;
                        break;
                    }
                    else if (birthMonth[1] == fullName[i])
                    {
                        bankRoll = 2000000.00;
                        break;
                    }
                    else if (birthMonth[2] == fullName[i])
                    {
                        bankRoll = 3000000.00;
                        break;
                    }
                    else
                    {
                        bankRoll = 500000.00;
                    }
                }

                Console.WriteLine("{0} {1} will retire in {2} years with ${3} in the bank, a vacation home in {4} and a {5}.", firstName, lastName, retireYears, bankRoll, sibFortune, transportation);
                Console.WriteLine("Would you like to play again? Enter Y for Yes or N for No");
                playAgain = Console.ReadLine().ToUpper();

                if (playAgain == "QUIT")
                {
                    quitProgram();
                    break;
                }
                else if (playAgain == "RESTART")
                {
                    Main(args);
                    break;
                }
            }
            while (playAgain == "Y");
        }

        static void quitProgram()
        {
            Console.Write("\n Nobody likes a quitter ... \n Press any key to Quit \n");
            Console.ReadKey();
        }
    }
}


        
    

