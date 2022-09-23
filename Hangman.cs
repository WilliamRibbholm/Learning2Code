using System.Diagnostics.CodeAnalysis;
using System.Text;
namespace Hangman
{
    internal class Program
    {
        const int maxGuesses = 10;
        static string secretWord = string.Empty;
        static char[] secretWordArr;
        static bool win = false;
        static StringBuilder guessedLetters = new StringBuilder();
        static void Main(string[] args)
        {
            int currentGuesses = 0;
            string[] secretWords = { "Whiskey", "Ethernet", "Computer", "Cold", "Banana", "Lagom", "Plant", "Lagoon", "Camera", "Canada", "Superstitious", "Terrorist", "Obama", "Bush", "Reagan", "Trump" };


            
            Random random = new Random();
            int index = random.Next(secretWords.Length);

            secretWord = secretWords[index];

            BuildCharArray();

            while (currentGuesses != maxGuesses)
            {
                if(win == true) { break; }
                Console.WriteLine("Welcome to Hangman!\n");
                Console.WriteLine("Remaining Guesses: " + (maxGuesses - currentGuesses).ToString());

                PrintSecretWordProgress();
                PrintGuessedLetters();

                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1) Guess a letter");
                Console.WriteLine("2) Guess the word");

                char Selection = new char();
                Selection = Console.ReadLine()[0];

                while (Selection != '1' && Selection != '2')
                {
                    Console.WriteLine("Invalid response, please try again: ");
                    Selection = Console.ReadLine()[0];
                }

                if (Selection == '1')
                {
                    if (GuessLetter() == false)
                    {
                        currentGuesses++;
                    }

                }
                else if (Selection == '2')
                {
                    if (GuessWord() == false)
                    {
                        currentGuesses++;
                    }

                }

                Console.Clear();
            }
            if (currentGuesses >= maxGuesses)
                Console.WriteLine("You ran out of guesses. Tough luck.");
            if (win == true)
                Console.WriteLine("You won!");
        }
        //This method will take our secret word and construct an array of '_' characters based on the secret word's length
        //We will then replace these characters as we guess them
        private static void BuildCharArray()
        {
            secretWordArr = secretWord.ToCharArray();

            for (int i = 0; i < secretWordArr.Length; i++)
            {
                secretWordArr[i] = '_';
            }
            

        }
        private static void PrintSecretWordProgress()
        {
            for (int i = 0; i < secretWordArr.Length; i++)
            {
                Console.Write(secretWordArr[i] + " ");
            }

            Console.WriteLine();
        }
        private static void PrintGuessedLetters()
        {
            Console.WriteLine("Incorrect Letters: ");
            for(int i = 0; i < guessedLetters.Length; i++)
            {
                Console.Write(guessedLetters[i].ToString().ToUpper() + " ");
            }

        }
        private static bool GuessLetter()
        {
            //Guessing the letter
            Console.WriteLine("Guess your letter: ");

            char guess = new char();
            guess = Console.ReadLine()[0];

            bool foundLetter = false;

            for (int i = 0; i < secretWord.Length; i++)
            {
                if (secretWord.ToLower()[i] == guess)
                {
                    secretWordArr[i] = char.ToUpper(guess);
                    foundLetter = true;
                    
                }
            }
            if(foundLetter == false)
            {
                if(guessedLetters.ToString().Contains(guess) == false)
                    guessedLetters.Append(guess);
            }

            string s = new string(secretWordArr);
            if (secretWord.ToUpper() == s.ToUpper())
            {
                win = true;
            }

            return foundLetter;
        }

        private static bool GuessWord()
        {
            Console.WriteLine("Guess the word: ");

            string guess = string.Empty;
            guess = Console.ReadLine();

            bool result = false;

            if(guess.ToUpper() == secretWord.ToUpper())
            {
                Console.WriteLine("You got it!");
                
                secretWordArr = secretWord.ToUpper().ToCharArray();
                win = true;
                result = true;
            }
            else
            {
                Console.WriteLine("Wrong word!");
            }
            Console.ReadLine();

            return result;
        }
    }
}