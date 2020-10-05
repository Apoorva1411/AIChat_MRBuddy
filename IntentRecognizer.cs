using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Dialogs.Adaptive.Recognizers;
using System.Collections.Generic;

namespace MRBuddy
{
    public static class IntentRecognizer
    {
        public static  Recognizer CreateRecognizer()
        {
           return new RegexRecognizer
            {
                Intents = new List<IntentPattern>
                {                    
                     new IntentPattern("combination", "(?i)coil combination"),
                     new IntentPattern("information", "(?i)Coil Information"),
                     new IntentPattern("examcard", "(?i)Examcards"),
                     new IntentPattern("coil","(?i)T/R Coil queries"),
                     new IntentPattern("default" , "(?i)default"),
                     new IntentPattern("default" , "(?i)menu"),
                     new IntentPattern("exit", "(?i)exit")
                }
            };
        }
    }
}

