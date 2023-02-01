using App.Common.Classes.DTO;
using System.Data;
using System.Data.SqlClient;
using System.Dynamic;

namespace App.Infrastructure.Procedures
{
    //Dynamic
    public static partial class StoredProcedures
    {

        public static void ExecuteNonQuery(string query, List<SqlParameter> parameters = null, string connectionString = null)
        {
            using (SqlConnection connection = GetSqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection) { CommandTimeout = connection.ConnectionTimeout })
                {
                    command.CommandType = parameters != null ? CommandType.StoredProcedure : CommandType.Text;
                    if (parameters != null && parameters.Count > 0)
                        command.Parameters.AddRange(parameters.ToArray());
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public static IEnumerable<dynamic> Execute(string query, List<SqlParameter> parameters = null, string connectionString = null)
        {
            using (SqlConnection connection = GetSqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection) { CommandTimeout = connection.ConnectionTimeout })
                {
                    command.CommandType = parameters != null ? CommandType.StoredProcedure : CommandType.Text;
                    if (parameters != null && parameters.Count > 0)
                        command.Parameters.AddRange(parameters.ToArray());
                    connection.Open();

                    using (SqlDataReader rdr = command.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        return rdr.Cast<IDataRecord>().Select(record =>
                        {
                            ExpandoObject expando = new ExpandoObject();
                            IDictionary<string, object> dictionary = expando as IDictionary<string, object>;
                            for (int i = 0; i < record.FieldCount; i++)
                                dictionary[record.GetName(i) ?? string.Empty] = record.GetValue(i) is DBNull ? null : record.GetValue(i);
                            return (dynamic)expando;
                        }).ToArray();
                    }
                }
            }
        }

        public static SqlConnection GetSqlConnection(string connectionString)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            return conn;
        }


    }
}
