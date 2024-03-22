namespace AppConfigurationTools.LiteDB.Entities;

public class BatchLastSyncAt : ILiteDbEntity
{
    public Guid Id { get; private set; }
    public string ParameterName { get; private set; }
    public DateTime LastSyncAt { get; private set; }
    public bool IsGracefulShutdown { get; private set; } 

    public static BatchLastSyncAt Create(string parameterName)
    {
        return new BatchLastSyncAt
        {
            Id = Guid.NewGuid(),
            ParameterName = parameterName,
            LastSyncAt = DateTime.Now,
            IsGracefulShutdown = false
        };
    }

    public void SetGracefullShutdown(bool value)
    {
        this.IsGracefulShutdown = value;
    }
}
