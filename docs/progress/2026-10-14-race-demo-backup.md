# My first race demo backup - 2026-10-14

I have written a C# console demo that asks for my driver's name, simulates six laps against a rival, adds the lap times, and displays the winner or a tie. Each lap time is randomly generated from 80 to 90 seconds. When a driver wins, I display the winning time difference.

I backed up the saved Program.cs, MotorsportManager.csproj and MotorsportManager.sln into src/MotorsportManager. The copies were checked against the original files using SHA-256. My original working files were preserved unchanged. Build output and IDE state are excluded.

My displayed run finished with 516 seconds for my driver and 512 seconds for the rival, correctly showing a four-second winning margin. This is evidence from my own run; no additional build or runtime test was performed for this backup. The saved code was reviewed for the result and time-difference calculations.

To open this backup in Visual Studio, open src/MotorsportManager/MotorsportManager.sln. With the .NET 9 SDK, I can also run: dotnet run --project src/MotorsportManager/MotorsportManager.csproj

My next step is to add a pace choice with a meaningful trade-off. Tyre wear, pit stops and a season are not implemented yet. GitHub upload completion is checked separately after this note is committed.
