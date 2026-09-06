namespace BeatMyTomato.Interfaces;

using BeatMyTomato.Enums;
public interface ITimerStateMachine
{
    SessionState CurrentState { get; }

    bool CanFire(SessionTrigger trigger);

    void Fire(SessionTrigger trigger);

}