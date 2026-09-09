using BeatMyTomato.Enums;
using BeatMyTomato.Services;

var sm = new TimerStateMachine(SessionState.Idle);
Console.WriteLine(sm.CurrentState);       // Idle
sm.Fire(SessionTrigger.Start);
Console.WriteLine(sm.CurrentState);       // Running
sm.Fire(SessionTrigger.Complete);
Console.WriteLine(sm.CurrentState);       // Completed
sm.Fire(SessionTrigger.Pause);            // Exception

