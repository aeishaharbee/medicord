namespace medicord_v1.Data
{
    public static class Database
    {
        private static readonly string connStr =
            System.Configuration.ConfigurationManager
                  .ConnectionStrings["MedicordV1"].ConnectionString;

        public static SqlConnection GetConnection() => new SqlConnection(connStr);

        public static DataTable GetTable(string sql, params SqlParameter[] parameters)
        {
            using var conn = GetConnection();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddRange(parameters);
            var dt = new DataTable();
            new SqlDataAdapter(cmd).Fill(dt);
            return dt;
        }

        public static int Execute(string sql, params SqlParameter[] parameters)
        {
            using var conn = GetConnection();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddRange(parameters);
            conn.Open();
            return cmd.ExecuteNonQuery();
        }

        public static object? Scalar(string sql, params SqlParameter[] parameters)
        {
            using var conn = GetConnection();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddRange(parameters);
            conn.Open();
            return cmd.ExecuteScalar();
        }
    }
}
