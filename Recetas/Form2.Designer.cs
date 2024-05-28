//namespace Recetas
//{
//    partial class Form2
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
//            btn_chefs = new Button();
//            btn_recetas = new Button();
//            PictureBox4 = new PictureBox();
//            Label6 = new Label();
//            ((System.ComponentModel.ISupportInitialize)PictureBox4).BeginInit();
//            SuspendLayout();
//            // 
//            // btn_chefs
//            // 
//            btn_chefs.Font = new Font("Microsoft Sans Serif", 11.25F);
//            btn_chefs.Location = new Point(198, 346);
//            btn_chefs.Name = "btn_chefs";
//            btn_chefs.Size = new Size(132, 41);
//            btn_chefs.TabIndex = 0;
//            btn_chefs.Text = "Chefs";
//            btn_chefs.UseVisualStyleBackColor = true;
//            // 
//            // btn_recetas
//            // 
//            btn_recetas.Font = new Font("Microsoft Sans Serif", 11.25F);
//            btn_recetas.Location = new Point(340, 346);
//            btn_recetas.Name = "btn_recetas";
//            btn_recetas.Size = new Size(132, 41);
//            btn_recetas.TabIndex = 1;
//            btn_recetas.Text = "Recetas";
//            btn_recetas.UseVisualStyleBackColor = true;
//            // 
//            // PictureBox4
//            // 
//            PictureBox4.Image = Properties.Resources.receta1;
//            PictureBox4.Location = new Point(580, 21);
//            PictureBox4.Name = "PictureBox4";
//            PictureBox4.Size = new Size(75, 71);
//            PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
//            PictureBox4.TabIndex = 2;
//            PictureBox4.TabStop = false;
//            // 
//            // Label6
//            // 
//            Label6.AutoSize = true;
//            Label6.Location = new Point(595, 111);
//            Label6.Name = "Label6";
//            Label6.Size = new Size(38, 15);
//            Label6.TabIndex = 3;
//            Label6.Text = "label1";
//            // 
//            // Form2
//            // 
//            AutoScaleDimensions = new SizeF(7F, 15F);
//            AutoScaleMode = AutoScaleMode.Font;
//            ClientSize = new Size(679, 450);
//            Controls.Add(Label6);
//            Controls.Add(PictureBox4);
//            Controls.Add(btn_recetas);
//            Controls.Add(btn_chefs);
//            Name = "Form2";
//            Text = "Form2";
//            Load += Form2_Load;
//            ((System.ComponentModel.ISupportInitialize)PictureBox4).EndInit();
//            ResumeLayout(false);
//            PerformLayout();
//        }

//        #endregion

//        private Button btn_chefs;
//        private Button btn_recetas;
//        private PictureBox PictureBox4;
//        private Label Label6;
//    }
//}

namespace Recetas
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btn_recetas;
        private System.Windows.Forms.Button btn_chefs;
        private System.Windows.Forms.PictureBox PictureBox4;
        private System.Windows.Forms.Label Label6;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            btn_recetas = new Button();
            btn_chefs = new Button();
            PictureBox4 = new PictureBox();
            Label6 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btn_recetas
            // 
            btn_recetas.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_recetas.Location = new Point(371, 361);
            btn_recetas.Name = "btn_recetas";
            btn_recetas.Size = new Size(130, 41);
            btn_recetas.TabIndex = 0;
            btn_recetas.Text = "Recetas";
            btn_recetas.UseVisualStyleBackColor = true;
            btn_recetas.Click += btn_recetas_Click;
            // 
            // btn_chefs
            // 
            btn_chefs.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_chefs.Location = new Point(196, 361);
            btn_chefs.Name = "btn_chefs";
            btn_chefs.Size = new Size(134, 41);
            btn_chefs.TabIndex = 1;
            btn_chefs.Text = "Chefs";
            btn_chefs.UseVisualStyleBackColor = true;
            btn_chefs.Click += btn_chefs_Click;
            // 
            // PictureBox4
            // 
            PictureBox4.Image = Properties.Resources.receta11;
            PictureBox4.Location = new Point(601, 25);
            PictureBox4.Name = "PictureBox4";
            PictureBox4.Size = new Size(71, 60);
            PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox4.TabIndex = 2;
            PictureBox4.TabStop = false;
            PictureBox4.Click += PictureBox4_Click;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label6.Location = new Point(588, 98);
            Label6.Name = "Label6";
            Label6.Size = new Size(99, 17);
            Label6.TabIndex = 3;
            Label6.Text = "Altas y cambios";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.gato_cocinero;
            pictureBox1.Location = new Point(123, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(437, 299);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-1, 25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 88);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.demicocina_a_tu_casa;
            pictureBox3.Location = new Point(-1, 109);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(125, 36);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // Form2
            // 
            ClientSize = new Size(699, 450);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(Label6);
            Controls.Add(PictureBox4);
            Controls.Add(btn_chefs);
            Controls.Add(btn_recetas);
            Name = "Form2";
            FormClosed += Form2_FormClosed;
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)PictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}
