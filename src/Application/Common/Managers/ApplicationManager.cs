using Lomboque.Application.Common.Interfaces;
using System.Net.Http;

namespace Lomboque.Application.Common.Managers
{
    public class ApplicationManager
    {
        private readonly IRuntimeService runtimeService;
        private readonly IHttpClientFactory clientFactory;

        public ApplicationManager(IRuntimeService runtimeService, IHttpClientFactory clientFactory)
        {
            this.runtimeService = runtimeService;
            this.clientFactory = clientFactory;
        }

        public async Task HourlyTask(string uri)
        {
            await runtimeService.RunInBackground(TimeSpan.FromSeconds(5), () => HttpRequest(uri).Wait());
        }
        
        private async Task HttpRequest(string uri)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, uri);
            var client = clientFactory.CreateClient();
            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                using var streamReader = new StreamReader(responseStream);

                string json = streamReader.ReadToEnd();
            }
        }
    }
}


/*
    private async Task RunInBackground(TimeSpan timeSpan, Action action)
    {
        var periodicTimer = new PeriodicTimer(timeSpan);
        while (await periodicTimer.WaitForNextTickAsync())
        {
            action();
        }
    }
*/