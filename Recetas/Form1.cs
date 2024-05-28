//using System;
//using System.Data;
//using System.Data.SqlClient;
//using System.Windows.Forms;

//namespace Recetas
//{
//    public partial class Form1 : Form
//    {
//        public int dani = 0;

//        public Form1()
//        {
//            InitializeComponent();
//        }

//        private void btn_login_Click(object sender, EventArgs e)
//        {
//            if (!string.IsNullOrEmpty(txt_user.Text) && !string.IsNullOrEmpty(txt_password.Text))
//            {
//                DatabaseConnection dbConnection = new DatabaseConnection();
//                SqlConnection conn = dbConnection.OpenConnection();

//                if (conn != null)
//                {
//                    try
//                    {
//                        if (conn.State == ConnectionState.Open)
//                        {
//                            SqlCommand cmd = conn.CreateCommand();
//                            cmd.CommandType = CommandType.StoredProcedure;
//                            cmd.CommandText = "Ingreso";
//                            cmd.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = txt_user.Text;

//                            SqlDataReader sqlread = cmd.ExecuteReader();

//                            if (sqlread.Read())
//                            {
//                                string password = sqlread["Contrase�a"].ToString();
//                                if (txt_password.Text == password)
//                                {
//                                    sqlread.Close(); // Cerrar el primer DataReader antes de llamar a VerificarTipoUsuario
//                                    VerificarTipoUsuario(conn);
//                                }
//                                else
//                                {
//                                    MessageBox.Show("Contrase�a incorrecta...", "Error");
//                                    sqlread.Close();
//                                }
//                            }
//                            else
//                            {
//                                MessageBox.Show("Usuario no encontrado...", "Error");
//                                sqlread.Close();
//                            }
//                        }
//                        else
//                        {
//                            MessageBox.Show("Error en la conexi�n", "Error");
//                        }
//                    }
//                    catch (Exception ex)
//                    {
//                        MessageBox.Show("Error al intentar iniciar sesi�n: " + ex.Message);
//                    }
//                    finally
//                    {
//                        dbConnection.CloseConnection(conn);
//                    }
//                }
//            }
//            else
//            {
//                MessageBox.Show("No puede dejar los espacios vac�os", "Alerta");
//            }
//        }

//        private void VerificarTipoUsuario(SqlConnection conn)
//        {
//            try
//            {
//                string sql = "SELECT Puesto FROM Chefs WHERE Usuario=@Usuario AND Contrase�a=@Contrase�a";
//                SqlCommand cmd = new SqlCommand(sql, conn);
//                cmd.Parameters.AddWithValue("@Usuario", txt_user.Text);
//                cmd.Parameters.AddWithValue("@Contrase�a", txt_password.Text);

//                SqlDataReader reader = cmd.ExecuteReader();
//                if (reader.HasRows)
//                {
//                    reader.Read();
//                    string puesto = reader["Puesto"].ToString();
//                    if (puesto == "Chef Ejecutivo")
//                    {
//                        dani = 1;
//                    }
//                    else
//                    {
//                        dani = 0;
//                    }
//                    Form2 form2 = new Form2();
//                    form2.Show();
//                    this.Hide();
//                }
//                reader.Close();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Error al verificar el tipo de usuario: " + ex.Message);
//            }
//        }
//    }
//}

using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Recetas
{
    public partial class Form1 : Form
    {
        public static int Dani { get; set; } = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_user.Text) && !string.IsNullOrEmpty(txt_password.Text))
            {
                DatabaseConnection dbConnection = new DatabaseConnection();
                SqlConnection conn = dbConnection.OpenConnection();

                if (conn != null)
                {
                    try
                    {
                        if (conn.State == ConnectionState.Open)
                        {
                            SqlCommand cmd = conn.CreateCommand();
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.CommandText = "Ingreso";
                            cmd.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = txt_user.Text;

                            SqlDataReader sqlread = cmd.ExecuteReader();

                            if (sqlread.Read())
                            {
                                string password = sqlread["Contrase�a"].ToString();
                                if (txt_password.Text == password)
                                {
                                    sqlread.Close(); // Cerrar el primer DataReader antes de llamar a VerificarTipoUsuario
                                    VerificarTipoUsuario(conn);
                                }
                                else
                                {
                                    MessageBox.Show("Contrase�a incorrecta...", "Error");
                                    sqlread.Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Usuario no encontrado...", "Error");
                                sqlread.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error en la conexi�n", "Error");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al intentar iniciar sesi�n: " + ex.Message);
                    }
                    finally
                    {
                        dbConnection.CloseConnection(conn);
                    }
                }
            }
            else
            {
                MessageBox.Show("No puede dejar los espacios vac�os", "Alerta");
            }
        }

        private void VerificarTipoUsuario(SqlConnection conn)
        {
            try
            {
                string sql = "SELECT Puesto FROM Chefs WHERE Usuario=@Usuario AND Contrase�a=@Contrase�a";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Usuario", txt_user.Text);
                cmd.Parameters.AddWithValue("@Contrase�a", txt_password.Text);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    string puesto = reader["Puesto"].ToString();
                    if (puesto == "Chef Ejecutivo")
                    {
                        Dani = 1;
                    }
                    else
                    {
                        Dani = 0;
                    }
                    Form2 form2 = new Form2();
                    form2.Show();
                    this.Hide();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar el tipo de usuario: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
