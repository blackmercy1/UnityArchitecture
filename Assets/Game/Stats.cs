public class Stats : IStats<int>
{
    private readonly GenericStats<int> _intStats;

    public Stats()
    {
    }

    public Stats(GenericStats<int> intStats)
    {
        _intStats = intStats;
    }

    public bool TryGet(string id, out ITypeStat<int> stat)
    {
        return _intStats.TryGet(id, out stat);
    }

    public IStats<int> Add(ITypeStat<int> stat)
    {
        _intStats.Add(stat);
        return this;
    }
}