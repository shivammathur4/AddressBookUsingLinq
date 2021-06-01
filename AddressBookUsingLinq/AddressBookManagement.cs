using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookUsingLinq
{
    public class AddressBookManagement
    {

        public void GetCountByType(DataTable dataTable)
        {
            var recordData = dataTable.AsEnumerable().GroupBy(r => r.Field<string>("type")).Select(r => new { type = r.Key, count = r.Count() });
            foreach (var data in recordData)
            {
                Console.WriteLine("Count for type- " + data.count);
            }
        }
    }
}
