namespace _07.CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>>employeesByCompanies = new Dictionary<string, List<string>>();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] companyData = command.Split(" -> ");
                string companiName = companyData[0];
                string employeeID = companyData[1];

                if (!employeesByCompanies.ContainsKey(companiName))
                {
                    employeesByCompanies.Add(companiName, new List<string>());
                }

                if (!employeesByCompanies[companiName].Contains(employeeID))
                {
                    employeesByCompanies[companiName].Add(employeeID);
                }

            }

            foreach (var item in employeesByCompanies)
            {
                Console.WriteLine(item.Key);

                foreach (string id in item.Value)
                {
                    Console.WriteLine($"-- {id}");
                }

            }
        }
    }
}
