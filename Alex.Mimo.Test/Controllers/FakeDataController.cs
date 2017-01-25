using System.Web.Http;
using Alex.Mimo.Test.BLL.Interfaces;

namespace Alex.Mimo.Test.Controllers
{
    [Route("api/[controller]")]
    public class FakeDataController : ApiController
    {
        private readonly IFakeDataService _fakeService;

        public FakeDataController(IFakeDataService fakeService)
        {
            this._fakeService = fakeService;
        }

        // POST: api/Lessons
        public IHttpActionResult Get()
        {
            this._fakeService.Fill();
            return this.Ok();
        }
    }
}