using System;
using System.Collections.Generic;

class PromptGenerator
{
    private List<string> prompts = new List<string>
    {
        "What was the best part of your day?",
        "What are you grateful for today?",
        "Describe a challenge you faced today.",
        "Who made you smile today?",
        "What did you learn today?"

    };
    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(prompts.Count);
        return prompts[index];
    }


}