namespace BowlingStuff;

public class BowlingApp
{
    public string player1;
    public int player1Score;
    public bool isAStrike;
    public int totalScore;
    public int startingPosition;
    public int randomPosition;
    static public int userPosition;
    
    // no idea why making userPosition static magically makes it, so I can use it in Main.

    public class BowlingTime(int player1Score, bool isAStrike, int totalScore, int roundNumber, int startingPosition, int randomPosition)
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Bowling Calculator!");
            Console.WriteLine("Please enter your Name: ");
            string nameInput = Console.ReadLine();
            
            Console.WriteLine(nameInput + ", Please enter your Score: ");
            string scoreInput = Console.ReadLine();
            if (int.TryParse(scoreInput, out int score))
            {
                Console.WriteLine("You entered: " + score);
            }
            else
            {
                Console.WriteLine("You entered an incorrect input. Please try again: Input must be an integer. ");
            }
            
            Console.WriteLine("Please enter in the total amount of rounds you want to play: "); 
            string roundInput = Console.ReadLine();
            if (int.TryParse(roundInput, out int rounds))
            {
                Console.WriteLine("You entered: " + rounds);
            }
            else
            {
                while (!int.TryParse(roundInput, out rounds) || rounds < 1 || rounds > 10) // Validation for the round to be between 1-10 does not work
                {
                    Console.Write("Inavalid input. Please try again: Input must be an integer. ");
                } 
            }

            for (int round = 1; round <= rounds; round++)
            {
                Console.WriteLine($"Enter in your position to throw the ball from:");
                string positionNumber = Console.ReadLine();
                if (int.TryParse(positionNumber, out int position))
                {
                    Console.WriteLine("You entered: " + position);
                }
                else
                {
                    Console.WriteLine("You entered an incorrect input. Please try again: Input must be an integer. ");
                }
                
                int startingPosition = position;
                Random starting = new Random();
                int randomPosition = starting.Next(0, 35);      

                if (Math.Abs(randomPosition = startingPosition) <=2)
                {
                    userPosition = randomPosition;
                    Console.WriteLine("It's a Strike! └(^o^ )Ｘ( ^o^)┘└(^o^ )Ｘ( ^o^)┘");
                }
                else if (randomPosition == 0)
                {
                    Console.WriteLine("Gutter Ball! ");
                }
                else if (userPosition > randomPosition)
                {
                    Random random = new Random();
                    double randomLessThan = random.Next(1, 5);
                    Console.WriteLine("You knocked over " + randomLessThan + " Pins!");
                }
                else if (userPosition < randomPosition)
                {
                    Random random = new Random();
                    double randomMoreThan = random.Next(6, 9);
                    Console.WriteLine("You knocked over " + randomMoreThan + " Pins!");
                }
            }

                // I need to limit the positions to integers of 5 between 0 and 35 like a bowling lane. I could also make strikes somewhat more common by giving them a bigger range by 1-2 numbers maybe randomly.
                // I need to loop the round by the enter in number of rounds the user wants to play, and then have a total score option.
                // Finally, a strike will not increase the round count, and add ten to the score.
                // Also, a gutter ball that eats a round and gives zero, I can do this the same as strike and enter it into a random number that the player can hit.

                // Optional: GUI, Strike animations, unit tests, setting up usings in seperated files for cleaner code. 
            
        }
    }
}