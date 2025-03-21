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
    
    // no idea why making userPosition static magically makes it so I can use it in Main

    public class BowlingTime(int player1Score, bool isAStrike, int totalScore, int roundNumber, int startingPosition, int randomPosition)
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Bowling Calculator!");
            Console.WriteLine("Please enter your Name: ");
            Console.WriteLine("Please enter your Score: ");
            Console.WriteLine("Please enter in the total amount of rounds you want to play: ");
            Console.WriteLine($"Enter in your position to throw the ball from:{userPosition}");
            
            // I need to take the users inputs, and calculate the number randomly to give a score and determine if it's a strike.
            
            int startingPosition = userPosition;
            Random starting = new Random();
            int randomPosition = starting.Next(5, 35);
            if (randomPosition == userPosition)
            {
                userPosition = randomPosition;
                Console.WriteLine("It's a Strike! └(^o^ )Ｘ( ^o^)┘└(^o^ )Ｘ( ^o^)┘");
            }
            else if (userPosition > randomPosition)
            {
                Random random = new Random();
                int randomLessthan = random.Next(1, 5);
                Console.WriteLine(randomLessthan);
            }
        }
    }
}