using System.Collections.Generic;
using System.Linq;
using SoccerIt.User.Domain.Entities;
using SoccerIt.User.ServiceLibrary.Services.Contracts;

namespace SoccerIt.User.ServiceLibrary.Services.Implementations
{
	public class UserAppService : IUserAppService
	{
		
		public IEnumerable<UserEntity> GetAll()
		{
			return null;
		}

		public UserEntity GetById(int id)
		{
			return null;
		}

		public bool Create(UserEntity user)
		{
			return false;
		}

		public bool Update(UserEntity user)
		{
			return false;
		}

		public bool Delete(int id)
		{
			return false;
		}
	}
}
