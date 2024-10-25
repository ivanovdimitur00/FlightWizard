using FlightWizard.Business;
using FlightWizard.Business.Domain;
using FlightWizard.Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace FlightWizard.Data.Repositories;
public class FlightRepository(ApplicationContext ctx) : IRepository<Flight>
{
	private readonly ApplicationContext _ctx = ctx;

	public bool Delete(int id)
	{
		try
		{
			var flight = _ctx.Set<Flight>().FirstOrDefault(x => x.FlightId == id);

			if (flight is null)
			{
				return false;
			}

			_ctx.Set<Flight>().Remove(flight);
			_ctx.SaveChanges();

			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public List<Flight> SearchByDate(DateTime dateFrom, DateTime dateTo)
	{
		return [.. _ctx.Set<Flight>().Where(f => f.Date > dateFrom && f.Date < dateTo)];
	}

	public List<Flight> Get()
	{
		return [.. _ctx.Set<Flight>().Include(x => x.FlightSeats)];
	}

	public Flight? GetById(int flightId)
	{
		var flight = _ctx.Set<Flight>().FirstOrDefault(x => x.FlightId == flightId);

		return flight;
	}

	public bool Insert(Flight entity)
	{
		try
		{
			_ctx.Set<Flight>().Add(entity);
			_ctx.SaveChanges();

			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public bool Update(Flight entity)
	{
		try
		{
			var flight = _ctx.Set<Flight>().FirstOrDefault(x => x.FlightId == entity.FlightId);

			if (flight is null)
			{
				return false;
			}

			flight.From = entity.From;
			flight.To = entity.To;
			flight.Date = entity.Date;
			flight.Price = entity.Price;

			_ctx.Set<Flight>().Update(flight);
			_ctx.SaveChanges();

			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}
}
