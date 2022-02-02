using Lomboque.Application.Common.Interfaces;

namespace Lomboque.Infrastructure.Services
{
    public class RuntimeService : IRuntimeService
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