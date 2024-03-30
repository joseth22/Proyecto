using Microsoft.AspNetCore.Mvc;

namespace Proyecto.Controllers
{
    public interface IHomeController
    {
        Task<IActionResult> Index(string tipo);
    }
}