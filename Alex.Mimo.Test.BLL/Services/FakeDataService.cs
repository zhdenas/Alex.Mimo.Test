using Alex.Mimo.Test.DataAccess.Repositories;

namespace Alex.Mimo.Test.BLL.Services
{
    public class FakeDataService : IFakeDataService
    {
        public void Fill()
        {
            FakeDataService.FillData();
        }

        public static void FillData()
        {
            FakeDataRepository.FillData();
        }
    }
}