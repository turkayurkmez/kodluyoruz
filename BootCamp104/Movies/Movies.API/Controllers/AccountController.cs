using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Movies.API.Models;
using Movies.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private IUserService userService;

        public AccountController(IUserService userService)
        {
            this.userService = userService;
        }
        [HttpPost]
        public IActionResult Login(UserLoginModel userLoginModel)
        {
            var user = userService.GetUser(userLoginModel.Email, userLoginModel.Password);
            if (user == null)
            {
                return BadRequest(new { message = "Hatalı kullanıcı adı ya da şifre " });

            }
            // TODO 1: Burada, JWT üreteceğiz ve kullanıcıya vereceğiz.
            return Ok();
        }
    }
}
