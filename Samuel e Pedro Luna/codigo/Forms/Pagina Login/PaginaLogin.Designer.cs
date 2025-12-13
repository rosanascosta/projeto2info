namespace Projeto
{
    partial class PaginaLogin
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
            label_emailusuario = new Label();
            label_senha = new Label();
            TxtEmailUsuario = new TextBox();
            TxtSenha = new TextBox();
            button_login = new Button();
            group_login = new GroupBox();
            label_NaoConta = new Label();
            label_cadastre = new Label();
            group_login.SuspendLayout();
            SuspendLayout();
            // 
            // label_emailusuario
            // 
            label_emailusuario.AutoSize = true;
            label_emailusuario.Location = new Point(41, 47);
            label_emailusuario.Name = "label_emailusuario";
            label_emailusuario.Size = new Size(148, 15);
            label_emailusuario.TabIndex = 1;
            label_emailusuario.Text = "Email ou nome de usuário:";
            // 
            // label_senha
            // 
            label_senha.AutoSize = true;
            label_senha.Location = new Point(147, 76);
            label_senha.Name = "label_senha";
            label_senha.Size = new Size(42, 15);
            label_senha.TabIndex = 2;
            label_senha.Text = "Senha:";
            // 
            // TxtEmailUsuario
            // 
            TxtEmailUsuario.Location = new Point(195, 44);
            TxtEmailUsuario.Name = "TxtEmailUsuario";
            TxtEmailUsuario.Size = new Size(131, 23);
            TxtEmailUsuario.TabIndex = 3;
            // 
            // TxtSenha
            // 
            TxtSenha.Location = new Point(195, 73);
            TxtSenha.Name = "TxtSenha";
            TxtSenha.Size = new Size(131, 23);
            TxtSenha.TabIndex = 4;
            TxtSenha.UseSystemPasswordChar = true;
            // 
            // button_login
            // 
            button_login.Location = new Point(216, 111);
            button_login.Name = "button_login";
            button_login.Size = new Size(91, 32);
            button_login.TabIndex = 5;
            button_login.Text = "Login";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_login_Click;
            // 
            // group_login
            // 
            group_login.Controls.Add(button_login);
            group_login.Controls.Add(label_emailusuario);
            group_login.Controls.Add(TxtSenha);
            group_login.Controls.Add(TxtEmailUsuario);
            group_login.Controls.Add(label_senha);
            group_login.Location = new Point(149, 129);
            group_login.Name = "group_login";
            group_login.Size = new Size(487, 160);
            group_login.TabIndex = 6;
            group_login.TabStop = false;
            group_login.Text = "Fazer Login";
            // 
            // label_NaoConta
            // 
            label_NaoConta.AutoSize = true;
            label_NaoConta.Location = new Point(293, 292);
            label_NaoConta.Name = "label_NaoConta";
            label_NaoConta.Size = new Size(131, 15);
            label_NaoConta.TabIndex = 7;
            label_NaoConta.Text = "Não possui uma conta?";
            // 
            // label_cadastre
            // 
            label_cadastre.AutoSize = true;
            label_cadastre.Cursor = Cursors.Hand;
            label_cadastre.ForeColor = Color.SteelBlue;
            label_cadastre.Location = new Point(425, 292);
            label_cadastre.Name = "label_cadastre";
            label_cadastre.Size = new Size(72, 15);
            label_cadastre.TabIndex = 8;
            label_cadastre.Text = "Cadastre-se.";
            label_cadastre.Click += label2_Click;
            // 
            // PaginaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label_cadastre);
            Controls.Add(label_NaoConta);
            Controls.Add(group_login);
            Name = "PaginaLogin";
            Text = "PaginaLogin";
            Load += PaginaLogin_Load;
            group_login.ResumeLayout(false);
            group_login.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label_emailusuario;
        private Label label_senha;
        private TextBox TxtEmailUsuario;
        private TextBox TxtSenha;
        private Button button_login;
        private GroupBox group_login;
        private Label label_NaoConta;
        private Label label_cadastre;
    }
}