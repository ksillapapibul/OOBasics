namespace OOBasics.Encapsulation
{
    public class Example
    {
        public static void Execute()
        {
            var account = new Account(1000, 456789);

            account.balance = 0;
        }
    }
}