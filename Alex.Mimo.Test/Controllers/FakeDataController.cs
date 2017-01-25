using System.Web.Http;
using System.Web.Http.Results;
using Alex.Mimo.Test.BLL.Interfaces;
using Alex.Mimo.Test.BLL.Models;

namespace Alex.Mimo.Test.Controllers
{
    public class FakeDataController: ApiController
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