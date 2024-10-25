using FlightWizard.Business;
using FlightWizard.Business.Domain;
using FlightWizard.Data.Contexts;

namespace FlightWizard.Data.Repositories;
public class FlightReservationRepository(ApplicationContext ctx): IRepository<FlightReservation>
{
	private readonly ApplicationContext _ctx = ctx;

	public bool Delete(int id)
	{
		try
		{
			var flightSeat = _ctx.Set<FlightReservation>().FirstOrDefault(x => x.FlightReservationId == id);

			if (flightSeat is null)
			{
				return false;
			}

			_ctx.Set<FlightReservation>().Remove(flightSeat);
			_ctx.SaveChanges();

			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public List<FlightReservation> Get()
	{
		return [.. _ctx.Set<FlightReservation>()];
	}

	public FlightReservation? GetById(int flightReservationId)
	{
		var flightReservation = _ctx.Set<FlightReservation>().FirstOrDefault(x => x.FlightReservationId == flightReservationId);

		return flightReservation;
	}

	public bool Insert(FlightReservation entity)
	{
		try
		{
			_ctx.Set<FlightReservation>().Add(entity);
			_ctx.SaveChanges();

			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public bool InsertMany(List<FlightReservation> entities)
	{
		try
		{
			_ctx.Set<FlightReservation>().AddRange(entities);
			_ctx.SaveChanges();

			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public bool Update(FlightReservation entity)
	{
		try
		{
			var flightReservation = _ctx.Set<FlightReservation>().FirstOrDefault(x => x.FlightReservationId == entity.FlightReservationId);

			if (flightReservation is null)
			{
				return false;
			}

			flightReservation.ExpirationDate = entity.ExpirationDate;
			flightReservation.Date = entity.Date;
			flightReservation.UserId = entity.UserId;

			_ctx.Set<FlightReservation>().Update(flightReservation);
			_ctx.SaveChanges();

			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}
}
