using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Windows.Forms;

namespace Minion
{
    class mongodb
    {
        /*The MongoConnectionStringBuilder supports .NET/SqlServer style connection strings, like this:

        var connectionString = "server=localhost;database=testDB;safe=true";
        var builder = new MongoConnectionStringBuilder(connectionString);

        If you want to use URL style connection strings use the MongoUrlBuilder class instead.

        You can also pass the connection string directly to MongoServer.Create, like this:

        var connectionString = "mongodb://localhost/?safe=true";
        var server = MongoServer.Create(connectionString);
        var database = server.GetDatabase("testDb");*/

        MongoServer mongo;
        public MongoServerState connect()
        {
            try
            {
                var connectionString = "mongodb://10.109.83.122/?safe=true";
                mongo = MongoServer.Create(connectionString);
                mongo.Connect();
                return mongo.State;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SEQuipt - MongoDB Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return mongo.State;
            }
        }
        public static void store()
        {
        }
        /*public static BsonString query()
        {

        }
        public static BsonDocument get()
        {

        }*/
        public MongoServerState disconnect()
        {
            try
            {
                mongo.Disconnect();
                return mongo.State;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SEQuipt - MongoDB Disconnect Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return mongo.State;
            }
        }

    }
}
