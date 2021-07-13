using SpeechSample.Services.Speech.Azure;
using System.Threading.Tasks;

namespace SpeechSample.Services
{
    public class SpeechService
    {
        private ISpeechSynthesizer synthesizer { get; set; }

        public SpeechService()
        {
            synthesizer = new AzureSpeechSynthesizer(new AzureSpeechConfig("Replace with your azure subscription key"));
        }

        public async Task FetchResponseAsync(string speech)
        {
            await synthesizer.SynthesizeAudioAsync(speech);
        }
    }
}
