namespace BowlingStuff;

public class BowlingApp
{
    public string player1;
    public int player1Score;
    public bool isAStrike;
    public int totalScore;
    public int roundNumber;
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
                Console.WriteLine("You entered an incorrect input. Please try again: ");
            }
            
            Console.WriteLine("Please enter in the total amount of rounds you want to play: "); 
            string roundInput = Console.ReadLine();
            if (int.TryParse(roundInput, out int round))
            {
                Console.WriteLine("You entered: " + round);
            }
            else
            {
                Console.WriteLine("You entered an incorrect input. Please try again: ");
            }
            
            Console.WriteLine($"Enter in your position to throw the ball from:");
            string positionNumber = Console.ReadLine();
            if (int.TryParse(positionNumber, out int position))
            {
                Console.WriteLine("You entered: " + position);
            }
            else
            {
                Console.WriteLine("You entered an incorrect input. Please try again: ");
            }
            
            // I need to take the users inputs, and calculate the number randomly to give a score and determine if it's a strike.
            
            int startingPosition = position;
            Random starting = new Random();
            int randomPosition = starting.Next(5, 35);
            if (randomPosition == startingPosition)
            {
                userPosition = randomPosition;
                Console.WriteLine("It's a Strike! └(^o^ )Ｘ( ^o^)┘└(^o^ )Ｘ( ^o^)┘");
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
                double randomMoreThan = random.Next(6, 10);
                Console.WriteLine("You knocked over " + randomMoreThan + " Pins!");
                
                // I need to limit the positions to integers of 5 between 0 and 35 like a bowling lane. I could also make strikes somewhat more common by giving them a bigger range by 1-2 numbers maybe randomly.
                // I need to loop the round by the enter in number of rounds the user wants to play, and then have a total score option.
                // Finally, a strike will not increase the round count, and add ten to the score.
                // Also, a gutter ball that eats a round and gives zero, I can do this the same as strike and enter it into a random number that the player can hit.
                
                // Optional: GUI, Strike animations, unit tests.
                
                
                
            }
        }
    }
}