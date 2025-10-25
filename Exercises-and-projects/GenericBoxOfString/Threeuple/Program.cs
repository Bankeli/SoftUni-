namespace Threeuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] data1 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            FullfillFirst(data1);

            string[] data2 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            FullfillSecond(data2);

            string[] data3 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            FullfillThird(data3);

        }

        static void FullfillFirst(string[] data1)
        {
            string name = data1[0];
            string lastName = data1[1];
            string fullName = $"{name} {lastName}";
            string adress = data1[2];
            string town = string.Join(" ", data1.Skip(3));

            CustomThreeuple<string, string, string> threeuple1 = new CustomThreeuple<string, string, string>(fullName, adress, town);

            Console.WriteLine(threeuple1);
        }

        static void FullfillSecond(string[] data)
        {
            string name = data[0];
            int liters = int.Parse(data[1]);
            bool drunk = data[2] == "drunk";
            CustomThreeuple<string, int, bool> threeuple = new CustomThreeuple<string, int, bool> ( name, liters, drunk );
            Console.WriteLine(threeuple);
        }

        static void FullfillThird(string[] data)
        {
            string name = data[0];
            double accBalance = double.Parse(data[1]);
            string bankName = data[2];

            CustomThreeuple<string,double,string> threeuple = new CustomThreeuple<string,double, string> ( name,accBalance, bankName );
            Console.WriteLine(threeuple);
        }
    }
}
