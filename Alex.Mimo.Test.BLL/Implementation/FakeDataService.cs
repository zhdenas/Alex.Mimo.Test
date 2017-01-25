using Alex.Mimo.Test.BLL.Interfaces;
using Alex.Mimo.Test.DataAccess.Repositories;

namespace Alex.Mimo.Test.BLL.Implementation
{
    public class FakeDataService: IFakeDataService
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