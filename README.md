# LionBank_SysTest_LabOne

Jag har valt ut att testa dessa tre metoder.

LionBankExampleProject > Admin > CurrencyRates()
Testa att ändra värdet på valutan Euro till ett nytt positivt värde, och ett negativt. (EuroRate finns som decimal property i Admin-klassen).
Önskvärt ska det inte gå att ändra till ett negativt värde.

LionBankExampleProject > Admin > ChangeInterestRate()
Testa att ändra värdet på räntan till ett nytt positivt värde, och ett negativt. (InterestRate finns som decimal property i Admin-klassen).
Önskvärt ska det inte gå att ändra till ett negativt värde.

LionBankExampleProject > Customer > Loans
Testa att ta ett lån på ett positivt värde och ett negativt värde.
Önskvärt ska pengarna på kontot ökar vid positivt värde och inte funka med ett negativt.


Change_EurRate_With_Pretedermined_Input_Of_An_IntValue_And_String_Expect_New_Decimal_Positive_Value_Of_InterestRate()
Förväntades bli grön, blev grön.
Change_EurRate_With_Pretedermined_Input_Of_An_IntValue_And_String_Expect_Value_Of_EurRate_To_Remain()
Förväntades bli röd, blev grön.

Change_InterestRate_With_Pretedermined_Input_Of_A_String_Expect_New_Decimal_Positive_Value_Of_InterestRate()
Förväntades bli grön, blev grön.
Change_InterestRate_With_Pretedermined_Input_Of_A_String_Expect_Value_Of_InterestRate_To_Remain()
Förväntades bli röd, blev grön.

Take_Loan_With_Predetermined_UserInput_Of_A_String_Representing_Positive_Value_Expect_Increased_Balance()
Förväntades bli grön, blev grön.
Take_Loan_With_Predetermined_UserInput_Of_A_String_Representing_Negative_Value_Expect_Balance_To_Remain()
Förväntades bli grön, blev röd.
