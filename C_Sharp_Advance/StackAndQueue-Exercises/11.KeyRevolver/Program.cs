namespace _11.KeyRevolver
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int bulletPrice = int.Parse(Console.ReadLine());
            int gunBarrel = int.Parse(Console.ReadLine());
            Stack<int> bullets = new(Console.ReadLine().Split().Select(int.Parse));
            Queue<int> locks = new(Console.ReadLine().Split().Select(int.Parse));
            int valueOfIntel = int.Parse(Console.ReadLine());
            bool isJobDone = false;
            int shootingBullet = 0;
            int counter = 0;

            while (bullets.Count > 0 && locks.Count > 0)
            {
                int shotPower = bullets.Peek();
                int lockSecure = locks.Peek();
                
                if (shotPower <= lockSecure)
                {
                    bullets.Pop();
                    locks.Dequeue();
                    Console.WriteLine("Bang!");
                }
                else
                {
                    bullets.Pop();
                    Console.WriteLine("Ping!");
                }
                shootingBullet++;
                counter++;
                if (counter == gunBarrel && bullets.Count > 0)
                { 
                    Console.WriteLine("Reloading!");
                    counter = 0;
                }
            }
                if (locks.Count == 0)
                {
                    isJobDone = true;
                }
            
            int moneyEarn = valueOfIntel - (shootingBullet * bulletPrice);

            Console.WriteLine(isJobDone ? ($"{bullets.Count} bullets left. Earned ${moneyEarn}") : $"Couldn't get through. Locks left: {locks.Count}");
        }
    }
}
