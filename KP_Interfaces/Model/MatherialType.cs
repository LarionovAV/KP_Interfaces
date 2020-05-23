using System.ComponentModel;
using System.Data.Common;
using Npgsql;
namespace Printers
{
    class MatherialType
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public MatherialType(int id, string name) {
            Id = id;
            Name = name;
        }

        public static BindingList<MatherialType> getMatherialTypes() {
            BindingList<MatherialType> result = new BindingList<MatherialType>();

            string sql = "select * from \"Matherial_type\"";
            NpgsqlDataReader reader = new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();
            foreach (DbDataRecord record in reader) {
                result.Add(new MatherialType(record.GetInt32(0), record.GetString(1)));
            }
            reader.Close();
            return result;
        }

        public static MatherialType create(string name) {
            string sql = "insert into \"Matherial_type\"(\"name\") values ('" + name + "') returning *";
            NpgsqlDataReader reader = new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();
            reader.Read();
            MatherialType newOne = new MatherialType(reader.GetInt32(0), name);
            CommonElements.MatherialTypes.Add(newOne);

            return newOne;
        }
    }
}
