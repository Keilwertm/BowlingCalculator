namespace BowlingStuff;
public class BowlingApp
{
    static public int playerScore;
    static public int userPosition;
    
    // no idea why making userPosition static magically makes it, so I can use it in Main.
    public class BowlingTime(int player1Score, bool isAStrike, int totalScore, int roundNumber, int startingPosition, int randomPosition)
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Bowling Calculator!");
            Console.WriteLine("Please enter your Name: ");
            string nameInput = Console.ReadLine();
            
            Console.WriteLine(nameInput + ", Please enter your starting score: ");
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
                int sum = playerScore + score;

                if (Math.Abs(randomPosition = startingPosition) <=2)
                {
                    Console.WriteLine($"\n--- Round {round} ---");
                    userPosition = randomPosition;
                    int strikeScore = 10;
                    playerScore += strikeScore;
                    round = round - 1;
                    Console.WriteLine("It's a Strike! └(^o^ )Ｘ( ^o^)┘└(^o^ )Ｘ( ^o^)┘");
                }
                else if (randomPosition == 0)
                {
                    Console.WriteLine($"\n--- Round {round} ---");
                    Console.WriteLine("Gutter Ball! ");
                }
                else if (userPosition > randomPosition)
                {
                    Console.WriteLine($"\n--- Round {round} ---");
                    Random random = new Random();
                    int randomLessThan = random.Next(1, 6);
                    Console.WriteLine("You knocked over " + randomLessThan + " Pins!");
                    playerScore += randomLessThan;
                }
                else if (userPosition < randomPosition)
                {
                    Console.WriteLine($"\n--- Round {round} ---");
                    Random random = new Random();
                    int randomMoreThan = random.Next(6, 10);
                    Console.WriteLine("You knocked over " + randomMoreThan + " Pins!");
                    playerScore += randomMoreThan;
                }
                Console.WriteLine("Your total score is " + playerScore);
            }
                // I need to limit the positions of integers of 5 between 0 and 35 like a bowling lane. 
                // Add a way to play again and display previous scores.
                
                // bugs - the number is not generating each loop. It's just staying the same, so if strike is 2 you can get a strike everytime by typing 2.

                // Optional: GUI, Strike animations, unit tests, setting up usings in seperated files for cleaner code. 
        }
    }
}