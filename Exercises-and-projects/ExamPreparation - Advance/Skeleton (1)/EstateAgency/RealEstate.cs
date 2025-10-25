namespace EstateAgency
{
    public class RealEstate
    {
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public decimal Price { get; set; }
        public double Size { get; set; }

        public RealEstate(string address, string postalCode,decimal price, double size)
        {
            this.Address = address;
            this.PostalCode = postalCode;
            this.Price = price;
            this.Size = size;
        }

        public override string ToString()
        {
            return $"Address: {Address}, PostalCode: {PostalCode}, Price: ${Price:f1}, Size: {Size} sq.m.";
        }
    }
}
