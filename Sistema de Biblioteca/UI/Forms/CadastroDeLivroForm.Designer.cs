namespace Sistema_de_Biblioteca
{
    partial class CadastroDeLivroForm
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
            textBoxQtd = new TextBox();
            label7 = new Label();
            textBoxAnoLanc = new TextBox();
            label6 = new Label();
            textBoxDescr = new TextBox();
            label5 = new Label();
            comboBoxCategoria = new ComboBox();
            label4 = new Label();
            textBoxAutor = new TextBox();
            textBoxTitle = new TextBox();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(textBoxQtd);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(textBoxAnoLanc);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(textBoxDescr);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(comboBoxCategoria);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBoxAutor);
            panel1.Controls.Add(textBoxTitle);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(88, 120);
            panel1.Name = "panel1";
            panel1.Size = new Size(783, 415);
            panel1.TabIndex = 0;
            // 
            // textBoxQtd
            // 
            textBoxQtd.Location = new Point(528, 96);
            textBoxQtd.Name = "textBoxQtd";
            textBoxQtd.Size = new Size(216, 23);
            textBoxQtd.TabIndex = 12;
            textBoxQtd.KeyPress += txtNumero_KeyPress;
            
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(528, 72);
            label7.Name = "label7";
            label7.Size = new Size(214, 25);
            label7.TabIndex = 11;
            label7.Text = "Quantidade em Estoque";
            // 
            // textBoxAnoLanc
            // 
            textBoxAnoLanc.Location = new Point(280, 96);
            textBoxAnoLanc.Name = "textBoxAnoLanc";
            textBoxAnoLanc.Size = new Size(216, 23);
            textBoxAnoLanc.TabIndex = 10;
            textBoxAnoLanc.KeyPress += txtNumero_KeyPress;
            textBoxAnoLanc.MaxLength = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(288, 72);
            label6.Name = "label6";
            label6.Size = new Size(180, 25);
            label6.TabIndex = 9;
            label6.Text = "Ano de Lançamento";
            // 
            // textBoxDescr
            // 
            textBoxDescr.Location = new Point(32, 163);
            textBoxDescr.Multiline = true;
            textBoxDescr.Name = "textBoxDescr";
            textBoxDescr.Size = new Size(720, 183);
            textBoxDescr.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(32, 139);
            label5.Name = "label5";
            label5.Size = new Size(94, 25);
            label5.TabIndex = 7;
            label5.Text = "Descricao";
            // 
            // comboBoxCategoria
            // 
            comboBoxCategoria.FormattingEnabled = true;
            comboBoxCategoria.Location = new Point(32, 96);
            comboBoxCategoria.Name = "comboBoxCategoria";
            comboBoxCategoria.Size = new Size(216, 23);
            comboBoxCategoria.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(32, 72);
            label4.Name = "label4";
            label4.Size = new Size(94, 25);
            label4.TabIndex = 5;
            label4.Text = "Categoria";
            // 
            // textBoxAutor
            // 
            textBoxAutor.Location = new Point(408, 40);
            textBoxAutor.Name = "textBoxAutor";
            textBoxAutor.Size = new Size(340, 23);
            textBoxAutor.TabIndex = 4;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(32, 40);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(344, 23);
            textBoxTitle.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(408, 16);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 2;
            label3.Text = "Autor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(32, 16);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 1;
            label2.Text = "Titulo";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(280, 371);
            button1.Name = "button1";
            button1.Size = new Size(215, 32);
            button1.TabIndex = 0;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonCadastrarCate_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(264, 40);
            label1.Name = "label1";
            label1.Size = new Size(430, 32);
            label1.TabIndex = 1;
            label1.Text = "Cadastrar Livro";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CadastroDeLivroForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(952, 661);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CadastroDeLivroForm";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "Cadastro - Sistema Bibliotecario";
            Load += CadastroDeLivro_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxTitle;
        private TextBox textBoxAutor;
        private Label label4;
        private ComboBox comboBoxCategoria;
        private Label label5;
        private TextBox textBoxDescr;
        private TextBox textBoxQtd;
        private Label label7;
        private TextBox textBoxAnoLanc;
        private Label label6;
    }
}