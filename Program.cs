using BeatMyTomato.Enums;
using BeatMyTomato.Services;

var sm = new TimerStateMachine(SessionState.Idle);
Console.WriteLine(sm.CurrentState);       // Idle
sm.Fire(SessionTrigger.Start);
Console.WriteLine(sm.CurrentState);       // Running
sm.Fire(SessionTrigger.Complete);
Console.WriteLine(sm.CurrentState);       // Completed
sm.Fire(SessionTrigger.Pause);            // 這裡應該會丟出例外，程式會中斷並印出 stack trace