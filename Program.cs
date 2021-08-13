using Microsoft.Azure.Cosmos.Table;
using System;

namespace AzureTable
{
    class Program
    {
        private static string connection_string = "CONNECTION_STRING";
        private static string tableName = "customer";
        static void Main(string[] args)
        {
            CloudStorageAccount _account = CloudStorageAccount.Parse(connection_string);
            CloudTableClient _table_client = _account.CreateCloudTableClient();
            CloudTable cloudTable =  _table_client.GetTableReference(tableName);
            cloudTable.CreateIfNotExists();
            Console.WriteLine("Table has been created");
            Console.ReadKey();
        }
    }
}
