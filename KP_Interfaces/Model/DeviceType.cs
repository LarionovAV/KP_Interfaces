using Npgsql;
using System.ComponentModel;
using System.Data.Common;

namespace Printers
{
    class DeviceType
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        private DeviceType() { }
        public DeviceType(int id, string name) {
            Id = id;
            Name = name;
        }

        public static BindingList<DeviceType> getDeviceTypes() {
            BindingList<DeviceType> result = new BindingList<DeviceType>();

            string sql = "select * from \"Device_type\"";
            NpgsqlDataReader reader = new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();
            foreach (DbDataRecord record in reader) {
                result.Add(new DeviceType(record.GetInt32(0), record.GetString(1)));
            }
            reader.Close();

            return result;
        }

        public static DeviceType create(string name) {
            string sql = "insert into \"Device_type\"(\"name\") values ('" + name + "') returning *";
            NpgsqlDataReader reader = new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();
            reader.Read();
            DeviceType newOne = new DeviceType(reader.GetInt32(0), name);
            CommonElements.DeviceTypes.Add(newOne);
            return newOne;
        }

        public static void delete(int id)
        {
            string sql = "delete from \"Device_type\" where \"device_type_pk\" = " + id;
            new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteNonQuery();
        }

        public static void update(int id, string newName)
        {
            string sql = "Update \"Device_type\" set \"name\" = '" + newName + "' where \"device_type_pk\" = " + id;
            new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteNonQuery();
        }
    }
}
