namespace FlightWizard.Business;

public class Key : IEquatable<Key>
{
	public int From { get; set; }
	public int Choice { get; set; } 

	public override int GetHashCode()
	{
		return 2 * From.GetHashCode() + 3 * Choice.GetHashCode();
	}

	public bool Equals(Key? other)
	{
		return other is not null && From == other.From && Choice == other.Choice;
	}

	public override bool Equals(object? other)
	{
		return other is Key && Equals(other);
	}
}
