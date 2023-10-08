using Syncfusion.Maui.Scheduler;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerTrial
{
    public class ControlViewModel
    {
        public ObservableCollection<SchedulerAppointment> SchedulerEvents { get; set; }
        public ControlViewModel()
        {
            this.SchedulerEvents = new ObservableCollection<SchedulerAppointment>
            {
                new SchedulerAppointment
                {
                    StartTime = new DateTime (2023, 10, 7, 8, 0, 0),
                    EndTime = new DateTime (2023, 10, 7, 9, 0, 0)
                }
            };
        }
    }
}
