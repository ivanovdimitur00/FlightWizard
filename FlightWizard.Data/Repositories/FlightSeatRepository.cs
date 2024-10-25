

using FlightWizard.Business.Domain;
using FlightWizard.Business;
using FlightWizard.Data.Contexts;

namespace FlightWizard.Data.Repositories;
public class FlightSeatRepository(ApplicationContext ctx) : IRepository<FlightSeat>
{
	private readonly ApplicationContext _ctx = ctx;

	public bool Delete(int id)
	{
		try
		{
			var flightSeat = _ctx.Set<FlightSeat>().FirstOrDefault(x => x.FlightId == id);

			if (flightSeat is null)
			{
				return false;
			}

			_ctx.Set<FlightSeat>().Remove(flightSeat);
			_ctx.SaveChanges();

			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public List<FlightSeat> Get()
	{
		return [.. _ctx.Set<FlightSeat>()];
	}

	public FlightSeat? GetById(int flightSeatId)
	{
		var flightSeat = _ctx.Set<FlightSeat>().FirstOrDefault(x => x.FlightSeatId == flightSeatId);

		return flightSeat;
	}

	public bool Insert(FlightSeat entity)
	{
		try
		{
			_ctx.Set<FlightSeat>().Add(entity);
			_ctx.SaveChanges();

			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}
	
	public bool InsertMany(List<FlightSeat> entities)
	{
		try
		{
			_ctx.Set<FlightSeat>().AddRange(entities);
			_ctx.SaveChanges();

			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public bool Update(FlightSeat entity)
	{
		try
		{
			var flightSeat = _ctx.Set<FlightSeat>().FirstOrDefault(x => x.FlightId == entity.FlightId);

			if (flightSeat is null)
			{
				return false;
			}

			flightSeat.IsFree = entity.IsFree;
			flightSeat.FlightId = entity.FlightId;

			_ctx.Set<FlightSeat>().Update(flightSeat);
			_ctx.SaveChanges();

			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}
}
