namespace AppConfigurationTools.LiteDB.Entities;

public class AppConfiguration : ILiteDbEntity
{
    public Guid Id { get; private set; }
    public string ConfigKey { get; set; }
    public string ConfigValue { get; set; }
    public DateTime CreatedUpdatedAt { get; set; }

}
