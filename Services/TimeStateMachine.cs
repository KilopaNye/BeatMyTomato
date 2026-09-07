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

        _machine.Configure(SessionState.Idle)
        .Permit(SessionTrigger.Start, SessionState.Running);

        _machine.Configure(SessionState.Running)
        .Permit(SessionTrigger.Pause, SessionState.Paused)
        .Permit(SessionTrigger.Complete, SessionState.Completed);

        _machine.Configure(SessionState.Paused)
        .Permit(SessionTrigger.Resume, SessionState.Running)
        .Permit(SessionTrigger.Complete, SessionState.Completed);
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
