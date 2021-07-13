using System.Threading.Tasks;
using Microsoft.CognitiveServices.Speech;

namespace SpeechSample.Services.Speech.Azure
{
    class AzureSpeechSynthesizer : ISpeechSynthesizer
    {
        private readonly SpeechSynthesizer _synthesizer;
        public AzureSpeechSynthesizer(AzureSpeechConfig SpeechConfig)
        {
            _synthesizer = new SpeechSynthesizer(SpeechConfig.Config);
        }

        public async Task<SpeechSynthesisResult> SynthesizeAudioAsync(string text)
        {
            return await _synthesizer.SpeakTextAsync(text);
        }
    }
}
