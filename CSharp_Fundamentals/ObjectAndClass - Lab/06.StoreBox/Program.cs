namespace _06.StoreBox
{
    internal class Program
    {
        public class Item
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
        }
        public class Box
        {
            public Box()
            {
                Item = new Item();
            }
            public string SerialNumber { get; set; }
            public Item Item { get; set; }
            public int Quantity { get; set; }
            public decimal PricePerBox { get; set; }
        }
        static void Main(string[] args)
        {
            string input = string.Empty;

            List<Box> boxColection = new List<Box>();

            while ((input = Console.ReadLine()) != "end")
            {
                string[] inputData = input.Split();
                Box box = new Box();
                box.SerialNumber = inputData[0];
                box.Item.Name = inputData[1];
                box.Quantity = int.Parse(inputData[2]);
                box.Item.Price = decimal.Parse(inputData[3]);

                box.PricePerBox = box.Item.Price * box.Quantity;

                boxColection.Add(box);

            }

            boxColection = boxColection.OrderByDescending(b => b.PricePerBox).ToList();
            PrintFinalResult(boxColection);
           
        }

        static void PrintFinalResult(List<Box>boxes)
        {
            foreach (Box box in boxes)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.Quantity}");
                Console.WriteLine($"-- ${box.PricePerBox:f2}");
            }
        }
    }
}
