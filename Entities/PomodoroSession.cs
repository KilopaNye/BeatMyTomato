namespace BeatMyTomato.Entities;
using BeatMyTomato.Enums;

public class PomodoroSession
{
    public Guid Id { get; set; }
    public SessionState State { get; set; }
    public DateTime? StartedAt { get; set; }
    public DateTime? PausedAt { get; set; }
    public TimeSpan PausedDuration { get; set; }
    public TimeSpan PlannedDuration { get; set; }

    public TimeSpan GetElapsed(DateTime now)
    {
        if (StartedAt is null)
        {
            return TimeSpan.Zero;
        }

        return now - StartedAt.Value - PausedDuration;
// 你來完成這裡：now 減去 StartedAt.Value，再減去 PausedDuration
    }
}