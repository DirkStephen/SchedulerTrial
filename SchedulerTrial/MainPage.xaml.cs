using Network;
using Syncfusion.Maui.Scheduler;

namespace SchedulerTrial
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            SfScheduler scheduler = new SfScheduler();
            scheduler.View = SchedulerView.Month;
            this.Content = scheduler;
        }
        /*DatePicker datePicker = new DatePicker
        {
            MinimumDate = new DateTime(2023, 1, 1),
            MaximumDate = new DateTime(2024, 1, 1),
            Date = new DateTime(2023, 10, 7)
        };
        TimePicker timePicker = new TimePicker
        {
            Time = new TimeSpan(0, 0, 0, 0)
        };*/
    }
}