using data_generator;

Console.WriteLine("Writing random data customer");
Console.WriteLine("*********************************************************************************************");

var informationGenerator = new InformationGenerator();
var dataCustomerRepository = new DataCustomerRepository();

var numberOfRows = 1000000;

var customerList = informationGenerator.GenerateCustomerInformation(numberOfRows);
dataCustomerRepository.SaveDataInFile(customerList, "c:/temp/data_customer_file.csv");

Console.WriteLine("It´s over now.");
Console.WriteLine("*********************************************************************************************");
