using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RejestrOsobZaginionych.Models;
using RejestrOsobZaginionych.Models.Common;
using RejestrOsobZaginionych.Services.Users;

namespace RejestrOsobZaginionych.Controllers;

public class UsersController : Controller
{

    private readonly GetUserListService _getUserListService;
    private readonly DeleteUserService _deleteUserService;
    private readonly SwitchUserRoleService _switchUserRoleService;

    public UsersController(GetUserListService getUserListService, DeleteUserService deleteUserService, SwitchUserRoleService switchUserRoleService)
    {
        _getUserListService = getUserListService;
        _deleteUserService = deleteUserService;
        _switchUserRoleService = switchUserRoleService;
    }


    [Authorize(Roles = "Admin")]
    public IActionResult List(int page = 0)
    {
        ViewBag.UserList = _getUserListService.GetUserList(new PaginationParameters(page, 20));
        return View();
    }

    [Authorize(Roles = "Admin")]
    [HttpDelete]
    public JsonResult Delete(string id)
    {
        var success = _deleteUserService.Delete(id);
        return Json(new { success });
    }
    
    [Authorize(Roles = "Admin")]
    [HttpPatch]
    public JsonResult SwitchRole(string id)
    {
        var success = _switchUserRoleService.SwitchRole(id);
        return Json(new { success });
    }
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}