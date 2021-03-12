using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Transactions
{
    public partial class Form1 : Form
    {
        SqlTransaction tr;
        public Form1()
        {
            InitializeComponent();
        }

        private void Transaction_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("data source=.;database=GestionTrans;integrated security=true");
            try
            {
                connection.Open();
                tr = connection.BeginTransaction();
                SqlCommand command = connection.CreateCommand();
                command.Transaction = tr;
                command.CommandText = "insert into Regions values(1,'the description to to waste you time')";
                command.ExecuteNonQuery();
                command.CommandText = "insert into Regions values(2,'the description to to waste you time')";
                command.ExecuteNonQuery();
                command.CommandText = "insert into Regions values(3,'the description to to waste you time')";
                command.ExecuteNonQuery();
                tr.Commit();
                MessageBox.Show("tous a ete ajoute");
            }catch(Exception ex)
            {
                tr.Rollback();
                connection.Close();
                MessageBox.Show(ex.Message,"Error");
            }
        }
    }
}