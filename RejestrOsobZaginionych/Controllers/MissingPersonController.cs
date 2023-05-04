using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RejestrOsobZaginionych.Models;
using RejestrOsobZaginionych.Models.Common;
using RejestrOsobZaginionych.Models.MissingPerson;
using RejestrOsobZaginionych.Services.MissingPerson;

namespace RejestrOsobZaginionych.Controllers;

public class MissingPersonController : Controller
{

    private readonly UserManager<IdentityUser> _userManager;
    private readonly AddMissingPersonService _addMissingPersonService;

    public MissingPersonController(UserManager<IdentityUser> userManager, AddMissingPersonService addMissingPersonService)
    {
        _userManager = userManager;
        _addMissingPersonService = addMissingPersonService;
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
        var creatorId = _userManager.GetUserId(User);
        Debug.Assert(creatorId != null, nameof(creatorId) + " != null");
        
        _addMissingPersonService.AddMissingPerson(newMissingPerson, creatorId);
        
        return RedirectToAction("Index", "Home");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}