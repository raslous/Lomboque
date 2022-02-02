using Microsoft.AspNetCore.Components;

namespace Lomboque.Presentation.Server.Pages.Layout
{
    public partial class MainLayout
    {
        [Inject] protected IHttpClientFactory ClientFactory { get; init; } = default!;
    
        private async Task RunInBackground(TimeSpan timeSpan, Action action)
        {
            var periodicTimer = new PeriodicTimer(timeSpan);
            while (await periodicTimer.WaitForNextTickAsync())
            {
                action();
            }
        }
        
        private async Task<string?> HttpRequest(string uri)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, uri);
            var client = ClientFactory.CreateClient();
            var response = await client.SendAsync(request);
            string json = string.Empty;

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                using var streamReader = new StreamReader(responseStream);

                json = streamReader.ReadToEnd();
            }
            
            return json;
        }
    }
}