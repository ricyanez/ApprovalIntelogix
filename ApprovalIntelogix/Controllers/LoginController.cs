using ApprovalIntelogix.Models;
using ApprovalIntelogix.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginWs.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class LoginController : Controller
    {
        private readonly IUserService userService;
        public LoginController(IUserService service)
        {
            userService = service;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<ObjectResult> Login([FromBody] LoginParameters parameters)
        {
            try
            {
                var context = new GeneralContext();
                //var query1 = "EXEC Api_Call_Login @Username ='{parameters.username}'";
                var query = $"select U.ID_User as IDUSER " +
                    $", U.ID_Employee as IDEMPLOYEE " +
                    $", U.Username as USERNAME " +
                    $", U.Password as PASS " +
                    $", P.position as POSITION " +
                    $", RT.RightType as RIGHTTYPE " +
                    $", U.FirstTime as FIRSTTIME " +
                    $", U.Status AS USERSTATUS " +
                    $", E.Name as NAMEU " +
                    $", E.P_LastName as PLASTNAME " +
                    $", E.M_LastName as MLASTNAME " +
                    $", E.pic as AVATAR " +
                    $", E.Email as EMAIL " +
                    $", D.Department as DEPARTAMENT " +
                    $", D.Description as DESCR " +
                    $" from Users U " +
                    $" inner join Employees E on U.ID_Employee = E.ID_Employee " +
                    $" inner join Job_Positions P on E.ID_Position = P.ID_Position " +
                    $" left join Rights_Type RT on RT.ID_Right = U.ID_Right " +
                    $" left join Department D on D.ID_Department = E.ID_Department where U.Username = '{parameters.username}'";
                var user = context.Users.FromSqlRaw(query).FirstOrDefault();
                if (user != null)
                {
                    if (SecurePassword.SecurePasword.Verify(parameters.password, user.Password))
                    {
                        var tokenizedUser = userService.Authenticate(user);

                        return StatusCode(200, tokenizedUser);
                    }
                    else
                    {
                        return StatusCode(400, parameters);
                    }
                }
                else
                {
                    return StatusCode(404, "User doesnt exists");
                }

            }
            catch (Exception e)
            {
                return StatusCode(404, e);
            }
        }
    }
}

