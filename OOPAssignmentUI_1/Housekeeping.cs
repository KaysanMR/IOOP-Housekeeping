using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
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

        public class ManageHousekeeping
        {
            private string connectionString = ConfigurationManager.ConnectionStrings["CSD1"].ToString();

            //data retrieval functions

            public DataTable GetAllSupplyRequests()
            {
                DataTable dt = new DataTable();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("SELECT * FROM SuppliesRequest", conn);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error fetching data: {ex.Message}");
                    }
                }

                return dt;
            }

            public DataTable GetCleaningScheduleForUser(int userId, string bookingStatus = "All")
            {
                DataTable dt = new DataTable();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        StringBuilder query = new StringBuilder(@"
                SELECT cs.schedule_id, cs.room_id, cs.housekeeping_id, cs.cleaning_date, cs.status
                FROM CleaningSchedule cs
                INNER JOIN Reservations r ON cs.room_id = r.room_id
                INNER JOIN housekeeping h ON cs.housekeeping_id = h.housekeeping_id
                WHERE h.user_id = @userId");

                        if (bookingStatus != "All")
                        {
                            query.Append(" AND r.status = @status");
                        }

                        SqlCommand cmd = new SqlCommand(query.ToString(), conn);
                        cmd.Parameters.AddWithValue("@userId", userId);

                        if (bookingStatus != "All")
                        {
                            cmd.Parameters.AddWithValue("@status", bookingStatus);
                        }

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error fetching data: {ex.Message}");
                    }
                }

                return dt;
            }

            public DataRow GetSupplyRequestById(int requestId)
            {
                DataTable dt = new DataTable();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("SELECT * FROM SuppliesRequest WHERE request_id = @requestId", conn);
                        cmd.Parameters.AddWithValue("@requestId", requestId);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            return dt.Rows[0];
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error fetching data: {ex.Message}");
                    }
                }

                return null;
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

            public DataRow GetUserProfileById(int userId)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "SELECT name, phone_number, address, notes, gender, nationality FROM Profiles WHERE user_id = @userId";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@userId", userId);
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                return dt.Rows[0];
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error fetching profile: {ex.Message}");
                    }
                }
                return null;
            }


            private int GetHousekeepingIdByUserId(int userId)
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT housekeeping_id FROM housekeeping WHERE user_id = @userId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);

                        object result = cmd.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int housekeepingId))
                        {
                            return housekeepingId;
                        }
                    }
                }
                return 0;
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

            public void UpdateUserProfile(int userId, string name, string phoneNumber, string address, string notes, string gender, string nationality)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = @"
                    UPDATE Profiles
                    SET name = @Name,
                        phone_number = @PhoneNumber,
                        address = @Address,
                        notes = @Notes,
                        gender = @Gender,
                        nationality = @Nationality
                    WHERE user_id = @UserId";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Name", name);
                            cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                            cmd.Parameters.AddWithValue("@Address", address);
                            cmd.Parameters.AddWithValue("@Notes", notes);
                            cmd.Parameters.AddWithValue("@Gender", gender);
                            cmd.Parameters.AddWithValue("@Nationality", nationality);
                            cmd.Parameters.AddWithValue("@UserId", userId);

                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Profile updated successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error updating profile: {ex.Message}");
                    }
                }
            }


            ///button functions

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

            public void EditEntry(int id, DateTime? cleaningDate, string status, string itemName = null, int? quantity = null)
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    if (cleaningDate.HasValue)
                    {
                        // Editing a CleaningSchedule entry
                        string queryCleaningSchedule = "UPDATE CleaningSchedule SET cleaning_date=@CleaningDate WHERE schedule_id=@Id";
                        string queryReservation = "UPDATE Reservations SET status=@Status WHERE room_id=(SELECT room_id FROM CleaningSchedule WHERE schedule_id=@Id)";

                        string confirmationMessage = $"Are you sure you want to update the Cleaning Schedule entry with ID {id}?\n\nChanges:\n";
                        confirmationMessage += $"Cleaning Date: {cleaningDate.Value.ToShortDateString()}\n";
                        confirmationMessage += $"Status: {status}";

                        DialogResult result = MessageBox.Show(confirmationMessage, "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            using (var cmd1 = new SqlCommand(queryCleaningSchedule, conn))
                            {
                                cmd1.Parameters.AddWithValue("@CleaningDate", cleaningDate.Value);
                                cmd1.Parameters.AddWithValue("@Id", id);
                                cmd1.ExecuteNonQuery();
                            }

                            using (var cmd2 = new SqlCommand(queryReservation, conn))
                            {
                                cmd2.Parameters.AddWithValue("@Status", status);
                                cmd2.Parameters.AddWithValue("@Id", id);
                                cmd2.ExecuteNonQuery();
                            }
                        }
                    }
                    else
                    {
                        // Editing a SupplyRequest entry
                        string querySupplyRequest = "UPDATE SuppliesRequest SET item_name=@ItemName, quantity=@Quantity, status=@Status WHERE request_id=@Id";

                        string confirmationMessage = $"Are you sure you want to update the Supply Request entry with ID {id}?\n\nChanges:\n";
                        confirmationMessage += $"Item Name: {itemName}\n";
                        confirmationMessage += $"Quantity: {quantity}\n";
                        confirmationMessage += $"Status: {status}";

                        DialogResult result = MessageBox.Show(confirmationMessage, "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            using (var cmd = new SqlCommand(querySupplyRequest, conn))
                            {
                                cmd.Parameters.AddWithValue("@ItemName", itemName);
                                cmd.Parameters.AddWithValue("@Quantity", quantity);
                                cmd.Parameters.AddWithValue("@Status", status);
                                cmd.Parameters.AddWithValue("@Id", id);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }

            public void DeleteEntry(int id, bool isCleaningSchedule)
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query;

                    if (isCleaningSchedule)
                    {
                        query = "DELETE FROM CleaningSchedule WHERE schedule_id = @Id";
                    }
                    else
                    {
                        query = "DELETE FROM SuppliesRequest WHERE request_id = @Id";
                    }

                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.ExecuteNonQuery();
                    } 
                }
            }

            public void NewItemRequest(int userId, string itemName, int itemQuantity)
            {
                int housekeepingId = GetHousekeepingIdByUserId(userId);

                if (housekeepingId == 0)
                {
                    MessageBox.Show("Invalid housekeeping ID.");
                    return;
                }

                using (var conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        string query = "INSERT INTO SuppliesRequest (housekeeping_id, item_name, quantity, status) VALUES (@housekeepingId, @itemName, @quantity, @status)";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@housekeepingId", housekeepingId);
                            cmd.Parameters.AddWithValue("@itemName", itemName);
                            cmd.Parameters.AddWithValue("@quantity", itemQuantity);
                            cmd.Parameters.AddWithValue("@status", "Pending"); // Default status: Pending

                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error adding request: {ex.Message}");
                    }
                }
            }

            // other
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



        }
    }
}
