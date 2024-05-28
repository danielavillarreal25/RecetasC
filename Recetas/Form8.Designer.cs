namespace Recetas
{
    partial class Form8
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TextBox1 = new TextBox();
            TextBox3 = new TextBox();
            TextBoxReceta = new TextBox();
            cmb_categoria1 = new ComboBox();
            cmb_tipo1 = new ComboBox();
            cmb_tiempo1 = new ComboBox();
            cmb_comensales1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            PictureBox1 = new PictureBox();
            PictureBox2 = new PictureBox();
            Button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox2).BeginInit();
            SuspendLayout();
            // 
            // TextBox1
            // 
            TextBox1.Location = new Point(204, 80);
            TextBox1.Name = "TextBox1";
            TextBox1.Size = new Size(80, 23);
            TextBox1.TabIndex = 0;
            // 
            // TextBox3
            // 
            TextBox3.Location = new Point(203, 342);
            TextBox3.Name = "TextBox3";
            TextBox3.Size = new Size(224, 23);
            TextBox3.TabIndex = 1;
            // 
            // TextBoxReceta
            // 
            TextBoxReceta.Location = new Point(203, 162);
            TextBoxReceta.Name = "TextBoxReceta";
            TextBoxReceta.Size = new Size(183, 23);
            TextBoxReceta.TabIndex = 2;
            // 
            // cmb_categoria1
            // 
            cmb_categoria1.FormattingEnabled = true;
            cmb_categoria1.Items.AddRange(new object[] { "Cocteles y bebidas", "Recetas de Huevos y lácteos", "Recetas de Mariscos", "Consejos de cocina", "Recetas de Legumbres", "Recetas de Carne", "Recetas de Ensaladas", "Recetas de Pan y bolleria", "Recetas de Pasta", "Recetas de Postres", "Recetas de Salsas", "Recetas de Aves y caza", "Recetas de Aperitivos y tapas", "Recetas de Sopas y cremas", "Recetas de Pescado", "Recetas d Guisos y Potajes", "Recetas de Arroces y cereales", "Recetas de Verduras" });
            cmb_categoria1.Location = new Point(203, 117);
            cmb_categoria1.Name = "cmb_categoria1";
            cmb_categoria1.Size = new Size(164, 23);
            cmb_categoria1.TabIndex = 3;
            // 
            // cmb_tipo1
            // 
            cmb_tipo1.FormattingEnabled = true;
            cmb_tipo1.Items.AddRange(new object[] { "Desayuno", "Cena", "Entrante", "Merienda", "Acompañamiento", "Postre", "Cumpleaños", "Plato Principal" });
            cmb_tipo1.Location = new Point(203, 300);
            cmb_tipo1.Name = "cmb_tipo1";
            cmb_tipo1.Size = new Size(110, 23);
            cmb_tipo1.TabIndex = 4;
            // 
            // cmb_tiempo1
            // 
            cmb_tiempo1.FormattingEnabled = true;
            cmb_tiempo1.Items.AddRange(new object[] { "10m", "6h", "45m", "2h 30m", "24h", "1h", "1h 30m", "8h", "15m", "3h", "4h", "30m" });
            cmb_tiempo1.Location = new Point(203, 256);
            cmb_tiempo1.Name = "cmb_tiempo1";
            cmb_tiempo1.Size = new Size(87, 23);
            cmb_tiempo1.TabIndex = 5;
            // 
            // cmb_comensales1
            // 
            cmb_comensales1.FormattingEnabled = true;
            cmb_comensales1.Items.AddRange(new object[] { "15", "9", "3", "32", "12", "35", "6", "7", "1", "50", "24", "30", "18", "10", "4", "25", "13", "5", "16", "45", "2", "48", "17", "60", "40", "11", "20", "80", "14", "8", "100" });
            cmb_comensales1.Location = new Point(203, 211);
            cmb_comensales1.Name = "cmb_comensales1";
            cmb_comensales1.Size = new Size(59, 23);
            cmb_comensales1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(101, 81);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 7;
            label1.Text = "Id Receta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(98, 118);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 8;
            label2.Text = "Categoria";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(116, 303);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 9;
            label3.Text = "Tipo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(101, 256);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 10;
            label4.Text = "Tiempo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(73, 212);
            label5.Name = "label5";
            label5.Size = new Size(124, 20);
            label5.TabIndex = 11;
            label5.Text = "Num Comensales";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(79, 165);
            label6.Name = "label6";
            label6.Size = new Size(113, 20);
            label6.TabIndex = 12;
            label6.Text = "Nombre Receta";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(90, 343);
            label7.Name = "label7";
            label7.Size = new Size(91, 20);
            label7.TabIndex = 13;
            label7.Text = "Ingredientes";
            // 
            // PictureBox1
            // 
            PictureBox1.Image = Properties.Resources.anadiendo1;
            PictureBox1.Location = new Point(187, 391);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(76, 53);
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox1.TabIndex = 14;
            PictureBox1.TabStop = false;
            PictureBox1.Click += PictureBox1_Click;
            // 
            // PictureBox2
            // 
            PictureBox2.Image = Properties.Resources.actualizar;
            PictureBox2.Location = new Point(291, 391);
            PictureBox2.Name = "PictureBox2";
            PictureBox2.Size = new Size(76, 53);
            PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox2.TabIndex = 15;
            PictureBox2.TabStop = false;
            PictureBox2.Click += PictureBox2_Click;
            // 
            // Button1
            // 
            Button1.Location = new Point(304, 78);
            Button1.Name = "Button1";
            Button1.Size = new Size(101, 23);
            Button1.TabIndex = 17;
            Button1.Text = "Buscar Receta";
            Button1.UseVisualStyleBackColor = true;
            Button1.Click += Button1_Click;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 466);
            Controls.Add(Button1);
            Controls.Add(PictureBox2);
            Controls.Add(PictureBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmb_comensales1);
            Controls.Add(cmb_tiempo1);
            Controls.Add(cmb_tipo1);
            Controls.Add(cmb_categoria1);
            Controls.Add(TextBoxReceta);
            Controls.Add(TextBox3);
            Controls.Add(TextBox1);
            Name = "Form8";
            Text = "Form8";
            Load += Form8_Load;
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBox1;
        private TextBox TextBox3;
        private TextBox TextBoxReceta;
        private ComboBox cmb_categoria1;
        private ComboBox cmb_tipo1;
        private ComboBox cmb_tiempo1;
        private ComboBox cmb_comensales1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private PictureBox PictureBox1;
        private PictureBox PictureBox2;
        private Button Button1;
    }
}