using System;
using SoccerIt.User.Console.Mongo;

class Program
{
	static void Main(string[] args)
	{
		var controller = new MongoController();
		var users = controller.GetAll();
		foreach(var user in users)
		{
			Console.WriteLine(user.Print());
		}
	}
}

