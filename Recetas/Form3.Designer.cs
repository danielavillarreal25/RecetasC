//namespace Recetas
//{
//    partial class Form3
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            btn_buscar = new Button();
//            cmb_categoria = new ComboBox();
//            cmb_comensales = new ComboBox();
//            cmb_tiempo = new ComboBox();
//            txt_ingrediente = new TextBox();
//            dataGridView1 = new DataGridView();
//            cmb_tipo = new ComboBox();
//            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
//            SuspendLayout();
//            // 
//            // btn_buscar
//            // 
//            btn_buscar.Location = new Point(677, 163);
//            btn_buscar.Name = "btn_buscar";
//            btn_buscar.Size = new Size(75, 23);
//            btn_buscar.TabIndex = 0;
//            btn_buscar.Text = "button1";
//            btn_buscar.UseVisualStyleBackColor = true;
//            // 
//            // cmb_categoria
//            // 
//            cmb_categoria.FormattingEnabled = true;
//            cmb_categoria.Location = new Point(12, 165);
//            cmb_categoria.Name = "cmb_categoria";
//            cmb_categoria.Size = new Size(160, 23);
//            cmb_categoria.TabIndex = 1;
//            // 
//            // cmb_comensales
//            // 
//            cmb_comensales.FormattingEnabled = true;
//            cmb_comensales.Location = new Point(347, 165);
//            cmb_comensales.Name = "cmb_comensales";
//            cmb_comensales.Size = new Size(95, 23);
//            cmb_comensales.TabIndex = 2;
//            // 
//            // cmb_tiempo
//            // 
//            cmb_tiempo.FormattingEnabled = true;
//            cmb_tiempo.Location = new Point(465, 165);
//            cmb_tiempo.Name = "cmb_tiempo";
//            cmb_tiempo.Size = new Size(79, 23);
//            cmb_tiempo.TabIndex = 3;
//            // 
//            // txt_ingrediente
//            // 
//            txt_ingrediente.Location = new Point(195, 165);
//            txt_ingrediente.Name = "txt_ingrediente";
//            txt_ingrediente.Size = new Size(129, 23);
//            txt_ingrediente.TabIndex = 5;
//            // 
//            // dataGridView1
//            // 
//            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
//            dataGridView1.Location = new Point(3, 214);
//            dataGridView1.Name = "dataGridView1";
//            dataGridView1.Size = new Size(758, 204);
//            dataGridView1.TabIndex = 6;
//            // 
//            // cmb_tipo
//            // 
//            cmb_tipo.FormattingEnabled = true;
//            cmb_tipo.Location = new Point(564, 164);
//            cmb_tipo.Name = "cmb_tipo";
//            cmb_tipo.Size = new Size(107, 23);
//            cmb_tipo.TabIndex = 7;
//            // 
//            // Form3
//            // 
//            AutoScaleDimensions = new SizeF(7F, 15F);
//            AutoScaleMode = AutoScaleMode.Font;
//            ClientSize = new Size(773, 450);
//            Controls.Add(cmb_tipo);
//            Controls.Add(dataGridView1);
//            Controls.Add(txt_ingrediente);
//            Controls.Add(cmb_tiempo);
//            Controls.Add(cmb_comensales);
//            Controls.Add(cmb_categoria);
//            Controls.Add(btn_buscar);
//            Name = "Form3";
//            Text = "Form3";
//            Load += Form3_Load;
//            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
//            ResumeLayout(false);
//            PerformLayout();
//        }

//        #endregion

//        private Button btn_buscar;
//        private ComboBox cmb_categoria;
//        private ComboBox cmb_comensales;
//        private ComboBox cmb_tiempo;
//        private TextBox txt_ingrediente;
//        private DataGridView dataGridView1;
//        private ComboBox cmb_tipo;
//    }
//}

namespace Recetas
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmb_categoria;
        private System.Windows.Forms.ComboBox cmb_comensales;
        private System.Windows.Forms.ComboBox cmb_tiempo;
        private System.Windows.Forms.ComboBox cmb_tipo;
        private System.Windows.Forms.TextBox txt_ingrediente;
        private System.Windows.Forms.Button btn_buscar;

        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            cmb_categoria = new ComboBox();
            cmb_comensales = new ComboBox();
            cmb_tiempo = new ComboBox();
            cmb_tipo = new ComboBox();
            txt_ingrediente = new TextBox();
            btn_buscar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 249);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(776, 189);
            dataGridView1.TabIndex = 0;
            // 
            // cmb_categoria
            // 
            cmb_categoria.FormattingEnabled = true;
            cmb_categoria.Items.AddRange(new object[] { "Cocteles y bebidas", "Recetas de Huevos y lacteos", "Recetas de Mariscos", "Consejos de cocina", "Recetas de Legumbres", "Recetas de Carne", "Recetas de Ensaladas", "Recetas de Pan y bolleria", "Recetas de Pasta", "Recetas de Postres", "Postres", "Recetas de Salsas", "Recetas de Aves y caza", "Recetas de Aperitivos y tapas", "Recetas de Sopas y cremas", "Recetas de Pescado", "Recetas de Guisos y Potajes", "Recetas de Arroces y cereales", "Recetas de Verduras" });
            cmb_categoria.Location = new Point(12, 202);
            cmb_categoria.Name = "cmb_categoria";
            cmb_categoria.Size = new Size(121, 23);
            cmb_categoria.TabIndex = 1;
            // 
            // cmb_comensales
            // 
            cmb_comensales.FormattingEnabled = true;
            cmb_comensales.Items.AddRange(new object[] { "15", "9", "3", "32", "12", "35", "6", "7", "1", "50", "24", "30", "18", "10", "4", "25", "13", "5", "16", "45", "2", "48", "17", "60", "40", "11", "20", "80", "14", "8", "100" });
            cmb_comensales.Location = new Point(280, 202);
            cmb_comensales.Name = "cmb_comensales";
            cmb_comensales.Size = new Size(107, 23);
            cmb_comensales.TabIndex = 2;
            // 
            // cmb_tiempo
            // 
            cmb_tiempo.FormattingEnabled = true;
            cmb_tiempo.Items.AddRange(new object[] { "10m", "6h", "45m", "2h 30m", "24h", "1h", "1h 30m", "8h", "15m", "3h", "4h", "30m" });
            cmb_tiempo.Location = new Point(403, 202);
            cmb_tiempo.Name = "cmb_tiempo";
            cmb_tiempo.Size = new Size(95, 23);
            cmb_tiempo.TabIndex = 3;
            // 
            // cmb_tipo
            // 
            cmb_tipo.FormattingEnabled = true;
            cmb_tipo.Items.AddRange(new object[] { "Desayuno", "Cena", "Entrante", "Merienda", "Acompañamiento", "Postre", "Cumpleaños", "Plato Principal" });
            cmb_tipo.Location = new Point(514, 202);
            cmb_tipo.Name = "cmb_tipo";
            cmb_tipo.Size = new Size(121, 23);
            cmb_tipo.TabIndex = 4;
            cmb_tipo.SelectedIndexChanged += cmb_tipo_SelectedIndexChanged;
            // 
            // txt_ingrediente
            // 
            txt_ingrediente.Location = new Point(139, 202);
            txt_ingrediente.Name = "txt_ingrediente";
            txt_ingrediente.Size = new Size(124, 23);
            txt_ingrediente.TabIndex = 5;
            // 
            // btn_buscar
            // 
            btn_buscar.Location = new Point(655, 201);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(69, 24);
            btn_buscar.TabIndex = 6;
            btn_buscar.Text = "Filtrar";
            btn_buscar.UseVisualStyleBackColor = true;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 171);
            label1.Name = "label1";
            label1.Size = new Size(66, 16);
            label1.TabIndex = 7;
            label1.Text = "Categoría";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(150, 171);
            label2.Name = "label2";
            label2.Size = new Size(74, 16);
            label2.TabIndex = 8;
            label2.Text = "Ingrediente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(280, 171);
            label3.Name = "label3";
            label3.Size = new Size(83, 16);
            label3.TabIndex = 9;
            label3.Text = "Comensales";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(414, 171);
            label4.Name = "label4";
            label4.Size = new Size(54, 16);
            label4.TabIndex = 10;
            label4.Text = "Tiempo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(524, 171);
            label5.Name = "label5";
            label5.Size = new Size(35, 16);
            label5.TabIndex = 11;
            label5.Text = "Tipo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Javanese Text", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(192, 29);
            label6.Name = "label6";
            label6.Size = new Size(171, 91);
            label6.TabIndex = 12;
            label6.Text = "Recetas";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.receta;
            pictureBox1.Location = new Point(340, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(268, 156);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 14;
            button1.Text = "Regresar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form3
            // 
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_buscar);
            Controls.Add(txt_ingrediente);
            Controls.Add(cmb_tipo);
            Controls.Add(cmb_tiempo);
            Controls.Add(cmb_comensales);
            Controls.Add(cmb_categoria);
            Controls.Add(dataGridView1);
            Name = "Form3";
            FormClosed += Form3_FormClosed;
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox1;
        private Button button1;
    }
}
