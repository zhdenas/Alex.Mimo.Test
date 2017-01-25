using Alex.Mimo.Test.BLL.Interfaces;

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
            
        }
    }
}