namespace _09.PadawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal amountOfMoney = decimal.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            decimal saberPrice = decimal.Parse(Console.ReadLine());
            decimal robePrice = decimal.Parse(Console.ReadLine());
            decimal beltPrice = decimal.Parse(Console.ReadLine());

            int lighSaberToBuy = (int)Math.Ceiling(students * 1.1);

            int freeBelts = students / 6;
            int beltsToBuy = students - freeBelts;

            decimal totalSumForEquipemnt = (saberPrice * lighSaberToBuy) + (robePrice * students) + (beltPrice * beltsToBuy);

            if (amountOfMoney >= totalSumForEquipemnt)
                Console.WriteLine($"The money is enough - it would cost {totalSumForEquipemnt:f2}lv.");
            else
                Console.WriteLine($" John will need {totalSumForEquipemnt - amountOfMoney:f2}lv more.");

            
        }
    }
}
