using System;


namespace PatMag_StoneScissorsPaper
{
    class Program
    {


        static void Main(string[] args)
        {


            int programScore = 0;
            int playerScore = 0;
            bool keepPlaying = true;


            Console.WriteLine("Welcome to a game of Scissors, Rock, Paper against the PC.\nFirst to 3 points wins and\nyou will select your hand first.\n");
            while (keepPlaying)
            {
                while (playerScore < 3 && programScore < 3)
                {
                    Console.WriteLine("Please select hand:\nPress S for SCISSORS.\nPress R for ROCK.\nPress P for PAPER.");
                    string playerHand = Console.ReadKey().Key.ToString();
                    string programHand = "P";
                    Random programHands = new Random();
                    if (playerHand == "S" && programHand == "R")
                    {
                        programScore++;
                    }
                    else if (playerHand == "S" && programHand == "P")
                    {
                        playerScore++;
                    }
                    else if (playerHand == "R" && programHand == "S")
                    {
                        playerScore++;
                    }
                    else if (playerHand == "R" && programHand == "P")
                    {
                        programScore++;
                    }
                    else if (playerHand == "P" && programHand == "R")
                    {
                        playerScore++;
                    }
                    else if (playerHand == "P" && programHand == "S")
                    {
                        programScore++;
                    }
                    else
                    {
                        Console.WriteLine("\nYou selected the same hands and this round is a draw. No points.");
                    }

                }
                if (playerScore > programScore)
                {
                    Console.WriteLine("You won with " + playerScore + " to " + programScore + ".\n");
                }
                else if (programScore > playerScore)
                {
                    Console.WriteLine("The program won with " + programScore + " to " + playerScore + ".\n");
                }
                Console.WriteLine("Want to play again? Press Y or N.");
                string playOrNot = Console.ReadKey().Key.ToString();
                if (playOrNot == "N")
                {
                    keepPlaying = false;
                }
                else if (playOrNot == "Y")
                {
                    playerScore = 0;
                    programScore = 0;
                }
            }
        }

        static void ScoreMaker()
        {

        }




    }
}



