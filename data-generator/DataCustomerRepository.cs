using System.Text;

namespace data_generator
{
    public class DataCustomerRepository
    {
        public void SaveDataInFile(List<DataCustomerModel> customers, string folderAndFileName = "c:/temp/data_customer_file.csv")
        {
            if (String.IsNullOrEmpty(folderAndFileName))
            {
                folderAndFileName = $"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}/data_customer_file.csv";
            }

            var count = 0;
            var updateDataFile = true;
            var encoding = new UTF8Encoding(false, true);
            var bufferSize = 65536; //64k buffer - The default size is 1k

            using (StreamWriter streamWriter = new (folderAndFileName, updateDataFile, encoding, bufferSize))
            {
                foreach (DataCustomerModel customer in customers)
                {
                    //Thread.Sleep(10);
                    streamWriter.WriteLine($"{customer.Id}|{customer.Name}|{customer.Email}");
                    count++;
                }
            };
        }
    }
}
