namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Dante! Welcome to your first circle of hell!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("You shouldn't have abandoned poor Virgil.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("We will help you learn to be more appreciative of your guides for next time...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Not that there will BE a next time...");
            Console.ReadLine();
            Console.Clear();

            FavoriteSubject();

            Console.ReadLine();
            Console.Clear();

            FavoriteNumber();

            Console.WriteLine("Let's do it again!");
            Repeat();
        }
        public static void FavoriteSubject()
            {//This method will get the user's favorite subject.
            Console.WriteLine("We want to make your experience as uncomfortable as possible..." +
                "\nWhat is your favorite school subject?" +
                "\n" +
                "\nChoose wisely...");
            string favoriteSubject = Console.ReadLine();

            switch (favoriteSubject)
            {
                case "Math":
                    Console.WriteLine("Wonderful! Let's start with a number guessing game!");
                    break;
                case "English":
                    Console.WriteLine("Excellent, we have many letters from Karens you must respond to." +
                        "\nBut first...");
                    break;
                case "Science":
                    Console.WriteLine("Perfect! Screwtape, send him to test the lava's texture. " +
                        "Make sure to dip him up to the neck." +
                        "\nBut before that...");
                    break;
                case "Phylosophy":
                    Console.WriteLine("Great! We will promote you to Imp!" +
                        "\nAfter you do one small assignment...");
                    break;
                case "P. E.":
                    Console.WriteLine("Splendid! Wormword, break out that doughnut feeder we used on Homer Simpson." +
                        "\nWhile he is getting that ready...");
                    break;
                default:
                    Console.WriteLine("Ah! Well, we will have to start with some general stuff. PREPARE THE RACK!" +
                        "\nWhile we wait...");
                    break;


            }


    }    public static void FavoriteNumber()
             {//This method will prompt user to guess number
            Console.WriteLine("Today we will begin in an exercise in boredom and repetition." +
                "\nTo start the torture, guess my favorite number:");

            int favNumber = 17;
      
            int userInput = int.Parse(Console.ReadLine());
                
                if (userInput < favNumber)
                {
                    Console.WriteLine("Too low. Try again.");
                    Console.ReadLine();
                }
                else if (userInput == favNumber)
                {
                    Console.WriteLine("You guessed!");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("...");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Do it again!");

                }
                else if (userInput > favNumber);
            {
                Console.WriteLine("Too high. Try again.");
                Console.ReadLine();
            }
        } 
        public static void Repeat()
        {
            while (true)
            {
                FavoriteNumber();
            }
        }
    }
}
