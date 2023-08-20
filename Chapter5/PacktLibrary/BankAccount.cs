namespace Packt.Shared
{
    public class BankAccount
    {
        private string? accountName;
        private decimal balance;
        private static decimal interestRate;
        public string? AccountName { get => accountName; set => accountName = value; }
        public static decimal InterestRate { get => interestRate; set => interestRate = value; }
        public decimal Balance { get => balance; set => balance = value; }
    }
}