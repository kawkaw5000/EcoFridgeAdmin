using AdminSideEcoFridge.Contracts;
using AdminSideEcoFridge.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using AdminSideEcoFridge.Repository;
using AdminSideEcoFridge.Utils;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using Microsoft.EntityFrameworkCore;
using AdminSideEcoFridge.Data;

namespace AdminSideEcoFridge.Controllers
{
    public class HomeController : BaseController
    {


        private readonly EcoFridgeDbContext _context;

        public IActionResult Dashboard()
        {
            List<VwUsersRoleView> userList = _vwUsersRoleViewRepo.GetAll();
            List<VwUsersFoodItem> foodList = _vwUsersFoodItemRepo.GetAll();
            List<User> user = _userRepo.GetAll();

            var viewModel = new DashboardViewModel
            {
                UserList = userList,
                FoodList = foodList,
                User = user
            };

            return View(user);
        }

        public IActionResult GetFoodItemsByUserId(int userId)
        {
            List<VwUsersFoodItem> foodItems = _vwUsersFoodItemRepo.GetAll()
                                               .Where(f => f.UserId == userId)
                                               .ToList();
            return Json(foodItems);
        }

        public IActionResult GetUserById(int id)
        {
            var user = _userRepo.Get(id);
            if (user == null)
            {
                return NotFound();
            }
            return Json(user);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var user = _userRepo.Get(id);
            if (user == null)
            {
                return NotFound(); 
            }
            return View(user); 
        }

        [HttpPost]
        public IActionResult Edit(User u)
        {
            if (!ModelState.IsValid)
            {
                return View(u); // Return the same view with user data if not valid
            }

            var result = _userRepo.Update(u.UserId, u); // Call the update method

            if (result == ErrorCode.Success)
            {
                TempData["Msg"] = $"User {u.Username} Updated";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Unable to update user. Please try again.");
            return View(u); // Return the same view with user data
        }

        #region Admin Create
        public IActionResult AdminCreate()
        {
            return View();
        }

        public IActionResult RegularCreate()
        {
            return View();
        }

        public IActionResult FoodBusinessCreate()
        {
            return View();
        }

        public IActionResult OrganizationCreate()
        {
            return View();
        }

        #endregion

    }
}
