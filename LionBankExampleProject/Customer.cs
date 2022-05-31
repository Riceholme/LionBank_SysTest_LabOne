using System;
using System.Collections.Generic;
using System.Text;

namespace LionBankExampleProject
{
    
        public class Customer : User
        {
            public Customer(string tempUsername, string tempPassword, Account baseAccount)
            {
                this.Username = tempUsername;
                this.Password = tempPassword;
                Accounts = new List<Account>();
                Log = new List<string>();
                Accounts.Add(baseAccount);
            }
            public override string ToString()
            {
                return ("Användarnamn: " + Username + "    Lösenord: " + Password + "    Inloggnings försök: " + LoginCounter);
            }
            
            
            public void Loans(string testUserLoanAmount)
            {
                string testUserPw = "Test123!";

                //Console.Clear();
                //BankSystem.CenterColor("LÅN\n",true,"Yellow");
                decimal intresteamount = 0;
                decimal IntrestCal = 0;
                decimal total = 0;
                decimal accountSum = 0;
                //Console.Write("Skriv in hur mycket du vill låna: ");
                decimal loanAmount;
                //string loanInput = BankSystem.ShowInput(); <<<<<<<<ORIGINAL
                string loanInput = testUserLoanAmount; // <<<<<<< NEW

                while (!decimal.TryParse(loanInput, out loanAmount) ^ loanInput == "ESC")
                {
                    //BankSystem.ClearLine();
                    //Console.Write("Skriv in hur mycket du vill låna: ");
                    //loanInput = BankSystem.ShowInput(); <<<<<<<<ORIGINAL
                    loanInput = testUserLoanAmount; // <<<<<<< NEW
                }
                if (loanInput != "ESC")
                {
                    //Console.Clear();
                    //BankSystem.CenterColor("LÅN\n", true, "Yellow");
                    foreach (Account u in Accounts)
                    {
                        accountSum = accountSum + u.Balance;
                    }
                    if (accountSum * 5 < loanAmount + LoanSum)
                    {
                        //Console.Clear();
                        //BankSystem.CenterColor("LÅN\n", true, "Yellow");
                        //BankSystem.CenterColor("Du har för lite pengar för att ta detta lån.",false,"Red");
                        //Console.WriteLine("Vänligen kontakta vår personal för att se över dina möjligheter");
                        //BankSystem.Return();
                    }
                    else
                    {
                        if (loanAmount < 100000)
                        {
                            IntrestCal = 1.05m;
                            intresteamount = 5m;
                            total = loanAmount * IntrestCal;
                        }
                        else if (loanAmount >= 100000)
                        {
                            IntrestCal = 1.02m;
                            intresteamount = 2m;
                            total = loanAmount * IntrestCal;
                        }
                        else if (loanAmount >= 500000)
                        {
                            IntrestCal = 1.015m;
                            intresteamount = 1.5m;
                            total = loanAmount * IntrestCal;
                        }
                        //Console.WriteLine("Din totala kostnad för ett lån på " + loanAmount + " blir " + total);
                        //Console.WriteLine("Du har då en ränta på " + intresteamount + "%\n");
                        bool loanCon = true;
                        while (loanCon)
                        {
                            if (accountSum * 5 > loanAmount + LoanSum)
                            {
                                //Console.Write("För att bekräfta skriv in ditt lösenord: ");
                                //string pass = BankSystem.HideInput(); //<<<<<<<<ORIGINAL
                                string pass = testUserPw; //<<<<<<< NEW
                                while (pass != Password && pass != "ESC")
                                {
                                    //BankSystem.ClearLine();
                                    //Console.WriteLine("För att bekräfta skriv in ditt lösenord: ");
                                    //BankSystem.CenterColor("Felaktigt lösenord", false,"Red");
                                    //Console.SetCursorPosition(41, 5);
                                    //pass = BankSystem.HideInput(); //<<<<<<<<ORIGINAL
                                    pass = testUserPw; //<<<<<<< NEW
                                }
                                if (pass == Password)
                                {
                                    //Console.Clear();
                                    //BankSystem.CenterColor("LÅN\n", true, "Yellow");
                                    //BankSystem.CenterColor($"\nGrattis till ditt lån. \nPengarna finns nu tillgängliga på {Accounts[0].Name}",false,"Green");
                                    LoanSum = LoanSum + total;
                                    Accounts[0].Balance += loanAmount;
                                    //Log.Add($"\n{DateTime.Now} \nEtt lån togs på {total} SEK. Din totala lånsumma blev då {LoanSum} SEK");
                                    //BankSystem.Return();
                                    loanCon = false;
                                }
                                else if (pass == "ESC")
                                {
                                    loanCon = false;
                                }
                                else
                                {
                                    //Console.Clear();
                                }
                            }
                        }
                    }
                }
            }
        }
    }

