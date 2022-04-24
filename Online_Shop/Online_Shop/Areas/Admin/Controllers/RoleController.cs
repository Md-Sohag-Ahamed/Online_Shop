using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Online_Shop.Areas.Admin.Models;
using Online_Shop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Shop.Areas.Admin.Controllers
{
  [Area("Admin")]
  public class RoleController : Controller
  {
    RoleManager<IdentityRole> _rolemanager;
    UserManager<IdentityUser> _userManager;
    ApplicationDbContext _db;
    public RoleController(RoleManager<IdentityRole> roleManager,ApplicationDbContext db,UserManager<IdentityUser>userManager)
    {
      _rolemanager = roleManager;
      _db = db;
      _userManager = userManager;
    }
    public IActionResult Index()
    {
      var roles = _rolemanager.Roles.ToList();
      ViewBag.Roles = roles;
      return View();
    }
    public async Task<IActionResult> Create()
    {
      return View();
    }
    [HttpPost]
    public async Task<IActionResult>Create(string name)
    {
      IdentityRole role = new IdentityRole();
      role.Name = name;
      var isExist = await _rolemanager.RoleExistsAsync(role.Name);
      if (isExist)
      {
        ViewBag.message = "This role is already Exist";
        ViewBag.name = name;
        return View();
      }
      var result = await _rolemanager.CreateAsync(role);
      if (result.Succeeded)
      {
        TempData["save"] = "Role has been Saved Successfully";
        return RedirectToAction(nameof(Index));


      }
      return View();
     
    }
    public async Task<IActionResult> Edit(string id)
    {
      var role = await _rolemanager.FindByIdAsync(id);
      if (role == null)
      {
        return NotFound();
      }
      ViewBag.id = role.Id;
      ViewBag.name = role.Name;

      return View();
    }
    [HttpPost]
    public async Task<IActionResult> Edit(string id, string name)
    {
      var role = await _rolemanager.FindByIdAsync(id);
      if (role == null)
      {
        return NotFound();
      }
      role.Name = name;
      var isExist = await _rolemanager.RoleExistsAsync(role.Name);
      if (isExist)
      {
        ViewBag.message = "This role is already Exist";
        ViewBag.name = name;
        return View();
      }
      var result = await _rolemanager.UpdateAsync(role);
      if (result.Succeeded)
      {
        TempData["update"] = "Role has been Updated Successfully";
        return RedirectToAction(nameof(Index));


      }
      return View();

    }
    public async Task<IActionResult> Delete(string id)
    {
      var role = await _rolemanager.FindByIdAsync(id);
      if (role == null)
      {
        return NotFound();
      }
      ViewBag.id = role.Id;
      ViewBag.name = role.Name;

      return View();
    }
    [HttpPost]
    [ActionName("Delete")]
    public async Task<IActionResult>DeleteConfirm(string id)
    {
      var role = await _rolemanager.FindByIdAsync(id);
      if (role == null)
      {
        return NotFound();
      }
      var result = await _rolemanager.DeleteAsync(role);
      if (result.Succeeded)
      {
        TempData["deletedata"] = "Role has been Deleted Successfully";
        return RedirectToAction(nameof(Index));

      }
      return View();

    }
    public async Task<IActionResult> Assign()
    {
      ViewData["UserId"] = new SelectList(_db.ApplicationUsers.Where(c=>c.LockoutEnd<DateTime.Now||c.LockoutEnd==null).ToList(), "Id", "UserName");
      ViewData["RoleId"] = new SelectList(_rolemanager.Roles.ToList(), "Name", "Name");
      return View();
    }
    [HttpPost]
    public async Task<IActionResult> Assign(RoleUserVm roleUser)
    {
      var user = _db.ApplicationUsers.FirstOrDefault(c => c.Id == roleUser.UserId);
      var isCheckRoleAssign = await _userManager.IsInRoleAsync(user, roleUser.RoleId);
      if (isCheckRoleAssign)
      {
        ViewBag.msg = "This user Already assign this role.";
        ViewData["UserId"] = new SelectList(_db.ApplicationUsers.Where(c => c.LockoutEnd < DateTime.Now || c.LockoutEnd == null).ToList(), "Id", "UserName");
        ViewData["RoleId"] = new SelectList(_rolemanager.Roles.ToList(), "Name", "Name");
        return View();
      }
      
      var role = await _userManager.AddToRoleAsync(user,roleUser.RoleId);
      if (role.Succeeded)
      {
        TempData["save"] = "User Role assign has been Successfully";
        return RedirectToAction(nameof(Index));

      }
      return View();
    }
    public ActionResult AssignUserRole()
    {
      var result = from ur in _db.UserRoles
                   join r in _db.Roles on ur.RoleId equals r.Id
                   join a in _db.ApplicationUsers on ur.UserId equals a.Id
                   select new UserRoleMapping()
                   {
                     UserId = ur.UserId,
                     RoleId=ur.RoleId,
                     UserName=a.UserName,
                     RoleName=r.Name

                   };
      ViewBag.UserRoles = result;
      return View();
    }

  }

}
