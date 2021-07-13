using Microsoft.CognitiveServices.Speech;

namespace SpeechSample.Services.Speech.Azure
{
    class AzureSpeechConfig
    {
        public SpeechConfig Config { get; private set; }
        public AzureSpeechConfig(string subscriptionKey, string region = "eastus")
        {
            Config = SpeechConfig.FromSubscription(subscriptionKey, region);
        }
    }
}
