using Domain.Constants;
using Domain.Services;
using Tests.Mock;

namespace Tests
{
    [TestClass]
    public class MoneyProviderTests
    {
        [TestMethod]
        public void TestWithdraw1()
        {
            //Arrange
            MockRepository mockRepository = new MockRepository();
            MoneyProvider moneyProvider = new MoneyProvider(mockRepository);

            //Act
            var result = moneyProvider.WithdrawMoney(1);

            //Assert
            Assert.IsTrue(result == Messages.SUCCESS);
        }

        [TestMethod]
        public void TestWithdraw2()
        {
            //Arrange
            MockRepository mockRepository = new MockRepository();
            MoneyProvider moneyProvider = new MoneyProvider(mockRepository);

            //Act
            var result = moneyProvider.WithdrawMoney(100);

            //Assert
            Assert.IsTrue(result == Messages.ERROR);
        }
    }
}