using System.IO;
using System.Threading.Tasks;

namespace data_generator
{
    public class DataCustomerRepository
    {
        public void SaveDataInFile(List<DataCustomerModel> customers, string folderAndFileName)
        {
            if (String.IsNullOrEmpty(folderAndFileName))
            {
                folderAndFileName = $"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}/data_customer_file.csv";
            }

            var count = 0;
            using (StreamWriter streamWriter = new(folderAndFileName))
            {
                foreach (DataCustomerModel customer in customers)
                {
                    Thread.Sleep(8);
                    streamWriter.WriteLineAsync($"{customer.Id}|{customer.Name}|{customer.Email}");
                    count++;
                }
            };
        }
    }
}
