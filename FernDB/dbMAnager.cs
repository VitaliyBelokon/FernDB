using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace FernDB
{
    static class DbManager
    {
        /// <summary>
        /// A class is a wrap for SQL all basic operations
        /// </summary>

        private static string connection = 
               "server=localhost;" +
               "user=root;" +
              // "user=fern;" +
               "database=ferndb;" +
               "port =3306;" +
                "password =simonbagdad00;";
               //"password =12;";
        //id
        //user
        //password


        private static Int32 idCounter;
        

        // Class accumulates all messages into this string
        private static StringBuilder messages;

        private static MySqlConnection sqlConnection;
        private static MySqlCommand sqlCommand;
        private static DataTable tempTable;
        private static StringBuilder sbString;
        
        private static string nl = Environment.NewLine;

        static DbManager()
        {
            sqlConnection = new MySqlConnection(connection);
            sqlCommand = null;
            tempTable = null;
            idCounter = 0;
            messages = new StringBuilder(String.Empty);
            sbString = new StringBuilder(String.Empty);
        }
      
        //Async task connect 
       public static async Task Connect()        
       {
            messages.Append("Connecting...");
            try
            {
                if (sqlConnection.State != ConnectionState.Open)
                {
                    await sqlConnection.OpenAsync();
                    messages.Append("Ok." + nl);
                }
                else messages.Append("Connection is already open!" + nl);

            }
            catch (Exception e)
            {
                messages.Append("Connection failed!" + nl);
                messages.Append("MsSQL error: " + e.Message.ToString() + nl);
            }
            
        }
        
        public static void Close()
        {
            sqlConnection.Close();
            messages.Append("Database closed." + nl + nl);
        }

        public static string RegisterNewUser()
        {
            return messages.ToString() + nl;
        }

        public static string SqlCommand(string SQLComm)
        {
            Connect();
            try
            {
                StringBuilder command = new StringBuilder(SQLComm);

                sqlCommand = new MySqlCommand(command.ToString(), sqlConnection);
                sqlCommand.ExecuteNonQuery();
                Close();
            }
            catch (Exception e)
            {
                messages.Append("Operation SqlCommand failed." + nl);
                messages.Append(e.Message.ToString() + nl);
                Close();
            }
            
            return messages.ToString() + nl;
        }
        public static string AddUser(string user, string objectType)
        {
           
            try
            {
              
                DateTime date = new DateTime();
                date = DateTime.Now;
                sbString = new StringBuilder (date.Millisecond.ToString() +
                    date.Second.ToString() +
                    date.Minute.ToString() +
                    date.Hour.ToString() +
                    date.Day.ToString() +
                    date.Year.ToString());
                StringBuilder command = new StringBuilder("USE ferndb; CREATE table " + idCounter + "userid" +
                                                          sbString.ToString() +
                                                          "(userid varchar(10), user varchar(10), pw varchar(10));");

                sqlCommand = new MySqlCommand(command.ToString(), sqlConnection);
                sqlCommand.ExecuteNonQuery();
                idCounter = idCounter + 1;
                messages.Append("New user joined: " + "id" + sbString.ToString() + nl);
             

            }
            catch (Exception e)
            {
                messages.Append("Operation AddUser failed." + nl);
                messages.Append(e.Message.ToString() + nl);
           
            }
            return messages.ToString();
        }

        //Deletes an object with given id
        public static string DelObject(string id)
        {
            try
            {
               
                sbString = new StringBuilder("USE ferndb;" + nl +
                    "DROP TABLE IF EXISTS " + id + ";" + nl);
                messages.Append("sbString: " + sbString + nl);
                sqlCommand = new MySqlCommand(sbString.ToString(), sqlConnection);
                sqlCommand.ExecuteNonQuery();
                idCounter = idCounter - 1;
            

            }
            catch (Exception e)
            {
                messages.Append("DROP TABLE failed." + nl);
                messages.Append(e.Message.ToString() + nl);
             
            }
            return messages.ToString();
        }

        public static string GetMessages()
        {
            return messages.ToString() + nl;
        }
           
        public static DataTable GetMetaData()
        {
            string schema = ""; //"MetaDataCollections"; //"Tables";
            
            Connect();
            try
            {
                if (sqlConnection.GetSchema(schema) != null)
                {
                    tempTable = sqlConnection.GetSchema(schema);
                    messages.Append(schema + nl);
                }
            }
            catch (Exception e)
            {
                messages.Append(e.Message.ToString());
            }
            
            Close();
            return tempTable;
        }
    }
}
