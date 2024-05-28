using System;
using System.Windows.Forms;

namespace Recetas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_recetas_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (Form1.Dani == 1) // Acceder a la propiedad estática Dani
            {
                PictureBox4.Visible = true;
                Label6.Visible = true;
            }
            else
            {
                PictureBox4.Visible = false;
                Label6.Visible = false;
            }
        }

        private void btn_chefs_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
        }
    }
}
