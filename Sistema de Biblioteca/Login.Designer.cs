namespace Sistema_de_Biblioteca
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            TitleLable = new Label();
            label1 = new Label();
            label2 = new Label();
            LoginText = new TextBox();
            PassText = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DimGray;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 15F);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(542, 422);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(116, 39);
            button1.TabIndex = 0;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // TitleLable
            // 
            TitleLable.Font = new Font("Segoe UI", 24F);
            TitleLable.ForeColor = Color.White;
            TitleLable.Location = new Point(365, 72);
            TitleLable.Name = "TitleLable";
            TitleLable.Size = new Size(470, 57);
            TitleLable.TabIndex = 1;
            TitleLable.Text = "SISTEMA BIBLIOTECARIO";
            TitleLable.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(425, 225);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 2;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(425, 295);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 3;
            label2.Text = "Senha";
            // 
            // LoginText
            // 
            LoginText.BackColor = Color.White;
            LoginText.BorderStyle = BorderStyle.FixedSingle;
            LoginText.Font = new Font("Segoe UI", 12F);
            LoginText.Location = new Point(425, 253);
            LoginText.Name = "LoginText";
            LoginText.Size = new Size(350, 29);
            LoginText.TabIndex = 4;
            // 
            // PassText
            // 
            PassText.BackColor = Color.White;
            PassText.BorderStyle = BorderStyle.FixedSingle;
            PassText.Cursor = Cursors.IBeam;
            PassText.Font = new Font("Segoe UI", 12F);
            PassText.Location = new Point(425, 323);
            PassText.Name = "PassText";
            PassText.PasswordChar = '*';
            PassText.Size = new Size(350, 29);
            PassText.TabIndex = 5;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1184, 661);
            Controls.Add(PassText);
            Controls.Add(LoginText);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TitleLable);
            Controls.Add(button1);
            Name = "Login";
            Text = "Sistema Bibliotecario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label TitleLable;
        private Label label1;
        private Label label2;
        private TextBox LoginText;
        private TextBox PassText;
    }
}
