using System.Dynamic;
using System.Text;

namespace DataCenter
{
    public class Rack
    {
        public int Slots { get; set; }
        public List<Server> Servers { get; set; } = new List<Server>();
        public int GetCount => Servers.Count;

        public Rack(int slots)
        {
            this.Slots = slots;
        }

        public void AddServer(Server server)
        {
            if (GetCount >= Slots)
                return;

            if (this.Servers.Any(s => s.SerialNumber == server.SerialNumber)) return;

            this.Servers.Add(server);
        }

        public bool RemoveServer(string serialNumber)
        {
            Server server = this.Servers.FirstOrDefault(s => s.SerialNumber == serialNumber);
            if (server != null) 
            {
                Servers.Remove(server);
                return true;
            } 
            return false;
        }

        public string  GetHighestPowerUsage()
        {
            return Servers.OrderByDescending(s => s.PowerUsage).First().ToString();
        }

        public int GetTotalCapacity()
        {
            return Servers.Sum (s => s.Capacity);
        }

        public string DeviceManager()
        {
            return $"{GetCount} servers operating:\n" +
            string.Join("\n", Servers.Select(s => s.ToString()));
        }
    }

    
}
