using System.Collections.Generic;
using SoccerIt.User.Domain.Entities;

namespace SoccerIt.User.ServiceLibrary.Services.Contracts
{
	public interface IUserAppService
	{
		IEnumerable<UserEntity> GetAll();
		UserEntity GetById(int id);
		bool Create(UserEntity user);
		bool Update(UserEntity user);
		bool Delete(int id);
	}
}
