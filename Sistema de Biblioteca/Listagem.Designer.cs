namespace Sistema_de_Biblioteca
{
    partial class Listagem
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
            panel1 = new Panel();
            panel2 = new Panel();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            TitleLable = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(148, 150);
            panel1.Name = "panel1";
            panel1.Size = new Size(904, 451);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(label6);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(15, 15);
            panel2.Name = "panel2";
            panel2.Size = new Size(874, 70);
            panel2.TabIndex = 0;
            // 
            // label6
            // 
            label6.Location = new Point(753, 30);
            label6.Name = "label6";
            label6.Size = new Size(19, 15);
            label6.TabIndex = 6;
            label6.Text = "12";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.Location = new Point(632, 30);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 4;
            label5.Text = "label5";
            // 
            // label4
            // 
            label4.Location = new Point(543, 30);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 3;
            label4.Text = "Frank Miller";
            // 
            // label3
            // 
            label3.Location = new Point(336, 30);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 2;
            label3.Text = "Batman: O Cavaleiro das Trevas";
            // 
            // label2
            // 
            label2.Location = new Point(247, 30);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 1;
            label2.Text = "Categoria";
            // 
            // label1
            // 
            label1.Location = new Point(141, 30);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // TitleLable
            // 
            TitleLable.Font = new Font("Segoe UI", 24F);
            TitleLable.ForeColor = Color.White;
            TitleLable.Location = new Point(365, 72);
            TitleLable.Name = "TitleLable";
            TitleLable.Size = new Size(470, 57);
            TitleLable.TabIndex = 2;
            TitleLable.Text = "ESTOQUE DE LIVROS";
            TitleLable.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Listagem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1184, 661);
            Controls.Add(TitleLable);
            Controls.Add(panel1);
            Name = "Listagem";
            Text = "Listagem - Sistema Bibliotecario";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label TitleLable;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
        private Label label6;
    }
}