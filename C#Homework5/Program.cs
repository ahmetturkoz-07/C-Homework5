using System;

    
        double[] week = [14.2, 17.5, 19.0, 16.8, 21.3, 22.7, 18.4];

        
        double avg = Average(week);
        Console.WriteLine($"Average Temperature: {avg:F1} °C");
        Console.WriteLine();

        
        int hottestIndex = 0;
        for (int i = 1; i < week.Length; i++)
        {
            if (week[i] > week[hottestIndex])
            {
                hottestIndex = i;
            }
        }
        Console.WriteLine($"Hottest day: Day {hottestIndex + 1} ({week[hottestIndex]} °C)");
        Console.WriteLine();

        
        Console.WriteLine("Days above average:");
        for (int i = 0; i < week.Length; i++)
        {
            if (week[i] > avg)
            {
                Console.WriteLine($"Day {i + 1}: {week[i]} °C");
            }
        }
        Console.WriteLine();

        
        Console.WriteLine("Temperatures for the last 3 days:");
        double[] lastThreeDays = week[^3..];
        Console.WriteLine(string.Join(", ", lastThreeDays));
    

    
    static double Average(double[] t)
    {
        double sum = 0;
        foreach (double temp in t)
        {
            sum += temp;
        }
        return sum / t.Length;
    }


