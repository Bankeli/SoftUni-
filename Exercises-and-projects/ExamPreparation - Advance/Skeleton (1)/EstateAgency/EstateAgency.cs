using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace EstateAgency
{
    public class EstateAgency
    {
        public EstateAgency(int capacity)
        {
         this.Capacity = capacity;
            this.RealEstates = new List<RealEstate> ();
        }
        public int Capacity { get; set; }
        public List<RealEstate> RealEstates { get; set; }
        public int Count => RealEstates.Count;

        public void AddRealEstate(RealEstate realestate)
        {
            if (Count >= Capacity) return;

            if (RealEstates.Any(r => r.Address == realestate.Address)) return;

            RealEstates.Add(realestate);
        }

        public bool RemoveRealEstate(string address)
        {
            var estate = RealEstates.FirstOrDefault(r => r.Address == address);
            if (estate != null)
            {
                RealEstates.Remove(estate);
                return true;
            }
            return false;
        }

        public List<RealEstate> GetRealEstates(string postalCode)
        {
            return RealEstates
                .Where(es => es.PostalCode == postalCode)
                .ToList();
        }

        public RealEstate GetCheapest()
        {
            return RealEstates.OrderBy(x => x.Price).FirstOrDefault();
        }

        public double GetLargest()
        {
            return RealEstates
                .OrderByDescending(r => r.Size)
                .FirstOrDefault().Size;
        }

        public string EstateReport()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Real estates available:");

            foreach (var estate in RealEstates)
            {
                sb.AppendLine(estate.ToString());
            }
            return sb.ToString().TrimEnd();
        }

        public RealEstate GetRealEstate(string address)
        {
            return RealEstates.FirstOrDefault(r => r.Address == address);
        }
    }
}
