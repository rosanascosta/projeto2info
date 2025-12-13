namespace Projeto.Forms
{
    partial class Configuracoes
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
            group_conta = new GroupBox();
            button_excluirconta = new Button();
            button_consultar = new Button();
            button_mudarsenha = new Button();
            group_conta.SuspendLayout();
            SuspendLayout();
            // 
            // group_conta
            // 
            group_conta.Controls.Add(button_excluirconta);
            group_conta.Controls.Add(button_consultar);
            group_conta.Controls.Add(button_mudarsenha);
            group_conta.Location = new Point(94, 46);
            group_conta.Name = "group_conta";
            group_conta.Size = new Size(601, 283);
            group_conta.TabIndex = 1;
            group_conta.TabStop = false;
            group_conta.Text = "Conta";
            // 
            // button_excluirconta
            // 
            button_excluirconta.Location = new Point(35, 212);
            button_excluirconta.Name = "button_excluirconta";
            button_excluirconta.Size = new Size(529, 46);
            button_excluirconta.TabIndex = 2;
            button_excluirconta.Text = "Excluir conta";
            button_excluirconta.UseVisualStyleBackColor = true;
            button_excluirconta.Click += button_excluirconta_Click;
            // 
            // button_consultar
            // 
            button_consultar.Location = new Point(35, 37);
            button_consultar.Name = "button_consultar";
            button_consultar.Size = new Size(529, 46);
            button_consultar.TabIndex = 1;
            button_consultar.Text = "Consultar dados";
            button_consultar.UseVisualStyleBackColor = true;
            button_consultar.Click += button_consultar_Click;
            // 
            // button_mudarsenha
            // 
            button_mudarsenha.Location = new Point(35, 119);
            button_mudarsenha.Name = "button_mudarsenha";
            button_mudarsenha.Size = new Size(529, 46);
            button_mudarsenha.TabIndex = 0;
            button_mudarsenha.Text = "Alterar senha";
            button_mudarsenha.UseVisualStyleBackColor = true;
            button_mudarsenha.Click += button_mudarsenha_Click;
            // 
            // Configuracoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(group_conta);
            Name = "Configuracoes";
            Text = "Configuracoes";
            group_conta.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox group_conta;
        private Button button_excluirconta;
        private Button button_consultar;
        private Button button_mudarsenha;
    }
}