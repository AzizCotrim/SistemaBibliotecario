namespace Sistema_de_Biblioteca
{
    partial class CadastroDeUsuario
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            buttonCadastrar = new Button();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            comboPermissao = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(422, 40);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(355, 45);
            label1.TabIndex = 0;
            label1.Text = "CADASTRAR USUARIOS";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(422, 158);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(355, 29);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(422, 127);
            label2.Name = "label2";
            label2.Size = new Size(66, 28);
            label2.TabIndex = 2;
            label2.Text = "Nome";
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(527, 495);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(146, 45);
            buttonCadastrar.TabIndex = 0;
            buttonCadastrar.Text = "CADASTRAR";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(422, 275);
            label3.Name = "label3";
            label3.Size = new Size(61, 28);
            label3.TabIndex = 4;
            label3.Text = "Login";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(422, 306);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(355, 29);
            textBox2.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(422, 357);
            label4.Name = "label4";
            label4.Size = new Size(65, 28);
            label4.TabIndex = 6;
            label4.Text = "Senha";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F);
            textBox3.Location = new Point(422, 388);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.Size = new Size(355, 29);
            textBox3.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(422, 204);
            label5.Name = "label5";
            label5.Size = new Size(170, 28);
            label5.TabIndex = 8;
            label5.Text = "Tipo de Permissao";
            // 
            // comboPermissao
            // 
            comboPermissao.Font = new Font("Segoe UI", 12F);
            comboPermissao.FormattingEnabled = true;
            comboPermissao.Location = new Point(422, 235);
            comboPermissao.Name = "comboPermissao";
            comboPermissao.Size = new Size(355, 29);
            comboPermissao.TabIndex = 9;
            // 
            // CadastroDeUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1184, 661);
            Controls.Add(comboPermissao);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(buttonCadastrar);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "CadastroDeUsuario";
            Text = "CadastroDeUsuario";
            Load += CadastroDeUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Button buttonCadastrar;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private ComboBox comboPermissao;
    }
}