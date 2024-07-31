using System;
using System.Collections.Generic;
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

            public DataTable GetCleaningScheduleForUser(int userId)
            {
                DataTable dt = new DataTable();
                string query = "SELECT * FROM CleaningSchedule WHERE housekeeping_id = (SELECT housekeeping_id FROM housekeeping WHERE user_id = @userId)";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);

                        try
                        {
                            con.Open();
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            adapter.Fill(dt);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error loading cleaning schedule: {ex.Message}");
                        }
                    }
                }

                return dt;
            }

            public string GetUserNameByHousekeepingId(int housekeepingId)
            {
                string userName = string.Empty;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
            SELECT u.username
            FROM users u
            INNER JOIN housekeeping h ON u.user_id = h.user_id
            WHERE h.housekeeping_id = @housekeepingId";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@housekeepingId", housekeepingId);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        userName = reader.GetString(0);
                    }
                }

                return userName;
            }


            public void MarkClean(int scheduleId)
            {
                ExecuteNonQuery("UPDATE CleaningSchedule SET status = @status WHERE schedule_id = @scheduleId",
                                new SqlParameter("@status", "Completed"),
                                new SqlParameter("@scheduleId", scheduleId));
            }

            public void MarkDirty(int scheduleId)
            {
                ExecuteNonQuery("UPDATE CleaningSchedule SET status = @status WHERE schedule_id = @scheduleId",
                                new SqlParameter("@status", "Scheduled"),
                                new SqlParameter("@scheduleId", scheduleId));
            }

            public void EditEntry(int scheduleId, DateTime cleaningDate, string status)
            {
                string queryCleaningSchedule = "UPDATE CleaningSchedule SET cleaning_date=@CleaningDate WHERE schedule_id=@ScheduleId";
                string queryReservation = "UPDATE Reservations SET status=@Status WHERE room_id=(SELECT room_id FROM CleaningSchedule WHERE schedule_id=@ScheduleId)";

                string confirmationMessage = $"Are you sure you want to update the entry with ID {scheduleId}?\n\nChanges:\n";
                confirmationMessage += $"Cleaning Date: {cleaningDate.ToShortDateString()}\n";
                confirmationMessage += $"Status: {status}";

                DialogResult result = MessageBox.Show(confirmationMessage, "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // User confirmed; proceed with the update
                    using (var conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        using (var cmd1 = new SqlCommand(queryCleaningSchedule, conn))
                        {
                            cmd1.Parameters.AddWithValue("@CleaningDate", cleaningDate);
                            cmd1.Parameters.AddWithValue("@ScheduleId", scheduleId);
                            cmd1.ExecuteNonQuery();
                        }

                        using (var cmd2 = new SqlCommand(queryReservation, conn))
                        {
                            cmd2.Parameters.AddWithValue("@Status", status);
                            cmd2.Parameters.AddWithValue("@ScheduleId", scheduleId);
                            cmd2.ExecuteNonQuery();
                        }
                    }
                }
            }

            public void DeleteEntry(int scheduleId)
            {
                ExecuteNonQuery("DELETE FROM CleaningSchedule WHERE schedule_id = @scheduleId",
                                new SqlParameter("@scheduleId", scheduleId));
            }

            public void NewRequest(string housekeepingId, int roomId, string cleaningDate, string status)
            {
                string query = "INSERT INTO CleaningSchedule (housekeeping_id, room_id, cleaning_date, status) " +
                               "VALUES (@housekeepingId, @roomId, @cleaningDate, @status)";
                ExecuteNonQuery(query,
                                new SqlParameter("@housekeepingId", housekeepingId),
                                new SqlParameter("@roomId", roomId),
                                new SqlParameter("@cleaningDate", cleaningDate),
                                new SqlParameter("@status", status));
            }

            private void ExecuteNonQuery(string query, params SqlParameter[] parameters)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddRange(parameters);
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

            public DataRow GetReservationDetailsById(int reservationId)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT check_in_date, check_out_date, status FROM Reservations WHERE reservation_id = @reservationId", conn);
                    cmd.Parameters.AddWithValue("@reservationId", reservationId);
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
