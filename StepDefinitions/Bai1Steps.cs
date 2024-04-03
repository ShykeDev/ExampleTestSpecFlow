using Lab7.MainCode;
using NUnit.Framework;

namespace Lab7.StepDefinitions
{
    [Binding]
    public sealed class Bai1Steps
    {
        int a, b;

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

        [When(@"Khi chia 2 số")]
        public void KhiChia2So()
        {
            
        }

        [Then(@"Giá trị trả về (.*)")]
        public void KiemTraHam(int result)
        {
            try
            {
                if (b == 0)
                {
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
