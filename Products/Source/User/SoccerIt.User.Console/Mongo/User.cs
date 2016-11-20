using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SoccerIt.User.Console
{
	public class User
	{
		[BsonElement("_id")]
		public int Id { get; set; }
		[BsonElement("Username")]
		public string Username { get; set; }
		[BsonElement("Email")]
		public string Email { get; set; }
		[BsonElement("Password")]
		public string Password { get; set; }
		[BsonElement("IsAdmin")]
		public bool IsAdmin { get; set; }

		public string Print()
		{
			return string.Format("[User: Id={0}, Username={1}, Email={2}, Password={3}, IsAdmin={4}]", Id, Username, Email, Password, IsAdmin);
		}
	}
}
