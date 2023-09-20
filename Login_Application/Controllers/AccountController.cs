using Login_Application.Data;
using Login_Application.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Login_Application.Controllers
{
	public class AccountController : Controller
	{
        public IActionResult Index()
        {
            return View();
        }

        private readonly ApplicationDbContext _dbContext;

		public AccountController(ApplicationDbContext dbContext)
        {
			_dbContext = dbContext;
		}
		[HttpGet]
        public IActionResult Register()
		{
			return View(new RegisterViewModel());
		}
		[HttpPost]
		public IActionResult Register(RegisterViewModel user)
		{
			if(ModelState.IsValid)
			{
				_dbContext.Accounts.Add(user);
				_dbContext.SaveChanges();
				return RedirectToAction("Login", "Account");
			}
			return View(user);
		}

		[HttpGet]
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Login(User model)
        {
			if(ModelState.IsValid)
			{
               var user = _dbContext.Accounts.FirstOrDefault(u => u.Email == model.Email);
				if(user != null && user.Password == model.Password) 
				{
                    return RedirectToAction("Index", "Home");
                }
				else
				{
					ModelState.AddModelError("", "Invalid email or password");
				}
            }
            return View();
        }
    }
}
