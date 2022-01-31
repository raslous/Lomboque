using System.Threading;

namespace Lomboque.Infrastructure.Services
{
    public class RuntimeService
    {
        public async Task RunInBackground(TimeSpan timeSpan, Action action)
        {
            var periodicTimer = new PeriodicTimer(timeSpan);
            while (await periodicTimer.WaitForNextTickAsync())
            {
                action();
            }
        }

    }
}