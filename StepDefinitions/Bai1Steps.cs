using Lab7.MainCode;
using NUnit.Framework;
using TechTalk.SpecFlow.Infrastructure;

namespace Lab7.StepDefinitions
{
    [Binding]
    public sealed class Bai1Steps
    {
        private readonly ISpecFlowOutputHelper _outputHelper;
        int a, b;

        public Bai1Steps(ISpecFlowOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }

        [Given(@"Số bị chia = (.*)")]
        public void LaySoBiChia(int number)
        {
            a = number;
        }

        [Given(@"Số chia = (.*)")]
        public void LaySoChia(int number)
        {
            b = number;
        }

        [Then(@"Giá trị trả về (.*)")]
        public void KiemTraHam(int result)
        {
            try
            {
                if (b == 0)
                {
                    _outputHelper.WriteLine("Ngoại lệ chia cho 0");
                    Assert.Throws<ArithmeticException>(() => Bai1.Chia2SoNguyen(a, b));
                }
                else
                {
                    Assert.AreEqual(result, Bai1.Chia2SoNguyen(a, b));
                }
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }
    }
}
