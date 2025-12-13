namespace Projeto
{
    partial class PaginaCadastro
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
            label_bemvindo = new Label();
            label_usuario = new Label();
            label_email = new Label();
            label_senha = new Label();
            TxtSenha = new TextBox();
            TxtUsuario = new TextBox();
            TxtEmail = new TextBox();
            button_enviar = new Button();
            SuspendLayout();
            // 
            // label_bemvindo
            // 
            label_bemvindo.Font = new Font("Segoe UI", 35F, FontStyle.Bold);
            label_bemvindo.Location = new Point(47, 41);
            label_bemvindo.Name = "label_bemvindo";
            label_bemvindo.Size = new Size(696, 105);
            label_bemvindo.TabIndex = 0;
            label_bemvindo.Text = "Bem vindo ao cadastro do site";
            // 
            // label_usuario
            // 
            label_usuario.AutoSize = true;
            label_usuario.Location = new Point(224, 163);
            label_usuario.Name = "label_usuario";
            label_usuario.Size = new Size(101, 15);
            label_usuario.TabIndex = 2;
            label_usuario.Text = "Nome de usuário:";
            // 
            // label_email
            // 
            label_email.AutoSize = true;
            label_email.Location = new Point(286, 206);
            label_email.Name = "label_email";
            label_email.Size = new Size(39, 15);
            label_email.TabIndex = 3;
            label_email.Text = "Email:";
            // 
            // label_senha
            // 
            label_senha.AutoSize = true;
            label_senha.Location = new Point(283, 251);
            label_senha.Name = "label_senha";
            label_senha.Size = new Size(42, 15);
            label_senha.TabIndex = 4;
            label_senha.Text = "Senha:";
            // 
            // TxtSenha
            // 
            TxtSenha.Location = new Point(331, 248);
            TxtSenha.Name = "TxtSenha";
            TxtSenha.Size = new Size(123, 23);
            TxtSenha.TabIndex = 5;
            TxtSenha.UseSystemPasswordChar = true;
            // 
            // TxtUsuario
            // 
            TxtUsuario.Location = new Point(331, 160);
            TxtUsuario.Name = "TxtUsuario";
            TxtUsuario.Size = new Size(123, 23);
            TxtUsuario.TabIndex = 6;
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(331, 203);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(123, 23);
            TxtEmail.TabIndex = 7;
            // 
            // button_enviar
            // 
            button_enviar.Location = new Point(346, 290);
            button_enviar.Name = "button_enviar";
            button_enviar.Size = new Size(93, 42);
            button_enviar.TabIndex = 8;
            button_enviar.Text = "Enviar";
            button_enviar.UseVisualStyleBackColor = true;
            button_enviar.Click += button_enviar_Click;
            // 
            // PaginaCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_enviar);
            Controls.Add(TxtEmail);
            Controls.Add(TxtUsuario);
            Controls.Add(TxtSenha);
            Controls.Add(label_senha);
            Controls.Add(label_email);
            Controls.Add(label_usuario);
            Controls.Add(label_bemvindo);
            Name = "PaginaCadastro";
            Text = "PaginaCadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_bemvindo;
        private Label label_usuario;
        private Label label_email;
        private Label label_senha;
        private TextBox TxtSenha;
        private TextBox TxtUsuario;
        private TextBox TxtEmail;
        private Button button_enviar;
    }
}