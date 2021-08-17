using System.IO;

namespace APIApplication.Infrastructure.Models
{
    public class ConnectionStrings
    {
        public TFOMongoDb TFOMongoDb { get; set; }
    }

    public class TFOMongoDb: ConnectionBase
    {
        public string TfoBulletinsCollectionName { get; set; }
    }

    public class ConnectionBase
    {
        public string ConnectionString { get; set; }
        public string Name { get; set; }
        public string Params { get; set; }
        public string FullConnectionString { 
            get {
                return $"{Path.Combine(ConnectionString ?? "", Name)?.Replace("\\","/")}{Params}";
            } 
        }
    }
}
