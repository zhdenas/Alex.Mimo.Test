using System.Web.Http;

namespace Alex.Mimo.Test.Controllers
{
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