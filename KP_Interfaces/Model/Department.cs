using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
namespace Printers
{
    class Department
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public int ParentId { get; private set; }

        public Department(int id, string name, int parent) {
            Id = id;
            Name = name;
            ParentId = parent;
        }

        public static BindingList<Department> getSiblingsByParent(int parent) {
            BindingList<Department> result = new BindingList<Department>();

            string sql;
            if (parent == -1)
                sql = "select * from \"Structure_unit\" where \"parent_unit_pk\" is null";
            else
                sql = "select * from \"Structure_unit\" where \"parent_unit_pk\" = " + parent;
            NpgsqlDataReader reader = new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();

            foreach (DbDataRecord record in reader) {
                result.Add(new Department(record.GetInt32(0), record.GetString(1), record[2] != DBNull.Value? record.GetInt32(2) : -1));
            }
            reader.Close();
            return result;
        }

        public static void fillTree(TreeNode root, int parrent) {
            BindingList<Department> list = getSiblingsByParent(parrent);

            foreach (Department dep in list)
            {
                TreeNode newNode = root.Nodes.Add(dep.Id.ToString(), dep.Name);
                fillTree(newNode, dep.Id);
            }

        }

        public static Department create(string name, int parent) {
            Department newDep = new Department(0, name, parent);

            string sql;
            if (parent == -1) {
                sql = "insert into \"Structure_unit\"(\"name\", \"parent_unit_pk\") values ('" + name + "', null) returning *";
            }
            else
                sql = "insert into \"Structure_unit\"(\"name\", \"parent_unit_pk\") values ('" + name + "', " + parent + ") returning *";

            NpgsqlDataReader reader = new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteReader();
            reader.Read();
            newDep.Id = reader.GetInt32(0);
            reader.Close();
            return newDep;
        }

        public static void delete(int id)
        {
            string sql = "delete from \"Structure_unit\" where \"unit_pk\" = " + id;
            new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteNonQuery();
        }

        public static void update(int id, string newName)
        {
            string sql = "Update \"Structure_unit\" set \"name\" = '" + newName + "' where \"unit_pk\" = " + id;
            new NpgsqlCommand(sql, DBConnection.getConnection()).ExecuteNonQuery();
        }
    }
}
