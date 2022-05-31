using Microsoft.VisualStudio.TestTools.UnitTesting;
using LionBankExampleProject;

namespace LionBankExampleProject.Tests
{

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [Description("Test the admin function of changing the property: interest rate, to another positive number")]
        [Owner("Erik R")]
        //[Ignore]
        public void Change_EurRate_To_Positive_Number_Return_Positive_EurRate()
        {
            //AAA 

            //Arrange
            Admin testAdmin = new Admin("TestAdm", "TestAdm1") { };

            //Act 
            Admin.CurrencyRates(/*System.ConsoleKey.D2*/ 2, "9");
            var actual = Admin.EurRate;
            var expected = 9m;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [Description("Test the admin function of changing the property: euro currencyrate, to another positive number")]
        [Owner("Erik R")]
        //[Ignore]
        public void Change_InterestRate_To_Positive_Number_Return_Positive_InterestRate()
        {
            //AAA 

            //Arrange
            Admin testAdmin = new Admin("TestAdm", "TestAdm1") { };

            //Act 
            Admin.ChangeInterestRate("5");
            var actual = Admin.InterestRate;
            var expected = 0.05m;

            //Assert
            Assert.AreEqual(actual, expected);

        }

        [TestMethod]
        [Description("Test the function 'Loans' with 'positive ' input and result in increased value of the decimal property 'balance'.")]
        [Owner("Erik R")]
        //[Ignore]
        public void Replace_User_Input_LoanAmount_With_Predetermined_Postitive_Value_Expect_Increased_Balance()
        {
            //AAA 

            //Arrange
            Customer testCustomer = new Customer("Testy", "Test123!", new Account { Balance = 10000, Name = "Testkonto", Currency = "SEK" });

            //Act 
            testCustomer.Loans("1000");
            var actual = testCustomer.Accounts[0].Balance;
            var expected = 11000;

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        [Description("Test the function 'Loans' with 'negative' input to see if 'balance' remains or lose value.")]
        [Owner("Erik R")]
        //[Ignore]
        public void Replace_User_Input_LoanAmount_With_Predetermined_Negative_Value_Expect_Balance_To_Remain()
        {
            //AAA 

            //Arrange
            Customer testCustomer = new Customer("Testy", "Test123!", new Account { Balance = 20000, Name = "Testkonto", Currency = "SEK" });

            //Act 
            testCustomer.Loans("-5000");
            var actual = testCustomer.Accounts[0].Balance;
            var expected = 20000;

            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}

