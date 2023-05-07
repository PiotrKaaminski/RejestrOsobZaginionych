using System.Diagnostics;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using RejestrOsobZaginionych.Models;
using RejestrOsobZaginionych.Models.Common;
using RejestrOsobZaginionych.Services.MissingPerson;

namespace RejestrOsobZaginionych.Controllers;

public class HomeController : Controller
{
    private readonly GetMissingPersonService _getMissingPersonService;

    public HomeController(GetMissingPersonService getMissingPersonService)
    {
        _getMissingPersonService = getMissingPersonService;
    }

    public IActionResult Index(bool? male, int page = 0)
    {
        ViewBag.MissingPersonList = _getMissingPersonService.GetMissingPersonList(new PaginationParameters(page, 5), male);
        return View();
    }

    public ActionResult PersonImage(int id)
    {
        var image = _getMissingPersonService.GetPersonImage(id);
        return File(image.File, image.Type);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}