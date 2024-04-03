using Lab7.MainCode;
using NUnit.Framework;
using TechTalk.SpecFlow.Infrastructure;

namespace Lab7.StepDefinitions
{
    [Binding]
    public class Bai3Steps
    {
        private ISpecFlowOutputHelper _outputHelper;
        private int diemHocSinh;
        public Bai3Steps(ISpecFlowOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }

        [Given(@"Điểm học sinh: (.*)")]
        public void GetDiem(int diem)
        {
            diemHocSinh = diem;
        }

        [Then(@"Xếp loại: (.*)")]
        public void CheckHocLuc(string result)
        {
            if (diemHocSinh < 0 || diemHocSinh > 100)
            {
                _outputHelper.WriteLine("Bắt lỗi ngoại lệ");
                Assert.Throws<ArgumentException>(() => StudentGrader.XepLoai(diemHocSinh));
            } else
            {
                Assert.IsTrue(result.Equals(StudentGrader.XepLoai(diemHocSinh)));
            }
        }
    }
}
