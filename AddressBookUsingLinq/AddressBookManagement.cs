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

        public void RetrievingContactDetailsByStateOrCity(DataTable dataTable)
        {
            var recordData = dataTable.AsEnumerable().Where(r => r.Field<string>("city") == "Celtics");
            var recordDataState = dataTable.AsEnumerable().Where(r => r.Field<string>("state") == "Charlotte");
            foreach (var data in recordDataState)
            {
                Console.WriteLine("FirstName:- " + data.Field<string>("firstName"));
                Console.WriteLine("lastName:- " + data.Field<string>("lastName"));
                Console.WriteLine("Address:- " + data.Field<string>("address"));
                Console.WriteLine("City:- " + data.Field<string>("city"));
                Console.WriteLine("State:- " + data.Field<string>("state"));
                Console.WriteLine("zip:- " + Convert.ToInt32(data.Field<int>("zip")));
                Console.WriteLine("phoneNumber:- " + Convert.ToDouble(data.Field<Double>("phoneNumber")));
                Console.WriteLine("eMail:- " + data.Field<string>("eMail"));
                Console.WriteLine("***************");
            }
        }



        public void GetCountByCityAndState(DataTable datatable)
        {
            var recordData = datatable.AsEnumerable().Where(r => r.Field<string>("city") == "Lakers" && r.Field<string>("state") == "Los Angeles").Count();
            var recordedData = from data in datatable.AsEnumerable()
                               group data by new { city = data.Field<string>("city"), state = data.Field<string>("state") } into g
                               select new { city = g.Key, count = g.Count() };
            Console.WriteLine(recordData);
            foreach (var data in recordedData.AsEnumerable())
            {
                Console.WriteLine("city:- " + data.city.city);
                Console.WriteLine("state:- " + data.city.state);
                Console.WriteLine("lastName:- " + data.count);
                Console.WriteLine("*******************");
            }
        }
    }
}
