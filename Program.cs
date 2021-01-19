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
                    Random rnd = new Random();
                    int programRandomHand = rnd.Next(1, 3);
                    //S = 1, R = 2, P = 3
                    Console.WriteLine("Please select hand:\nPress S for SCISSORS.\nPress R for ROCK.\nPress P for PAPER.");
                    string playerHand = Console.ReadKey().Key.ToString();

                    if (playerHand == "S" && programRandomHand == 2)
                    {
                        programScore++;
                        Console.WriteLine("\nYou selected Scissors and the program selected Rock.\nYou: " + playerScore + "\nProgram: " + programScore + "\n");
                    }
                    else if (playerHand == "S" && programRandomHand == 3)
                    {
                        playerScore++;
                        Console.WriteLine("\nYou selected Scissors and the program selected Paper.\nYou: " + playerScore + "\nProgram: " + programScore + "\n");
                    }
                    else if (playerHand == "R" && programRandomHand == 1)
                    {
                        playerScore++;
                        Console.WriteLine("\nYou selected Rock and the program selected Scissors.\nYou: " + playerScore + "\nProgram: " + programScore + "\n");
                    }
                    else if (playerHand == "R" && programRandomHand == 3)
                    {
                        programScore++;
                        Console.WriteLine("\nYou selected Rock and the program selected Paper.\nYou: " + playerScore + "\nProgram: " + programScore + "\n");
                    }
                    else if (playerHand == "P" && programRandomHand == 2)
                    {
                        playerScore++;
                        Console.WriteLine("\nYou selected Paper and the program selected Rock.\nYou: " + playerScore + "\nProgram: " + programScore + "\n");
                    }
                    else if (playerHand == "P" && programRandomHand == 1)
                    {
                        programScore++;
                        Console.WriteLine("\nYou selected Paper and the program selected Scissors.\nYou: " + playerScore + "\nProgram: " + programScore + "\n");
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



