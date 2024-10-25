using FlightWizard.Business.Models;

namespace FlightWizard.Business.Domain;
public class FlightReservation
{
	public int FlightReservationId { get; set; }
	public int UserId { get; set; }
	public User User { get; set; } = default!;
	public DateTime Date { get; set; } = default!;
	public DateTime ExpirationDate { get; set; } = default!;
}
