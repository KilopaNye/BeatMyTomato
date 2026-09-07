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


    public SessionState CurrentState => _machine.State;

    public bool CanFire(SessionTrigger trigger)
    {
        return _machine.CanFire(trigger);
    }

    public void Fire(SessionTrigger trigger)
    {
        if (!CanFire(trigger))
        {
            throw new InvalidStateTransitionException(CurrentState,trigger);
        }

        _machine.Fire(trigger);
    }
}
