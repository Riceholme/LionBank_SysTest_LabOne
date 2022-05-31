using Microsoft.VisualStudio.TestTools.UnitTesting;
using LionBankExampleProject;

namespace LionBankExampleProject.Tests
{

    [TestClass]
    public class UnitTest1
    {
        //CURRENCY RATE POSITIVE VALUE
        [TestMethod]
        [Description("Test the admin function of changing the property: interest rate")]
        [Owner("Erik R")]
        //[Ignore]
        public void Change_EurRate_With_Pretedermined_Input_Of_An_IntValue_And_String_Expect_New_Decimal_Positive_Value_Of_InterestRate()
        {
            //AAA 

            //Arrange
            Admin testAdmin = new Admin("TestAdm", "TestAdm1") { };

            //Act 
            Admin.CurrencyRates(/*System.ConsoleKey.D2*/ 2, "9");
            var actual = Admin.EurRate;
            var expected = 9m;

            //Assert
            Assert.AreEqual(expected, actual); //EXPECTED GREEN, BECAME GREEN
        }
        
        //CURRENCY RATE NEGATIVE VALUE
        [TestMethod]
        //[Ignore]
        public void Change_EurRate_With_Pretedermined_Input_Of_An_IntValue_And_String_Expect_Value_Of_EurRate_To_Remain()
        {
            //AAA 

            //Arrange
            Admin testAdmin = new Admin("TestAdm", "TestAdm1") { };

            //Act 
            Admin.CurrencyRates(/*System.ConsoleKey.D2*/ 2, "-9");
            var actual = Admin.EurRate;
            var expected = -9m;

            //Assert
            Assert.AreEqual(expected, actual); //EXPECTED RED, BECAME GREEN
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //INTEREST RATE POSITIVE VALUE
        [TestMethod]
        [Description("Test the admin function of changing the property: euro currencyrate")]
        [Owner("Erik R")]
        //[Ignore]
        public void Change_InterestRate_With_Pretedermined_Input_Of_A_String_Expect_New_Decimal_Positive_Value_Of_InterestRate()
        {
            //AAA 

            //Arrange
            Admin testAdmin = new Admin("TestAdm", "TestAdm1") { };

            //Act 
            Admin.ChangeInterestRate("5");
            var actual = Admin.InterestRate;
            var expected = 0.05m;

            //Assert
            Assert.AreEqual(actual, expected); //EXPECTED GREEN, BECAME GREEN
        }

        //INTEREST RATE NEGATIVE VALUE
        [TestMethod]
        //[Ignore]
        public void Change_InterestRate_With_Pretedermined_Input_Of_A_String_Expect_Value_Of_InterestRate_To_Remain()
        {
            //AAA 

            //Arrange
            Admin testAdmin = new Admin("TestAdm", "TestAdm1") { };

            //Act 
            Admin.ChangeInterestRate("-5");
            var actual = Admin.InterestRate;
            var expected = -0.05m;

            //Assert
            Assert.AreEqual(actual, expected); //EXPECTED RED, BECAME GREEN
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //TAKE LOAN POSITIVE VALUE
        [TestMethod]
        [Description("Test the function 'Loans' with 'positive ' input and result in increased value of the decimal property 'balance'.")]
        [Owner("Erik R")]
        //[Ignore]
        public void Take_Loan_With_Predetermined_UserInput_Of_A_String_Representing_Positive_Value_Expect_Increased_Balance()
        {
            //AAA 

            //Arrange
            Customer testCustomer = new Customer("Testy", "Test123!", new Account { Balance = 10000, Name = "Testkonto", Currency = "SEK" });

            //Act 
            testCustomer.Loans("1000");
            var actual = testCustomer.Accounts[0].Balance;
            var expected = 11000;

            //Assert
            Assert.AreEqual(actual, expected); //EXPECTED GREEN, BECAME GREEN
        }

        //TAKE LOAN NEGATIVE VALUE
        [TestMethod]
        [Description("Test the function 'Loans' with 'negative' input to see if 'balance' remains or lose value.")]
        [Owner("Erik R")]
        //[Ignore]
        public void Take_Loan_With_Predetermined_UserInput_Of_A_String_Representing_Negative_Value_Expect_Balance_To_Remain()
        {
            //AAA 

            //Arrange
            Customer testCustomer = new Customer("Testy", "Test123!", new Account { Balance = 20000, Name = "Testkonto", Currency = "SEK" });

            //Act 
            testCustomer.Loans("-5000");
            var actual = testCustomer.Accounts[0].Balance;
            var expected = 20000;

            //Assert
            Assert.AreEqual(actual, expected); //EXPECTED GREEN, BECAME RED
        }
    }
}

