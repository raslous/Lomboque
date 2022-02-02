using Lomboque.Application.Actions;
using Lomboque.Domain.Entities;
using Microsoft.AspNetCore.Components;

namespace Lomboque.Presentation.Server.Pages
{
    public partial class RealTime
    {
        [Inject] public AppController AppController { get; init; } = default!;
        protected List<Observasi> HasilObservasiPot1 = new();
        protected List<Observasi> HasilObservasiPot2 = new();

        protected List<Observasi> RealTimeObservasi = new();


    }
}