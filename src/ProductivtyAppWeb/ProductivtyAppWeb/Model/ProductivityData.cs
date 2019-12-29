using ProductivtyAppWeb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductivtyAppWeb.Model
{
    public class ProductivityData
    {
        public bool BreakButtonHidden { get; set; }
        public bool StopButtonHidden { get; set; }
        public bool StartButtonHidden { get; set; }
        public string StartButtonMessege { get; set; } 
        public string BackgroundColor { get; set; }
        public string Message { get; set; }
        public ProductivityState CurrentState { get; set; }
        public TimeSpan BreakLength { get; }
        public TimeSpan ProductivtyLength { get; }

        public int MaxPhaseNumber{ get; }
        public int CurrentPhaseNumber { get; set; }

        public ProductivityData()
        {
            BreakButtonHidden  = true;
            StopButtonHidden = true;
            StartButtonHidden = false;
            StartButtonMessege = "Start";
            BackgroundColor = "grey";
            Message = "ready";
            CurrentState = ProductivityState.NOTSTARTED;
            MaxPhaseNumber = 5;
            CurrentPhaseNumber = 0;
            BreakLength = TimeSpan.FromMinutes(2);
            BreakLength = TimeSpan.FromMinutes(10);
        }
    }
}