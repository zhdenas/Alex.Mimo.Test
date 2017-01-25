using System.Web.Http;
using Alex.Mimo.Test.Models;

namespace Alex.Mimo.Test.Controllers
{
    public abstract class BaseController : ApiController
    {
        protected UserModel AuthUser;

        protected BaseController()
        {
            AuthUser=new UserModel()
            {
                Id = 1,
                Email = "test@gmail.com"
            };
        }
    }
}