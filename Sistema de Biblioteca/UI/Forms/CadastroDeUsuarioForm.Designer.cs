namespace Sistema_de_Biblioteca
{
    partial class CadastroDeUsuarioForm
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
            txtName = new TextBox();
            label2 = new Label();
            buttonCadastrar = new Button();
            label3 = new Label();
            txtlogin = new TextBox();
            label4 = new Label();
            txtpassword = new TextBox();
            label5 = new Label();
            comboPermissao = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(305, 75);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(355, 45);
            label1.TabIndex = 0;
            label1.Text = "CADASTRAR USUARIOS";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F);
            txtName.Location = new Point(305, 193);
            txtName.Name = "txtName";
            txtName.Size = new Size(355, 29);
            txtName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(305, 162);
            label2.Name = "label2";
            label2.Size = new Size(66, 28);
            label2.TabIndex = 2;
            label2.Text = "Nome";
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(410, 530);
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
            label3.Location = new Point(305, 310);
            label3.Name = "label3";
            label3.Size = new Size(61, 28);
            label3.TabIndex = 4;
            label3.Text = "Login";
            // 
            // txtlogin
            // 
            txtlogin.Font = new Font("Segoe UI", 12F);
            txtlogin.Location = new Point(305, 341);
            txtlogin.Name = "txtlogin";
            txtlogin.Size = new Size(355, 29);
            txtlogin.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(305, 392);
            label4.Name = "label4";
            label4.Size = new Size(65, 28);
            label4.TabIndex = 6;
            label4.Text = "Senha";
            // 
            // txtpassword
            // 
            txtpassword.Font = new Font("Segoe UI", 12F);
            txtpassword.Location = new Point(305, 423);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(355, 29);
            txtpassword.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(305, 239);
            label5.Name = "label5";
            label5.Size = new Size(170, 28);
            label5.TabIndex = 8;
            label5.Text = "Tipo de Permissao";
            // 
            // comboPermissao
            // 
            comboPermissao.Font = new Font("Segoe UI", 12F);
            comboPermissao.FormattingEnabled = true;
            comboPermissao.Location = new Point(305, 270);
            comboPermissao.Name = "comboPermissao";
            comboPermissao.Size = new Size(355, 29);
            comboPermissao.TabIndex = 9;
            // 
            // CadastroDeUsuarioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(952, 661);
            Controls.Add(comboPermissao);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtpassword);
            Controls.Add(label3);
            Controls.Add(txtlogin);
            Controls.Add(buttonCadastrar);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CadastroDeUsuarioForm";
            Text = "CadastroDeUsuario";
            Load += CadastroDeUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Label label2;
        private Button buttonCadastrar;
        private Label label3;
        private TextBox txtlogin;
        private Label label4;
        private TextBox txtpassword;
        private Label label5;
        private ComboBox comboPermissao;
    }
}