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
          Id = "seb",
          Name = "Sebastian Parker",
          Gender = "male",
          Ethnicity = "bear",
          VoiceLines = new List<string>
          {
            "I'm old and done with my life. 18 years ago, this world used to be much more smaller.",
            "I'm going back to my family. They're not my blood, I grew up with them. They're my family.",
            "They fucking keep on doing the same mistake over and over again. I am not to be held accountable for their mistakes. I quit.",
            "sighs You know, I don't get it. Why do some people feel the need to act like they know everything?",
            "Another scandal, another broken promise. It's like they've forgotten what our roots were. We need to go back.",
            "I'm neither an uncle nor wise, but they won't live with their own failures. Where is that going to bring them? Back to me.",
            "They didn't have to do that you know. Just cuz I'm an oldie, does not mean I would be used and lied to."
          },
          Partners = new List<string> { "scarlett", null, "emma", "nancy", "emma", "sabrina", "aadhya" },
          Kids = new List<string> { "", "" },
          Mood = new List<string> { "Relaxed", "Peaceful", "Frustrated", "Confused", "Dissatisfied", "Wise", "Excluded" }
      },
      new NPC
      {
          Id = "nancy",
          Name = "Nancy Robinson",
          Gender = "female",
          Ethnicity = "dolphin",
          VoiceLines = new List<string>
          {
              "It weirdly feels like the CIA is onto me.",
              "Dude's crying because the lawyers took 70% of his property, yet... he's- still- smiling?",
              "Life just reminded of back when I was in my 20s. Young, foolish, fucking whoever I want.",
              "It's not my fucking fault I know too much about dormant volcanoes and it's impact on the Tesla Cybertrucks in Arizona.",
              "I've come to a realization that I may have too many kids right now. Looking for a break.",
              "WAIT WAIT WAIT CAN YOU BELIEVE IT? THERE'S A LIFE OF CHAI SIMP ON THE TRAIN. FUCK YEAH!!",
              "Eh do I really need to change my ways? My life is already beyond repair. It's not like I'm committing a crime."
          },
          Partners = new List<string> { "franklin", "tyler", "dominic", "seb", "steve", "dominic", "franklin" },
          Kids = new List<string> {},
          Mood = new List<string> { "Hateful", "Secure", "Warm", "Excited", "Peaceful", "Miserable", "Insecure" }
      },
      new NPC
      {
          Id = "aadhya",
          Name = "Aadhya Parmar",
          Gender = "female",
          Ethnicity = "eagle",
          VoiceLines = new List<string>
          {
            "You know, the Sicilian Defense is my favorite opening. It's a great way to counter e4. You should really learn it.",
            "Ok this is clearly racist. OK. I don't understand this. Maybe I am overreacting. What the fuck.",
            "Peculiar creatures. Just peculiar. This train is a fucking circus.",
            "Woah ok... calm down buddy... That level of narcisissm is umatched and unseen.",
            "I might- be in love. This guy has crazy deep thoughts that give me existential crisis half the time. Yeah I would totally love spending my life with him.",
            "You wouldn't last an hour in the asylum where they raised me",
            "Days do fleet, and years doth swiftly follow; I age, and in my years become the very visage of that which I most despised in all my life. I rue the day I lay with him."
          },
          Partners = new List<string> { null, "dylan", "steve", "dominic", "tyler", "steve", "sebastian" },
          Kids = new List<string> {},
          Mood = new List<string> { "Neglected", "Respected", "Excited", "Indifferent", "Hopeful", "Trusting", "Amused" }
      },
      new NPC
      {
          Id = "emma",
          Name = "Emma Fenton",
          Gender = "female",
          Ethnicity = "sheep",
          VoiceLines = new List<string> {
            "I'm looking for a man in finance, trust fund, 6'5\", blue eyes...",
            "I got this fruit basket for the journey. Do you wanna have some?",
            "Bro got wronged by someone. He was sobbing?? The whole train is scared of him as of right now.",
            "Did you ever wonder if penguins wear tuxedos because they're always ready for a fancy iceberg party? I mean, it’s gotta be the snazziest bird fashion choice ever!",
            "Vintage men. Always. Fucking. Complaining.",
            "Goddamnit, I hooked up with him again. I think it's just something that turns me on whenever guys are like all possessive and stuff about love.",
            "You know, I've been thinking about trying to fit in more at work. Maybe I should change my style, you know, blend in with everyone else."
          },
          Partners = new List<string> { null, "steve", "seb", null, "seb", "franklin", "steve" },
          Kids = new List<string> {},
          Mood = new List<string> { "Hateful", "Frustrated", "Bored", "Sad", "Satisfied", "Optimistic", "Stressed" }
      },
      new NPC
      {
          Id = "scarlett",
          Name = "Scarlett Dawson",
          Gender = "female",
          Ethnicity = "bear",
          VoiceLines = new List<string>
          {
            "I'm pretty sure the earth is round. Right? Right? Has it always been the same? What about 18 years ago?",
            "At some point we all look up and realize we are lost in a maze.",
            "As long as we don't die, this is is gonna be one hell of a story.",
            "There's a part of me that feels empathetic for the privileged. But, I also lowkey hate them.",
            "Jeez, that was deep. I can feel my brain cells dying of your stupidity.",
            "He should drink some water. He looks like he's about to pass out.",
            "OH MY GOD OH MY GOD WHAT DO I DOOOO. My dad's gonna kill me for using his crocs™ - 1984 edition and stepping on dog poop."
          },
          Partners = new List<string> { "seb", null, null, "dylan", "dominic", "tyler", "dominic" },
          Kids = new List<string> {},
          Mood = new List<string> { "Optimistic", "Unfulfilled", "Tender", "Serious", "Warm", "Loving", "Nostalgic" }
      },
      new NPC
      {
          Id = "dom",
          Name = "Dominic Johnson",
          Gender = "male",
          Ethnicity = "eagle",
          VoiceLines = new List<string>
          {
            "Bro this gotta be my biggest album release so far. You need to check it out.",
            "Hey, I'm one of those people who are gonna negotiate the hell out of a deal. I'm not gonna let anyone force me into anything.",
            "I'm going to college in two months. It's pretty crazy, new life, new friends, new everything.",
            "Winners don't make excuses when the other side plays the game.",
            "I don't pave the way for people... people pave the way for me.",
            "Hello sweetheart, come join me while I bake some bread. You wanna eat my bread, sweetie?",
            "Shut up bitch. I know a guy who knows a guy who'll fix that for you."
          },
          Partners = new List<string> { null, null, "nancy", "aadhya", "scarlett", "nancy", "scarlett" },
          Kids = new List<string> {},
          Mood = new List<string> { "Eager", "Resentful", "Motivated", "Harsh", "Proud", "Shady", "Anxious" }
      },
      new NPC
      {
          Id = "franklin",
          Name = "Franklin Smith",
          Gender = "male",
          Ethnicity = "bison",
          VoiceLines = new List<string>
          {
              "I worked as a CIA operative once. And then my console turned off.",
              "All these fucking techbros? They yap all day on twitter and don't have a life outside their computer",
              "Hey hey hey hey hey listen up. I can tolerate shit on me. But the moment you go on my family. You're in deep shit buddy.",
              "Life is like a poker game. You're dealt with random hands all the time. It's upto you how you decide to play your hand",
              "Stop worrying too much about the future. Live in the moment. Live where you are, stop thinking about where you aren't.",
              "Sometimes, We Do Bad Things For The People We Love. It Doesn't Mean It's Right; It Means Love Is More Important.",
              "The first step to fixing something is to know no matter how destroyed it seems, it can always be saved."
          },
          Partners = new List<string> { "nancy", null, "sabrina", null, "sabrina", "emma", "nancy" },
          Kids = new List<string> {},
          Mood = new List<string> { "happy", "sad", "angry", "confused", "excited", "bored", "tired" }
      },
      new NPC
      {
          Id = "dylan",
          Name = "Dylan Stevens",
          Gender = "male",
          Ethnicity = "cow",
          VoiceLines = new List<string>
          {
            "I bought another round of boba for everyone, but I’m still going home alone. What’s the point?",
            "I invited that lass to this new Indian place, but what if she thinks I'm just a rich snob?",
            "Whoa, did that just happen? It’s hard to wrap my head around how messed up things can get.",
            "Every time I go out, I feel like people expect me to have it all together just because I’m well off.",
            "I might be average in some ways, but I’ve worked hard to earn my friends' respect. That’s something money can’t buy.",
            "What keeps me alive in this world is neither bodily organs nor muscles — it's my soul",
            "The world is better off with some people gone. Our lives are not all interconnected. That theory is crock. Some people truly do not need to be here."
          },
          Partners = new List<string> { null, "aadhya", null, "scarlett", "jane", "jane", "sabrina" },
          Kids = new List<string> { "", "" },
          Mood = new List<string> { "Discouraged", "Nervous", "Shocked", "Anxious", "Respected", "Happy", "Agitated" }
      },
      new NPC
      {
          Id = "tyler",
          Name = "Tyler Sanders",
          Gender = "male",
          Ethnicity = "parrot",
          VoiceLines = new List<string>
          {
            "Another great day at work! I can't wait to see what tomorrow brings.",
            "It’s tough when things don’t go as planned, but hey, tomorrow’s a new opportunity!",
            "A weapon? They’re my nail scissors you idiot. They’re gold plated. They cost $2000.00.",
            "What do you mean I gave him money for weed? He's a marshmallow, he said he's using those $20 to cure his mom from cancer.",
            "A lesson without pain is meaningless. That’s because no one can gain without sacrificing something. But by enduring that pain and overcoming it, he shall obtain a powerful, unmatched heart... a fullmetal heart.",
            "Wa- Wa- Wa- Waterfront? I don't know what you're talking about. I'm just here to see the sights.",
            "Lalalalalalalalalaalalalalala"
          },
          Partners = new List<string> { null, "nancy", null, "jane", "aadhya", "scarlett", "jane" },
          Kids = new List<string> {},
          Mood = new List<string> { "Satisfied", "Disappointed", "Pleased", "Loving", "Discouraged", "Humble", "Hateful" }
      },
      new NPC
      {
          Id = "sabrina",
          Name = "Sabrina Raven",
          Gender = "female",
          Ethnicity = "sheep",
          VoiceLines = new List<string>
          {
            "Womp Womp.",
            "Thinking about him lately.",
            "He's insane. He's instantly such a keeper as soon as he's a family guy.",
            "I feel like I'm with the best guy ever. I am willing to give birth to 20 of his kids right the fuck now",
            "Why does it feel like I don't belong here. I'm like depressed or some shit.",
            "Jeezus, calm down uncle sam.",
            "Ok that was deep, but it's making me really really uncomfortable right now. About time I call 911."
          },
          Partners = new List<string> { null, null, "franklin", "steve", "franklin", "seb", "dylan" },
          Kids = new List<string> { "", "" },
          Mood = new List<string> { "Loving", "Valued", "Doubtful", "Trusting", "Gloomy", "Resentful", "Suspicious" }
      },
      new NPC
      {
          Id = "steve",
          Name = "Steve Pattinson",
          Gender = "male",
          Ethnicity = "bear",
          VoiceLines = new List<string>
          {
            "No more distractions! I’m going to conquer this video game level if it’s the last thing I do!",
            "Why do I feel like something’s watching me? Is it a ghost? Or maybe... a giant banana?",
            "I don’t trust that cat. It’s been eyeing my sandwich for too long. The fuck does it want from me dude",
            "Alright, let’s get this party started! First, we build a pillow fort, then we conquer the world!",
            "Hey, don’t worry about it. Even if you don’t believe in love, we can still believe in awesome friendships!",
            "Point is, haters gonna hate. Shake it off. Taylor Swift, always right.",
            "'Be myself' — what kind of garbage advice is that?",
          },
          Partners = new List<string> { null, "emma", "aadhya", "sabrina", "nancy", "aadhya", "emma" },
          Kids = new List<string> { "", "" },
          Mood = new List<string> { "Resolved", "Anxious", "Suspicious", "Motivated", "Compassionate", "Grateful", "Serious" }
      },
      new NPC
      {
          Id = "jane",
          Name = "Jane Hansen",
          Gender = "female",
          Ethnicity = "dolphin",
          VoiceLines = new List<string>
          {
            "In a world ravaged by a giant, mutant hamster, our only solace is a surprise butt plug.",
            "Nothing says 'I love you' like a surprise visit from grandma… and her collection of medieval torture devices.",
            "My new workout routine? Lifting a gallon of celsius to my mouth repeatedly.",
            "That's not HOW IT WORKS. GOD FUCKING DAMN IT.",
            "Why the fuck does that guy keep flexing his money?",
            "This fucking hippie; but I gotta give him that. Whatever he said was deep. I'm gonna think about him all night. No wonder I already have a kid with him.",
            "It smells like WEED. I'm telling YOU. It smells like WEED in here. This guy is as HIGH as MOUNT FRICKING EVEREST."
          },
          Partners = new List<string> { null, null, null, "tyler", "dylan", "dylan", "tyler" },
          Kids = new List<string> { null, null, null, "tyler", "dylan", "dylan", "tyler" },
          Mood = new List<string> { "Discouraged", "Frustrated", "Peaceful", "Amused", "Grateful", "Neglected", "Proud" }
      }
  };
}