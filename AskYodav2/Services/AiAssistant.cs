﻿// Note: The Azure OpenAI client library for .NET is in preview.
// Install the .NET library via NuGet: dotnet add package Azure.AI.OpenAI --version 1.0.0-beta.5
using Azure;
using Azure.AI.OpenAI;

OpenAIClient client = new OpenAIClient(
  new Uri("https://yodachatbot.openai.azure.com/"),
  new AzureKeyCredential(Environment.GetEnvironmentVariable("AZURE_OPENAI_API_KEY")));

Response<ChatCompletions> responseWithoutStream = await client.GetChatCompletionsAsync(
"Yoda-Chat",
new ChatCompletionsOptions()
{
    Messages =
  {
      new ChatMessage(ChatRole.System, @"You are an AI assistant that helps people find information."),

  },
    Temperature = (float)0.7,
    MaxTokens = 800,


    NucleusSamplingFactor = (float)0.95,
    FrequencyPenalty = 0,
    PresencePenalty = 0,
});


ChatCompletions response = responseWithoutStream.Value;

