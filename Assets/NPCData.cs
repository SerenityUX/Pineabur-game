using UnityEngine;
using System.Collections.Generic;

public static class NPCData
{
    public class NPC
    {
        public string Id;
        public string Name;
        public string Gender;
        public string Ethnicity;
        public List<string> VoiceLines;
        public List<string> Partners;
        public List<string> Kids;
        public List<string> Mood;
    }

    public static List<NPC> NPCList = new List<NPC>
    {
        new NPC
        {
            Id = "franklin",
            Name = "Franklin Smith",
            Gender = "male",
            Ethnicity = "bear",
            VoiceLines = new List<string>
            {
                "I worked as a CIA operative once. And then my console turned off.",
                "All these fucking techbros? They yap all day on twitter and don't have a life outside their computer",
                "When you're with the right person, you do the right thing and I was smart to let her go home that day.",
                "Sometimes, We Do Bad Things For The People We Love. It Doesn't Mean It's Right; It Means Love Is More Important.",
                "The first step to fixing something is to know no matter how destroyed it seems, it can always be saved.",
                "Life is like a poker game. You're dealt with random hands all the time. It's upto you how you decide to play your hand",
                "Stop worrying too much about the future. Live in the moment. Live where you are, stop thinking about where you aren't."
            },
            Partners = new List<string> { "nancy", "aadhya", null, "sarah", "nancy", "sadie", "emma" },
            Kids = new List<string> { "jimmy", "joel", "jenny", "hank" },
            Mood = new List<string> { "happy", "sad", "angry", "confused", "excited", "bored", "tired" }
        },
        new NPC
        {
            Id = "nancy",
            Name = "Nancy Robinson",
            Gender = "female",
            Ethnicity = "dolphin",
            VoiceLines = new List<string> { "nancy-1", "nancy-2", "nancy-3", "nancy-4", "nancy-5", "nancy-6", "nancy-7" },
            Partners = new List<string> { "joe", "jill" },
            Kids = new List<string> { "jimmy", "jenny" },
            Mood = new List<string> { "Hateful", "Secure", "Warm", "Excited", "Peaceful", "Miserable", "Insecure" }
        },
        new NPC
        {
            Id = "steve",
            Name = "Steve Pattinson",
            Gender = "male",
            Ethnicity = "bear",
            VoiceLines = new List<string> { "joe-1", "joe-2", "joe-3", "joe-4", "joe-5", "joe-6", "joe-7" },
            Partners = new List<string> { "jane", "jill" },
            Kids = new List<string> { "jimmy", "jenny" },
            Mood = new List<string> { "Resolved", "Anxious", "Suspicious", "Motivated", "Compassionate", "Grateful", "Serious" }
        },
        new NPC
        {
            Id = "tyler",
            Name = "Tyler Sanders",
            Gender = "male",
            Ethnicity = "bear",
            VoiceLines = new List<string> { "joe-1", "joe-2", "joe-3", "joe-4", "joe-5", "joe-6", "joe-7" },
            Partners = new List<string> { "jane", "jill" },
            Kids = new List<string> { "jimmy", "jenny" },
            Mood = new List<string> { "Satisfied", "Disappointed", "Pleased", "Loving", "Discouraged", "Humble", "Hateful" }
        },
        new NPC
        {
            Id = "dylan",
            Name = "Dylan Stevens",
            Gender = "male",
            Ethnicity = "bear",
            VoiceLines = new List<string> { "joe-1", "joe-2", "joe-3", "joe-4", "joe-5", "joe-6", "joe-7" },
            Partners = new List<string> { "jane", "jill" },
            Kids = new List<string> { "jimmy", "jenny" },
            Mood = new List<string> { "Discouraged", "Shocked", "Nervous", "Anxious", "Respected", "Happy", "Agitated" }
        },
        new NPC
        {
            Id = "dom",
            Name = "Dominic Johnson",
            Gender = "male",
            Ethnicity = "bear",
            VoiceLines = new List<string> { "joe-1", "joe-2", "joe-3", "joe-4", "joe-5", "joe-6", "joe-7" },
            Partners = new List<string> { "jane", "jill" },
            Kids = new List<string> { "jimmy", "jenny" },
            Mood = new List<string> { "Eager", "Resentful", "Motivated", "Harsh", "Defeated", "Relaxed", "Anxious" }
        },
        new NPC
        {
            Id = "seb",
            Name = "Sebastian Parker",
            Gender = "male",
            Ethnicity = "bear",
            VoiceLines = new List<string> { "joe-1", "joe-2", "joe-3", "joe-4", "joe-5", "joe-6", "joe-7" },
            Partners = new List<string> { "jane", "jill" },
            Kids = new List<string> { "jimmy", "jenny" },
            Mood = new List<string> { "Relaxed", "Peaceful", "Frustrated", "Confused", "Dissatisfied", "Panicked", "Excluded" }
        },
        new NPC
        {
            Id = "sarah",
            Name = "Sarah Dawson",
            Gender = "female",
            Ethnicity = "bear",
            VoiceLines = new List<string> { "joe-1", "joe-2", "joe-3", "joe-4", "joe-5", "joe-6", "joe-7" },
            Partners = new List<string> { "jane", "jill" },
            Kids = new List<string> { "jimmy", "jenny" },
            Mood = new List<string> { "Optimistic", "Unfulfilled", "Tender", "Serious", "Warm", "Loving", "Nostalgic" }
        },
        new NPC
        {
            Id = "sadie",
            Name = "Sadie Dixon",
            Gender = "female",
            Ethnicity = "bear",
            VoiceLines = new List<string> { "joe-1", "joe-2", "joe-3", "joe-4", "joe-5", "joe-6", "joe-7" },
            Partners = new List<string> { "jane", "jill" },
            Kids = new List<string> { "jimmy", "jenny" },
            Mood = new List<string> { "Loving", "Valued", "Doubtful", "Trusting", "Gloomy", "Resentful", "Suspicious" }
        },
        new NPC
        {
            Id = "aadhya",
            Name = "Aadhya Parmar",
            Gender = "female",
            Ethnicity = "bear",
            VoiceLines = new List<string> { "joe-1", "joe-2", "joe-3", "joe-4", "joe-5", "joe-6", "joe-7" },
            Partners = new List<string> { "jane", "jill" },
            Kids = new List<string> { "jimmy", "jenny" },
            Mood = new List<string> { "Neglected", "Respected", "Excited", "Indifferent", "Hopeful", "Trusting", "Amused" }
        },
        new NPC
        {
            Id = "zuri",
            Name = "Zuri Hansen",
            Gender = "female",
            Ethnicity = "bear",
            VoiceLines = new List<string> { "joe-1", "joe-2", "joe-3", "joe-4", "joe-5", "joe-6", "joe-7" },
            Partners = new List<string> { "jane", "jill" },
            Kids = new List<string> { "jimmy", "jenny" },
            Mood = new List<string> { "Discouraged", "Frustrated", "Peaceful", "Amused", "Grateful", "Neglected", "Proud" }
        },
        new NPC
        {
            Id = "emma",
            Name = "Emma Fenton",
            Gender = "female",
            Ethnicity = "bear",
            VoiceLines = new List<string> { "joe-1", "joe-2", "joe-3", "joe-4", "joe-5", "joe-6", "joe-7" },
            Partners = new List<string> { "jane", "jill" },
            Kids = new List<string> { "jimmy", "jenny" },
            Mood = new List<string> { "Hateful", "Frustrated", "Bored", "Sad", "Satisfied", "Optimistic", "Stressed" }
        }
    };
}
