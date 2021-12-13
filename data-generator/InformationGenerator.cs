namespace data_generator
{
    public class InformationGenerator
    {
        public List<DataCustomerModel> GenerateCustomerInformation(int quantityOfCustomers)
        {
            List <DataCustomerModel> customers = new List<DataCustomerModel>();

            for (int i = 0; i < quantityOfCustomers; i++)
            {
                var name = GenerateName(6);
                var email = $"{name}@exemple.com";
                var customer = new DataCustomerModel(Guid.NewGuid(), name, email);

                customers.Add(customer);
            }

            return customers;
        }

        private static string GenerateName(int len)
        {
            Random r = new Random();
            string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l", "n", "p", "q", "r", "s", "sh", "zh", "t", "v", "w", "x" };
            string[] vowels = { "a", "e", "i", "o", "u", "ae", "y" };
            string Name = "";
            Name += consonants[r.Next(consonants.Length)].ToUpper();
            Name += vowels[r.Next(vowels.Length)];
            int b = 2; //b tells how many times a new letter has been added. It's 2 right now because the first two letters are already in the name.
            while (b < len)
            {
                Name += consonants[r.Next(consonants.Length)];
                b++;
                Name += vowels[r.Next(vowels.Length)];
                b++;
            }

            return Name;
        }


    }
}
