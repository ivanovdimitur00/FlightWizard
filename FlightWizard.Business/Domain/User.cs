using FlightWizard.Business.Domain;

namespace FlightWizard.Business.Models;
public class User
{
	public int UserId { get; set; }
	public string Username { get; set; } = string.Empty;
	public string Password { get; set; } = string.Empty;
	public Role Role { get; set; }
	public List<FlightReservation> FlightReservations { get; set; } = default!;
}
