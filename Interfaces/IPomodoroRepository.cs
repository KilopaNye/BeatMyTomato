namespace BeatMyTomato.Interfaces;

using BeatMyTomato.Entities;

public interface IPomodoroRepository
{
    PomodoroSession? GetById(Guid id);

    IEnumerable<PomodoroSession> GetAll();

    PomodoroSession Add(PomodoroSession session);

    void Update(PomodoroSession session);

    bool Delete(Guid id);
}