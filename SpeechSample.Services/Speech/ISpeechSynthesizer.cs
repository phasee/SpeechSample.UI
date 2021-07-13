using Microsoft.CognitiveServices.Speech;
using System.Threading.Tasks;

namespace SpeechSample.Services
{
    interface ISpeechSynthesizer
    {
        Task<SpeechSynthesisResult> SynthesizeAudioAsync(string text);
    }
}