using System;
using System.ComponentModel;
using System.Data.Common;
using Npgsql;

namespace Printers
{
    class Creator
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        private Creator() { }
        public Creator(int id, string name) {
            Id = id;
            Name = name;
        }

        public static BindingList<Creator> getCreators() {
            BindingList<Creator> result = new BindingList<Creator>();

            string sql = "select * from \"Creator\"";
            NpgsqlDataReader reader = new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();
            foreach (DbDataRecord record in reader) {
                result.Add(new Creator(record.GetInt32(0), record.GetString(1)));
            }
            reader.Close();

            return result;
        }

        public static Creator create(string name) { 
            string sql = "insert into \"Creator\"(\"name\") values ('" + name + "') returning *";
            NpgsqlDataReader reader = new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();
            reader.Read();
            Creator newOne = new Creator(reader.GetInt32(0), name);
            reader.Close();
            CommonElements.Creators.Add(newOne);
            return newOne;
        }

        public static void delete(int id)
        {
            string sql = "delete from \"Creator\" where \"creator_pk\" = " + id;
            new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteNonQuery();
        }

        public static void update(int id, string newName) {
            string sql = "Update \"Creator\" set \"name\" = '" + newName + "' where \"creator_pk\" = " + id;
            new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteNonQuery();
        }

    }
}
