using Lab7.MainCode;
using NUnit.Framework;
using TechTalk.SpecFlow.Assist;
using TechTalk.SpecFlow.Infrastructure;

namespace Lab7.StepDefinitions
{
    [Binding]
    public class Bai4Steps
    {
        private ISpecFlowOutputHelper _outputHelper;
        private BaiHatService baiHatServices;
        private BaiHat baiHat;
        public Bai4Steps(ISpecFlowOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
            baiHatServices = new BaiHatService();
        }


        [Given(@"Thêm dữ liệu bài hát:")]
        public void getData(Table data)
        {
            baiHat = data.CreateInstance<BaiHat>();
            baiHat.doDai = Convert.ToInt32(baiHat.doDai);
        }

        [Then(@"Kết quả mong muốn: (.*)")]
        public void KetQua(string ketqua)
        {
            if (ketqua.Equals("Thành công")) {
                Assert.IsTrue(baiHatServices.Add(baiHat));
            } else {
                Assert.IsFalse(baiHatServices.Add(baiHat));
            }
        }
    }
}
