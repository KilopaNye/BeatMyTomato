namespace BeatMyTomato.Repositories;

using System.Collections.Concurrent;
using BeatMyTomato.Interfaces;
using BeatMyTomato.Entities;

public class InMemoryPomodoroRepository : IPomodoroRepository
{
    private readonly ConcurrentDictionary<Guid, PomodoroSession> _sessions = new();

    public PomodoroSession? GetById(Guid id)
    {
        return _sessions.TryGetValue(id, out var session) ? session : null;
    }

    public IEnumerable<PomodoroSession> GetAll()
    {
        return _sessions.Values;
    }

    public PomodoroSession Add(PomodoroSession session)
    {
        _sessions.TryAdd(session.Id, session);
        return session;
    }

    public void Update(PomodoroSession session)
    {
        throw new NotImplementedException();
    }

    public bool Delete(Guid id)
    {
        throw new NotImplementedException();
    }

}