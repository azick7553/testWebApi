using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Results;

namespace webApi.Controllers
{
    public class ValuesController : ApiController
    {
        [Route("getUserList")]
        [HttpGet]
        public List<Users> getUserList()
        {

            var list = new List<Users>()
            {
                   new Users()
                {
                    Id = 1,
                    Login = "login1",
                    Password = "password1"
                },
                  new Users()
                {
                    Id = 2,
                    Login = "login2",
                    Password = "password2"
                },
                    new Users()
                {
                    Id = 3,
                    Login = "login3",
                    Password = "password3"
                },
                      new Users()
                {
                    Id = 4,
                    Login = "login4",
                    Password = "password4"
                }
            };
            return list;
        }
        [Route("getUserJsonList")]
        [HttpGet]
        public JsonResult<List<Users>> getUserJsonList()
        {

            var list = new List<Users>()
            {
                   new Users()
                {
                    Id = 1,
                    Login = "login1",
                    Password = "password1"
                },
                  new Users()
                {
                    Id = 2,
                    Login = "login2",
                    Password = "password2"
                },
                    new Users()
                {
                    Id = 3,
                    Login = "login3",
                    Password = "password3"
                },
                      new Users()
                {
                    Id = 4,
                    Login = "login4",
                    Password = "password4"
                }
            };
            return Json(list);
        }
    }
    public class Users
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}