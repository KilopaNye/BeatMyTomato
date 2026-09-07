namespace BeatMyTomato.Services;
using BeatMyTomato.Enums;
using BeatMyTomato.Exceptions;
using BeatMyTomato.Interfaces;
using Stateless;



public class TimerStateMachine : ITimerStateMachine
{
    private readonly StateMachine<SessionState,SessionTrigger> _machine;

    public TimerStateMachine(SessionState initialState)
    {
        _machine = new StateMachine<SessionState, SessionTrigger>(initialState);
    }


    public SessionState CurrentState => throw new NotImplementedException();

    public bool CanFire(SessionTrigger trigger)
    {
        throw new NotImplementedException();
    }

    public void Fire(SessionTrigger trigger)
    {
        throw new NotImplementedException();
    }
}
