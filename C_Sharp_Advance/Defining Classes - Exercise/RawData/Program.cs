using System.Net.Cache;

namespace RawData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> carList = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

               string model = data[0];
                Engine engine = new Engine();
                engine.Speed = int.Parse(data[1]);
                engine.Power = int.Parse(data[2]);

                Cargo cargo = new Cargo();
                cargo.Weight = int.Parse(data[3]);
                cargo.Type = data[4];

                Tires tire1= new Tires {Pressure = double.Parse(data[5]), Age = int.Parse(data[6])};
                Tires tire2= new Tires {Pressure = double.Parse(data[7]), Age = int.Parse(data[8])};
                Tires tire3= new Tires {Pressure = double.Parse(data[9]), Age = int.Parse(data[10])};
                Tires tire4= new Tires {Pressure = double.Parse(data[11]), Age = int.Parse(data[12])};

                Car car = new Car(model, engine, cargo, [tire1, tire2, tire3, tire4]);
                carList.Add(car);
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                foreach (var car in carList.Where(c => c.Cargo.Type == "fragile").Where(t => t.Tires.Any(t => t.Pressure < 1)))
                    Console.WriteLine(car.Model);
            }
            else
            {
                foreach (var car in carList.Where(c => c.Cargo.Type == "flammable").Where(e => e.Engine.Power > 250))
                    Console.WriteLine(car.Model);
            }

        }
    }
}
