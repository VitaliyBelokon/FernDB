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
    public partial class vfMetaData : Form
    {
        private vfDbMessages VFMessages;
        public vfMetaData()
        {
            InitializeComponent();
            VFMessages = new vfDbMessages();

            //VFMessages.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DbManager.Connect();
                InfoTextBox.Text = DbManager.AddUser("","");
            DbManager.Close();

            WriteInfotext(DbManager.GetMessages());
   //         WriteInfotext(DbManager.DelObject("1t"));
            if (VFMessages != null) VFMessages.RefreshMessages();
        }

        public void WriteInfotext(string tb_text)
        {
            InfoTextBox.Text = tb_text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VFMessages = new vfDbMessages();
            VFMessages.Show();
        }

        private void bMetadata_Click(object sender, EventArgs e)
        {
            DbManager.Connect();
            dataGridView1.DataSource = DbManager.GetMetaData();
            DbManager.Close();
        }

        private void bMetaDataRun_Click(object sender, EventArgs e)
        {
            DbManager.Connect();
            WriteInfotext(DbManager.SqlCommand(tbMetaDataCommand.Text));//DelObject(tbMetaDataCommand.Text));
            DbManager.Close();
        }
    }
}
