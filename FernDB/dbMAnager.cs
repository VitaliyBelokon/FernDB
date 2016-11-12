using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace FernDB
{
    public partial class dbMAnager : Form
    {
        public dbMAnager()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
          

            // DBConnector.
            string connStr = 
                "server=localhost;" +
                "user=root;" +
                "database=ferndb;" +
                "port =3306;" + 
                "password =simonbagdad00;";
            MySqlConnection sqlConnection = new MySqlConnection(connStr);
            DataTable table = new DataTable();

            try
            {
                InfoTextBox.Text = "Connecting to MySQL...";
                sqlConnection.Open();
                table = sqlConnection.GetSchema("MetaDataCollections");

               

                for (Int32 i = 0; i < 5; i++)
                {
                    string command = "USE ferndb; CREATE table tl"+i.ToString()+"(id int(6));";
                    MySqlCommand sqlCommand = new MySqlCommand(command, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                }

                //DataTable table = conn.GetSchema("UDF");
                // DisplayData(table);

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                InfoTextBox.Text = ex.ToString();
            }
            InfoTextBox.Text = "Done.";

           
            //DataTable table = new DataTable();
            /*
            // Declare DataColumn and DataRow variables.
            DataColumn column;
            DataRow row;

            // Create new DataColumn, set DataType, ColumnName
            // and add to DataTable.    
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "id";
            table.Columns.Add(column);

            // Create second column.
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "item";
            table.Columns.Add(column);

            // Create new DataRow objects and add to DataTable.    
            for (int i = 0; i < 10; i++)
            {
                row = table.NewRow();
                row["id"] = i;
                row["item"] = "item " + i;
                table.Rows.Add(row);
            }
            */


            // Set to DataGrid.DataSource property to the table.
            dataGridView1.DataSource = table;

        }

        public void WriteInfotext(string tb_text)
        {
            InfoTextBox.Text = tb_text;
        }
    }
}
