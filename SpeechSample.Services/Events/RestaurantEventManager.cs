using SpeechSample.Models;
using System.Threading.Tasks;

namespace SpeechSample.Services
{
    public class RestaurantEventManager
    {
        public IEmployee Employee { get; set; }
        public ILocation Location { get; set; }

        public RestaurantEventManager(IEmployee employee, ILocation location)
        {
            Employee = employee;
            Location = location;
        }
        public async Task TriggerEvent(RestaurantEvent someEvent, object args)
        {
            if (someEvent.Equals(RestaurantEvent.ORDER_SENT))
            {
                string order = (string)args;

                if (Location is ILocation kitchen)
                {
                    KitchenManager manager = new KitchenManager((Chef) Employee, (Kitchen) kitchen);

                    manager.Chef.SpeechData = order;

                    await manager.FetchAnnouncementAsync();
                }                
            }
        }
    }
}
