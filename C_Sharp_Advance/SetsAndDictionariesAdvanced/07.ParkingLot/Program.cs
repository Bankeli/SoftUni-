namespace _07.ParkingLot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            HashSet<string> parkingLot = new HashSet<string>();

            while ((input = Console.ReadLine()) != "END")
            {
                string[] data = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string direction = data[0];
                string carNumber = data[1];

                if (direction == "IN")
                {
                    parkingLot.Add(carNumber);
                }
                else if (direction == "OUT")
                {
                    parkingLot.Remove(carNumber);
                }
            }
            if (parkingLot.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
                return;
            }

            foreach (var car in parkingLot)
            {
                Console.WriteLine(car);
            }
        }
    }
}
