namespace Projeto.Forms
{
    partial class Admin
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
            tabela_usuarios = new DataGridView();
            label_usuarios = new Label();
            group_actions = new GroupBox();
            button_abrirApp = new Button();
            button_fecharApp = new Button();
            button_excluirConta = new Button();
            ((ISupportInitialize)tabela_usuarios).BeginInit();
            group_actions.SuspendLayout();
            SuspendLayout();
            // 
            // tabela_usuarios
            // 
            tabela_usuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabela_usuarios.Location = new Point(43, 43);
            tabela_usuarios.Name = "tabela_usuarios";
            tabela_usuarios.Size = new Size(392, 347);
            tabela_usuarios.TabIndex = 0;
            // 
            // label_usuarios
            // 
            label_usuarios.AutoSize = true;
            label_usuarios.Font = new Font("Segoe UI", 17F);
            label_usuarios.Location = new Point(147, 9);
            label_usuarios.Name = "label_usuarios";
            label_usuarios.Size = new Size(184, 31);
            label_usuarios.TabIndex = 1;
            label_usuarios.Text = "Lista de usuários";
            // 
            // group_actions
            // 
            group_actions.Controls.Add(button_abrirApp);
            group_actions.Controls.Add(button_fecharApp);
            group_actions.Controls.Add(button_excluirConta);
            group_actions.Location = new Point(501, 43);
            group_actions.Name = "group_actions";
            group_actions.Size = new Size(252, 347);
            group_actions.TabIndex = 2;
            group_actions.TabStop = false;
            group_actions.Text = "Ações de admin";
            // 
            // button_abrirApp
            // 
            button_abrirApp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_abrirApp.Location = new Point(36, 221);
            button_abrirApp.Name = "button_abrirApp";
            button_abrirApp.Size = new Size(182, 79);
            button_abrirApp.TabIndex = 3;
            button_abrirApp.Text = "Reinstaurar acesso";
            button_abrirApp.UseVisualStyleBackColor = true;
            button_abrirApp.Click += button_abrirApp_Click;
            // 
            // button_fecharApp
            // 
            button_fecharApp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_fecharApp.Location = new Point(36, 136);
            button_fecharApp.Name = "button_fecharApp";
            button_fecharApp.Size = new Size(182, 79);
            button_fecharApp.TabIndex = 2;
            button_fecharApp.Text = "Remover acesso";
            button_fecharApp.UseVisualStyleBackColor = true;
            button_fecharApp.Click += button_fecharApp_Click;
            // 
            // button_excluirConta
            // 
            button_excluirConta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_excluirConta.Location = new Point(36, 51);
            button_excluirConta.Name = "button_excluirConta";
            button_excluirConta.Size = new Size(182, 79);
            button_excluirConta.TabIndex = 1;
            button_excluirConta.Text = "Excluir Conta";
            button_excluirConta.UseVisualStyleBackColor = true;
            button_excluirConta.Click += button_excluirConta_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(group_actions);
            Controls.Add(label_usuarios);
            Controls.Add(tabela_usuarios);
            DoubleBuffered = true;
            Name = "Admin";
            Text = "Admin";
            Load += Admin_Load;
            ((ISupportInitialize)tabela_usuarios).EndInit();
            group_actions.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tabela_usuarios;
        private Label label_usuarios;
        private GroupBox group_actions;
        private Button button_excluirConta;
        private Button button_fecharApp;
        private Button button_abrirApp;
    }
}