namespace FlightWizard.Business.Domain;
public class FlightSeat
{
	public int FlightSeatId { get; set; }
	public bool IsFree { get; set; }
	public int FlightId { get; set; }
	public Flight Flight { get; set; } = default!;
}
