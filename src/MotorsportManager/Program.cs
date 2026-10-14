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
            int tyreCondition = 100;
            int rivalTyreCondition = 100;
            int[] playerLapTimes = new int[totalLaps];
            int[] rivalLapTimes = new int[totalLaps];

            Console.WriteLine("Number of laps: " + totalLaps);

            Random random = new Random();
            for (int i = 1; i <= totalLaps; i++)
            {
                Console.WriteLine("Lap " + i + ":");

                Console.WriteLine("Current tyre condition: " + tyreCondition + "%");
                Console.Write("Pit for fresh tyres? (y/n) ");
                string pitChoice = Console.ReadLine();

                if (pitChoice.ToLower() == "y")
                {
                    tyreCondition = 100;
                    Console.WriteLine("Fresh tyres are fitted. Tyre condition is now 100%. Pitstop time cost: 12 seconds added.\n");
                }

                Console.WriteLine("What pace do you want for this lap?");
                Console.WriteLine("1. Drive carefully");
                Console.WriteLine("2. Push harder");
                Console.WriteLine("3. Drive normally");
                Console.Write("Choose your pace: ");
                string paceChoice = Console.ReadLine();
                int playerLapTime = random.Next(80, 91);

                if (pitChoice.ToLower() == "y")
                {
                    playerLapTime += 12;
                }

                if (paceChoice== "1")
                {
                    playerLapTime += 2;
                    tyreCondition -= 5;
                    Console.WriteLine("You chose to drive carefully.\n");
                }
                else if (paceChoice == "2")
                {
                    playerLapTime -= 2;
                    tyreCondition -= 20;
                    Console.WriteLine("You chose to push harder.\n");
                }
                else if (paceChoice == "3")
                {
                    tyreCondition -= 10;
                    Console.WriteLine("You chose to drive normally.\n");
                }
                else
                {
                    tyreCondition -= 10;
                    Console.WriteLine("Invalid choice. Normal pace will be used.\n");
                }

                if (tyreCondition < 0)
                {
                    tyreCondition = 0;
                }
                Console.WriteLine("Tyre condition: " + tyreCondition + "%\n");

                if (tyreCondition <= 20)
                {
                    playerLapTime += 8;
                    Console.WriteLine("Your tyres are in poor condition. Your lap time has increased by 8 seconds.\n");
                }
                else if (tyreCondition <= 40)
                {
                    playerLapTime += 4;
                    Console.WriteLine("Your tyres are getting a bit worn. Your lap time has increased by 4 seconds.\n");
                }

                playerLapTimes[i - 1] = playerLapTime;
                playerTotalTime += playerLapTime;


                int rivalLapTime = random.Next(80, 91);
                rivalTyreCondition -= 10;

                if (rivalTyreCondition < 0)
                {
                    rivalTyreCondition = 0;
                }

                if (rivalTyreCondition <= 20)
                {
                    rivalLapTime += 8;
                }
                else if (rivalTyreCondition <= 40)
                {
                    rivalLapTime += 4;
                }
                Console.WriteLine("Rival's tyre condition: " + rivalTyreCondition + "%\n");

                rivalLapTimes[i - 1] = rivalLapTime;
                rivalTotalTime += rivalLapTime;


                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Your lap time: " + playerLapTime + " seconds");
                Console.WriteLine("Rival's lap time: " + rivalLapTime + " seconds");
                Console.WriteLine("------------------------------------------\n");
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


            int fastestLapTime = playerLapTimes[0];


            for (int lapIndex = 0; lapIndex < playerLapTimes.Length; lapIndex++)
            {
                Console.WriteLine("Your lap times: " + playerLapTimes[lapIndex] + " seconds");

                if (playerLapTimes[lapIndex] < fastestLapTime)
                {
                    fastestLapTime = playerLapTimes[lapIndex];
                }
            }
            Console.WriteLine("Your fastest lap time is: " + fastestLapTime + " seconds");

            double playerAverageLapTime = (double)playerTotalTime / totalLaps;
            Console.WriteLine("Your average lap time is: " + playerAverageLapTime.ToString("F3") + " seconds");

            int rivalFastestLapTime = rivalLapTimes[0];

            for (int lapIndex = 0; lapIndex < rivalLapTimes.Length; lapIndex++)
            {
                Console.WriteLine("Rival's lap times: " + rivalLapTimes[lapIndex] + " seconds");

                if (rivalLapTimes[lapIndex] < rivalFastestLapTime)
                {
                    rivalFastestLapTime = rivalLapTimes[lapIndex];
                }
            }
            Console.WriteLine("Your rivals fastest lap time is: " + rivalFastestLapTime + " seconds");

            double rivalAverageLapTime = (double)rivalTotalTime / totalLaps;
            Console.WriteLine("Your rivals average lap time is: " + rivalAverageLapTime.ToString("F3") + " seconds");


            Console.ReadLine();
        }
    }
}
