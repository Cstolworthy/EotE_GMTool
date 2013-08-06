using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class SampleRepo
    {
        MongoDatabase _database;

        public SampleRepo()
        {
            var connectionString = "mongodb://sample:myPassword@dharma.mongohq.com:10035/Sample";
            var client = new MongoClient(connectionString);
            var server = client.GetServer();
            _database = server.GetDatabase("Sample"); // "test" is the name of the database
        }

        public string TestInsert()
        {
            var collection = _database.GetCollection<TestObject>("SampleEntities");

            var obj = new TestObject(){FirstName="John", LastName="Doe"};

            collection.Insert(obj);

            return obj.Id.ToString();
        }

        public TestObject TestRetrieveWithId(string id)
        {
            var collection = _database.GetCollection<TestObject>("SampleEntities");
            var query = Query<TestObject>.EQ(e => e.Id, new ObjectId(id));
            var result = collection.FindOne(query);

            return result;
        }
    }
}
