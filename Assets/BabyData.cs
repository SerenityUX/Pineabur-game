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
            Name = "Ralph",
            Father = "seb",
            Mother = "scarlett",
            DayBorn = 0,
            Qualities = new List<string> { "Old", "Nostalgic", "Disappointed" }
        },
        new Baby
        {
            Name = "Lily",
            Father = "seb",
            Mother = "emma",
            DayBorn = 2,
            Qualities = new List<string> { "Accountable", "Old", "Reflective", "Confused" }
        },
        new Baby
        {
            Name = "Jack",
            Father = "seb",
            Mother = "nancy",
            DayBorn = 3,
            Qualities = new List<string> { "Old", "Confused", "Disappointed", "Accountable" }
        },
        new Baby
        {
            Name = "Anna",
            Father = "seb",
            Mother = "emma",
            DayBorn = 4,
            Qualities = new List<string> { "Reflective", "Excluded", "Disappointed" }
        },
        new Baby
        {
            Name = "Tom",
            Father = "seb",
            Mother = "sabrina",
            DayBorn = 5,
            Qualities = new List<string> { "Reflective", "Confused", "Old", "Disappointed" }
        },
        new Baby
        {
            Name = "Eve",
            Father = "seb",
            Mother = "aadhya",
            DayBorn = 6,
            Qualities = new List<string> { "Disappointed", "Excluded", "Reflective", "Accountable" }
        },
        new Baby
        {
            Name = "Max",
            Father = "dom",
            Mother = "nancy",
            DayBorn = 2,
            Qualities = new List<string> { "Aggressive", "Confident", "Determined" }
        },
        new Baby
        {
            Name = "Nina",
            Father = "dom",
            Mother = "aadhya",
            DayBorn = 3,
            Qualities = new List<string> { "Ambitious", "Playful", "Confident" }
        },
        new Baby
        {
            Name = "Leo",
            Father = "dom",
            Mother = "scarlett",
            DayBorn = 4,
            Qualities = new List<string> { "Playful", "Confident", "Determined" }
        },
        new Baby
        {
            Name = "Mia",
            Father = "dom",
            Mother = "nancy",
            DayBorn = 5,
            Qualities = new List<string> { "Confident", "Ambitious", "Playful" }
        },
        new Baby
        {
            Name = "Sam",
            Father = "dom",
            Mother = "scarlett",
            DayBorn = 6,
            Qualities = new List<string> { "Determined", "Ambitious", "Confident", "Excited" }
        },
        new Baby
        {
            Name = "Amy",
            Father = "franklin",
            Mother = "nancy",
            DayBorn = 0,
            Qualities = new List<string> { "Mindful", "Critical" }
        },
        new Baby
        {
            Name = "Luke",
            Father = "franklin",
            Mother = "sabrina",
            DayBorn = 2,
            Qualities = new List<string> { "Mindful", "Paranoid", "Philosophical" }
        },
        new Baby
        {
            Name = "Zoe",
            Father = "franklin",
            Mother = "sabrina",
            DayBorn = 4,
            Qualities = new List<string> { "Paranoid", "Philosophical", "Critical", "Protective" }
        },
        new Baby
        {
            Name = "Finn",
            Father = "franklin",
            Mother = "emma",
            DayBorn = 5,
            Qualities = new List<string> { "Critical", "Loving", "Optimistic", "Paranoid" }
        },
        new Baby
        {
            Name = "Grace",
            Father = "franklin",
            Mother = "nancy",
            DayBorn = 6,
            Qualities = new List<string> { "Optimistic", "Protective", "Critical", "Mindful" }
        },
        new Baby
        {
            Name = "Owen",
            Father = "dylan",
            Mother = "aadhya",
            DayBorn = 1,
            Qualities = new List<string> { "Generous", "Pessimistic", "Philosophical", "Shocked" }
        },
        new Baby
        {
            Name = "Ella",
            Father = "dylan",
            Mother = "scarlett",
            DayBorn = 3,
            Qualities = new List<string> { "Pressured", "Generous", "Pessimistic" }
        },
        new Baby
        {
            Name = "Noah",
            Father = "dylan",
            Mother = "jane",
            DayBorn = 4,
            Qualities = new List<string> { "Pessimistic", "Shocked", "Pressured", "Generous" }
        },
        new Baby
        {
            Name = "Ivy",
            Father = "dylan",
            Mother = "jane",
            DayBorn = 5,
            Qualities = new List<string> { "Shocked", "Philosophical", "Generous", "Pressured" }
        },
        new Baby
        {
            Name = "Eli",
            Father = "dylan",
            Mother = "sabrina",
            DayBorn = 6,
            Qualities = new List<string> { "Shocked", "Pressured", "Pessimistic" }
        },
        new Baby
        {
            Name = "Ruby",
            Father = "tyler",
            Mother = "nancy",
            DayBorn = 1,
            Qualities = new List<string> { "Optimistic", "Cheerful", "Resilient" }
        },
        new Baby
        {
            Name = "Ben",
            Father = "tyler",
            Mother = "jane",
            DayBorn = 3,
            Qualities = new List<string> { "Resilient", "Materialistic", "Naive", "Optimistic" }
        },
        new Baby
        {
            Name = "Luna",
            Father = "tyler",
            Mother = "aadhya",
            DayBorn = 4,
            Qualities = new List<string> { "Optimistic", "Materialistic", "Cheerful" }
        },
        new Baby
        {
            Name = "Jay",
            Father = "tyler",
            Mother = "scarlett",
            DayBorn = 5,
            Qualities = new List<string> { "Materialistic", "Optimistic", "Reflective", "Cheerful" }
        },
        new Baby
        {
            Name = "Rose",
            Father = "tyler",
            Mother = "jane",
            DayBorn = 6,
            Qualities = new List<string> { "Reflective", "Touristic", "Cheerful" }
        },
        new Baby
        {
            Name = "Alec",
            Father = "steve",
            Mother = "emma",
            DayBorn = 1,
            Qualities = new List<string> { "Confident", "Determined", "Paranoid" }
        },
        new Baby
        {
            Name = "Lila",
            Father = "steve",
            Mother = "aadhya",
            DayBorn = 2,
            Qualities = new List<string> { "Skeptical", "Confident", "Paranoid", "Friendly" }
        },
        new Baby
        {
            Name = "Ray",
            Father = "steve",
            Mother = "sabrina",
            DayBorn = 3,
            Qualities = new List<string> { "Determined", "Friendly", "Playful" }
        },
        new Baby
        {
            Name = "Eden",
            Father = "steve",
            Mother = "nancy",
            DayBorn = 4,
            Qualities = new List<string> { "Playful", "Paranoid", "Suspicious" }
        },
        new Baby
        {
            Name = "Nate",
            Father = "steve",
            Mother = "aadhya",
            DayBorn = 5,
            Qualities = new List<string> { "Playful", "Skeptical", "Determined", "Friendly" }
        },
        new Baby
        {
            Name = "Cara",
            Father = "steve",
            Mother = "emma",
            DayBorn = 6,
            Qualities = new List<string> { "Determined", "Confident", "Friendly", "Paranoid" }
        }
    };
}
