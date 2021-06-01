using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookUsingLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to Address Book Using Linq!");
            DataTable addressBookTable = new DataTable();

            DataColumn column;
            DataRow row;

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "firstName";
            addressBookTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "lastName";
            addressBookTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "address";
            addressBookTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "city";
            addressBookTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "state";
            addressBookTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "zip";
            addressBookTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Double");
            column.ColumnName = "phoneNumber";
            addressBookTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "eMail";
            addressBookTable.Columns.Add(column);

            DataColumn[] PrimaryKeyColumns = new DataColumn[2];
            PrimaryKeyColumns[0] = addressBookTable.Columns["firstName"];
            PrimaryKeyColumns[1] = addressBookTable.Columns["phoneNumber"];
            addressBookTable.PrimaryKey = PrimaryKeyColumns;

            addressBookTable.Rows.Add("Kim", "Kardashian", "Street 1", "Lakers", "Los Angeles", 444556, 6785674567, "lb@gmail.com");
            addressBookTable.Rows.Add("Kylie", "Jenner", "Street 3", "Celtics", "Boston", 345267, 2345678987, "kylie@gmail.com");
            addressBookTable.Rows.Add("Kris", "Jenner", "Block 4", "Warriors", "Golden State", 987654, 3456787654, "kris@gmail.com");
            addressBookTable.Rows.Add("Khloe", "Lamar", "Street 5", "Rockets", "Houston", 234566, 6543456789, "khloe@gmail.com");
            addressBookTable.Rows.Add("Kourtney", "Scott", "Block 2", "Hornets ", "Charlotte ", 444556, 3456787654, "ks@gmail.com");

            AddressBookManagement addressBookManagement = new AddressBookManagement();
            addressBookTable = addressBookManagement.DeletingContactFromTable(addressBookTable);
        }
    }
}
