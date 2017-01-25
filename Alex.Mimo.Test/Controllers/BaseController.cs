using System.Web.Http;

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