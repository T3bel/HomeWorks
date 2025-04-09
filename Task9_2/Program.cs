using System.Text;

namespace Task9_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var myBankAccount = new BankAccount();
            var myWifeBankAccount = new BankAccount();

            myBankAccount.Deposit(15000);
            myBankAccount.Withdraw(10000);

            myWifeBankAccount.Deposit(10000);
            myWifeBankAccount.Withdraw(5000);
            myWifeBankAccount.Withdraw(-1000);

            try
            {
                myWifeBankAccount.Withdraw(6000);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка: {e.Message}\n");
            }
            try
            {
                myBankAccount.Deposit(-1000);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка: {e.Message}\n");
            }


            Console.WriteLine(myWifeBankAccount);
            Console.WriteLine(myBankAccount);
            Console.ReadKey();

            

        }
    }
    class BankAccount
    {
        private decimal _balance;

        const int _accountNumberValue = 4;
        private static int TotalAccounts = 0;
        private const string _currency = "$";
        public readonly string AccountNumber;

        public BankAccount()
        {
            Random random = new Random();
            StringBuilder accountNumber = new StringBuilder();
            for (int i = 0; i < _accountNumberValue; i++)
            {
                accountNumber.Append(random.Next(10));
            }
            TotalAccounts++;
            AccountNumber = accountNumber.ToString();
        }
        public override string ToString()
        {
            return $"Номер счета: {AccountNumber}\nБаланс: {_balance}{_currency}\n";
        }
        public void Deposit(decimal amount)
        {
            if (amount < 0) throw new ArgumentException("Депозит не может быть отрицательным");
            _balance += amount;
            Console.WriteLine($"Вы пополнили счет {AccountNumber} на {amount}{_currency}\nОстаток: {_balance}{_currency}\n");

        }

        public void Withdraw(decimal amount)
        {
            if (amount > _balance) throw new ArgumentException("Недостаточно средств на счете");
            _balance -= Math.Abs(amount);
            Console.WriteLine($"Вы сняли со счета {AccountNumber}: {amount}{_currency}\nОстаток: {_balance}{_currency}\n");
        }

    }

}
