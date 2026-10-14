namespace MotorsportManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Motorsport Manager!");
            Console.WriteLine("What is your driver's name?");
            string driverName = Console.ReadLine();
            Console.WriteLine("Welcome, " + driverName + "! Let's get started with your teams racing career!");

            int totalLaps = 6;
            int playerTotalTime = 0;
            int rivalTotalTime = 0;

            Console.WriteLine("Number of laps: " + totalLaps);

            Random random = new Random();
            for (int i = 1; i <= totalLaps; i++)
            {
                Console.WriteLine("Lap " + i + ":");
                int playerLapTime = random.Next(80, 91);
                playerTotalTime += playerLapTime;
                int rivalLapTime = random.Next(80, 91);
                rivalTotalTime += rivalLapTime;
                Console.WriteLine("Your lap time: " + playerLapTime + " seconds");
                Console.WriteLine("Rival's lap time: " + rivalLapTime + " seconds");
            }

            Console.WriteLine("Race finished!");
            Console.WriteLine("Your total time: " + playerTotalTime + " seconds");
            Console.WriteLine("Rival's total time: " + rivalTotalTime + " seconds");

            if (playerTotalTime < rivalTotalTime)
            {
                Console.WriteLine(driverName + " wins!");

                int timeDifference = rivalTotalTime - playerTotalTime;
                Console.WriteLine("Winning time difference: " + timeDifference + " seconds");
            }
            else if (playerTotalTime > rivalTotalTime)
            {
                Console.WriteLine("Rival wins!");

                int timeDifference = playerTotalTime - rivalTotalTime;
                Console.WriteLine("Winning time difference: " + timeDifference + " seconds");
            }
            else
            {
                Console.WriteLine("It's a tie!");
            }


                Console.ReadLine();
        }
    }
}
