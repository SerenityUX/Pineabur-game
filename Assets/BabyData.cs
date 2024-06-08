using UnityEngine;
using System.Collections.Generic;

public static class BabyData
{
    public class Baby
    {
        public string Name;
        public string Father;
        public string Mother;
        public int DayBorn; // 0 - 6 (representing days of the week)
        public List<string> Qualities;
    }

    public static List<Baby> GetBabiesBornOnDay(int day)
    {
        return BabyList.FindAll(baby => baby.DayBorn == day);
    }

    public static List<Baby> BabyList = new List<Baby>
    {
        new Baby
        {
            Name = "lil ralphie.",
            Father = "franklin",
            Mother = "nancy",
            DayBorn = 0,
            Qualities = new List<string>
            {
                "Paranoid",
                "Secretive",
                "Protective"
            }
        },
        new Baby
        {
            Name = "lil ralphie2",
            Father = "franklin",
            Mother = "nancy",
            DayBorn = 0,
            Qualities = new List<string>
            {
                "Paranoid a bit",
                "Secretive",
                "Protective"
            }
        }
    };
}
