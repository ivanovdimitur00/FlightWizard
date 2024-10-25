using FlightWizard.Business.Domain;

namespace FlightWizard.Business.Contracts;
public interface IState
{
	PanelType Id { get; }
	void AddToScreen();
	void RemoveFromScreen();
}