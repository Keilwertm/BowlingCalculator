namespace BowlingStuff;
public class BowlingApp
{
    static public int playerScore;
    static public int userPosition;
    static public int position;
    public class BowlingTime()
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
                Console.WriteLine(nameInput + " ,entered an incorrect input. Please try again: InpSut must be an integer. ");
            }
            
            Console.WriteLine("Please enter in the total amount of rounds you want to play: "); 
            string roundInput = Console.ReadLine();
            if (int.TryParse(roundInput, out int rounds))
            {
                Console.WriteLine(nameInput + " entered: " + rounds);
            }
            else
            {
                while (!int.TryParse(roundInput, out rounds) || rounds < 1 || rounds > 10) // validation to make sure rounds are 1-10 does not work
                {
                    Console.Write("Inavalid input. Please try again: Input must be an integer. ");
                } 
            }

            for (int round = 1; round <= rounds; round++)
            {
                while (true) 
                {
                    Console.WriteLine("Enter your position to throw the ball from (must be between 0 and 35):");
                    string positionNumber = Console.ReadLine();

                    if (int.TryParse(positionNumber, out position) && position >= 0 && position <= 35)
                    {
                        break; 
                    }

                    Console.WriteLine("Invalid input. Please enter an integer between 0 and 35.");
                }

                Console.WriteLine($"You entered: {position}");
            }
                Random starting = new Random();
                int randomPosition = starting.Next(0, 35);
                int sum = playerScore + score;
                int strikeStreak = 0;

                if (Math.Abs(randomPosition = position) <=2)
                {
                    Console.WriteLine($"\n--- Round {rounds} ---");
                    userPosition = randomPosition;
                    int strikeScore = 10;
                    playerScore += strikeScore;
                    strikeStreak++;

                    if (strikeStreak >= 2)
                    {
                        rounds++; 
                        Console.WriteLine("Double Strike! 🎳🎉");
                    }
                    else
                    {
                        rounds--; 
                    }

                    Console.WriteLine("It's a Strike! └(^o^ )Ｘ( ^o^)┘└(^o^ )Ｘ( ^o^)┘");
                }
                else if (randomPosition == 0)
                {
                    Console.WriteLine($"\n--- Round {rounds} ---");
                    Console.WriteLine("Gutter Ball! ");
                }
                else if (userPosition > randomPosition)
                {
                    Console.WriteLine($"\n--- Round {rounds} ---");                         // something wrong with the rng. It only picks 1 number in a range, instead of picking any number above or below the random number
                    Random random = new Random();
                    int randomLessThan = random.Next(1, 6);
                    Console.WriteLine("You knocked over " + randomLessThan + " Pins!");
                    playerScore += randomLessThan;
                }
                else if (userPosition < randomPosition)
                {
                    Console.WriteLine($"\n--- Round {rounds} ---");
                    Random random = new Random();
                    int randomMoreThan = random.Next(6, 10);
                    Console.WriteLine("You knocked over " + randomMoreThan + " Pins!");
                    playerScore += randomMoreThan;
                }
                Console.WriteLine("Your total score is " + playerScore);
            }
        }
    }
    
// Add a way to play again and display previous scores.

// Optional: GUI, Strike animations, unit tests, setting up usings in seperated files for cleaner code. 