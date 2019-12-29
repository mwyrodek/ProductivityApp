using System;
using System.Threading;
using System.Threading.Tasks;

namespace ProductivtyAppWeb.Data
{
    public class TimerService
    {
        public async Task Wait(TimeSpan waitTime,CancellationToken cancellationToken)
        {
            
            var task= Task.Delay(waitTime, cancellationToken);
            try
            {
                await task;
            }
            catch (TaskCanceledException)
            {
                return;
            }
        }
    }
}
