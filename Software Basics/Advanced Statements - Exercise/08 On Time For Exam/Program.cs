﻿using System;

namespace _08_On_Time_For_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinutes = int.Parse(Console.ReadLine());

            int examTime = examHour * 60 + examMinutes;
            int arrivalTime = arrivalHour * 60 + arrivalMinutes;

            if (arrivalTime > examTime)
            {
                Console.WriteLine("Late");
                if (arrivalTime - examTime < 60)
                {
                    Console.WriteLine($"{arrivalTime - examTime} minutes after the start");
                }
                else
                {
                    int hour = (arrivalTime - examTime) / 60;
                    int minutes = (arrivalTime - examTime) % 60;
                    

                    if (minutes < 10)
                    {
                        Console.WriteLine($"{hour}:0{minutes} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine($"{hour}:{minutes} hours after the start");
                    }
                }

            }
            else if (arrivalTime == examTime || examTime - arrivalTime <= 30)
            {
                Console.WriteLine("On time");
                if (examTime - arrivalTime != 0)
                {
                    Console.WriteLine($"{examTime - arrivalTime} minutes before the start");
                }

            }
            else if (examTime - arrivalTime > 30)
            {
                Console.WriteLine("Early");
                if (examTime - arrivalTime < 60)
                {
                    Console.WriteLine($"{examTime - arrivalTime} minutes before the start");
                }
                else
                {
                    int hours = (examTime - arrivalTime) / 60;
                    int minutes = (examTime - arrivalTime) % 60;

                    Console.WriteLine($"{hours}:{minutes:D2} hours before the start");
                }

            }
        }

    }
}
