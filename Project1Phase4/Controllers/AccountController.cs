using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project1Phase4.Models;
using System.ComponentModel.DataAnnotations;

namespace Project1Phase4.Controllers
{
    public class AccountController : Controller
    {
        
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Models.User user)
        {
            
            //FIRST METHOD FOR LOGIN PAGE
           // if(user.Username == "rashmi" && user.Password == "rashmi@123")
           // {
           //     return RedirectToAction("Dashboard","Account");
           // }
           // if(user == null)
           // {
           //     return RedirectToAction("Login");
           // }
           //     ViewBag.ErrorMessage = "Invalid username or password";
           //     return View(user);
           


            //SECOND METHOD
            if(ModelState.IsValid)
            {
                if (user.Username == "rashmi" && user.Password == "rashmi@123")
                {
                    TempData["Email"] = GetEmailByUsername(user.Username);
                    return RedirectToAction("Dashboard", "Account");
                }
                else if (user == null)
                {
                    return RedirectToAction("Login");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid username or password");
                }
            }
            return View(user);
        }

        public IActionResult Dashboard()
        {

            string? email = TempData["Email"] as string;
            ViewData["Email"] = email;

            return View();
        }


        //private bool IsLoginSuccessful(Models.User user)
        //{
        //    string? validUsername = "demoUser";
        //    string? validPassword = "demoPassword";


        //    return true;
        //}

        public string GetEmailByUsername(string username)
        {
            // Implement logic to retrieve the email address based on the username
            // For demonstration purposes, assume a static email address
            return "user@example.com";
        }


        public IActionResult Logout()
        {
            return View();
        }
        [HttpGet]
        public IActionResult UpdateEmail()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UpdateEmail(string newEmail)
        {
            if (IsValidEmail(newEmail))
            {
                ViewBag.SuccessMessage = "Email updated successfully!";
            }
            else
            {
                ViewBag.ErrorMessage = "Invalid email format. Please enter a valid email address.";
            }
            //return View();
            return RedirectToAction("Dashboard", "Account");
        }

        private bool IsValidEmail(string email)
        {
            return new EmailAddressAttribute().IsValid(email);
        }

        [HttpGet]
        public IActionResult ChangePassword()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ChangePassword(string currentPassword, string newPassword, string confirmPassword)
        {
            // Validate and change the password in your database or user profile
            if (IsValidPasswordChange(currentPassword, newPassword, confirmPassword))
            {
                // Change the password (this is a placeholder, replace with your actual logic)
                // Example: userService.ChangePassword(User.Identity.Name, newPassword);

                ViewBag.SuccessMessage = "Password changed successfully!";
            }
            else
            {
                ViewBag.ErrorMessage = "Invalid password change. Please check your inputs and try again.";
            }
            return RedirectToAction("Dashboard", "Account");

        }

        private bool IsValidPasswordChange(string currentPassword, string newPassword, string confirmPassword)
        {
            // Implement your password change validation logic (e.g., check against current password, match with confirmation)
            // This is a simple example, you might want to use a more robust validation method.
            return !string.IsNullOrEmpty(currentPassword) &&
                   !string.IsNullOrEmpty(newPassword) &&
                   newPassword == confirmPassword;
        }



        public IActionResult Faq()
        {
            return View();
           // return RedirectToAction("Dashboard", "Account");
        }


        public IActionResult Documentation()
        {
            return View();
        }


    }
}
