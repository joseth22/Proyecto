namespace Proyecto.Controllers
{
    internal interface IEventosApiClient
    {
        Task<List<Evento>> GetEventos();
    }
}

