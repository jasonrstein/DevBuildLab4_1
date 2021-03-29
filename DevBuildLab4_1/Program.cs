using System;

namespace Lab4_1
{
    class Program
    {

        static string DidYouWin(int x)
        {
            string winner;

            if (x == 2 || x == 3 || x == 12)
            {
                winner = "Craps!";
                return winner;
            }
            else if (x == 7 || x == 11)
            {
                winner = "You are a winner";
                return winner;
            }
            else
            {
                winner = "---";
                return winner;
            }
        }

        static string DiceMessage(int x, int y)
        {
            string diceCombonation = " ";
            string returnedMessage;

            // Snake Eyes: Two 1s
            //  Ace Deuce: A 1 and 2
            //  Box Cars: Two 6s
            //  Win: A total of 7 or 11
            //  Craps: A total of 2, 3, or 12

            if (x == 1 && y == 1)
            {
                returnedMessage = "Snake Eyes";
                return returnedMessage;
            }

            else if (x == 1 && y == 2)
            {
                returnedMessage = "Ace Deuce";
                return returnedMessage;
            }

            else if (x == 2 && y == 1)
            {
                returnedMessage = "Ace Deuce";
                return returnedMessage;
            }

            else if (x == 6 && y == 6)
            {
                returnedMessage = "Box Cars";
                return returnedMessage;
            }


            return diceCombonation;
        }

        static void Main(string[] args)
        {
            int rollOne;
            int rollTwo;
            bool keepRolling = true;
            int sidesOnDice;
            int roll = 1;

            int totalnum;
            string contYN;

            Random rand = new Random();
            while (keepRolling)
            {
                Console.Write("Please enter amount of sides on first dice: ");
                sidesOnDice = Int32.Parse(Console.ReadLine());
                rollOne = rand.Next(1, sidesOnDice);
                rollTwo = rand.Next(1, sidesOnDice);
                totalnum = rollOne + rollTwo;
                Console.WriteLine($"Roll {roll}");
                Console.WriteLine($"You rolled a {rollOne} and a {rollTwo} -- ({totalnum} total)");


                if (sidesOnDice == 6)
                {

                    Console.WriteLine(DiceMessage(rollOne, rollTwo));

                }

                Console.WriteLine(DidYouWin(totalnum));

                do
                {
                    Console.Write("Would like to continue? Please respond with a y or n: ");
                    contYN = Console.ReadLine().ToLower();

                    if (contYN == "n")
                    {
                        keepRolling = false;
                    }

                    else if (contYN != "y" && contYN != "n")
                    {
                        Console.WriteLine("Not a valid response");
                    }

                } while (contYN != "y" && contYN != "n");

                roll++;
            }



        }
    }
}
