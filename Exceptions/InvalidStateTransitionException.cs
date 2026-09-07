namespace BeatMyTomato.Exceptions;
using BeatMyTomato.Enums;

public class InvalidStateTransitionException : Exception
{
    public InvalidStateTransitionException(SessionState currentState, SessionTrigger attemptedTrigger) 
        : base($"Cannot fire {attemptedTrigger} from state {currentState}")
    {
    }
}