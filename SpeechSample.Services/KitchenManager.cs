using SpeechSample.Models;
using System.Threading.Tasks;

namespace SpeechSample.Services
{
    public class KitchenManager
    {
        public Chef Chef { get; set; }
        public Kitchen Kitchen { get; set; }
        private SpeechService _service { get; set; }

        public KitchenManager(Chef employee, Kitchen location)
        {
            Chef = employee;
            Kitchen = location;
            _service = new SpeechService();
        }

        public async Task FetchAnnouncementAsync()
        {
            await _service.FetchResponseAsync(Chef.SpeechData);
        }
    }
}
