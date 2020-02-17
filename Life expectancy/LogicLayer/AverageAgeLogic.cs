using Life_expectancy.Models;
using System;
using System.Collections.Generic;

namespace Life_expectancy.LogicLayer
{
    public class AverageAgeLogic
    {
        public static double averageAge = 62;
        public static double maxAge = 123;
        public static List<AverageAgeBasedOnCountry> AverageAgeData = GetAllAverageAge();

        public static List<AverageAgeBasedOnCountry> GetAllAverageAge()
        {
            AverageAgeData = new List<AverageAgeBasedOnCountry>
            {
                new AverageAgeBasedOnCountry(1,"South Africa",62),
                new AverageAgeBasedOnCountry(2,"America",68)
            };

            return AverageAgeData;
        }

        public static void SetAverageAge(int id)
        {
            averageAge = GetAverageAge(id);
        }

        public static bool CheckIfIdExist(int id)
        {
            foreach(var item in AverageAgeData)
            {
                if (item.Id == id) return true;
            }
            return false;
        }

        public static double GetAverageAge(int id)
        {
            foreach (var item in AverageAgeData)
            {
                if (item.Id == id) return item.AverageAgeInCounty;
            }
            return averageAge;
        }

        public static void DisplayCountyCode()
        {
            foreach(var item in AverageAgeData)
            {
                Console.WriteLine($"County Code : {item.Id}" +
                    $"\n Country Name : {item.CountyName}" +
                    $"\n");
            }
        }
    }
}
