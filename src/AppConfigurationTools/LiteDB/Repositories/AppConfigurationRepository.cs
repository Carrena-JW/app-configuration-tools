namespace AppConfigurationTools.LiteDB.Repositories;

public class AppConfigurationRepository : RepositoryBase<AppConfiguration>
{
  
    public AppConfigurationRepository(string databaseName) : base(databaseName)
    {
      
    }
}
