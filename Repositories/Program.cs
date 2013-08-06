using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    class Program
    {
        static void Main(params string[] args)
        {
            Console.WriteLine("Started");
            SampleRepo sr = new SampleRepo();
            var id = sr.TestInsert();

            Console.WriteLine(String.Format("Successfully saved object with ID {0}", id));
            var result = sr.TestRetrieveWithId(id);
            Console.WriteLine(String.Format("Successfully retrieved object with firstname of {0} and lastname of {1}",result.FirstName,result.LastName));

            Console.Read();
        }
    }
}
