namespace Sistema_de_Biblioteca
{
    partial class MainForm
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
            if (disposing && (components != null)) {
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
            button3 = new Button();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(260, 663);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.FlatAppearance.MouseOverBackColor = SystemColors.ControlDark;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button3.Location = new Point(0, 274);
            button3.Margin = new Padding(0);
            button3.Name = "buttonListagem";
            button3.Size = new Size(260, 38);
            button3.TabIndex = 3;
            button3.Text = "Listagem";
            button3.UseVisualStyleBackColor = true;
            button3.FlatAppearance.MouseOverBackColor = SystemColors.ControlDark;
            button3.Click += buttonListagem_Click;
            // 
            // button4
            // 
            button4.FlatAppearance.MouseOverBackColor = SystemColors.ControlDark;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button4.Location = new Point(0, 311);
            button4.Margin = new Padding(0);
            button4.Name = "buttonCategorias";
            button4.Size = new Size(260, 38);
            button4.TabIndex = 2;
            button4.Text = "Categorias";
            button4.UseVisualStyleBackColor = true;
            button4.FlatAppearance.MouseOverBackColor = SystemColors.ControlDark;
            button4.Click += buttonCategorias_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.MouseOverBackColor = SystemColors.ControlDark;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.Location = new Point(0, 237);
            button2.Margin = new Padding(0);
            button2.Name = "buttonLivros";
            button2.Size = new Size(260, 38);
            button2.TabIndex = 1;
            button2.Text = "Cadastrar Livro";
            button2.UseVisualStyleBackColor = true;
            button2.FlatAppearance.MouseOverBackColor = SystemColors.ControlDark;
            button2.Click += buttonLivros_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.MouseOverBackColor = SystemColors.ControlDark;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.Location = new Point(0, 200);
            button1.Margin = new Padding(0);
            button1.Name = "buttonUsuarios";
            button1.Size = new Size(260, 38);
            button1.TabIndex = 0;
            button1.Text = "Cadastrar Usuario";
            button1.UseVisualStyleBackColor = true;
            button1.FlatAppearance.MouseOverBackColor = SystemColors.ControlDark;
            button1.Click += buttonUsuario_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(259, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(925, 661);
            panel2.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1184, 661);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "MainForm";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}