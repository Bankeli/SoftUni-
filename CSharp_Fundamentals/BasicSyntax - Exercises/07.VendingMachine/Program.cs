namespace _07.VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            double sum = 0;
            while ((input = Console.ReadLine()) != "Start")
            {
                double coin = double.Parse(input);

                if (coin == 0.1 || coin == 0.2 || coin == 0.5 || coin == 1 || coin == 2)
                    sum += coin;
                else
                    Console.WriteLine($"Cannot accept {coin}");


            }

            while ((input = Console.ReadLine()) != "End")
            {

                double price = 0;
                bool isValidProduct=false;


                if (input == "Nuts")
                {
                    price = 2;

                }
                else if (input == "Water")
                {
                    price = 0.7;

                }
                else if (input == "Crisps")
                {
                    price = 1.5;

                }
                else if (input == "Soda")
                {
                    price = 0.8;

                }
                else if (input == "Coke")
                    price = 1;
                else
                {
                    Console.WriteLine("Invalid product");
                    isValidProduct = false;
                    continue;
                }
                   
                

                if (sum >= price)
                {
                    Console.WriteLine($"Purchased {input.ToLower()}");
                    sum -= price;

                }
                else 
                {
                    Console.WriteLine("Sorry, not enough money");
                    
                }
                    

               

            }
            Console.WriteLine($"Change: {sum:f2}");


        }
    }
}
