using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{
    public class ContactMap : ClassMap<Contact>
    {
        public ContactMap()
        {
            Map(m => m.bookName).Name("bookName");
            Map(m => m.firstName).Name("firstName");
            Map(m => m.lastName).Name("lastName");
            Map(m => m.address).Name("address");
            Map(m => m.city).Name("city");
            Map(m => m.state).Name("state");
            Map(m => m.zip).Name("zip");
            Map(m => m.phone).Name("phone");
            Map(m => m.email).Name("email");
        }
    }
}
