using System;
using System.Windows.Forms;

namespace FernDB
{
    public partial class vfDbMessages : Form
    {
        public string message;
        public vfDbMessages()
        {
            InitializeComponent();
            dbMessages.Text = DbManager.GetMessages();

        }

        public void RefreshMessages()
        {
            dbMessages.Text = DbManager.GetMessages();
        }

        private void bDatabaseMessagesClose_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        private void bDatabaseMessagesRefresh_Click(object sender, EventArgs e)
        {
            RefreshMessages();

        }
    }
}
