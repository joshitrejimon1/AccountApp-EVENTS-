using AccountApp_EVENTS_.Model;

namespace AccountApp_EVENTS_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account(101, "Joshit", 5000);

            account1.OnBalanceChanged += SendSMS;
            account1.OnBalanceChanged += SendEmail;

            account1.Desposite(1000);
        }

        static void SendSMS(Account account)
        {
            Console.WriteLine("sending sms " +
                "Main Balance is " + account.Balance);
        }
        static void SendEmail(Account account)
        {
            Console.WriteLine("sending Email " +
                "Main Balance is " + account.Balance);
        }
    }
}