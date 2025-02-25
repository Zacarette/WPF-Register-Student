using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRegisterStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Program()).run();
        }

        void run()
        {
            string choice; //changed type to string
            int intchoice; //added variable for int version of choice
            int firstChoice = 0; //moved to seperate line
            int secondChoice = 0; //moved to seperate line
            int thirdChoice = 0; //moved to seperate line
            int totalCredit = 0;
            string yesOrNo = "";

            System.Console.WriteLine("Zaccaria\n"); //changed teacher's copy to my name

            do
            {
                WritePrompt();
                choice = Console.ReadLine(); //changed to just read input as string

                //tries to convert string to int, if it fails, it will ask for input again
                while (!int.TryParse(choice, out intchoice))
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 7.\n");
                    WritePrompt();
                    choice = Console.ReadLine();
                }

                switch (ValidateChoice(intchoice, firstChoice, secondChoice, thirdChoice, totalCredit)) //changed choice to intchoice
                {
                    case -1:
                        Console.WriteLine("Your entered selection {0} is not a recognized course.", intchoice); //changed choice to intchoice
                        break;

                    case -2:
                        Console.WriteLine("You have already registerd for this {0} course.", ChoiceToCourse(intchoice)); //changed choice to intchoice
                        break;

                    case -3:
                        Console.WriteLine("You can not register for more than 9 credit hours.");
                        break;

                    case -4: //changed case from 0 to -4
                        Console.WriteLine("Registration Confirmed for course {0}.", ChoiceToCourse(intchoice)); //changed choice to intchoice
                        totalCredit += 3;
                        if (firstChoice == 0)
                            firstChoice = intchoice; //changed choice to intchoice

                        else if (secondChoice == 0)
                            secondChoice = intchoice; //changed choice to intchoice

                        else if (thirdChoice == 0)
                            thirdChoice = intchoice; //changed choice to intchoice
                        break;
                }

                WriteCurrentRegistration(firstChoice, secondChoice, thirdChoice);
                Console.Write("\nDo you want to register for another course (Y|N)? : ");
                yesOrNo = (Console.ReadLine()).ToUpper();

            } while (yesOrNo == "Y");

            Console.WriteLine("Thank you for registering with us");
        }

        void WritePrompt()
        {
            Console.WriteLine("Please select a course for which you want to register by typing the number inside []");
            Console.WriteLine("[1]IT 145\n[2]IT 200\n[3]IT 201\n[4]IT 270\n[5]IT 315\n[6]IT 328\n[7]IT 330");
            Console.Write("Enter your choice : ");
        }

        int ValidateChoice(int intchoice, int firstChoice, int secondChoice, int thirdChoice, int totalCredit) //changed choice to intchoice
        {
            if (intchoice < 1 || intchoice > 7) //changed 70 to 7 and changed choice to intchoice
                return -1;

            else if (intchoice == firstChoice || intchoice == secondChoice || intchoice == thirdChoice) //changed and to or and changed choice to intchoice
                return -2;

            else if (totalCredit + 3 > 9) //checks if adding 3 credit hours will exceed 9
                return -3;

            else
                return -4;
        }

        void WriteCurrentRegistration(int firstChoice, int secondChoice, int thirdChoice)
        {
            if (secondChoice == 0)
                Console.WriteLine("You are currently registered for {0}", ChoiceToCourse(firstChoice));

            else if (thirdChoice == 0)
                Console.WriteLine("You are currently registered for {0}, {1}", ChoiceToCourse(firstChoice), ChoiceToCourse(secondChoice));

            else
                Console.WriteLine("You are currently registered for {0}, {1}, {2}", ChoiceToCourse(firstChoice), ChoiceToCourse(secondChoice), ChoiceToCourse(thirdChoice));
        }

        string ChoiceToCourse(int intchoice) //changed choice to intchoice
        {
            string course = "";
            switch (intchoice) //changed choice to intchoice
            {
                case 1:
                    course = "IT 145";
                    break;

                case 2:
                    course = "IT 200";
                    break;

                case 3:
                    course = "IT 201";
                    break;

                case 4:
                    course = "IT 270";
                    break;

                case 5:
                    course = "IT 315";
                    break;

                case 6:
                    course = "IT 328";
                    break;

                case 7:
                    course = "IT 330";
                    break;

                default:
                    break;
            }
            return course;
        }
    }
}
