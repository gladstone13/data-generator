using data_generator;

Console.WriteLine("Writing random data customer");
Console.WriteLine("*********************************************************************************************");

var informationGenerator = new InformationGenerator();
var dataCustomerRepository = new DataCustomerRepository();

var customerList = informationGenerator.GenerateCustomerInformation(10);
dataCustomerRepository.SaveDataInFile(customerList, "c:/temp/data_customer_file.csv");

Console.WriteLine("It´s over now.");
Console.WriteLine("*********************************************************************************************");
