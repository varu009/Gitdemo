using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Assignmenr5
{
    class Account
    {
        int accountNo;
        int accountBalance;
        int accountPassword;
        int amount;
       

        public Account()
        {

        }

        public Account(int amount)
        {
            this.Amount = amount;
        }

        public Account(int accountNo, int accountBalance, int accountPassword)
        {
            this.AccountNo = accountNo;
            this.AccountBalance = accountBalance;
            this.AccountPassword = accountPassword;
        }

        public int AccountNo { get => accountNo; set => accountNo = value; }
        public int AccountBalance { get => accountBalance; set => accountBalance = value; }
        public int AccountPassword { get => accountPassword; set => accountPassword = value; }
        public int Amount { get => amount; set => amount = value; }

        public virtual void withdraw()
        {
            Amount -= Amount;
        }
    }
    
    class SavingsAccount : Account
    {
        int minimumBalance;
        
     
        public SavingsAccount()
        {

        }

        public SavingsAccount(int minimumBalance, int accountNo,int accountBalance, int accountPassword) :base(accountNo,accountBalance,accountPassword)
        {
            this.MinimumBalance = minimumBalance;
        }

        public int MinimumBalance { get => minimumBalance; set => minimumBalance = value; }


        public override void withdraw()
        {
            Console.WriteLine("Amount to be withdraw Saving Account");
            int i =Convert.ToInt32 (Console.ReadLine());

            AccountBalance = AccountBalance - i;


        }


    }
    class CurrentAccount : Account
    {
        int overdraftLimitAmount;

        public CurrentAccount()
        {

        }

        public CurrentAccount(int overdraftLimitAmount,int accountNo,int accountBalance,int accountPassword):base(accountNo,accountBalance,accountPassword)
        {
            this.OverdraftLimitAmount = overdraftLimitAmount;
        }

        public int OverdraftLimitAmount { get => overdraftLimitAmount; set => overdraftLimitAmount = value; }

        public override void withdraw()
        {
            Console.WriteLine("Amount to be withdraw from current Account");
            int i = Convert.ToInt32(Console.ReadLine());

            AccountBalance = AccountBalance - i;


        }


    }
    class Info
    {
        public void displayAccount(Account account)
        {
            Console.WriteLine("Account number= " + account.AccountNo);
            Console.WriteLine("Account balance= " + account.AccountBalance);
            Console.WriteLine("Account password= " + account.AccountPassword);
        }
        public void displayAccount1(SavingsAccount savingaccount)
        {
            Console.WriteLine("Minimum balance= " + savingaccount.MinimumBalance);
        }
        public void displayAccount2(CurrentAccount currentaccount)
        {
            Console.WriteLine("OverDraftlimit Amount= " + currentaccount.OverdraftLimitAmount);
        }
    }
    class show
    {
        static void Main()
        {
            //Account a1 = new Account(123456789, 500000, 1234);
            //Account a2 = new Account(987654321, 600000, 2222);
            //Account a3 = new Account(121314151, 700000, 1609);

            Info info = new Info();
            //info.displayAccount(a1);
            //info.displayAccount(a2);
            //info.displayAccount(a3);

            SavingsAccount sa = new SavingsAccount(1000, 1234567, 500000, 1234);
            sa.withdraw();
            info.displayAccount(sa);
            info.displayAccount1(sa);

            CurrentAccount ca = new CurrentAccount(2000, 987654321, 600000, 1234);
            ca.withdraw();
            info.displayAccount(ca);
            info.displayAccount2(ca);

        }

    }
    interface ATM
    {
        public void withdraw(int accountNumber, double amount);
        public void changePassword(int accountNumber, String oldPassword, String newPassword);
        public void checkBalance();

    }
    class SbiAtm : ATM
    {
        public void changePassword(int accountNumber, string oldPassword, string newPassword)
        {
            throw new NotImplementedException();
        }

        public void checkBalance()
        {
            throw new NotImplementedException();
        }

        public void withdraw(int accountNumber, double amount)
        {
            throw new NotImplementedException();
        }
    }
    class IciciAtm : ATM
    {
        public void changePassword(int accountNumber, string oldPassword, string newPassword)
        {
            throw new NotImplementedException();
        }

        public void checkBalance()
        {
            throw new NotImplementedException();
        }

        public void withdraw(int accountNumber, double amount)
        {
            throw new NotImplementedException();
        }
    }
    //class InsufficientFundException : ApplicationException
    //{
    //    public InsufficientFundException(string message) : base(message)
    //    {

    //    }
    //    void ExceptionH()
    //    {
    //        if()
    //        {
    //            throw new InsufficientFundException("amount exceeding the current balance");
    //        }
    //    }
    //}
    interface AccountDao
    {
        public void addAnAccount(Account account);
        public void withdraw(int accountNumber, double amount);
        public void checkBalance();
        public void changePassword(int accountNumber, String oldPassword, String newPassword);
        public List<Account> viewAllAccounts();
        public void getAccountDetails(int accountNumber);

    }
    class InMemoryAccountDaoImpl : AccountDao
    {
        public void addAnAccount(Account account)
        {
            Console.WriteLine("Account number= " + account.AccountNo);
            Console.WriteLine("Account balance= " + account.AccountBalance);
            Console.WriteLine("Account password= " + account.AccountPassword);

        }

        public void changePassword(int accountNumber, string oldPassword, string newPassword)
        {
            throw new NotImplementedException();
        }

        public void checkBalance()
        {
            throw new NotImplementedException();
        }

        public void getAccountDetails(int accountNumber)
        {
            throw new NotImplementedException();
        }

        public List<Account> viewAllAccounts()
        {
            throw new NotImplementedException();
        }

        public void withdraw(int accountNumber, double amount)
        {
            throw new NotImplementedException();
        }
    }
    class AccountDaoImpl : AccountDao
    {
        List<Account> accounts = new List<Account>();
        InMemoryAccountDaoImpl ima = new InMemoryAccountDaoImpl();

        SqlConnection con = null;
        SqlCommand cmd = null;

        public void addAnAccount(Account account)
        {
            throw new NotImplementedException();
        }

        public void changePassword(int accountNumber, string oldPassword, string newPassword)
        {
            throw new NotImplementedException();
        }

        public void checkBalance()
        {
            throw new NotImplementedException();
        }

        public void getAccountDetails(int accountNumber)
        {
            throw new NotImplementedException();
        }

        public SqlConnection GetConnection()
        {
            con = new SqlConnection("Data Source=aroma; Initial Catalog = ass;" +" Integrated Security = true");
            con.Open();
            return con;

        }
       
        public void register(Account account)
        {
            try
            {
                con = GetConnection();
                ima.addAnAccount(account);
                cmd = new SqlCommand("Insert into Account(AccountNo,AccountBalance,AccountPassword)" +
                    " values(@accountNo,@accountBalance,@accountPassword)", con);
                cmd.Parameters.AddWithValue("@accountNo", account.AccountNo);
                cmd.Parameters.AddWithValue("@accountBalance", account.AccountBalance);
                cmd.Parameters.AddWithValue("@accountPassword", account.AccountPassword);
                int i = cmd.ExecuteNonQuery();    //returns int
                Console.WriteLine("No. of Rows Affected:{0}", i);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                con.Close();
            }



        }

        public List<Account> viewAllAccounts()
        {
            throw new NotImplementedException();
        }

        public void withdraw(int accountNumber, double amount)
        {
            throw new NotImplementedException();
        }
    }

}
