using Npgsql;
using System.Diagnostics;

var stopWatch = new Stopwatch();
stopWatch.Start();
Console.WriteLine("*************************************************************");
Console.WriteLine("The data ingestion was started.");

var connString = "Host=localhost;Username=postgres;Password=123456;Database=etl_db;CommandTimeout=600";

using var conn = new NpgsqlConnection(connString);
conn.Open();

var file = @"E'C:\\temp\\data_customer_file_10000k.csv'";

using (var cmd = new NpgsqlCommand($"copy public.data_customer from {file} DELIMITERS '|';", conn))
{
    cmd.ExecuteNonQuery();
}

//conn.BeginTextImport($"copy public.data_customer from {file} DELIMITERS '|';");
conn.Close();
conn.Dispose();
Console.WriteLine($"Time elapsed: {stopWatch.Elapsed}");
stopWatch.Stop();
Console.WriteLine("*************************************************************");
Console.WriteLine("The data ingestion was ended.");