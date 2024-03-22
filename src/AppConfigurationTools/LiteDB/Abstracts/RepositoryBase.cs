namespace AppConfigurationTools.LiteDB.Abstracts;

public class RepositoryBase<TEntity> where TEntity: class, ILiteDbEntity
{
    private const string DATABASE_PREFIX = "st11";
    protected readonly string _databasePath;
    protected readonly string _collectionName;

    public RepositoryBase(string databaseName)
    {
        _databasePath = $"{DATABASE_PREFIX}_{databaseName}.db";
        _collectionName = typeof(TEntity).Name;
    }

    public void Insert(TEntity entity)
    {
        using (var db = new LiteDatabase(_databasePath))
        {
            var collection = db.GetCollection<TEntity>(_collectionName);
            collection.Insert(entity);
        }
    }

    public TEntity FindById(Guid id)
    {
        using (var db = new LiteDatabase(_databasePath))
        {
            var collection = db.GetCollection<TEntity>(_collectionName);
            return collection.FindById(id);
        }
    }

    public TEntity FindOne(BsonExpression expression)
    {
        using (var db = new LiteDatabase(_databasePath))
        {
            var collection = db.GetCollection<TEntity>(_collectionName);
            return collection.FindOne(expression);
        }
    }

    public List<TEntity> GetAll()
    {
        using (var db = new LiteDatabase(_databasePath))
        {
            var collection = db.GetCollection<TEntity>(_collectionName);
            return collection.FindAll().ToList();
        }
    }

    public bool Update(TEntity entity)
    {
        using (var db = new LiteDatabase(_databasePath))
        {
            var collection = db.GetCollection<TEntity>(_collectionName);
            return collection.Update(entity);
        }
    }

    public bool Delete(Guid id)
    {
        using (var db = new LiteDatabase(_databasePath))
        {
            
            var collection = db.GetCollection<TEntity>(_collectionName);
            return collection.Delete(id);
        }
    }
}
