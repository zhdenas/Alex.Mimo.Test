using System.Web.Http;
using Alex.Mimo.Test.BLL.Models;

namespace Alex.Mimo.Test.Controllers
{
    public abstract class BaseController : ApiController
    {
        protected UserModel AuthUser;

        protected BaseController()
        {
            this.AuthUser = new UserModel
            {
                Id = 1,
                Email = "test@gmail.com"
            };
        }
    }
}