using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;

namespace SoccerIt.User.Console.Mongo
{
	public class MongoController
	{
		MongoClient Client;
		IMongoDatabase Database;

		public MongoController()
		{
			this.Client = new MongoClient("mongodb://admin:admin@ds159217.mlab.com:59217/users");
			this.Database = this.Client.GetDatabase("users");
		}

		public IEnumerable<User> GetAll()
		{
			var result = this.Database.GetCollection<User>("User").Find(FilterDefinition<User>.Empty).ToEnumerable();
			return result;
		}
	}
}
