using System;
using System.Collections.Generic;

namespace Guessing_Game
{
    class Program
    {
        private static IEnumerable<int> numbersEntered;

        static void Main(string[] args)
        {
            Random randomNumber = new Random();

            int winNumber = randomNumber.Next(1, 10);

            int numberOfGuesses = 0;

            const int MAX_NUMBER_GUESSES = 3;
            int[] numbersEntered = new int[11];

            bool win= false;

            do
            {            
                Console.WriteLine("Guess Number between 1 and 10");

                String guessNum = Console.ReadLine();//read user input

                int enteredNum = int.Parse(guessNum);//change entered string(numner) into integer

                if(numberOfGuesses < MAX_NUMBER_GUESSES - 1)
                {
                    if (enteredNum > winNumber)
                    {
                        Console.WriteLine("Number is too high");
                    }
                    else if (enteredNum < winNumber)
                    {
                        Console.WriteLine("Number: " + enteredNum + " is too low");
                    }
                    else if(enteredNum == winNumber)
                    {
                        Console.WriteLine("Congratulations, you won");
                        PrintNumbers();
                        break;
                    }

                    numberOfGuesses += 1;//increases number of guesses by 1
                    numbersEntered[enteredNum]++;//stores numbers entered/guessed

                    Console.WriteLine("Number of guesses: " + numberOfGuesses);
                }
                else
                {
                    Console.WriteLine("You lost");
                    PrintNumbers();
                    break;
                }

            } while (win == false);

        }

        public static void PrintNumbers()
        {
            foreach (int allNumbers in numbersEntered)
            {
                Console.WriteLine(allNumbers);
            }

        }
    }
}
