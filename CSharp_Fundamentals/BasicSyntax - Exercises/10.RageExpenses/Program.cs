namespace _10.RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int lostGame = int.Parse(Console.ReadLine());
            decimal headsetPrice = decimal.Parse(Console.ReadLine());
            decimal mousePrice = decimal.Parse(Console.ReadLine());
            decimal keyboardPrice = decimal.Parse(Console.ReadLine());
            decimal displayPrice =  decimal.Parse(Console.ReadLine());

            int brokenHeadset = lostGame / 2;
            int brokenMouse = lostGame / 3;
            int brokenKeyboard = lostGame / 6;
            int brokenMonitor = brokenKeyboard / 2;

            decimal totalSum = (brokenHeadset* headsetPrice) + (brokenMouse * mousePrice) + (brokenKeyboard * keyboardPrice)+ (brokenMonitor * displayPrice);

            Console.WriteLine($"Rage expenses: {totalSum:f2} lv.");
        }
    }
}
