using System.IO;

namespace CarSalesman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int EnginesCount = int.Parse(Console.ReadLine());
            Dictionary<string, Engine> engineMap = new Dictionary<string, Engine>();
            for (int i = 0; i < EnginesCount; i++)
            {
                string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = data[0];
                int power = int.Parse(data[1]);

                int? displacement = null;
                string efficiency = null;

                if (data.Length > 2)
                {
                    if (int.TryParse(data[2], out int disp))
                    {
                        displacement = disp;

                        if (data.Length > 3)
                            efficiency = data[3];
                    }
                    else
                    {
                        efficiency = data[2];
                    }
                }

                Engine engine = new Engine { Model = model, Power = power, Displacement = displacement, Efficiency = efficiency };
                engineMap[model] = engine;
            }

            int carNumber = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < carNumber; i++)
            {
                string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = data[0];
                string engineModel = data[1];
                Engine engine = engineMap[engineModel];

                int? weight = null;
                string color = null;

                if (data.Length > 2)
                {

                    if (int.TryParse(data[2], out int wgt))
                    {
                        weight = wgt;

                        if (data.Length > 3)
                        {
                            color = data[3];
                        }
                    }
                    else
                    {
                        color = data[2];
                    }
                }

                Car car = new Car { Model = model, Engine = engine, Weight = weight, Color = color };
                cars.Add(car);
            }

            foreach (Car car in cars)
                Console.WriteLine(car);
        }
    }
}
