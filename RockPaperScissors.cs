using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class FirstSeeSharp
    {

        public static void Main(string[] args)
        {
           
            // Introduce user to game, and set up our scores and end condition outside of our loop
            Console.WriteLine("Play rock, paper, scissors against a CPU!");
            Console.WriteLine("To play: simply type 'rock', 'paper', or 'scissors' to make your move.");
            bool endGame = false;
            int userScore = 0;
            int CPUScore = 0;


            while (!endGame)
            {

                // Use a random() object to get a random input from 1 to 3
                string userInput = Console.ReadLine();
                string CPUTurn = "";
                Random rnd = new Random();
                int CPUChoice = rnd.Next(1, 3);

                // Base case: if the user ends we continue to the next iteration where our while loop will now stop due to the boolean condition
                if (userInput.Equals("end"))
                {
                    endGame = true;
                    Console.WriteLine("Game over! Restart this program if you'd like to play again!");
                    continue;
                }

                // User our randomized score to get a randomized choice each iteration
                if (CPUChoice == 1)
                {
                    CPUTurn = "rock";
                }
                else if (CPUChoice == 2)
                {
                    CPUTurn = "paper";
                }
                else
                {
                    CPUTurn = "scissors";
                }

                // Switch cases to more efficiently get our results, still tedious due to combinations
                switch (CPUTurn)
                {
                    case "rock":
                        if (userInput.Equals("rock"))
                        {
                            Console.WriteLine("It's a draw! Two rocks!");
                            Console.WriteLine("Current Score | User Score: " + userScore + " | CPU Score: " + CPUScore);
                            break;
                        }
                        else if (userInput.Equals("paper"))
                        {
                            Console.WriteLine("You win! Paper covers rock!");
                            userScore++;
                            Console.WriteLine("Current Score | User Score: " + userScore + " | CPU Score: " + CPUScore);
                            break;
                        }
                        else if (userInput.Equals("scissors"))
                        {
                            Console.WriteLine("You lose! Scissors gets crushed by rock!");
                            CPUScore++;
                            Console.WriteLine("Current Score | User Score: " + userScore + " | CPU Score: " + CPUScore);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Not a valid choice, sorry!");
                            break;
                        }


                    case "paper":
                        if (userInput.Equals("rock"))
                        {
                            Console.WriteLine("You lose! Paper covers rock!");
                            CPUScore++;
                            Console.WriteLine("Current Score | User Score: " + userScore + " | CPU Score: " + CPUScore);
                            break;
                        }
                        else if (userInput.Equals("paper"))
                        {
                            Console.WriteLine("A tie! Two pieces of paper!");
                            Console.WriteLine("Current Score | User Score: " + userScore + " | CPU Score: " + CPUScore);
                            break;
                        }
                        else if (userInput.Equals("scissors"))
                        {
                            Console.WriteLine("You win! Scissors cuts paper!");
                            userScore++;
                            Console.WriteLine("Current Score | User Score: " + userScore + " | CPU Score: " + CPUScore);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Not a valid choice, sorry!");
                            break;
                        }


                    case "scissors":
                        if (userInput.Equals("rock"))
                        {
                            Console.WriteLine("You win! Rock beats scissors!");
                            userScore++;
                            Console.WriteLine("Current Score | User Score: " + userScore + " | CPU Score: " + CPUScore);
                            break;
                        }
                        else if (userInput.Equals("paper"))
                        {
                            Console.WriteLine("You lose! Paper gets cut!");
                            CPUScore++;
                            Console.WriteLine("Current Score | User Score: " + userScore + " | CPU Score: " + CPUScore);
                            break;
                        }
                        else if (userInput.Equals("scissors"))
                        {
                            Console.WriteLine("It's a draw, two pairs of scissors!");
                            Console.WriteLine("Current Score | User Score: " + userScore + " | CPU Score: " + CPUScore);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Not a valid choice, sorry!");
                            break;
                        }
                }
            }
        }
    }
    // End of program
}
