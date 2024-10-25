namespace FlightWizard.Business.Domain;
public class Flight
{
	public int FlightId { get; set; }
	public DateTime Date { get; set; }
	public decimal Price { get; set; }
	public string From { get; set; } = string.Empty;
	public string To { get; set; } = string.Empty;
	public List<FlightSeat> FlightSeats { get; set; } = default!;
}
