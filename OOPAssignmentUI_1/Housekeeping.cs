using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OOPAssignmentUI_1
{
    internal static class Housekeeping
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new housekeeper_welcome());

        }

        public class RoomManager
        {
            private string connectionString = ConfigurationManager.ConnectionStrings["CSD1"].ToString();

            public DataTable GetCleaningSchedule()
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM CleaningSchedule";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }

            public void MarkClean(int scheduleId)
            {
                ExecuteNonQuery($"UPDATE CleaningSchedule SET status='Clean' WHERE schedule_id={scheduleId}");
            }

            public void MarkDirty(int scheduleId)
            {
                ExecuteNonQuery($"UPDATE CleaningSchedule SET status='Dirty' WHERE schedule_id={scheduleId}");
            }

            public void EditEntry(int scheduleId, string housekeepingId, int roomId, DateTime cleaningDate, string status)
            {
                string query = $"UPDATE CleaningSchedule SET housekeeping_id='{housekeepingId}', room_id={roomId}, cleaning_date='{cleaningDate}', status='{status}' WHERE schedule_id={scheduleId}";
                ExecuteNonQuery(query);
            }

            public void DeleteEntry(int scheduleId)
            {
                ExecuteNonQuery($"DELETE FROM CleaningSchedule WHERE schedule_id={scheduleId}");
            }

            public void NewRequest(string housekeepingId, int roomId, DateTime cleaningDate, string status)
            {
                string query = $"INSERT INTO CleaningSchedule (housekeeping_id, room_id, cleaning_date, status) VALUES ('{housekeepingId}', {roomId}, '{cleaningDate}', '{status}')";
                ExecuteNonQuery(query);
            }

            private void ExecuteNonQuery(string query)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            public DataRow GetEntryById(int scheduleId)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = $"SELECT * FROM CleaningSchedule WHERE schedule_id={scheduleId}";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    if (dataTable.Rows.Count > 0)
                    {
                        return dataTable.Rows[0];
                    }
                    return null;
                }
            }

            public DataRow GetRoomDetailsById(int roomId)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Rooms WHERE room_id = @roomId", conn);
                    cmd.Parameters.AddWithValue("@roomId", roomId);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        return dt.Rows[0];
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }
    }
}
