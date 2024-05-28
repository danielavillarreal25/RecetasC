using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Recetas
{
    public partial class Form4 : Form
    {
        private DatabaseConnection dbConnection = new DatabaseConnection();
        private SqlConnection conn;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            conn = dbConnection.OpenConnection();
            QuerySelect();
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            dbConnection.CloseConnection(conn);
        }

        private void QuerySelect()
        {
            try
            {
                string sql = "Select IdChef, Nombre, Apellido, Telefono, Puesto from Chefs";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "Chefs");
                dataGridView1.DataSource = ds.Tables["Chefs"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
