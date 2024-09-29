namespace CondominiumManagerApi.Core.Entities.Common
{
    public class SqlSettings(string connectionString)
    {
        public string ConnectionString { get; set; } = connectionString;
    }
}