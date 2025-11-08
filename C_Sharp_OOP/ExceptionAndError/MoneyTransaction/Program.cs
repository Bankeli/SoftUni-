namespace MoneyTransaction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bankData = Console.ReadLine().Split(",",StringSplitOptions.RemoveEmptyEntries);
            Dictionary<int, decimal> bankMap = new();

            foreach (var client in bankData)
            {
               var parts= client.Split("-");
               var bankAcc = int.Parse(parts[0]);
                var accBalance = decimal.Parse(parts[1]);

                bankMap[bankAcc] = accBalance;
            }
            string command = string.Empty;
           while ((command = Console.ReadLine()) != "End")
            {
                string[] data = command.Split(" ",StringSplitOptions.RemoveEmptyEntries); 
                string action = data[0];
                int account = int.Parse(data[1]);
                decimal balance = decimal.Parse(data[2]);
                try
                {
                    if (action == "Deposit")
                    {
                        bankMap[account] += balance;
                    }
                    else if (action == "Withdraw")
                    {
                        if (balance > bankMap[account])
                            throw new ArgumentException("Insufficient balance!");

                        bankMap[account] -= balance;
                    }
                    else
                        throw new Exception("Invalid command!");

                    Console.WriteLine($"Account {account} has new balance: {bankMap[account]:f2}");
                }
                catch (KeyNotFoundException)
                {
                    Console.WriteLine("Invalid account!");
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }

                Console.WriteLine("Enter another command");
            }
        }
    }
}
