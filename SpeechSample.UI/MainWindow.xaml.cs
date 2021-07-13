using SpeechSample.Models;
using SpeechSample.Services;
using System.Threading.Tasks;
using System.Windows;

namespace SpeechSample.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            Run();
        }

        private void Run()
        {
            IEmployee Chef = new Chef();
            ILocation Kitchen = new Kitchen();

            RestaurantEventManager eventManager = new RestaurantEventManager(Chef, Kitchen);

            TriggerEventAsync(eventManager).GetAwaiter().GetResult();
        }

        private async Task TriggerEventAsync(RestaurantEventManager eventManager)
        {
            await eventManager.TriggerEvent(RestaurantEvent.ORDER_SENT, "Order Received");
        }
    }
}
