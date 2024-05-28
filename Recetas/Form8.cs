using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Recetas
{
    public partial class Form8 : Form
    {
        private DatabaseConnection dbConnection = new DatabaseConnection();
        private SqlConnection conn;

        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            conn = dbConnection.OpenConnection();
            if (conn == null || conn.State != ConnectionState.Open)
            {
                MessageBox.Show("Error al abrir la conexión.");
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn == null || conn.State != ConnectionState.Open)
                {
                    MessageBox.Show("La conexión no se ha inicializado.");
                    return;
                }

                string sql = "INSERT INTO Recetas (Categoria, NombreReceta, NumComensales, Tiempo, Tipo, Ingredientes) " +
                             "VALUES (@Categoria, @NombreReceta, @NumComensales, @Tiempo, @Tipo, @Ingredientes)";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Categoria", cmb_categoria1.Text);
                    cmd.Parameters.AddWithValue("@NombreReceta", TextBoxReceta.Text);
                    cmd.Parameters.AddWithValue("@NumComensales", cmb_comensales1.Text);
                    cmd.Parameters.AddWithValue("@Tiempo", cmb_tiempo1.Text);
                    cmd.Parameters.AddWithValue("@Tipo", cmb_tipo1.Text);
                    cmd.Parameters.AddWithValue("@Ingredientes", TextBox3.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Receta agregada correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar la receta.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la receta: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn == null || conn.State != ConnectionState.Open)
                {
                    MessageBox.Show("La conexión no se ha inicializado.");
                    return;
                }

                string sql = "UPDATE Recetas SET Categoria=@Categoria, NombreReceta=@NombreReceta, NumComensales=@NumComensales, Tiempo=@Tiempo, Tipo=@Tipo, Ingredientes=@Ingredientes WHERE IdReceta=@IdReceta";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Categoria", cmb_categoria1.Text);
                    cmd.Parameters.AddWithValue("@NombreReceta", TextBoxReceta.Text);
                    cmd.Parameters.AddWithValue("@NumComensales", cmb_comensales1.Text);
                    cmd.Parameters.AddWithValue("@Tiempo", cmb_tiempo1.Text);
                    cmd.Parameters.AddWithValue("@Tipo", cmb_tipo1.Text);
                    cmd.Parameters.AddWithValue("@Ingredientes", TextBox3.Text);
                    cmd.Parameters.AddWithValue("@IdReceta", TextBox1.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Receta actualizada correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar la receta.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la receta: " + ex.Message);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn == null || conn.State != ConnectionState.Open)
                {
                    MessageBox.Show("La conexión no se ha inicializado.");
                    return;
                }

                string sql = "SELECT * FROM Recetas WHERE IdReceta = @IdReceta";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@IdReceta", TextBox1.Text);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                cmb_categoria1.Text = reader["Categoria"].ToString();
                                TextBoxReceta.Text = reader["NombreReceta"].ToString();
                                cmb_comensales1.Text = reader["NumComensales"].ToString();
                                cmb_tiempo1.Text = reader["Tiempo"].ToString();
                                cmb_tipo1.Text = reader["Tipo"].ToString();
                                TextBox3.Text = reader["Ingredientes"].ToString();
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se encontró una receta con el ID proporcionado.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar la receta: " + ex.Message);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                dbConnection.CloseConnection(conn);
            }
            base.OnFormClosing(e);
        }
    }
}
