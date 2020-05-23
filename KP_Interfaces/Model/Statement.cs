using Npgsql;
using System.ComponentModel;
using System.Data.Common;

namespace Printers
{
    class Statement
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        private Statement() { }
        public Statement(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public static BindingList<Statement> getStatements()
        {
            BindingList<Statement> result = new BindingList<Statement>();

            string sql = "select * from \"Statement\"";
            NpgsqlDataReader reader = new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();
            foreach (DbDataRecord record in reader)
            {
                result.Add(new Statement(record.GetInt32(0), record.GetString(1)));
            }
            reader.Close();

            return result;
        }

        public static Statement create(string name)
        {

            string sql = "insert into \"Statement\"(\"name\") values ('" + name + "') returning *";
            NpgsqlDataReader reader = new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();
            reader.Read();
            Statement newOne = new Statement(reader.GetInt32(0), name);
            CommonElements.Statements.Add(newOne);
            return newOne;
        }
    }
}
