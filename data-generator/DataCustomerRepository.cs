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

            using StreamWriter streamWriter = new(folderAndFileName);

            foreach (DataCustomerModel customer in customers)
            {
                streamWriter.WriteLineAsync($"{customer.Id}|{customer.Name}|{customer.Email}");
            }

        }
    }
}
