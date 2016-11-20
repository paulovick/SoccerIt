﻿using System;

namespace SoccerIt.User.Domain.Entities
{
	public class UserEntity
	{
		public int Id { get; set; }
		public string Username { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public bool IsAdmin { get; set; }
	}
}
