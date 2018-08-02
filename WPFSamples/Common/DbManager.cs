using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace WPFSamples.Common
{
    public class DbManager : IDisposable
    {
        private readonly SqlConnection sqlConnection;
        public delegate void ConnectionEventHandler(string status);

        public event ConnectionEventHandler StatusChange;

        public ConnectionState State => sqlConnection.State;

        public DbManager(string server, string dataBase, string userName, string password)
        {
            SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder
            {
                DataSource = server,
                InitialCatalog = dataBase,
                UserID = userName,
                Password = password,
                PersistSecurityInfo = true
            };
            sqlConnection = new SqlConnection(stringBuilder.ConnectionString);
        }

        public bool Open()
        {
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            return true;
        }

        public bool Close()
        {
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            return true;
        }

        public void ToggleConnection()
        {
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
                OnStatusChange("Disconnected");
            }
            else
            {
                sqlConnection.Open();
                OnStatusChange("Connected");
            }
        }

        public async Task<object> ExecuteNonAsync(string query)
        {
            if (State == ConnectionState.Closed) return 0;
            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = query;
            int result = await command.ExecuteNonQueryAsync();
            return $"{result} row Updated";
        }

        public async Task<object> ExecuteScalarAsync(string query)
        {
            try
            {
                if (State == ConnectionState.Closed) return "";
                SqlCommand command = sqlConnection.CreateCommand();
                command.CommandText = query;
                object result = await command.ExecuteScalarAsync();
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IDataReader> ExecuteReadersync(string query)
        {
            try
            {
                if (State == ConnectionState.Closed) return null;
                SqlCommand command = sqlConnection.CreateCommand();
                command.CommandText = query;
                IDataReader result = await command.ExecuteReaderAsync();
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void OnStatusChange(string status)
        {
            StatusChange?.Invoke(status);
        }

        public void Dispose()
        {
            if (State == ConnectionState.Open)
                sqlConnection.Close();
            GC.SuppressFinalize(this);
        }
    }
}
