using FlightWizard.Business.Contracts;
using FlightWizard.Business.Domain;

namespace FlightWizard.Business;
public class Session()
{
	private readonly Dictionary<PanelType, IState> _states = [];

	private readonly Dictionary<Key, PanelType> _transitions = [];
	public SessionData SessionData { get; init; } = new();

	public void AddPanel(IState state, PanelType type)
	{
		_states.TryAdd(type, state);
	}

	public static void ShowPanel(IState state)
	{
		state.AddToScreen();
	}

	public void ChangePanel(PanelType from, int choice)
	{
		var currentState = _states.GetValueOrDefault(from) ?? throw new Exception("Application is in an invalid state!");

		currentState.RemoveFromScreen();

		var transition = _transitions.GetValueOrDefault(new Key { Choice = choice, From = (int)from });

		if (transition == PanelType.None)
		{
			throw new Exception($"Transition to panel {transition} is impossible! Please check your panel configuration.");
		}

		var nextState = _states.GetValueOrDefault(transition) ?? throw new Exception($"Next state {transition} is not configured!");

		ShowPanel(nextState);
	}


	public void AddTransition(PanelType from, int choice, PanelType to)
	{
		var key = new Key()
		{
			From = (int)from,
			Choice = choice
		};

		_transitions.TryAdd(key, to);
	}
}
