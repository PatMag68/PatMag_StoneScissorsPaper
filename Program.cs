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
            bool gameDone = false;

            Console.WriteLine("Welcome to a game of Scissors, Rock, Paper against the PC.\nFirst to 3 points wins and you will select your hand first.\n");
            while (keepPlaying)
            {
                while (playerScore < 3 && programScore < 3)
                {
                    Random rnd = new Random();
                    int programRandomHand = rnd.Next(1, 3);
                    //S = 1, R = 2, P = 3
                    Console.WriteLine("\n\nPlease select hand:\nPress S for SCISSORS.\nPress R for ROCK.\nPress P for PAPER.");
                    string playerHand = Console.ReadKey().Key.ToString();

                    if (playerHand == "S" | playerHand == "R" | playerHand == "P")
                    {
                        if (playerHand == "S" && programRandomHand == 2)
                        {
                            programScore++;
                            Console.WriteLine("\n\nYou selected Scissors and the program selected Rock.\nYou: " + playerScore + "\nProgram: " + programScore + "\n\n");
                        }
                        else if (playerHand == "S" && programRandomHand == 3)
                        {
                            playerScore++;
                            Console.WriteLine("\n\nYou selected Scissors and the program selected Paper.\nYou: " + playerScore + "\nProgram: " + programScore + "\n\n");
                        }
                        else if (playerHand == "R" && programRandomHand == 1)
                        {
                            playerScore++;
                            Console.WriteLine("\n\nYou selected Rock and the program selected Scissors.\nYou: " + playerScore + "\nProgram: " + programScore + "\n\n");
                        }
                        else if (playerHand == "R" && programRandomHand == 3)
                        {
                            programScore++;
                            Console.WriteLine("\n\nYou selected Rock and the program selected Paper.\nYou: " + playerScore + "\nProgram: " + programScore + "\n\n");
                        }
                        else if (playerHand == "P" && programRandomHand == 2)
                        {
                            playerScore++;
                            Console.WriteLine("\n\nYou selected Paper and the program selected Rock.\nYou: " + playerScore + "\nProgram: " + programScore + "\n\n");
                        }
                        else if (playerHand == "P" && programRandomHand == 1)
                        {
                            programScore++;
                            Console.WriteLine("\n\nYou selected Paper and the program selected Scissors.\nYou: " + playerScore + "\nProgram: " + programScore + "\n\n");
                        }
                        else
                        {
                            Console.WriteLine("\n\nYou selected the same hands and this round is a draw. No points.\n\n");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\n\nYou must enter S, R or N.\n");
                    }

                }
                if (playerScore > programScore && gameDone == false)
                {
                    gameDone = true;
                    Console.WriteLine("You won with " + playerScore + " to " + programScore + ".\n");
                }
                else if (programScore > playerScore && gameDone == false)
                {
                    gameDone = true;
                    Console.WriteLine("The program won with " + programScore + " to " + playerScore + ".\n");
                }
                Console.WriteLine("\nWant to play again? Press Y or N.\n");
                string playOrNot = Console.ReadKey().Key.ToString();
                if (playOrNot == "Y" | playOrNot == "N")
                {
                    if (playOrNot == "N")
                    {
                        keepPlaying = false;
                    }
                    else if (playOrNot == "Y")
                    {
                        gameDone = false;
                        playerScore = 0;
                        programScore = 0;
                    }
                    else
                    {

                    }
                }
            }

        }
    }

}

