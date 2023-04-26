using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RejestrOsobZaginionych.Models;
using RejestrOsobZaginionych.Models.Common;
using RejestrOsobZaginionych.Models.MissingPerson;
using RejestrOsobZaginionych.Services.MissingPerson;

namespace RejestrOsobZaginionych.Controllers;

public class MissingPersonController : Controller
{

    public MissingPersonController()
    {
    }

    [Authorize]
    public IActionResult Add()
    {
        return View();
    }
    
    [Authorize]
    [HttpPost]
    public IActionResult Add(AddMissingPersonRequest newMissingPerson)
    {
        // add missing person
        return RedirectToAction("Index", "Home");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}