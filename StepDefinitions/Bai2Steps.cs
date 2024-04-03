using Lab7.MainCode;
using NUnit.Framework;
using TechTalk.SpecFlow.Infrastructure;

namespace Lab7.StepDefinitions
{
    [Binding]
    public class Bai2Steps
    {
        private readonly ISpecFlowOutputHelper _outputHelper;
        double a, b;
        bool phepTinh;

        public Bai2Steps(ISpecFlowOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }

        [Given(@"a = (.*)")]
        public void LaySoThuNhat(double number)
        {
            a = number;
        }

        [Given(@"b = (.*)")]
        public void LaySoThuHai(double number)
        {
            b = number;
        }

        [When(@"Phép tính (.*)")]
        public void LayPhepTinh(string pheptinh)
        {
            phepTinh = pheptinh.Equals("chia");
        }


        [Then(@"Giá trị trả về phép tính (.*)")]
        public void KiemTraHam(double result)
        {
            try
            {
                if (phepTinh) 
                { 
                    if (b == 0)
                    {
                        _outputHelper.WriteLine("Ngoại lệ chia cho 0");
                        Assert.Throws<ArithmeticException>(() => Caculator.Chia2So(a, b));
                    }
                    else
                    {
                        Assert.AreEqual(result, Caculator.Chia2So(a, b));
                    }
                } else
                {
                    Assert.AreEqual(result, Caculator.Nhan2So(a, b));
                }
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }
    }
}
