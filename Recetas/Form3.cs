using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Recetas
{
    public partial class Form3 : Form
    {
        private DatabaseConnection dbConnection = new DatabaseConnection();
        private SqlConnection conn;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            conn = dbConnection.OpenConnection();
            QuerySelect();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            dbConnection.CloseConnection(conn);
            Application.Exit();
        }

        private void QuerySelect()
        {
            try
            {
                string sql = "Select * from Recetas";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "Recetas");
                dataGridView1.DataSource = ds.Tables["Recetas"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT * FROM Recetas WHERE";
                string[] palabras_clave = txt_ingrediente.Text.Split(',');

                for (int i = 0; i < palabras_clave.Length; i++)
                {
                    sql += " Ingredientes LIKE @Ingrediente" + i;
                    if (i < palabras_clave.Length - 1)
                    {
                        sql += " OR";
                    }
                }

                if (!string.IsNullOrEmpty(cmb_categoria.Text))
                {
                    sql += " AND Categoria LIKE @Categoria";
                }
                if (!string.IsNullOrEmpty(cmb_comensales.Text))
                {
                    sql += " AND NumComensales LIKE @NumComensales";
                }
                if (!string.IsNullOrEmpty(cmb_tipo.Text))
                {
                    sql += " AND Tipo LIKE @Tipo";
                }
                if (!string.IsNullOrEmpty(cmb_tiempo.Text))
                {
                    sql += " AND Tiempo LIKE @Tiempo";
                }

                SqlCommand cmd = new SqlCommand(sql, conn);

                for (int i = 0; i < palabras_clave.Length; i++)
                {
                    cmd.Parameters.AddWithValue("@Ingrediente" + i, "%" + palabras_clave[i].Trim() + "%");
                }
                if (!string.IsNullOrEmpty(cmb_categoria.Text))
                {
                    cmd.Parameters.AddWithValue("@Categoria", "%" + cmb_categoria.Text + "%");
                }
                if (!string.IsNullOrEmpty(cmb_comensales.Text))
                {
                    cmd.Parameters.AddWithValue("@NumComensales", "%" + cmb_comensales.Text + "%");
                }
                if (!string.IsNullOrEmpty(cmb_tipo.Text))
                {
                    cmd.Parameters.AddWithValue("@Tipo", "%" + cmb_tipo.Text + "%");
                }
                if (!string.IsNullOrEmpty(cmb_tiempo.Text))
                {
                    cmd.Parameters.AddWithValue("@Tiempo", "%" + cmb_tiempo.Text + "%");
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "Recetas");
                dataGridView1.DataSource = ds.Tables["Recetas"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmb_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide(); // Oculta el formulario actual en lugar de cerrarlo
        }
    }
}



