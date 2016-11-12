using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace FernDB
{
    class DBConnector: IEntryData 
    {
        public List<Object> Data;

        public List<Object> EntryData
        {
            get { return Data; }
        }

        public List<Object> AddObjects()
        {
            return Data;
        }

        public void GetEntryData()
        {
            // DBConnector.
            string connStr =
                "server=localhost;" +
                "user=root;" +
                "database=world;" +
                "port =3306;" +
                "password =simonbagdad;";
            MySqlConnection conn = new MySqlConnection(connStr);
            //cmd = new MySql.Data.MySqlClient.MySqlCommand();



            DataTable table = new DataTable();

            try
            {
                //Form1.WriteInfoText();
                //InfoTextBox.Text = "Connecting to MySQL...";
                conn.Open();
                //conn.CreateCommand("");
                table = conn.GetSchema("MetaDataCollections");
                //DataTable table = conn.GetSchema("UDF");
                //DisplayData(table);

                conn.Close();
            }
            catch (Exception ex)
            {
                //InfoTextBox.Text = ex.ToString();
            }
            //InfoTextBox.Text = "Done.";
            //
        }

    }
}
