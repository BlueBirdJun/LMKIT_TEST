using LMKit;

// See https://aka.ms/new-console-template for more information
var model = new LMKit.Model.LLM("Llama-3-Open-Ko-8B-Q4_0.gguf");

// Create a multi-turn conversation instance
var chat = new LMKit.TextGeneration.MultiTurnConversation(model);

// Submit a prompt and get the response. The Submit method returns an object of type [LMKit.TextGeneration.TextGenerationResult](https://docs.lm-kit.com/lm-kit-net/api/LMKit.TextGeneration.TextGenerationResult.html)
var response = chat.Submit("오늘 날씨가 어때?");

// Output the generated text
Console.WriteLine("Response: " + response.Completion);

