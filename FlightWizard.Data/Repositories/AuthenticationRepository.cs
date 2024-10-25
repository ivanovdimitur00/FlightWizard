using FlightWizard.Business;
using FlightWizard.Business.Models;
using FlightWizard.Data.Contexts;

namespace FlightWizard.Data.Repositories;
public class AuthenticationRepository(ApplicationContext ctx) : IRepository<User>
{
	private readonly ApplicationContext _ctx = ctx;

	public bool Delete(int id)
	{
		try
		{
			var user = _ctx.Set<User>().FirstOrDefault(x => x.UserId == id);

			if (user is null)
			{
				return false;
			}

			_ctx.Set<User>().Remove(user);
			_ctx.SaveChanges();

			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public List<User> Get()
	{
		return [.. _ctx.Set<User>()];
	}

	public User? GetById(int userId)
	{
		var user = _ctx.Set<User>().FirstOrDefault(x => x.UserId == userId);

		return user;
	}

	public User? GetByUsername(string username)
	{
		var user = _ctx.Set<User>().FirstOrDefault(x => x.Username == username);

		return user;
	}

	public bool Insert(User entity)
	{
		try
		{
			_ctx.Set<User>().Add(entity);
			_ctx.SaveChanges();

			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public bool Update(User entity)
	{
		try
		{
			var user = _ctx.Set<User>().FirstOrDefault(x => x.UserId == entity.UserId);

			if (user is null)
			{
				return false;
			}

			user.Username = user.Username;
			user.Password = user.Password;

			_ctx.Set<User>().Update(user);
			_ctx.SaveChanges();

			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}
}
